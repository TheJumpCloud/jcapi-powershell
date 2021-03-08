$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkLdapServerTraverseUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkLdapServerTraverseUser' {
    BeforeAll {
        Set-JcSdkLdapServerAssociation -LdapserverId $($global:PesterLdapServer.Id) -Id $($global:PesterTestUser.Id) -Op 'add' -Type 'user'
    }
    AfterAll {
        Set-JcSdkLdapServerAssociation -LdapserverId $($global:PesterLdapServer.Id) -Id $($global:PesterTestUser.Id) -Op 'remove' -Type 'user'
    }
    It 'List' {
        Get-JcSdkLdapServerTraverseUser -LdapserverId $($global:PesterLdapServer.Id) | Should -Not -BeNullOrEmpty
    }
}
