$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserTraverseGSuite.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserTraverseGSuite' {
    BeforeAll{
        # Associate User > G Suite
        Set-JCSdkUserAssociation -UserId:($global:PesterTestUser.Id) -Id:($global:PesterTestGSuite.Id) -Op:('add') -Type:("g_suite")
    }

    AfterAll{
        # Remove Associations
Set-JCSdkUserAssociation -UserId:($global:PesterTestUser.Id) -Id:($global:PesterTestGSuite.Id) -Op:('remove') -Type:("g_suite")   }

    It 'Get' {
        $AssociationTest = JumpCloud.SDK.V2\Get-JcSdkUserTraverseGSuite -UserId:($global:PesterTestUser.Id)
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
