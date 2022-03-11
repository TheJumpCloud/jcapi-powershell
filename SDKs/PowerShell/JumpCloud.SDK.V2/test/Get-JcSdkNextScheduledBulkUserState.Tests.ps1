BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkNextScheduledBulkUserState.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkNextScheduledBulkUserState' {
    It 'Get' {
        # { throw [System.NotImplementedException] } | Should -Not -Throw
        # Create a new bulkuserstate user
        $username = "PesterTestNextBulkUser-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        $user = New-JCsdkUser -Username $username -Email "$username@pestertest.com"
        # Suspend the use with this endpoint
        New-JcSdkBulkUserState -StartDate (Get-Date).AddDays(1) -UserIds $user.Id
        { Get-JcSdkNextScheduledBulkUserState -Users @($user.Id) } | Should -Not -Throw
        # Cleanup any users with the username matching "PesterTestBulkUserState-"
        $users = Get-JCSDKUser | Where-Object { $_.username -match "PesterTestNextBulkUser-" }
        foreach ($user in $users)
        {
            Remove-JcSdkUser -Id $user.Id
        }
    }
}
