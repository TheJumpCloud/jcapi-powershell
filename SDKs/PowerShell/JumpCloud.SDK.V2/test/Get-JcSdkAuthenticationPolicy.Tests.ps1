BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkAuthenticationPolicy.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkAuthenticationPolicy' -Tag:(""){
    It 'List' {
        { Get-JcSdkAuthenticationPolicy } | Should -Not -Throw
    }

    It 'List Auth Policy Filter Tests' {
        $authPolicy = Get-JcSdkAuthenticationPolicy | Get-Random -Count 1
        Get-JcSdkAuthenticationPolicy -Filter @("name:eq:$($authPolicy.name)") | Should -Not -BeNullOrEmpty
        Get-JcSdkAuthenticationPolicy -Filter @("name:eq:$($authPolicy.name)", "type:eq:$($authPolicy.type)") | Should -Not -BeNullOrEmpty
        Get-JcSdkAuthenticationPolicy -Filter @("name:eq:$($authPolicy.name)", "type:eq:fakeType") | Should -BeNullOrEmpty
    }

    It 'Get' {
        { Get-JcSdkAuthenticationPolicy -Id:($global:PesterTestAuthenticationPolicy.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkAuthenticationPolicy -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

