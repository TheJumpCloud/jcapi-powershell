$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSoftwareAppAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkSoftwareAppAssociation' {
    It 'Get' {
        { Get-JcSdkSoftwareAppAssociation -SoftwareAppId:($global:PesterTestSoftwareApp.Id) -Targets:('system_group') } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkSoftwareAppAssociation -InputObject '<IJumpCloudApIsIdentity>' -Targets:('system_group') } | Should -Not -Throw
    }
}
