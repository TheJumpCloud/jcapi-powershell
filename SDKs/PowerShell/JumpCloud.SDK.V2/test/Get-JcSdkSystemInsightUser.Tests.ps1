BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightUser' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightUser } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siUser = Get-JcSdkSystemInsightUser | Get-Random -Count 1
        if ($siUser) {
            Get-JcSdkSystemInsightUser -Filter @("system_id:eq:$($siUser.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightUser -Filter @("system_id:eq:$($siUser.systemId)", "description:eq:$($siUser.description)") | Should -Not -BeNullOrEmpty
            # description description strings, fakeString is a fake value
            Get-JcSdkSystemInsightUser -Filter @("system_id:eq:$($siUser.systemId)", "description:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

