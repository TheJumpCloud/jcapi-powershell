BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkOffice365Association.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkOffice365Association' -Tag:(""){
    It 'Get' {
        { Get-JcSdkOffice365Association -Office365Id:($global:PesterTestOffice365.Id) -Targets:('user') } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkOffice365Association -InputObject '<IJumpCloudApIsIdentity>' -Targets:('user') } | Should -Not -Throw
    }
}

