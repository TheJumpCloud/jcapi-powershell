$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-JcSdkExpireUserPassword.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-JcSdkExpireUserPassword' {
    AfterAll {
        Set-JcSdkUser -Id:($global:PesterTestUser.Id) -Password:($global:PesterDefUser.Password)
    }
    
    It 'Post' {
        { Invoke-JcSdkExpireUserPassword -Id:($global:PesterTestUser.Id) } | Should -Not -Throw
        (Get-JcSdkUser -Id:($global:PesterTestUser.Id)).PasswordExpired | Should -Be $true
    }

    It 'PostViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
