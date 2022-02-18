$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Search-JcSdkOrganization.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Search-JcSdkOrganization' {
    # TODO: MTP Function: Forbidden: organization selection not allowed via header - ORG ID should not be set when running this function
    It 'SearchExpanded' -skip {
        { Search-JcSdkOrganization [-Fields1 '<String>'] [-Filter1 '<Hashtable>'] [-SearchFilter '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Search' -skip {
        { Search-JcSdkOrganization -Body:($global:PesterTestOrganization) } | Should -Not -Throw
    }
}
