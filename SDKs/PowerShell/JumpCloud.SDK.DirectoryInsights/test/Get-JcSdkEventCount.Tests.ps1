$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkEventCountCount.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkEventCountCount' {
    BeforeAll {
        # Define parameters for functions
        $ParamHash = @{
            "StartTime"     = (Get-Date).AddHours(-24).ToUniversalTime();
            "EndTime"       = (Get-Date).ToUniversalTime();
            "Service"       = "all";
            "Sort"          = "DESC"
            "SearchTermAnd" = @{
                "event_type" = "user_delete"
            }
        }
    }
    <# ToDo
    Service - Not sure how to validate yet (Test that results service value matches parameter value)
    #>
    It 'GetExpanded' {
        $eventTest = JumpCloud.SDK.DirectoryInsights\Get-JcSdkEventCount -Service:($ParamHash.Service) -StartTime:($ParamHash.StartTime) -EndTime:($ParamHash.EndTime) -Sort:($ParamHash.Sort) -SearchTermAnd:($ParamHash.SearchTermAnd)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
    }
    It 'Get' {
        $eventTest = JumpCloud.SDK.DirectoryInsights\Get-JcSdkEventCount -Body:($ParamHash)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
    }
}
