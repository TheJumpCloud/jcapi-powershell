BeforeAll {
    if(($null -eq $TestName) -or ($TestName -contains 'Initialize-JcSdkUserState'))
    {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'Initialize-JcSdkUserState.Recording.json'
        $currentPath = $PSScriptRoot
        while(-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }
}
Describe 'Initialize-JcSdkUserState' -Tag:(""){
    It 'ActivateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Activate' {
        $AltEmail     = "PesterInitState-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))@altExample.com";
        $body = [JumpCloud.SDK.V1.Models.Systemuserput]@{
            Email     = "PesterInitState-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))@example.com";
            Firstname = "UserState";
            Lastname  = "Init";
            Username  = "PesterInitState-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))";
        }
        $userToInit = New-JcSdkUser -Body $body
        Initialize-JcSdkUserState -Id $userToInit.Id -email $AltEmail
        $userToInit.State | Should -Be "ACTIVATED"
        Remove-JcSdkUser -Id $userToInit.Id
    }

    It 'ActivateViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ActivateViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
