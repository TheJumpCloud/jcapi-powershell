BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkOffice365Association.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkOffice365Association' -Tag:(""){
    It 'SetExpanded' {
       # get some user group
        $group = get-jcsdkuserGroup | Select-Object -First 1
        {Set-JcSdkOffice365Association -Office365Id $global:PesterTestOffice365.Id -Op 'add' -Type 'user_group' -id $group.Id} | Should -Not -Throw
        {Set-JcSdkOffice365Association -Office365Id $global:PesterTestOffice365.Id -Op 'remove' -Type 'user_group' -id $group.Id} | Should -Not -Throw
    }


    It 'SetViaIdentity' -skip {
        { Set-JcSdkOffice365Association -Body:(@{Id = $global:PesterTestUser.Id; Op = 'add'; Type = 'user';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkOffice365Association -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

