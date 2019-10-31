<#
.Synopsis
This endpoint will delete a specific System User's SSH Key.
.Description
This endpoint will delete a specific System User's SSH Key.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/remove-jcsdksshkey
.Inputs
JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloudApiSdkV1.Models.IPathsSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/remove-jcsdksshkey
#>
function Remove-JcSdkSshKey {
[OutputType([JumpCloudApiSdkV1.Models.IPathsSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [JumpCloudApiSdkV1.Category('Path')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Id},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [JumpCloudApiSdkV1.Category('Path')]
    [System.String]
    # HELP MESSAGE MISSING
    ${SystemuserId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Path')]
    [JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [JumpCloudApiSdkV1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [JumpCloudApiSdkV1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'JumpCloudApiSdkV1.private\Remove-JcSdkSshKey_Delete';
            DeleteViaIdentity = 'JumpCloudApiSdkV1.private\Remove-JcSdkSshKey_DeleteViaIdentity';
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
