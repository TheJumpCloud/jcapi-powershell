BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightProgram.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightProgram' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightProgram } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siProgram = Get-JcSdkSystemInsightProgram | Where-Object { $_.Name -notmatch "\+\+" } | Get-Random -Count 1
        if ($siProgram) {
            Get-JcSdkSystemInsightProgram -Filter @("system_id:eq:$($siProgram.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightProgram -Filter @("system_id:eq:$($siProgram.systemId)", "name:eq:$($siProgram.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightProgram -Filter @("system_id:eq:$($siProgram.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

