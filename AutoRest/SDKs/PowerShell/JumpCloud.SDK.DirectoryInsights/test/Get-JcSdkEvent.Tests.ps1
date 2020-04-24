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

Describe 'Get-JcSdkEvent' {
    <# ToDo
        Service - Not sure how to validate yet (Test that results service value matchesparameter parameter value)
        Paginate - If $Paginate parameter exists then validate it somehow If(((Get-Command Get-JcSdkEvent).Parameters.Paginate)){ DoSomething }
    #>
    $ParamHash = @{
        "StartTime"     = "2020-04-15T00:00:00Z";
        "EndTime"       = "2020-04-16T23:00:00Z";
        "Service"       = "all";
        "Sort"          = "DESC"
        "Limit"         = 10;
        "SearchTermAnd" = @{
            "event_type" = "group_create"
        }
    }
    It 'GetExpanded' {
        $eventTest = Get-JcSdkEvent -Service:($ParamHash.Service) -StartTime:($ParamHash.StartTime) -EndTime:($ParamHash.EndTime) -Limit:($ParamHash.Limit) -Sort:($ParamHash.Sort) -SearchTermAnd:($ParamHash.SearchTermAnd)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
        Else
        {
            $eventTest = ($eventTest).ToJsonString() | ConvertFrom-Json
            $StartTime = Get-Date -Date:(([DateTime]$ParamHash.StartTime).ToUniversalTime())
            $EndTime = Get-Date -Date:(([DateTime]$ParamHash.EndTime).ToUniversalTime())
            $MostRecentRecord = ($eventTest | Select-Object -First 1).timestamp
            $OldestRecord = ($eventTest | Select-Object -Last 1).timestamp
            # Limit - Test that results count matches parameter value
            $eventTest.Count | Should -Be $ParamHash.Limit
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
        $eventTest = Get-JcSdkEvent -EventQueryBody:($ParamHash)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
        Else
        {
            $eventTest = ($eventTest).ToJsonString() | ConvertFrom-Json
            $StartTime = Get-Date -Date:(([DateTime]$ParamHash.StartTime).ToUniversalTime())
            $EndTime = Get-Date -Date:(([DateTime]$ParamHash.EndTime).ToUniversalTime())
            $MostRecentRecord = ($eventTest | Select-Object -First 1).timestamp
            $OldestRecord = ($eventTest | Select-Object -Last 1).timestamp
            # Limit - Test that results count matches parameter value
            $eventTest.Count | Should -Be $ParamHash.Limit
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
