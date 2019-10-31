<#
.Synopsis
This endpoint returns the _direct_ associations of this G Suite instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```
.Description
This endpoint returns the _direct_ associations of this G Suite instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/set-jcsdkgraphgsuitegraphgsuiteassociation
.Inputs
JumpCloudApiSdkV2.Models.IGraphManagementReq
.Inputs
JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IGraphManagementReq>: GraphManagementReq
  Id <String>: The ObjectID of graph object being added or removed as an association.
  Op <String>: How to modify the graph connection.
  Type <String>: The graph type.
  [Attributes <IGraphManagementReqAttributes>]: The graph connection's attributes.

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [ActivedirectoryId <String>]: ObjectID of the Active Directory instance.
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [GroupId <String>]: ObjectID of the User Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: 
  [JobId <String>]: 
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: ObjectID of the Policy.
  [ProviderId <String>]: 
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SystemId <String>]: 
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/set-jcsdkgraphgsuitegraphgsuiteassociation
#>
function Set-JcSdkGraphGSuiteGraphGSuiteAssociation {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Path')]
    [System.String]
    # ObjectID of the G Suite instance.
    ${GsuiteId},

    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Path')]
    [JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.IGraphManagementReq]
    # GraphManagementReq
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # The ObjectID of graph object being added or removed as an association.
    ${Id},

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # How to modify the graph connection.
    ${Op},

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # The graph type.
    ${Type},

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.IGraphManagementReqAttributes]
    # The graph connection's attributes.
    ${Attributes},

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

    [Parameter()]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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
            Set = 'JumpCloudApiSdkV2.private\Set-JcSdkGraphGSuiteGraphGSuiteAssociation_Set';
            SetExpanded = 'JumpCloudApiSdkV2.private\Set-JcSdkGraphGSuiteGraphGSuiteAssociation_SetExpanded';
            SetViaIdentity = 'JumpCloudApiSdkV2.private\Set-JcSdkGraphGSuiteGraphGSuiteAssociation_SetViaIdentity';
            SetViaIdentityExpanded = 'JumpCloudApiSdkV2.private\Set-JcSdkGraphGSuiteGraphGSuiteAssociation_SetViaIdentityExpanded';
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
