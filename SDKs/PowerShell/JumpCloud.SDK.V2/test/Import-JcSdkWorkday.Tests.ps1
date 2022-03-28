BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Import-JcSdkWorkday.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Import-JcSdkWorkday' -Tag:("")){
    It 'Import' -skip {
        { Import-JcSdkWorkday -Body:($global:PesterTestWorkday) -WorkdayId '<String>' } | Should -Not -Throw
    }

    It 'ImportViaIdentity' -skip {
        { Import-JcSdkWorkday -Body:($global:PesterTestWorkday) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

