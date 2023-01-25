BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightLaunchd.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightLaunchd' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightLaunchd } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siLaunchD = Get-JcSdkSystemInsightLaunchd | Get-Random -Count 1
        if ($siLaunchD) {
            Get-JcSdkSystemInsightLaunchd -Filter @("system_id:eq:$($siLaunchD.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightLaunchd -Filter @("system_id:eq:$($siLaunchD.systemId)", "name:eq:$($siLaunchD.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightLaunchd -Filter @("system_id:eq:$($siLaunchD.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

