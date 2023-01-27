BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightAlf.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightAlf' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightAlf } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siAlf = Get-JcSdkSystemInsightAlf | Get-Random -Count 1
        if ($siAlf){
            Get-JcSdkSystemInsightAlf -Filter @("system_id:eq:$($siAlf.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightAlf -Filter @("system_id:eq:$($siAlf.systemId)", "global_state:eq:$($siAlf.globalState)") | Should -Not -BeNullOrEmpty
            # global_state accepts ints, 9 is a fake value
            Get-JcSdkSystemInsightAlf -Filter @("system_id:eq:$($siAlf.systemId)", "global_state:eq:9") | Should -BeNullOrEmpty
        }
    }
}

