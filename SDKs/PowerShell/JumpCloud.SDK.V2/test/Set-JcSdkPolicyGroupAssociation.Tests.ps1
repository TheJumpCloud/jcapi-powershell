BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkPolicyGroupAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkPolicyGroupAssociation' -Tag:(""){
    It 'SetExpanded' -skip {
        # get some system group
        $group = get-jcsdksystemGroup | Select-Object -First 1
        # if the group is already associated with the policy, remove it first
        $groupAssoc = Get-JcSdkPolicyGroupAssociation -GroupId $global:PesterTestPolicyGroup.Id | Where-Object { $_.Type -eq 'system_group' -and $_.Id -eq $group.Id }
        if ($groupAssoc) {
            {Set-JcSdkPolicyGroupAssociation -GroupId $global:PesterTestPolicyGroup.Id -Op 'remove' -Type 'system_group' -id $group.Id} | Should -Not -Throw
        }
        {Set-JcSdkPolicyGroupAssociation -GroupId $global:PesterTestPolicyGroup.Id -Op 'add' -Type 'system_group' -id $group.Id} | Should -Not -Throw
        {Set-JcSdkPolicyGroupAssociation -GroupId $global:PesterTestPolicyGroup.Id -Op 'remove' -Type 'system_group' -id $group.Id} | Should -Not -Throw

    }


    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

