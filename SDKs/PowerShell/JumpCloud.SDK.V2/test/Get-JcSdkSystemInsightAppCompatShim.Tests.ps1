BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightAppCompatShim.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightAppCompatShim' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightAppCompatShim } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siAppShim = Get-JcSdkSystemInsightAppCompatShim | Get-Random -Count 1
        if ($siAppShim){
            Get-JcSdkSystemInsightAppCompatShim -Filter @("system_id:eq:$($siAppShim.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightAppCompatShim -Filter @("system_id:eq:$($siAppShim.systemId)", "enabled:eq:$($siAppShim.enabled)") | Should -Not -BeNullOrEmpty
            # enabled accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightAppCompatShim -Filter @("system_id:eq:$($siAppShim.systemId)", "enabled:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

