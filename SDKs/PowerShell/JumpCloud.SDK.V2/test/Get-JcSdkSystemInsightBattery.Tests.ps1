BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightBattery.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightBattery' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightBattery } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siBattery = Get-JcSdkSystemInsightBattery | Get-Random -Count 1
        if ($siBattery) {
            Get-JcSdkSystemInsightBattery -Filter @("system_id:eq:$($siBattery.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightBattery -Filter @("system_id:eq:$($siBattery.systemId)", "health:eq:$($siBattery.health)") | Should -Not -BeNullOrEmpty
            # health accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightBattery -Filter @("system_id:eq:$($siBattery.systemId)", "health:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

