$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkGSuiteAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkGSuiteAssociation' {
    It 'SetExpanded' -skip {
        { Set-JcSdkGSuiteAssociation -GsuiteId:($global:PesterTestGsuite.Id) -Id:($global:PesterTestGSuiteAssociation.Id) -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkGSuiteAssociation -Body '<IGraphOperationGSuite>' -GsuiteId:($global:PesterTestGsuite.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkGSuiteAssociation -Body '<IGraphOperationGSuite>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkGSuiteAssociation -Id:($global:PesterTestGSuiteAssociation.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }
}
