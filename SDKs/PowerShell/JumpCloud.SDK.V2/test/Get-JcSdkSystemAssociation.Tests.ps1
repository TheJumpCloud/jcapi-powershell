BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemAssociation' -Tag:(""){
    It 'Get' {
        { Get-JcSdkSystemAssociation -SystemId:($global:PesterTestSystem.Id) -Targets:('user') } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkSystemAssociation -InputObject '<IJumpCloudApIsIdentity>' -Targets:('user') [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }
}

