$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemTraversePolicy.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

$global:PesterTestAuthenticationPolicy

Describe 'Get-JcSdkSystemTraversePolicy' {
    BeforeAll {
        # Associate User Group > System Group > System
        # Note: $global:PesterTestAuthenticationPolicy is attached to $global:PesterTestUserGroup, which is why this works
        Set-JcSdkUserGroupAssociation -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestSystemGroup.Id) -Op:('add') -Type:('system_group')
        Set-JcSdkSystemGroupMember -GroupId:($global:PesterTestSystemGroup.Id) -Id:($global:PesterTestSystem.Id) -Op:('add')
    }

    AfterAll {
        # Remove Associations
        Set-JcSdkUserGroupAssociation -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestSystemGroup.Id) -Op:('remove') -Type:('system_group')
        Set-JcSdkSystemGroupMember -GroupId:($global:PesterTestSystemGroup.Id) -Id:($global:PesterTestSystem.Id) -Op:('remove')
    }

    It 'Get' {
        $AssociationTest = JumpCloud.SDK.V2\Get-JcSdkSystemTraversePolicy -SystemId:($global:PesterTestSystem.Id)
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
