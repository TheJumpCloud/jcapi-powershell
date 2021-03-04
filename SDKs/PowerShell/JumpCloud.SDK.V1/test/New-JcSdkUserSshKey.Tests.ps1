$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkUserSshKey.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

$global:PesterTestUserSshKeyName = 'PesterTestUserSshKeyName'
$global:PesterTestUserSshKeyPublicKey = 'PesterTestUserSshKeyPublicKey'
Describe 'New-JcSdkUserSshKey' {
    It 'CreateExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        $global:PesterDefUserSshKey.Id = $global:PesterTestUser.Id
        $global:PesterTestUserSshKey = New-JcSdkUserSshKey @global:PesterDefUserSshKey
        $global:PesterTestUserSshKey | Should -Not -BeNullOrEmpty
    }

    It 'CreateViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
