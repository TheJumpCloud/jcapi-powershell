BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightAlfExplicitAuth.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightAlfExplicitAuth' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightAlfExplicitAuth } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siAlfAuth = Get-JcSdkSystemInsightAlfExplicitAuth | Get-Random -Count 1
        if ($siAlfAuth){
            Get-JcSdkSystemInsightAlfExplicitAuth -Filter @("system_id:eq:$($siAlfAuth.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightAlfExplicitAuth -Filter @("system_id:eq:$($siAlfAuth.systemId)", "process:eq:$($siAlfAuth.process)") | Should -Not -BeNullOrEmpty
            # process accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightAlfExplicitAuth -Filter @("system_id:eq:$($siAlfAuth.systemId)", "process:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

