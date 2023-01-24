BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightMount.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightMount' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightMount } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siMount = Get-JcSdkSystemInsightMount | Get-Random -Count 1
        if ($siMount) {
            Get-JcSdkSystemInsightMount -Filter @("system_id:eq:$($siMount.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightMount -Filter @("system_id:eq:$($siMount.systemId)", "path:eq:$($siMount.path)") | Should -Not -BeNullOrEmpty
            # path accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightMount -Filter @("system_id:eq:$($siMount.systemId)", "path:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

