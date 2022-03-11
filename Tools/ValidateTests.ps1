param (
    [Parameter()]
    [System.String]
    $Path,
    [Parameter()]
    [System.Boolean]
    $ReplacePesterBlock
)
Begin
{
    Write-Host $Path
    # Regex search for tests
    $regex = [regex]"It.*{"
    $pesterRegex = [regex]"[\S\s]*(?=Describe)"
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
        # Search for code outside describe block
        $raw = Get-Content -Path ($test.FullName) -Raw
        $rogueText = [regex]::match($raw, $pesterRegex)
        if ($rogueText.Value -notmatch "BeforeAll"){
            Write-Warning "Pester test: $($test.BaseName) contains code outside valid blocks; This test may not execute"
            if ($ReplacePesterBlock){
                Write-Warning "Updating test: $($test.BaseName)"
                $raw = Get-Content -Path $test.FullName -Raw
                $pesterRegex.Replace($raw, ('BeforeAll {' + "`n" + [regex]::match($raw, $pesterRegex) + "`n" + '}' + "`n"), 1) | Set-Content -Path $test.FullName
                $raw = Get-Content -Path $test.FullName -Raw
                $rogueText = [regex]::match($raw, $pesterRegex)
            }
        }
        $TestResults += [PSCustomObject]@{
            TestName = $($test.BaseName)
            Tests    = "($notSkipped / $count)"
            Coverage = if (($notSkipped / $count -eq 1)) { "$([char]0x1b)[92mOK" }elseif ($count - $notSkipped -lt $count) { "$([char]0x1b)[93m-" }else { "$([char]0x1b)[91mx" }
            "Pester 5 Compatible"   = if ($rogueText.Value -notmatch "BeforeAll") { "$([char]0x1b)[91mx" }else { "$([char]0x1b)[92mOK" }
        }
    }
}
End {
    $TestResults | Format-Table | Out-Host
}