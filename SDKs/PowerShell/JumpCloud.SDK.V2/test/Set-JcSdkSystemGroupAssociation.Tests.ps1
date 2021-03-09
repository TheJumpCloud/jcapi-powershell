$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystemGroupAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSystemGroupAssociation' {
    It 'SetExpanded' -skip {
        { Set-JcSdkSystemGroupAssociation -GroupId '<String>' -Id '<String>' -Op '<String>' -Type '<String>' [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkSystemGroupAssociation -Body '<IGraphOperationSystemGroup>' -GroupId '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystemGroupAssociation -Body '<IGraphOperationSystemGroup>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystemGroupAssociation -Id '<String>' -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
