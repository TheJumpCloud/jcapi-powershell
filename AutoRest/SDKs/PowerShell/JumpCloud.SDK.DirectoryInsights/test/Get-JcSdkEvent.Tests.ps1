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
    #Requires -Modules JumpCloud
    <# ToDo
        Service - Not sure how to validate yet (Test that results service value matches parameter value)
    #>
    # Define parameters for functions
    $ParamHash = @{
        "StartTime"     = Get-Date -Date:(((Get-Date).ToUniversalTime())) -Format:('o');
        "EndTime"       = 'PlaceHolderDateTime';
        "Service"       = "all";
        "Sort"          = "DESC"
        "Limit"         = 2;
        "SearchTermAnd" = @{
            "event_type" = "group_create"
        }
    }
    If ((Get-Command Get-JcSdkEvent).Parameters.ContainsKey('Paginate'))
    {
        $ParamHash.Limit = ($ParamHash.Limit * 2)
    }
    Else
    {
        $ParamHash.Limit
    }
    # Create event records for tests
    Connect-JCOnline -force | Out-Null
    For ($i = 1; $i -le $ParamHash.Limit; $i++)
    {
        $GroupName = 'JCSystemGroupTest-{0}' -f $i
        Write-Host ("Creating add/delete records for: $GroupName")
        If (Get-JCGroup -Type:('System') | Where-Object { $_.Name -eq $GroupName })
        {
            Remove-JCSystemGroup -GroupName:($GroupName) -Force
        }
        New-JCSystemGroup -GroupName:($GroupName) | Remove-JCSystemGroup -Force
    }
    # Allow server time to process
    Start-Sleep -Seconds:(10)
    # Set EndTime
    $ParamHash.EndTime = Get-Date -Date:(((Get-Date).ToUniversalTime())) -Format:('o');
    # Convert times to UTC
    $StartTime = Get-Date -Date:(([DateTime]$ParamHash.StartTime).ToUniversalTime())
    $EndTime = Get-Date -Date:(([DateTime]$ParamHash.EndTime).ToUniversalTime())
    It 'GetExpanded' {
        $eventTest = Get-JcSdkEvent -Service:($ParamHash.Service) -StartTime:($ParamHash.StartTime) -EndTime:($ParamHash.EndTime) -Limit:($ParamHash.Limit) -Sort:($ParamHash.Sort) -SearchTermAnd:($ParamHash.SearchTermAnd)
        If ([System.String]::IsNullOrEmpty($eventTest))
        {
            $eventTest | Should -Not -BeNullOrEmpty
        }
        Else
        {
            $eventTest = ($eventTest).ToJsonString() | ConvertFrom-Json
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
