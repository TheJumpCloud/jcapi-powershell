$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkLdapServerAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkLdapServerAssociation' {
    BeforeAll {
        Set-JcSdkLdapServerAssociation -LdapserverId $($global:PesterLdapServer.Id) -Id $($global:PesterTestUser.id) -op add -type user
    }
    AfterAll {
        Set-JcSdkLdapServerAssociation -LdapserverId $($global:PesterLdapServer.Id) -Id $($global:PesterTestUser.id) -op remove -type user
    }
    It 'List' {
        Get-JcSdkLdapServerAssociation -LdapserverId $($global:PesterLdapServer.Id) -Targets user | Should -Not -BeNullOrEmpty
    }
}
