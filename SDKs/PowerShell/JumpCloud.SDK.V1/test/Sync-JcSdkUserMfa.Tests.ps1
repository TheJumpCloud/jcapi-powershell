BeforeAll {
if(($null -eq $TestName) -or ($TestName -contains 'Sync-JcSdkUserMfa'))
{
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Sync-JcSdkUserMfa.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'Sync-JcSdkUserMfa' -Tag:(""){
    It 'Sync' {
        $body = [JumpCloud.SDK.V1.Models.Systemuserput]@{
            Email     = "PesterMFASync-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))@example.com";
            Firstname = "PesterMFA";
            Lastname  = "Sync";
            Username  = "PesterMFASync-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))";
            Password  = "TestTest1234!@#"
        }
        $userToSync = New-JcSdkUser -Body $body
        { Sync-JcSdkUserMfa -Id $userToSync.Id } | Should -Not Throw
    }

    It 'SyncViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
