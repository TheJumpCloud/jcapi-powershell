param (
    [Parameter()]
    [System.String]
    $Path
)
Begin
{
    Write-Host $Path
    # Regex search for tests
    $regex = [regex]"It.*{"
    # Test List
    $TestResults = @()
}
Process{
    # Get Tests Path
    $tests = Get-ChildItem -Path "$Path/*" -Include *.Tests.ps1
    foreach ($test in $tests) {
        # Write-Host $test.FullName
        $itTests = Select-String -Path:($test.FullName) -Pattern:($regex)
        $count = $itTests.Matches.Count
        # Write-Host $count
        $notSkipped = 0
        foreach ($match in $itTests.Matches)
        {
            if ($match -notmatch "-skip"){
                $notSkipped += 1
            }
        }
        $TestResults += [PSCustomObject]@{
            TestName = $($test.BaseName)
            Tests    = "($notSkipped / $count)"
            Coverage = if (($notSkipped / $count -eq 1)) { "✅" }elseif($count - $notSkipped -lt $count){"🟡"}else { "❌"}
        }
    }
}
End {
    $TestResults | Format-Table | Out-Host
}