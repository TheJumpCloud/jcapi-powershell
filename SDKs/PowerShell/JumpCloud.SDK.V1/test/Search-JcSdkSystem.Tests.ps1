BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Search-JcSdkSystem.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Search-JcSdkSystem' -Tag:(""){
    # TODO: This functions does not allow us to filter/ only returns all results
    It 'SearchExpanded' -skip {
        { Search-JcSdkSystem [-Fields1 '<String>'] [-Filter1 '<Hashtable>'] [-SearchFilter '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Search' {
        $Search = @{
            filter = @{
                or = @(
                    'displayName:$regex:/linux/i'
                )
            }
        }
        { Search-JcSdkSystem -Body:($Search) } | Should -Not -Throw
    }
}
