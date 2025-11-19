BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkAuthenticationPolicy.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkAuthenticationPolicy' -Tag:(""){
    It 'CreateExpanded' {
        $global:PesterDefAuthenticationPolicy.UserGroupInclusions = $global:PesterTestUserGroup.Id
        $global:PesterTestAuthenticationPolicy = New-JcSdkAuthenticationPolicy -Body $global:PesterDefAuthenticationPolicy
        $global:PesterTestAuthenticationPolicy | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkAuthenticationPolicy -Body:($global:PesterTestAuthenticationPolicy) } | Should -Not -Throw
    }
}

