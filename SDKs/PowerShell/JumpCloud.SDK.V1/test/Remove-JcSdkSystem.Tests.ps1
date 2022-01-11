$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkSystem.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-JcSdkSystem' {
    # TODO: implemnet a step to add the pester test system after we run this.
    # This test is removing the system necessary for Pester Tests to complete in the PowerShell Module pipeline
    It 'Delete' -Skip {
        { Remove-JcSdkSystem -Id:($global:PesterTestSystem.Id) } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -skip {
        { Remove-JcSdkSystem -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
