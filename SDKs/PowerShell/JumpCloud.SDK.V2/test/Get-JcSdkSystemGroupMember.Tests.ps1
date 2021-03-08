$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemGroupMember.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkSystemGroupMember' {
    BeforeAll{
        Set-JcSdkSystemGroupMember -GroupId:($global:PesterTestSystemGroup.Id) -Id:($global:PesterTestSystem.Id) -Op:('add')
    }

    AfterAll{
        # Remove Associations
        Set-JcSdkSystemGroupMember -GroupId:($global:PesterTestSystemGroup.Id) -Id:($global:PesterTestSystem.Id) -Op:('remove')
    }

    It 'Get' {
        $AssociationTest = JumpCloud.SDK.V2\Get-JcSdkSystemMember -SystemId:($global:PesterTestSystem.Id)
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
