BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkPolicyGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkPolicyGroup' -Tag:(""){
    It 'SetExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Set' {
        $groups = Get-JcSdkPolicyGroup
        # if some Group already exists with the same name, delete it
        $existingGroup = $groups | Where-Object { $_.Name -eq "Pester_Set_Test" }
        if ($existingGroup) {
            Remove-JcSdkPolicyGroup -Id:($existingGroup.Id)
        }
        { Set-JcSdkPolicyGroup -Id:($global:PesterTestPolicyGroup.Id) -Name "Pester_Set_Test" } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

