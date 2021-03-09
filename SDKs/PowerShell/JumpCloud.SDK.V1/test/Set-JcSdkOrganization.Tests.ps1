$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkOrganization.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkOrganization' {
    It 'SetExpanded' -Skip {
        { Set-JcSdkOrganization -Id '<String>' [-Settings '<IOrganizationsettingsput>'] } | Should -Not -Throw
    }

    It 'Set' -Skip {
        { Set-JcSdkOrganization -Body '<IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema>' -Id '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -Skip {
        { Set-JcSdkOrganization -Body '<IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -Skip {
        { Set-JcSdkOrganization -InputObject '<IJumpCloudApIsIdentity>' [-Settings '<IOrganizationsettingsput>'] } | Should -Not -Throw
    }
}
