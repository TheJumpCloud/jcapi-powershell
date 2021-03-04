$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserGroupMembership.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserGroupMembership' {
    BeforeAll{
        # Associate User Group > User
        Set-JcSdkUserGroupMember -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestUser.Id) -Op:('add')
    }

    AfterAll{
        # Remove Associations
        Set-JcSdkUserGroupMember -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestUser.Id) -Op:('remove')
    }

    It 'Get' {
        $AssociationTest = JumpCloud.SDK.V2\Get-JcSdkUserGroupMembership -GroupId:($global:PesterTestUserGroup.Id)
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
