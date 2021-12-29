$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkBulkUsersResult.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkBulkUsersResult' {
    It 'Get' {
        # Create a new users from bulk import
        $Body = @(
            @{
                Username  = "BulkUsers-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
                FirstName = "Pester"
                LastName  = "Test"
                Password  = "Testing123!"
                Email     = "pester.test@example$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ })).com"
            },
            @{
                Username  = "BulkUsers-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
                FirstName = "Pester"
                LastName  = "Test"
                Password  = "Testing123!"
                Email     = "pester.test@example$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ })).com"
            }
        )
        # Per swagger definition, this returns a string in the meantime
        $bulkUsersImport = New-JcSdkBulkUser -Body $Body -CreationSource 'jumpcloud:bulk'
        { Get-JcSdkBulkUsersResult -JobId $bulkUsersImport } | Should -not -Throw
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

AfterAll {
    # Cleanup any users with the username matching "PesterTestBulkUserState-"
    Get-JCSDKUser | Where-Object { $_.username -match "BulkUsers-" } | ForEach-Object { Remove-JcSdkUser -Id $_.Id }
}