BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightSafariExtension.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightSafariExtension' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightSafariExtension } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siSafariExt = Get-JcSdkSystemInsightSafariExtension | Get-Random -Count 1
        if ($siSafariExt) {
            Get-JcSdkSystemInsightSafariExtension -Filter @("system_id:eq:$($siSafariExt.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightSafariExtension -Filter @("system_id:eq:$($siSafariExt.systemId)", "name:eq:$($siSafariExt.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightSafariExtension -Filter @("system_id:eq:$($siSafariExt.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

