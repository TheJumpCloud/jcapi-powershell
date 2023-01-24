BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightOSVersion.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightOSVersion' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightOSVersion } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siOSVer = Get-JcSdkSystemInsightOSVersion | Get-Random -Count 1
        if ($siOSVer) {
            Get-JcSdkSystemInsightOSVersion -Filter @("system_id:eq:$($siOSVer.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightOSVersion -Filter @("system_id:eq:$($siOSVer.systemId)", "version:eq:$($siOSVer.version)") | Should -Not -BeNullOrEmpty
            # version accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightOSVersion -Filter @("system_id:eq:$($siOSVer.systemId)", "version:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

