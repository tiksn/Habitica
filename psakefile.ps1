Task Publish -Depends Pack {
    $nupkg = Join-Path -Path $script:trashFolder -ChildPath "TIKSN-Habitica.$script:NextVersion.nupkg"
    $nupkg = Resolve-Path -Path $nupkg
    $nupkg = $nupkg.Path

    $apiKey = [Environment]::GetEnvironmentVariable('TIKSN-Habitica-ApiKey')

    Exec { nuget push $nupkg -ApiKey $apiKey -Source https://api.nuget.org/v3/index.json }
}

Task Pack -Depends Build, EstimateVersions {
    $project = "./Habitica/Habitica.csproj"
    $project = Resolve-Path $project
    $project = $project.Path

    Exec { dotnet pack --configuration Release --output $script:trashFolder -p:version=$script:NextVersion $project }
}

Task EstimateVersions {
    $Version = [Version]$Version

    Assert ($Version.Revision -eq -1) "Version should be formatted as Major.Minor.Patch like 1.2.3"
    Assert ($Version.Build -ne -1) "Version should be formatted as Major.Minor.Patch like 1.2.3"

    $Version = $Version.ToString()
    $script:NextVersion = $Version
}

Task Build -Depends Clean {
    $solution = Resolve-Path "./Habitica.sln"
    $solution = $solution.Path
    Exec { dotnet restore $solution }
    Exec { dotnet build $solution }
}

Task Clean -Depends Init {
}

Task Init {
    $date = Get-Date
    $ticks = $date.Ticks
    $script:trashFolder = Join-Path -Path . -ChildPath ".trash"
    $script:trashFolder = Join-Path -Path $script:trashFolder -ChildPath $ticks.ToString("D19")
    New-Item -Path $script:trashFolder -ItemType Directory | Out-Null
    $script:trashFolder = Resolve-Path -Path $script:trashFolder
}