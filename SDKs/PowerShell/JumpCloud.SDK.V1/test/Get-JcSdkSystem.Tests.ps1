BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystem.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkSystem' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystem } | Should -Not -Throw
    }

    It 'List System Filter Tests' {
        $system  = Get-JcSdkSystem | Get-Random -count 1
        Get-jcsdksystem -filter @("os:`$eq:$($system.os)") | Should -Not -BeNullOrEmpty
        Get-jcsdksystem -filter @("os:`$eq:$($system.os)", "_id:`$eq:$($system.id)") | Should -Not -BeNullOrEmpty
        Get-jcsdksystem -filter @("os:`$eq:fakeValue", "_id:`$eq:$($system.id)") | Should -BeNullOrEmpty
    }

    It 'Get' {
        { Get-JcSdkSystem -Id:($global:PesterTestSystem.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkSystem -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
