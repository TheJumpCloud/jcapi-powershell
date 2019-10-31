<#
.Synopsis
This endpoint will create a specific System User's Public SSH Key.
.Description
This endpoint will create a specific System User's Public SSH Key.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdksshkey
.Inputs
JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloudApiSdkV1.Models.ISshkeypost
.Outputs
JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema
.Outputs
JumpCloudApiSdkV1.Models.ISshkeylist
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISshkeypost>: SSHKeyPost
  Name <String>: The name of the SSH key.
  PublicKey <String>: The Public SSH key.

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdksshkey
#>
function New-JcSdkSshKey {
[OutputType([JumpCloudApiSdkV1.Models.ISshkeylist], [JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Path')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Id},

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Path')]
    [JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.ISshkeypost]
    # SSHKeyPost
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # The name of the SSH key.
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # The Public SSH key.
    ${PublicKey},

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
            Create = 'JumpCloudApiSdkV1.private\New-JcSdkSshKey_Create';
            CreateExpanded = 'JumpCloudApiSdkV1.private\New-JcSdkSshKey_CreateExpanded';
            CreateViaIdentity = 'JumpCloudApiSdkV1.private\New-JcSdkSshKey_CreateViaIdentity';
            CreateViaIdentityExpanded = 'JumpCloudApiSdkV1.private\New-JcSdkSshKey_CreateViaIdentityExpanded';
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
