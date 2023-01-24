BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightDiskInfo.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightDiskInfo' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightDiskInfo } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siAppShim = Get-JcSdkSystemInsightDiskInfo | Get-Random -Count 1
        if ($siAppShim) {
            Get-JcSdkSystemInsightDiskInfo -Filter @("system_id:eq:$($siAppShim.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightDiskInfo -Filter @("system_id:eq:$($siAppShim.systemId)", "disk_index:eq:$($siAppShim.disk_index)") | Should -Not -BeNullOrEmpty
            # disk_index accepts ints, 9988 is a fake value
            Get-JcSdkSystemInsightDiskInfo -Filter @("system_id:eq:$($siAppShim.systemId)", "disk_index:eq:9988") | Should -BeNullOrEmpty
        }
    }
}

