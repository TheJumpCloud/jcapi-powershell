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
        { Set-JcSdkLdapServerAssociation -Id:($global:PesterTestUser.Id) -LdapserverId:($global:PesterTestLdapserver.Id) -Op:('add') -Type:('user') } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkLdapServerAssociation -Body:($global:PesterTestLdapServerAssociation) -LdapserverId:($global:PesterTestLdapserver.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkLdapServerAssociation -Body:($global:PesterTestLdapServerAssociation) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkLdapServerAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
