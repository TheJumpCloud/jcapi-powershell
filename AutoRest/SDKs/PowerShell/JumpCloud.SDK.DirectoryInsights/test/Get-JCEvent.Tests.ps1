$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JCEvent.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JCEvent' {
    It 'GetExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
Describe 'Get-JCEvent' {
    <# ToDo
        Service - Not sure how to validate yet (Test that results service value matches parameter value)
    #>
    # Define parameters for functions
    $ParamHash = @{
        "StartTime"     = (Get-Date).AddHours(-12).ToUniversalTime();
        "EndTime"       = 'PlaceHolderDateTime';
        "Service"       = "all";
        "Sort"          = "DESC"
        "Limit"         = 2;
        "SearchTermAnd" = @{
            "event_type" = "user_delete"
        }
    }
    # Set EndTime
    $ParamHash.EndTime = (Get-Date).ToUniversalTime();
    # Convert times to UTC
    $StartTime = [DateTime]$ParamHash.StartTime
    $EndTime = [DateTime]$ParamHash.EndTime
    It 'GetExpanded' {
        $eventTest = JumpCloud.SDK.DirectoryInsights\Get-JCEvent -Service:($ParamHash.Service) -StartTime:($ParamHash.StartTime) -EndTime:($ParamHash.EndTime) -Limit:($ParamHash.Limit) -Sort:($ParamHash.Sort) -SearchTermAnd:($ParamHash.SearchTermAnd)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
        Else
        {
            $eventTest = $eventTest
            $MostRecentRecord = ([System.DateTime]($eventTest | Select-Object -First 1).timestamp).ToUniversalTime()
            $OldestRecord = ([System.DateTime]($eventTest | Select-Object -Last 1).timestamp).ToUniversalTime()
            # Sort - Test that results come back in decending DateTime
            $MostRecentRecord.Ticks | Should -BeGreaterThan $OldestRecord.Ticks
            # EndTime - Test that results are not newer than EndTime parameter value
            $MostRecentRecord.Ticks | Should -BeLessOrEqual $EndTime.Ticks
            # StartTime - Test that results are not older than StartTime parameter value
            $OldestRecord.Ticks | Should -BeGreaterOrEqual $StartTime.Ticks
            # SearchTermAnd - Test that results matches parameter value
            ($eventTest.event_type | Select-Object -Unique) | Should -Be $ParamHash.SearchTermAnd.event_type
        }
    }
    It 'Get' {
        $eventTest = JumpCloud.SDK.DirectoryInsights\Get-JCEvent -Body:($ParamHash)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
        Else
        {
            $eventTest = $eventTest
            $MostRecentRecord = ([System.DateTime]($eventTest | Select-Object -First 1).timestamp).ToUniversalTime()
            $OldestRecord = ([System.DateTime]($eventTest | Select-Object -Last 1).timestamp).ToUniversalTime()
            # Sort - Test that results come back in decending DateTime
            $MostRecentRecord.Ticks | Should -BeGreaterThan $OldestRecord.Ticks
            # EndTime - Test that results are not newer than EndTime parameter value
            $MostRecentRecord.Ticks | Should -BeLessOrEqual $EndTime.Ticks
            # StartTime - Test that results are not older than StartTime parameter value
            $OldestRecord.Ticks | Should -BeGreaterOrEqual $StartTime.Ticks
            # SearchTermAnd - Test that results matches parameter value
            ($eventTest.event_type | Select-Object -Unique) | Should -Be $ParamHash.SearchTermAnd.event_type
        }
    }
}
