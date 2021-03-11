$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkCommand.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkCommand' {
    It 'CreateExpanded' {
        # #TODO #BUG Swagger for New-JcSdkCommand does not return an id
        $NewCommand = New-JcSdkCommand @global:PesterDefCommand
        $global:PesterTestCommand = Get-JcSdkCommand | Where-Object { $_.Name -eq $NewCommand.Name } | Select-Object -First 1
        $global:PesterTestCommand | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        New-JcSdkCommand -Body '<ICommand>' | Should -Not -BeNullOrEmpty
    }
}
