BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkPolicy.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkPolicy' -Tag:(""){
    It 'List' {
        { Get-JcSdkPolicy } | Should -Not -Throw
    }

    It 'List Policy Filter Tests' {
        $policy = Get-JcSdkPolicy | Get-Random -Count 1
        Get-JcSdkPolicy -Filter @("name:eq:$($policy.name)") | Should -Not -BeNullOrEmpty
        Get-JcSdkPolicy -Filter @("name:eq:$($policy.name)", "id:eq:$($policy.id)") | Should -Not -BeNullOrEmpty
        Get-JcSdkPolicy -Filter @("name:eq:fakeName", "id:eq:$($policy.id)") | Should -BeNullOrEmpty
    }

    It 'Get' {
        { Get-JcSdkPolicy -Id:($global:PesterTestPolicy.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkPolicy -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

