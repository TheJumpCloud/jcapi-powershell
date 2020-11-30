$global:PesterTestCommandName = 'PesterTestCommand'
$global:PesterTestCommand = 'Write-Host ("Hello World!")'
$global:PesterTestCommandType = 'windows'
$global:PesterTestCommandShell = 'PowerShell'
Describe 'New-JcSdkCommand' {
    It 'CreateExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        $Command = Get-JcSdkCommand | Where-Object { $_.Name -eq $global:PesterTestCommandName }
        If ($Command)
        {
            Remove-JcSdkCommand -Id:($Command.Id)
        }
        New-JcSdkCommand -Name:($global:PesterTestCommandName) -Command:($global:PesterTestCommand) -CommandType:($global:PesterTestCommandType) -Shell:($global:PesterTestCommandShell) | Should -Not -BeNullOrEmpty
    }
}
