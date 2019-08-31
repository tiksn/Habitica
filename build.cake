#addin "Cake.Http"
#addin "Cake.Json"
#addin "Cake.ExtendedNuGet"
#addin nuget:?package=Newtonsoft.Json&version=9.0.1
#addin nuget:?package=NuGet.Core&version=2.14.0
#addin nuget:?package=NuGet.Versioning&version=4.6.2
#addin nuget:?package=Cake.Git
#addin nuget:?package=TIKSN-Cake&loaddependencies=true

var target = Argument("target", "Publish");
var solution = "Habitica.sln";
var nuspec = "Habitica.nuspec";
var nugetPackageId = "TIKSN-Habitica";

using System;
using System.Linq;
using NuGet.Versioning;
DirectoryPath buildArtifactsDir;

Setup(context =>
{
    SetTrashParentDirectory(GitFindRootFromPath("."));
});

Teardown(context =>
{
    // Executed AFTER the last task.
});

Task("Publish")
  .Description("Publish NuGet package.")
  .IsDependentOn("Pack")
  .Does(() =>
{
 var package = string.Format("{0}/{1}.{2}.nupkg", GetTrashDirectory(), nugetPackageId, (NuGetVersion)GetNextEstimatedVersion());

 NuGetPush(package, new NuGetPushSettings {
     Source = "nuget.org",
     ApiKey = EnvironmentVariable("TIKSN-Habitica-ApiKey")
 });
});

Task("Pack")
  .Description("Pack NuGet package.")
  .IsDependentOn("Build")
  .IsDependentOn("Test")
  .IsDependentOn("EstimateNextVersion")
  .Does(() =>
{
  var nuGetPackSettings = new NuGetPackSettings {
    Version = GetNextEstimatedVersion().ToString(),
    BasePath = buildArtifactsDir,
    OutputDirectory = GetTrashDirectory()
    };

  NuGetPack(nuspec, nuGetPackSettings);
});

Task("Test")
  .IsDependentOn("Build")
  .Does(() =>
{
    DotNetCoreTest(
        "Habitica.Tests/Habitica.Tests.csproj",
        new DotNetCoreTestSettings()
        {
            Configuration = "Release",
            NoBuild = false
        });
});

Task("Build")
  .IsDependentOn("Clean")
  .IsDependentOn("Restore")
  .Does(() =>
{
  buildArtifactsDir = CreateTrashSubDirectory("artifacts");

  MSBuild(solution, configurator =>
    configurator.SetConfiguration("Release")
        .SetVerbosity(Verbosity.Minimal)
        .UseToolVersion(MSBuildToolVersion.VS2019)
        .SetMSBuildPlatform(MSBuildPlatform.x64)
        .SetPlatformTarget(PlatformTarget.MSIL)
        .WithProperty("OutDir", buildArtifactsDir.FullPath)
        //.WithTarget("Rebuild")
        );
});

Task("EstimateNextVersion")
  .Description("Estimate next version.")
  .Does(() =>
{
  var packageList = NuGetList(nugetPackageId, new NuGetListSettings {
      AllVersions = false,
      Prerelease = true
      });
  SetPublishedVersions(packageList.Select(v => new NuGetVersion(v.Version)));
  Information("Next version estimated to be " + GetNextEstimatedVersion());
});

Task("Restore")
  .Description("Restores packages.")
  .Does(() =>
{
  NuGetRestore(solution);
});

Task("Clean")
  .Description("Cleans all directories that are used during the build process.")
  .Does(() =>
{
  CleanDirectories("**/bin/**");
  CleanDirectories("**/obj/**");
});

RunTarget(target);