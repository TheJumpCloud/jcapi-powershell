BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkCommandResult.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-JcSdkCommandResult' -Tag:(""){
    It 'Delete' {
        { Get-JcSdkCommandResult | Where-Object { $_.Name -eq $global:PesterDefCommandName } | ForEach-Object { Remove-JcSdkCommandResult -Id $_.Id } } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -skip {
        { Remove-JcSdkCommandResult -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
