$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserTraverseOffice365.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserTraverseOffice365' {
    BeforeAll{
        # Associate User > Office 365
        Set-JCSdkUserAssociation -UserId:($global:PesterTestUser.Id) -Id:($global:PesterTestOffice365.Id) -Op:('add') -Type:("office_365")
    }

    AfterAll{
        # Remove Associations
        Set-JCSdkUserAssociation -UserId:($global:PesterTestUser.Id) -Id:($global:PesterTestOffice365.Id) -Op:('remove') -Type:("office_365")
   }

    It 'Get' {
        $AssociationTest = JumpCloud.SDK.V2\Get-JcSdkUserTraverseOffice365 -UserId:($global:PesterTestUser.Id)
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
