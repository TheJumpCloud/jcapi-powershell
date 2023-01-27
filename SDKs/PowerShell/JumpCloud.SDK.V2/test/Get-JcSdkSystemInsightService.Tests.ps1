BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightService.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightService' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightService } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siservice = Get-JcSdkSystemInsightService | Get-Random -Count 1
        if ($siservice) {
            Get-JcSdkSystemInsightService -Filter @("system_id:eq:$($siservice.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightService -Filter @("system_id:eq:$($siservice.systemId)", "name:eq:$($siservice.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightService -Filter @("system_id:eq:$($siservice.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

