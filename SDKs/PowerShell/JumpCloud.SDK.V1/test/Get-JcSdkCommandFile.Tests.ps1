BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkCommandFile.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkCommandFile' -Tag:(""){
    It 'Get' {
        $newCommand = New-JcSdkCommand @global:PesterDefCommand
        $testCommandFile = Get-JcSdkCommand | Where-Object { $_.Name -eq $NewCommand.Name } | Select-Object -First 1
        { Get-JcSdkCommandFile -Id:($($testCommandFile.Id)) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkCommandFile -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
