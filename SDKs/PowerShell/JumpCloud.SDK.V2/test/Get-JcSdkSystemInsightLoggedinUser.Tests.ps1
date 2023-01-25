BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightLoggedinUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightLoggedinUser' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightLoggedinUser } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siUser = Get-JcSdkSystemInsightLoggedinUser | Get-Random -Count 1
        if ($siUser) {
            Get-JcSdkSystemInsightLoggedinUser -Filter @("system_id:eq:$($siUser.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightLoggedinUser -Filter @("system_id:eq:$($siUser.systemId)", "type:eq:$($siUser.type)") | Should -Not -BeNullOrEmpty
            # type accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightLoggedinUser -Filter @("system_id:eq:$($siUser.systemId)", "type:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

