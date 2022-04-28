BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkUser.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-JcSdkUser' -Tag:(""){
    It 'Delete' {
        { Remove-JcSdkUser -Id:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -skip {
        { Remove-JcSdkUser -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
