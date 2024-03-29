BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkActiveDirectory.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkActiveDirectory' -Tag:(""){
    It 'CreateExpanded' {
        $global:PesterTestActiveDirectory = New-JcSdkActiveDirectory @global:PesterDefActiveDirectory
        $global:PesterTestActiveDirectory | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkActiveDirectory -Body:($global:PesterTestActiveDirectory) } | Should -Not -Throw
    }
}

