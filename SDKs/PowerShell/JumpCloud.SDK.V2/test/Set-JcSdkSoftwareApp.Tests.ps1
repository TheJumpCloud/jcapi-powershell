$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSoftwareApp.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSoftwareApp' {
    It 'UpdateExpanded' {
        { Set-JcSdkSoftwareApp -Id:($global:PesterTestSoftwareApp.Id) -DisplayName:("Adobe Reader MODIFIED") } | Should -Not -Throw
    }

    It 'Update' {
        $PesterDefSofware = @{
            DisplayName = "Adobe Reader"
        }

        { Set-JcSdkSoftwareApp -Id:($global:PesterTestSoftwareApp.Id) -Body:($PesterDefSofware) } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
