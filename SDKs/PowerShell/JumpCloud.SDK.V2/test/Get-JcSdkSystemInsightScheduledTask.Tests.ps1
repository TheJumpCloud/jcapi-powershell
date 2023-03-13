BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightScheduledTask.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightScheduledTask' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightScheduledTask } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siSchedTask = Get-JcSdkSystemInsightScheduledTask | Get-Random -Count 1
        if ($siSchedTask) {
            Get-JcSdkSystemInsightScheduledTask -Filter @("system_id:eq:$($siSchedTask.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightScheduledTask -Filter @("system_id:eq:$($siSchedTask.systemId)", "enabled:eq:$($siSchedTask.enabled)") | Should -Not -BeNullOrEmpty
            # enabled accepts ints, 9988 is a fake value
            Get-JcSdkSystemInsightScheduledTask -Filter @("system_id:eq:$($siSchedTask.systemId)", "enabled:eq:9988") | Should -BeNullOrEmpty
        }
    }
}

