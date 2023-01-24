BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightUptime.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightUptime' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightUptime } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siUptime = Get-JcSdkSystemInsightUptime | Get-Random -Count 1
        if ($siUptime) {
            Get-JcSdkSystemInsightUptime -Filter @("system_id:eq:$($siUptime.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightUptime -Filter @("system_id:eq:$($siUptime.systemId)", "days:eq:$($siUptime.days)") | Should -Not -BeNullOrEmpty
            # days accepts strings, 9988 is a fake value
            Get-JcSdkSystemInsightUptime -Filter @("system_id:eq:$($siUptime.systemId)", "days:eq:9988") | Should -BeNullOrEmpty
        }
    }
}

