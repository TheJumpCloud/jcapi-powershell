BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkBulkUserState.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Remove-JcSdkBulkUserState' -Tag:(""){
    It 'Delete' {
        # { throw [System.NotImplementedException] } | Should -Not -Throw
        # Create a new bulkuserstate user
        $username = "PesterBulkUser-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        $user = New-JCsdkUser -Username $username -Email "$username@pestertest.com"
        # Suspend the use with this endpoint
        $bulkJob = New-JcSdkBulkUserState -StartDate (Get-Date).AddDays(1) -UserIds $user.Id -State "SUSPENDED"
        { Remove-JcSdkBulkUserState -Id $bulkJob.ScheduledJobId } | Should -Not -Throw
        # Cleanup any users with the username matching "PesterTestBulkUserState-"
        $users = Get-JCSDKUser | Where-Object { $_.username -match "PesterBulkUser-" }
        foreach ($user in $users)
        {
            Remove-JcSdkUser -Id $user.Id
        }
    }

    It 'DeleteViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
