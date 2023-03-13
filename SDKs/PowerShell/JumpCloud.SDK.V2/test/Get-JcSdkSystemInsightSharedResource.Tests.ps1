BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightSharedResource.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightSharedResource' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightSharedResource } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siSharedResource = Get-JcSdkSystemInsightSharedResource | Get-Random -Count 1
        if ($siSharedResource) {
            Get-JcSdkSystemInsightSharedResource -Filter @("system_id:eq:$($siSharedResource.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightSharedResource -Filter @("system_id:eq:$($siSharedResource.systemId)", "type:eq:$($siSharedResource.type)") | Should -Not -BeNullOrEmpty
            # type accepts ints, 9988 is a fake value
            Get-JcSdkSystemInsightSharedResource -Filter @("system_id:eq:$($siSharedResource.systemId)", "type:eq:9988") | Should -BeNullOrEmpty
        }
    }
}

