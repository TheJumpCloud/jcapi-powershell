$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkAppleMdm.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkAppleMdm' {
    It 'List' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
    It 'Valid MDM Server' {
        $mdm = Get-JcSdkAppleMdm
        $mdm.DepServerTokenState | Should -Be "valid"
        $mdm.Id | Should -BeOfType System.String
        $mdm.DepAccessTokenExpiry | Should -BeOfType System.String
        $mdm.ApnsCertExpiry | Should -BeOfType System.String
    }
}
