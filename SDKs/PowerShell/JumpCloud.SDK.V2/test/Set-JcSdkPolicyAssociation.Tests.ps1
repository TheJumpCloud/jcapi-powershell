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
        { Set-JcSdkPolicyAssociation -Id '<String>' -Op '<String>' -PolicyId '<String>' -Type '<String>' [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkPolicyAssociation -Body '<IGraphOperationPolicy>' -PolicyId '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkPolicyAssociation -Body '<IGraphOperationPolicy>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkPolicyAssociation -Id '<String>' -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
