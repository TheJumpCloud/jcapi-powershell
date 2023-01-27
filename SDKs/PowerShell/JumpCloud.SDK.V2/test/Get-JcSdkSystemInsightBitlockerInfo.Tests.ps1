BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightBitlockerInfo.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightBitlockerInfo' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightBitlockerInfo } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siBitLocker = Get-JcSdkSystemInsightBitlockerInfo | Get-Random -Count 1
        if ($siBitLocker) {
            Get-JcSdkSystemInsightBitlockerInfo -Filter @("system_id:eq:$($siBitLocker.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightBitlockerInfo -Filter @("system_id:eq:$($siBitLocker.systemId)", "protection_status:eq:$($siBitLocker.protectionstatus)") | Should -Not -BeNullOrEmpty
            # protection_status accepts ints, 9988 is a fake value
            Get-JcSdkSystemInsightBitlockerInfo -Filter @("system_id:eq:$($siBitLocker.systemId)", "protection_status:eq:9988") | Should -BeNullOrEmpty
        }
    }
}

