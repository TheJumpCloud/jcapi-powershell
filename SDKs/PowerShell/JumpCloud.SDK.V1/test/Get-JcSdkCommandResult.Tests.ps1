BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkCommandResult.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkCommandResult' -Tag:(""){
    It 'List' {
        { Get-JcSdkCommandResult } | Should -Not -Throw
    }

    It 'Get' -Skip {
        # TODO: Id Param not accepted, fix required
        { Get-JcSdkCommandResult -Id:($global:PesterTestCommand.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkCommandResult -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
