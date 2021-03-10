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
    It 'SetExpanded' -skip {
        { Set-JcSdkLdapServerAssociation -Id:($global:PesterTestLdapServerAssociation.Id) -LdapserverId '<String>' -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkLdapServerAssociation -Body '<IGraphOperationLdapServer>' -LdapserverId '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkLdapServerAssociation -Body '<IGraphOperationLdapServer>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkLdapServerAssociation -Id:($global:PesterTestLdapServerAssociation.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }
}
