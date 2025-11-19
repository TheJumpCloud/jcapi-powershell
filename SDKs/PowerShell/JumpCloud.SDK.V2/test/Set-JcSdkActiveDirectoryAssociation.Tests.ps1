BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkActiveDirectoryAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkActiveDirectoryAssociation' -Tag:(""){
    It 'SetExpanded' {
        # Set association to user group
        $group = get-jcsdkuserGroup | Select-Object -First 1
        {Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId $global:PesterTestActiveDirectory.Id -Op 'add' -Type 'user_group' -id $group.Id} | Should -Not -Throw

        {Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId $global:PesterTestActiveDirectory.Id -Op 'remove' -Type 'user_group' -id $group.Id} | Should -Not -Throw

    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkActiveDirectoryAssociation -Body:(@{Id = $global:PesterTestUser.Id; Op = 'add'; Type = 'user';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkActiveDirectoryAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

