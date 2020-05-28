$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JCEventCount.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JCEventCount' {
    <# ToDo
        Service - Not sure how to validate yet (Test that results service value matches parameter value)
    #>
    # Define parameters for functions
    $ParamHash = @{
        "StartTime"     = (Get-Date).AddHours(-24).ToUniversalTime();
        "EndTime"       = (Get-Date).ToUniversalTime();
        "Service"       = "all";
        "Sort"          = "DESC"
        "Limit"         = 10000;
        "SearchTermAnd" = @{
            "event_type" = "user_delete"
        }
    }
    It 'GetExpanded' {
        $eventTest = JumpCloud.SDK.DirectoryInsights\Get-JCEventCount -Service:($ParamHash.Service) -StartTime:($ParamHash.StartTime) -EndTime:($ParamHash.EndTime) -Sort:($ParamHash.Sort) -SearchTermAnd:($ParamHash.SearchTermAnd)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
        Else
        {
            $eventTest | Should -BeGreaterThan 0
        }
    }
    It 'Get' {
        $eventTest = JumpCloud.SDK.DirectoryInsights\Get-JCEventCount -Body:($ParamHash)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
        Else
        {
            $eventTest | Should -BeGreaterThan 0
        }
    }
}
