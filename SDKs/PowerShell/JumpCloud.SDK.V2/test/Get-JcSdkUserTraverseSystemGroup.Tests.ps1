$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserTraverseSystemGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserTraverseSystemGroup' {
    BeforeAll{
        # Associate User > User Group > System Group
        Set-JCSdkUserGroupMember -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestUser.Id) -Op:('add')
        Set-JcSdkUserGroupAssociation -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestSystemGroup.Id) -Op:('add') -Type:('system_group')
    }

    AfterAll{
        # Remove Associations
        Set-JCSdkUserGroupMember -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestUser.Id) -Op:('remove')
        Set-JcSdkUserGroupAssociation -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestSystemGroup.Id) -Op:('remove') -Type:('system_group')
    }

    It 'Get' {
        $AssociationTest = JumpCloud.SDK.V2\Get-JcSdkUserTraverseSystemGroup -UserId:($global:PesterTestUser.Id)
        If ([System.String]::IsNullOrEmpty($AssociationTest))
        {
            $AssociationTest | Should -Not -BeNullOrEmpty
        }
        else
        {
            # Test that an association exists
            $AssociationTest.Count | Should -BeGreaterOrEqual 1
        }
    }
    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
