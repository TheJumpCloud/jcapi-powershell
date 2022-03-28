BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-JcSdkLdapServer.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Update-JcSdkLdapServer' -Tag:("")){
    It 'UpdateExpanded' -skip {
        { Update-JcSdkLdapServer -Id:($global:PesterTestLdapServer.Id) [-Id1 '<String>'] [-UserLockoutAction '<String>'] [-UserPasswordExpirationAction '<String>'] } | Should -Not -Throw
    }

    It 'Update' -skip {
        { Update-JcSdkLdapServer -Body:($global:PesterTestLdapServer) -Id:($global:PesterTestLdapServer.Id) } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' -skip {
        { Update-JcSdkLdapServer -InputObject '<IJumpCloudApIsIdentity>' [-Id '<String>'] [-UserLockoutAction '<String>'] [-UserPasswordExpirationAction '<String>'] } | Should -Not -Throw
    }

    It 'UpdateViaIdentity' -skip {
        { Update-JcSdkLdapServer -Body:($global:PesterTestLdapServer) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

