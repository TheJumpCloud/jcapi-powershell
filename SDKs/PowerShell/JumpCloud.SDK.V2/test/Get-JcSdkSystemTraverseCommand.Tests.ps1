$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemTraverseCommand.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkSystemTraverseCommand' {
    BeforeAll{
        # Associate User > System
        Set-JCSdkSystemAssociation -SystemId:($global:PesterTestSystem.Id) -Id:($global:PesterTestCommand.Id) -Op:('add') -Type:("command")
    }

    AfterAll{
        # Remove Associations
        Set-JCSdkSystemAssociation -SystemId:($global:PesterTestSystem.Id) -Id:($global:PesterTestCommand.Id) -Op:('remove') -Type:("command")
    }

    It 'Get' {
        $AssociationTest = JumpCloud.SDK.V2\Get-JcSdkSystemTraverseCommand -SystemId:($global:PesterTestSystem.Id)
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
