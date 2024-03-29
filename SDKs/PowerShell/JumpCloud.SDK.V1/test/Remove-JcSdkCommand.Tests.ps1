BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkCommand.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-JcSdkCommand' -Tag:(""){
    It 'Delete a single command' {
        { Remove-JcSdkCommand -Id:($global:PesterTestCommand.Id) } | Should -Not -Throw
    }
    It 'Delete multiple commands'{
        Get-JcSdkCommand | Where-Object { $_.Name -eq $global:PesterDefCommandName } | ForEach-Object { Remove-JcSdkCommand -Id $_.id }
    }

    It 'DeleteViaIdentity' -skip {
        { Remove-JcSdkCommand -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
