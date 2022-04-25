BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkUser.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-JcSdkUser' -Tag:(""){
    It 'CreateExpanded' {
        $global:PesterTestUser = New-JcSdkUser @global:PesterDefUser
        $global:PesterTestUser | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkUser -Body:($global:PesterTestUser) } | Should -Not -Throw
    }
}
