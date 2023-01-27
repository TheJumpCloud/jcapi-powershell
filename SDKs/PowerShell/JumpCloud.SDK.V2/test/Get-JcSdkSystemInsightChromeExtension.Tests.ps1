BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightChromeExtension.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightChromeExtension' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightChromeExtension } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siChromeExt = Get-JcSdkSystemInsightChromeExtension | Get-Random -Count 1
        if ($siChromeExt) {
            Get-JcSdkSystemInsightChromeExtension -Filter @("system_id:eq:$($siChromeExt.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightChromeExtension -Filter @("system_id:eq:$($siChromeExt.systemId)", "name:eq:$($siChromeExt.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightChromeExtension -Filter @("system_id:eq:$($siChromeExt.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

