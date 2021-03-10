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
        { Set-JcSdkApplicationAssociation -ApplicationId:($global:PesterTestApplication.Id) -Id:($global:PesterTestApplicationAssociation.Id) -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkApplicationAssociation -ApplicationId:($global:PesterTestApplication.Id) -Body '<IGraphOperationApplication>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkApplicationAssociation -Body '<IGraphOperationApplication>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkApplicationAssociation -Id:($global:PesterTestApplicationAssociation.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }
}
