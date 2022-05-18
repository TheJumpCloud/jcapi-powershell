BeforeAll {
if(($null -eq $TestName) -or ($TestName -contains 'Search-JcSdkCommand'))
{
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Search-JcSdkCommand.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'Search-JcSdkCommand' -Tag:(""){
    It 'SearchExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Search' {
        { $Search = @{
            filter = @{
                or = @(
                    'Name:$regex:/PesterTestCommand/i'
                )
            }
        }
        { Search-JcSdkCommand -Body:($Search) } | Should -Not -Throw } | Should -Not -Throw
    }
}
