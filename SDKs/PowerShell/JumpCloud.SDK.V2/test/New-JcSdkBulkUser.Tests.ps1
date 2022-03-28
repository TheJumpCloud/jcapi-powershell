BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkBulkUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkBulkUser' -Tag:("")){
    It 'Create' {
        $global:PesterTestBulkUserJobId =  New-JcSdkBulkUser -Body:($global:PesterDefBulkUser) -CreationSource:('jumpcloud:bulk')
        { $global:PesterTestBulkUserJobId } | Should -Not -BeNullOrEmpty
        { Get-JcSdkUser -id $global:PesterTestBulkUserJobId.Id } | Should -Not -BeNullOrEmpty
    }
}

