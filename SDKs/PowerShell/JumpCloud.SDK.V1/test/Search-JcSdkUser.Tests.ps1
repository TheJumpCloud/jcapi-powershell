$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Search-JcSdkUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Search-JcSdkUser' {
    It 'SearchExpanded' -skip {
        { Search-JcSdkUser  [-Fields1 '<String>'] [-Filter1 '<Hashtable>'] [-SearchFilter '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Search' -skip {
        { Search-JcSdkUser -Body '<ISearch>'  } | Should -Not -Throw
    }
}
