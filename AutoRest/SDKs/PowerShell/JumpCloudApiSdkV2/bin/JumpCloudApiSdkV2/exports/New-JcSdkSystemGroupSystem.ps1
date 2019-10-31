<#
.Synopsis
This endpoint allows you to create a new System Group.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```
.Description
This endpoint allows you to create a new System Group.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdksystemgroupsystem
.Inputs
JumpCloudApiSdkV2.Models.ISystemGroupData
.Outputs
JumpCloudApiSdkV2.Models.ISystemGroup
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISystemGroupData>: SystemGroupData
  Name <String>: Display name of a System Group.
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdksystemgroupsystem
#>
function New-JcSdkSystemGroupSystem {
[OutputType([JumpCloudApiSdkV2.Models.ISystemGroup])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.ISystemGroupData]
    # SystemGroupData
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # Display name of a System Group.
    ${Name},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [JumpCloudApiSdkV2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [JumpCloudApiSdkV2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV2.Category('Runtime')]
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
            Create = 'JumpCloudApiSdkV2.private\New-JcSdkSystemGroupSystem_Create';
            CreateExpanded = 'JumpCloudApiSdkV2.private\New-JcSdkSystemGroupSystem_CreateExpanded';
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
