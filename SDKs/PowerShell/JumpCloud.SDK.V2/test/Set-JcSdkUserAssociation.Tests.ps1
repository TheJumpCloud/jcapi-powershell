$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUserAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkUserAssociation' {
    It 'SetExpanded' -skip {
        { Set-JcSdkUserAssociation -Id '<String>' -Op '<String>' -Type '<String>' -UserId '<String>' [-AttributeSudoEnabled] [-AttributeSudoWithoutPassword] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkUserAssociation -Body '<IGraphOperationUser>' -UserId '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserAssociation -Body '<IGraphOperationUser>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserAssociation -Id '<String>' -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' [-AttributeSudoEnabled] [-AttributeSudoWithoutPassword] } | Should -Not -Throw
    }
}
