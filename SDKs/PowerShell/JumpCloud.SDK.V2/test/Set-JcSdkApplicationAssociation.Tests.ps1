$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkApplicationAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkApplicationAssociation' {
    It 'SetExpanded' -skip {
        { Set-JcSdkApplicationAssociation -ApplicationId '<String>' -Id '<String>' -Op '<String>' -Type '<String>' [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkApplicationAssociation -ApplicationId '<String>' -Body '<IGraphOperationApplication>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkApplicationAssociation -Body '<IGraphOperationApplication>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkApplicationAssociation -Id '<String>' -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
