BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkGSuiteAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkGSuiteAssociation' -Tag:(""){
    It 'SetExpanded' {
        # get some user group
        $group = get-jcsdkuserGroup | Select-Object -First 1
        {Set-JcSdkGSuiteAssociation -GSuiteId $global:PesterTestGSuite.Id -Op 'add' -Type 'user_group' -id $group.Id} | Should -Not -Throw
        {Set-JcSdkGSuiteAssociation -GSuiteId $global:PesterTestGSuite.Id -Op 'remove' -Type 'user_group' -id $group.Id} | Should -Not -Throw

    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkGSuiteAssociation -Body:(@{Id = $global:PesterTestUser.Id; Op = 'add'; Type = 'user';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkGSuiteAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

