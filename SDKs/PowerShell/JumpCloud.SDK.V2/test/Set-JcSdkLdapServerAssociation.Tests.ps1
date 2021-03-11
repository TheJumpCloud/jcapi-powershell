$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkLdapServerAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkLdapServerAssociation' {
    It 'SetExpanded' {
        { Set-JcSdkLdapServerAssociation -LdapserverId:($global:PesterLdapServer.Id) -Id:($global:PesterTestUser.id) -op:('add') -type:('user') } | Should -Not -Throw
        { Set-JcSdkLdapServerAssociation -LdapserverId:($global:PesterLdapServer.Id) -Id:($global:PesterTestUser.id) -op:('remove') -type:('user') } | Should -Not -Throw
    }

    It 'Set' {
        $PesterDefAssociation = @{
            Id = $global:PesterTestUser.Id
            Op = 'add'
            Type = 'user'
        } 
        { Set-JcSdkLdapServerAssociation -LdapserverId:($global:PesterLdapServer.Id) -Body:($PesterDefAssociation) } | Should -Not -Throw
        $PesterDefAssociation.Op = 'remove'
        { Set-JcSdkLdapServerAssociation -LdapserverId:($global:PesterLdapServer.Id) -Body:($PesterDefAssociation) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
