$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserGroup' {
    It 'List' {
        $GroupListTest = JumpCloud.SDK.V2\Get-JcSdkUserGroup
        If ([System.String]::IsNullOrEmpty($GroupListTest))
        {
            $GroupListTest | Should -Not -BeNullOrEmpty
        }
        else
        {
            # Test that a group exists
            $GroupListTest.Count | Should -BeGreaterOrEqual 1
        }
    }

    It 'Get' {
        $GroupGetTest = JumpCloud.SDK.V2\Get-JcSdkUserGroup -Id:($global:PesterTestUserGroup.Id)
        If ([System.String]::IsNullOrEmpty($GroupGetTest))
        {
            $GroupGetTest | Should -Not -BeNullOrEmpty
        }
        else
        {
            # Test that a group exists and you can query it by ID
            $GroupGetTest.Count | Should -BeGreaterOrEqual 1
        }
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
