$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkPolicyAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkPolicyAssociation' {
    It 'SetExpanded' -skip {
        { Set-JcSdkPolicyAssociation -Id:($global:PesterTestSystem.Id) -Op:('add') -PolicyId:($global:PesterTestPolicy.Id) -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkPolicyAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -PolicyId:($global:PesterTestPolicy.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkPolicyAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkPolicyAssociation -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
