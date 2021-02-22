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
        $User = (Get-JcSdkUser)[0]
        $SshKey = Get-JcSdkUserSshKey -Id:($User.Id)
        If (-not [System.String]::IsNullOrEmpty($SshKey))
        {
            $SshKey.Id | ForEach-Object {
                Remove-JcSdkUserSshKey -Id:($_) -UserId:($User.Id)
            }
        }
        New-JcSdkUserSshKey -Id:($User.Id) -Name:($global:PesterTestUserSshKeyName) -PublicKey:($global:PesterTestUserSshKeyPublicKey) | Should -Not -BeNullOrEmpty
    }

    It 'CreateViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
