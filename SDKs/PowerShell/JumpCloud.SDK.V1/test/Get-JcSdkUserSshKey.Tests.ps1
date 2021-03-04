$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserSshKey.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

$global:PesterTestUserSshKeyName = 'PesterTestUserSshKeyName'
$global:PesterTestUserSshKeyPublicKey = 'PesterTestUserSshKeyPublicKey'
Describe 'Get-JcSdkUserSshKey' {
    It 'List' {
        Start-Sleep -Seconds:(10)
        Get-JcSdkUserSshKey -Id:($global:PesterTestUser.Id) | Should -Not -BeNullOrEmpty
    }
}