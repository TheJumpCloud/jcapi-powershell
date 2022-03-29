BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkWorkday.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkWorkday' -Tag:(""){
    It 'CreateExpanded' -skip {
        $global:PesterTestWorkday = New-JcSdkWorkday @global:PesterDefWorkday
        $global:PesterTestWorkday | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkWorkday -Body:($global:PesterTestWorkday) } | Should -Not -Throw
    }
}

