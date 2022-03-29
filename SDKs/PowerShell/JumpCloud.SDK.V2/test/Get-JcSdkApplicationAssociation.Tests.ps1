BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkApplicationAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkApplicationAssociation' -Tag:(""){
    It 'Get' {
        { Get-JcSdkApplicationAssociation -ApplicationId:($global:PesterTestApplication.Id) -Targets:('user') } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkApplicationAssociation -InputObject '<IJumpCloudApIsIdentity>' -Targets:('user') } | Should -Not -Throw
    }
}

