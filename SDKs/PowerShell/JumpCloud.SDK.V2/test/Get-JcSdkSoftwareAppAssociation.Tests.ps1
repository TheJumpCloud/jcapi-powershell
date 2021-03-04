$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSoftwareAppAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkSoftwareAppAssociation' {
    BeforeAll {
        Set-JcSdkSoftwareAppAssociation -SoftwareAppId $($global:PesterTestSoftwareApp.Id) -Id $($global:PesterTestSystem.Id) -Op 'add' -Type 'system'
    }
    AfterAll {
        Set-JcSdkSoftwareAppAssociation -SoftwareAppId $($global:PesterTestSoftwareApp.Id) -Id $($global:PesterTestSystem.Id) -Op 'remove' -Type 'system'
    }
    It 'Get' -skip {
        Get-JcSdkSoftwareAppAssociation -SoftwareAppId ($global:PesterTestSoftwareApp.id) -Targets system | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
