$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Stop-JcSdkSystem.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Stop-JcSdkSystem' {
    It 'Stop' -Skip {
        { Stop-JcSdkSystem -SystemId '<String>' } | Should -Not -Throw
    }

    It 'StopViaIdentity' -Skip {
        { Stop-JcSdkSystem -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
