BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkPolicyGroupMember.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkPolicyGroupMember' -Tag:(""){
    It 'SetExpanded' {
        # if policy group already exists delete it
        $policyGroupExists = Get-JcsdkPolicyGroup | Where-Object { $_.Name -eq "TestGroupMember" }
        if ($policyGroupExists) {
            Remove-JcSdkPolicyGroup -ID:($policyGroupExists.Id)
        }
        $PesterTestPolicyGroup = New-JcSdkPolicyGroup -Name "TestGroupMember"
        $Policy = New-JcSdkPolicy -Name "GroupMemberTestPolicy" -TemplateID 5d1bd26645886d53586ec529

        # if the policy is already a member, remove it first
        $existingMembers = Get-JcSdkPolicyGroupMember -GroupId:($PesterTestPolicyGroup.Id)
        if ($existingMembers | Where-Object { $_.Id -eq $Policy.Id }) {
            { Set-JcSdkPolicyGroupMember -GroupId:($PesterTestPolicyGroup.Id) -Id:($Policy.Id) -Op 'remove' } | Should -Not -Throw
        }
        { Set-JcSdkPolicyGroupMember -GroupId:($PesterTestPolicyGroup.Id) -Id:($Policy.Id) -Op 'add' } | Should -Not -Throw

        Remove-JcSdkPolicy -ID:($Policy.Id)
        Remove-JcSdkPolicyGroup -ID:($PesterTestPolicyGroup.Id)
    }

    It 'Set' -skip {
        #TODO: Set using Body param
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

