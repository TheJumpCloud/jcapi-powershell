BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkCustomEmailConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkCustomEmailConfiguration' -Tag:("") -skip{
    It 'Get' {
        { Get-JcSdkCustomEmailConfiguration -CustomEmailType:($global:PesterTestCustomEmailConfiguration.Type) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkCustomEmailConfiguration -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

