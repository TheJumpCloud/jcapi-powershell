BeforeAll {
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
}

Describe 'Set-JcSdkOrganization' -Tag:(""){
    It 'SetExpanded' -skip {
        { Set-JcSdkOrganization -Id:($global:PesterTestOrganization.Id) } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkOrganization -Body:($global:PesterTestOrganization) -Id:($global:PesterTestOrganization.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkOrganization -Body:($global:PesterTestOrganization) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkOrganization -InputObject '<IJumpCloudApIsIdentity>' [-Settings '<IOrganizationsettingsput>'] } | Should -Not -Throw
    }
}
