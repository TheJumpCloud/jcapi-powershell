BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightShadow.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightShadow' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightShadow } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siShadow = Get-JcSdkSystemInsightShadow | Get-Random -Count 1
        if ($siShadow) {
            Get-JcSdkSystemInsightShadow -Filter @("system_id:eq:$($siShadow.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightShadow -Filter @("system_id:eq:$($siShadow.systemId)", "username:eq:$($siShadow.username)") | Should -Not -BeNullOrEmpty
            # username accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightShadow -Filter @("system_id:eq:$($siShadow.systemId)", "username:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

