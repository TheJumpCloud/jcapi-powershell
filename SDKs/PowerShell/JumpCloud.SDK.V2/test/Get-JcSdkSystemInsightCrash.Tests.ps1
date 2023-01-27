BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightCrash.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightCrash' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightCrash } | Should -Not -Throw
    }
    It 'List Filter Tests' {
        $siCrash = Get-JcSdkSystemInsightCrash | Get-Random -Count 1
        if ($siCrash) {
            Get-JcSdkSystemInsightCrash -Filter @("system_id:eq:$($siCrash.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightCrash -Filter @("system_id:eq:$($siCrash.systemId)", "identifier:eq:$($siCrash.identifier)") | Should -Not -BeNullOrEmpty
            # identifier accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightCrash -Filter @("system_id:eq:$($siCrash.systemId)", "identifier:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

