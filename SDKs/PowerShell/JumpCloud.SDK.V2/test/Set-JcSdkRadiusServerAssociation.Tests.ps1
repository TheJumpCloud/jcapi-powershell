BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkRadiusServerAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkRadiusServerAssociation' -Tag:(""){
    It 'SetExpanded' {
        # get some user group
        $group = get-jcsdkuserGroup | Select-Object -First 1
        {Set-JcSdkRadiusServerAssociation -RadiusServerId $global:PesterTestRadiusServer.Id -Op 'add' -Type 'user_group' -id $group.Id} | Should -Not -Throw
        {Set-JcSdkRadiusServerAssociation -RadiusServerId $global:PesterTestRadiusServer.Id -Op 'remove' -Type 'user_group' -id $group.Id} | Should -Not -Throw

    }


    It 'SetViaIdentity' -skip {
        { Set-JcSdkRadiusServerAssociation -Body:(@{Id = $global:PesterTestUser.Id; Op = 'add'; Type = 'user';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkRadiusServerAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

