$PesterTestCommandName = 'PesterTestCommand'
$PesterTestCommand = 'Write-Host ("Hello World!")'
$PesterTestCommandType = 'windows'
$PesterTestCommandShell = 'PowerShell'
Describe 'New-JcSdkCommand' {
    It 'CreateExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        $Command = Get-JcSdkCommand | Where-Object { $_.Name -eq $PesterTestCommandName }
        If ($Command)
        {
            Remove-JcSdkCommand -Id:($Command.Id)
        }
        New-JcSdkCommand -Name:($PesterTestCommandName) -Command:($PesterTestCommand) -CommandType:($PesterTestCommandType) -Shell:($PesterTestCommandShell) | Should -Not -BeNullOrEmpty
    }
}
