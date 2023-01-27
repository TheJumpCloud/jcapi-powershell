BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightDiskEncryption.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightDiskEncryption' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightDiskEncryption } | Should -Not -Throw
    }
    It 'List Filter Tests' {
        $siEncrypt = Get-JcSdkSystemInsightDiskEncryption | Get-Random -Count 1
        if ($siEncrypt) {
            Get-JcSdkSystemInsightDiskEncryption -Filter @("system_id:eq:$($siEncrypt.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightDiskEncryption -Filter @("system_id:eq:$($siEncrypt.systemId)", "encryption_status:eq:$($siEncrypt.encryptionStatus)") | Should -Not -BeNullOrEmpty
            # encryption_status accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightDiskEncryption -Filter @("system_id:eq:$($siEncrypt.systemId)", "encryption_status:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

