$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkEvent.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName
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
Describe 'Get-JcSdkEvent' {
    <# ToDo
        Service - Not sure how to validate yet (Test that results service value matches parameter value)
    #>
    It 'GetExpanded' {
        $eventTest = JumpCloud.SDK.DirectoryInsights\Get-JcSdkEvent -Service:($ParamHash.Service) -StartTime:($ParamHash.StartTime) -EndTime:($ParamHash.EndTime) -Sort:($ParamHash.Sort) -SearchTermAnd:($ParamHash.SearchTermAnd)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
        Else
        {
            # $eventTest = $eventTest
            $MostRecentRecord = ([System.DateTime]($eventTest | Select-Object -First 1).timestamp).ToUniversalTime()
            $OldestRecord = ([System.DateTime]($eventTest | Select-Object -Last 1).timestamp).ToUniversalTime()
            # Sort - Test that results come back in decending DateTime
            $MostRecentRecord | Should -BeGreaterThan $OldestRecord
            # EndTime - Test that results are not newer than EndTime parameter value
            $MostRecentRecord | Should -BeLessOrEqual $ParamHash.EndTime
            # StartTime - Test that results are not older than StartTime parameter value
            $OldestRecord | Should -BeGreaterOrEqual $ParamHash.StartTime
            # SearchTermAnd - Test that results matches parameter value
            ($eventTest.event_type | Select-Object -Unique) | Should -Be $ParamHash.SearchTermAnd.event_type
        }
    }
    It 'Get' {
        $eventTest = JumpCloud.SDK.DirectoryInsights\Get-JcSdkEvent -Body:($ParamHash)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
        Else
        {
            # $eventTest = $eventTest
            $MostRecentRecord = ([System.DateTime]($eventTest | Select-Object -First 1).timestamp).ToUniversalTime()
            $OldestRecord = ([System.DateTime]($eventTest | Select-Object -Last 1).timestamp).ToUniversalTime()
            # Sort - Test that results come back in decending DateTime
            $MostRecentRecord | Should -BeGreaterThan $OldestRecord
            # EndTime - Test that results are not newer than EndTime parameter value
            $MostRecentRecord | Should -BeLessOrEqual $ParamHash.EndTime
            # StartTime - Test that results are not older than StartTime parameter value
            $OldestRecord | Should -BeGreaterOrEqual $ParamHash.StartTime
            # SearchTermAnd - Test that results matches parameter value
            ($eventTest.event_type | Select-Object -Unique) | Should -Be $ParamHash.SearchTermAnd.event_type
        }
    }
}