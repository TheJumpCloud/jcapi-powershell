BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-JcSdkAuthenticationPolicy.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Update-JcSdkAuthenticationPolicy' -Tag:("")){
    It 'update' -skip {
        { Update-JcSdkAuthenticationPolicy -body:($global:PesterDefApplicationd) } | Should -Not -Throw
    }

    It 'UpdateExpanded' {
        { Update-JcSdkAuthenticationPolicy -Id:($global:PesterTestAuthenticationPolicy.Id) -UserGroupInclusions:($global:PesterTestUserGroup.id) -TargetResources:($global:PesterTestAuthenticationPolicy.TargetResources)  } | Should -Not -Throw
    }

    It 'UpdateViaIdentity' -skip {
        { Update-JcSdkAuthenticationPolicy -Body:($global:PesterTestAuthenticationPolicy) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' -skip {
        { Update-JcSdkAuthenticationPolicy -InputObject '<IJumpCloudApIsIdentity>' [-Conditions '<Hashtable>'] [-Description '<String>'] [-Disabled] [-EffectAction '<String>'] [-MfaRequired] [-Name '<String>'] [-TargetResources '<IAuthnPolicyResourceTarget[]>'] [-Type '<String>'] [-UserGroupExclusions '<String[]>'] [-UserGroupInclusions '<String[]>'] [-UserInclusions '<String[]>'] } | Should -Not -Throw
    }
}

