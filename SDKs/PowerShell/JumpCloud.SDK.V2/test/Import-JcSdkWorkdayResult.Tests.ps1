BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Import-JcSdkWorkdayResult.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Import-JcSdkWorkdayResult' -Tag:(""){
    It 'Import' -skip {
        { Import-JcSdkWorkdayResult -Id:($global:PesterTestWorkdayResult.Id) -JobId '<String>' } | Should -Not -Throw
    }

    It 'ImportViaIdentity' -skip {
        { Import-JcSdkWorkdayResult -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

