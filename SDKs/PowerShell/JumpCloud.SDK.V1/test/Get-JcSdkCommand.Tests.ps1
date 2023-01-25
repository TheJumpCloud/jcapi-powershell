BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkCommand.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkCommand' -Tag:(""){
    It 'List' {
        { Get-JcSdkCommand } | Should -Not -Throw
    }

    It 'List Command Filter Tests' {
        $command = Get-JcSdkCommand | Select-Object -First 1
        Get-JcSdkCommand -Filter @("name:eq:$($command.name)") | Should -Not -BeNullOrEmpty
        Get-JcSdkCommand -Filter @("name:eq:$($command.name)", "_id:eq:$($command.id)")  | Should -Not -BeNullOrEmpty
        Get-JcSdkCommand -Filter @("name:eq:$($command.name)", "_id:eq:$($command.Organization)")  | Should -BeNullOrEmpty
    }

    It 'Get' {
        { Get-JcSdkCommand -Id:($global:PesterTestCommand.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkCommand -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
