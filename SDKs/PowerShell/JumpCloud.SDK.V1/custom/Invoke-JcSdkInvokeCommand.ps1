<#
.Synopsis
This endpoint allows you to run a command.
.Description
This endpoint allows you to run a command.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
System.Boolean
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/examples/Invoke-JcSdkInvokeCommand.md
#>
 Function Invoke-JcSdkInvokeCommand
{
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='Invoke', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V1.internal\Invoke-JcSdkInternalInvokeCommand @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

