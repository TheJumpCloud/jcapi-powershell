BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightCupDestination.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightCupDestination' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightCupDestination } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siCups = Get-JcSdkSystemInsightCupDestination | Get-Random -Count 1
        if ($siCups) {
            Get-JcSdkSystemInsightCupDestination -Filter @("system_id:eq:$($siCups.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightCupDestination -Filter @("system_id:eq:$($siCups.systemId)", "name:eq:$($siCups.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightCupDestination -Filter @("system_id:eq:$($siCups.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

