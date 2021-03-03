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

Describe 'New-JcSdkAuthenticationPolicy' {
    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        $global:PesterTestAuthenticationPolicy = New-JcSdkAuthenticationPolicy -Name "AuthenticationPolicy-$(RandomString -len 7)" -EffectAction allow -TargetResources @{"type" = "user_portal" } -UserGroupInclusions $($global:PesterTestUserGroup.id)
        $global:PesterTestAuthenticationPolicy | Should -Not -BeNullOrEmpty
    }
}
