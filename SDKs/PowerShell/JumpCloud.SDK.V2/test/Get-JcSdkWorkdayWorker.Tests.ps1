BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkWorkdayWorker.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkWorkdayWorker' -Tag:(""){
    It 'Get' -skip {
        { Get-JcSdkWorkdayWorker -WorkdayId '<String>' } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkWorkdayWorker -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

