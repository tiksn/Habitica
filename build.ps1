param(
    [switch]$CSharp,
    [switch]$CPP
)

if ($CSharp) {
    Invoke-psake -buildFile .\psakefile.ps1 -taskList BuildCSharp
}

if ($CPP) {
    Invoke-psake -buildFile .\psakefile.ps1 -taskList BuildCPP
}
