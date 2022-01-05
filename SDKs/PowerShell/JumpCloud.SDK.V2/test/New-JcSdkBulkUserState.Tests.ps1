$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkBulkUserState.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkBulkUserState' {
    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        # Create a new bulkuserstate user
        $username = "PesterTestBulkUserState-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        $user = New-JCsdkUser -Username $username -Email "$username@pestertest.com"
        # Suspend the use with this endpoint
        { New-JcSdkBulkUserState -StartDate (Get-Date).AddDays(1) -UserIds $user.Id } | Should -Not -Throw
        # Cleanup any users with the username matching "PesterTestBulkUserState-"
        $users = Get-JCSDKUser | Where-Object { $_.username -match "PesterTestBulkUserState-" }
        foreach ($user in $users)
        {
            Remove-JcSdkUser -Id $user.Id
        }
    }
}