BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkCommand.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Set-JcSdkCommand' -Tag:(""){
    It 'Start a command just by command Id' {
        Start-JcSdkCommand -Id:($global:PesterTestCommand.Id) | Should -Not -Throw
    }
    It 'Start a command by command Id and system Id' {
        Start-JcSdkCommand -Id:($global:PesterTestCommand.Id) -SystemId:($global:PesterTestSystem.Id) | Should -Not -Throw
    }
}
