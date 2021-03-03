$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkAppleMdm.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkAppleMdm' {
    It 'UpdateExpanded' {
        $body = @{
            Name                         = "Joe's MDM"
            WelcomeScreenButton          = "Let's Grow!"
            WelcomeScreenParagraph       = "This laptop should help you, a farmer, plant and grow many vegetables."
            WelcomeScreenTitle           = "Hello There"
        }
        Set-JcSdkAppleMdm -id $global:PesterAppleMDM.id -body $body
    }

    It 'Update' {
        $body = @{
            Name                   = "Joe's MDM"
            WelcomeScreenButton    = "Let's Grow!"
            WelcomeScreenParagraph = "This laptop should help you, a farmer, plant and grow many vegetables."
            WelcomeScreenTitle     = "Hello There"
        }
        Set-JcSdkAppleMdm -id $global:PesterAppleMDM.id -name $($body.name) -WelcomeScreenButton $($body.WelcomeScreenTitle) -WelcomeScreenParagraph $($body.WelcomeScreenTitle) -WelcomeScreenTitle $($body.WelcomeScreenTitle)
    }

    It 'UpdateViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
