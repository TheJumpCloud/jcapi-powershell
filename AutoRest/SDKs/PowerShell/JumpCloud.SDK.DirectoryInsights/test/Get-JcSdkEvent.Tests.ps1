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
    It 'GetExpanded' {
        $eTest = (Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-15T00:00:00Z') -EndTime:('2020-04-16T23:00:00Z') -Limit:(10) -Sort:("DESC") -searchTermAnd:@{"event_type" = "group_create" }).ToJsonString() | ConvertFrom-Json
        $upper = Get-Date([datetime]'2020-04-16T23:00:00Z')
        $lower = Get-Date([datetime]'2020-04-15T00:00:00Z')
        # check valid single result
        ($eTest | select-object -First 1).count | Should -EQ 1
        # check valid time, ie. resutls not before or after
        $eTest[0].timestamp | Should -BeOfType [datetime]
        # test highest time range (disabled for the time being, issues with time conversion)
        # $eTest[0].timestamp.Ticks | Should -BeLessOrEqual $upper.Ticks
        # test lowest time range
        $eTest[9].timestamp.Ticks | Should -BeGreaterOrEqual $lower.Ticks
        # test the decending time param
        $eTest[0].timestamp.Ticks | Should -BeGreaterThan $eTest[9].timestamp.Ticks
        # check that function does not return more then limit
        $eTest.count | Should -EQ 10
        # check that function does not return something outside filter
        forEach ($rslt in $eTest) {
            $rslt.event_type | Should -Be "group_create"
        }
        # $eTest[0].timestamp.Ticks | Should -BeGreaterThan $eTest[9].timestamp.Ticks
        # { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get' {
        $hash = @{
            "StartTime"     = "2020-04-15T00:00:00Z";
            "EndTime"       = "2020-04-16T23:00:00Z";
            "service"       = "all";
            "Sort"          = "DESC"
            "Limit"         = 10;
            "SearchTermAnd" = @{
                "event_type" = "group_create"
            }

        }
        $hash | ConvertTo-Json
        $eTest = (Get-JcSdkEvent -EventQueryBody $hash).ToJsonString() | ConvertFrom-Json
        $upper = Get-Date([datetime]'2020-04-16T23:00:00Z')
        $lower = Get-Date([datetime]'2020-04-15T00:00:00Z')
        # check valid single result
        # ($eTest | select-object -First 1).count | Should -EQ 1
        # check valid time, ie. resutls not before or after
        $eTest[0].timestamp | Should -BeOfType [datetime]
        # test highest time range (disabled for the time being, issues with time conversion)
        # $eTest[0].timestamp.Ticks | Should -BeLessOrEqual $upper.Ticks
        # test lowest time range
        $eTest[9].timestamp.Ticks | Should -BeGreaterOrEqual $lower.Ticks
        # test the decending time param
        $eTest[0].timestamp.Ticks | Should -BeGreaterThan $eTest[9].timestamp.Ticks
        # check that function does not return more then limit
        $eTest.count | Should -EQ 10
        # check that function does not return something outside filter
        forEach ($rslt in $eTest) {
            $rslt.event_type | Should -Be "group_create"
        }
        # { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    # It 'Check Output Result exists' {
    #     ((Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-15T00:00:00Z') -EndTime:('2020-04-16T23:00:00Z')).ToJsonString() | ConvertFrom-Json | Select-Object -First 1).count | Should -EQ 1
    # }

    # It 'Check Output Client IP ' {
    #     ((Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-15T00:00:00Z') -EndTime:('2020-04-16T23:00:00Z')).ToJsonString() | ConvertFrom-Json | Select-Object -First 1).client_ip | Should -Eq 76.25.29.226
    # }
}
