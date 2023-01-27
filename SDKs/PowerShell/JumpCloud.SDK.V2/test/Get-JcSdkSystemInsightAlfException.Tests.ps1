BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightAlfException.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightAlfException' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightAlfException } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siAlfExc = Get-JcSdkSystemInsightAlfException | Get-Random -Count 1
        if ($siAlfExc){
            Get-JcSdkSystemInsightAlfException -Filter @("system_id:eq:$($siAlfExc.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightAlfException -Filter @("system_id:eq:$($siAlfExc.systemId)", "state:eq:$($siAlfExc.state)") | Should -Not -BeNullOrEmpty
            # state accepts ints, 9 is a fake value
            Get-JcSdkSystemInsightAlfException -Filter @("system_id:eq:$($siAlfExc.systemId)", "state:eq:9") | Should -BeNullOrEmpty
        }
    }
}

