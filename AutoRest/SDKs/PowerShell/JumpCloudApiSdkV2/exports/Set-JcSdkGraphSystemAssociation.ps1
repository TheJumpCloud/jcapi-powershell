<#
.Synopsis
This endpoint allows you to manage the _direct_ associations of a System.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n   \"attributes\": {\n      \"sudo\": {\n         \"enabled\": true,\n         \"withoutPassword\": false\n      }\n   },\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"UserID\"\n}'\n\n```
.Description
This endpoint allows you to manage the _direct_ associations of a System.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n   \"attributes\": {\n      \"sudo\": {\n         \"enabled\": true,\n         \"withoutPassword\": false\n      }\n   },\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"UserID\"\n}'\n\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/set-jcsdkgraphsystemassociation
.Inputs
JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloudApiSdkV2.Models.ISystemGraphManagementReq
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISystemGraphManagementReq>: SystemGraphManagementReq
  Id <String>: The ObjectID of graph object being added or removed as an association.
  Op <String>: How to modify the graph connection.
  Type <String>: 
  [SudoEnabled <Boolean?>]: 
  [SudoWithoutPassword <Boolean?>]: 

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
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/set-jcsdkgraphsystemassociation
#>
function Set-JcSdkGraphSystemAssociation {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Path')]
    [System.String]
    # ObjectID of the System.
    ${SystemId},

    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Path')]
    [JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [JumpCloudApiSdkV2.Category('Header')]
    [System.String]
    # Authorization header for the System Context API
    ${Authorization},

    [Parameter()]
    [JumpCloudApiSdkV2.Category('Header')]
    [System.String]
    # Current date header for the System Context API
    ${Date},

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.ISystemGraphManagementReq]
    # SystemGraphManagementReq
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
    # HELP MESSAGE MISSING
    ${Type},

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${SudoEnabled},

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${SudoWithoutPassword},

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
            Set = 'JumpCloudApiSdkV2.private\Set-JcSdkGraphSystemAssociation_Set';
            SetExpanded = 'JumpCloudApiSdkV2.private\Set-JcSdkGraphSystemAssociation_SetExpanded';
            SetViaIdentity = 'JumpCloudApiSdkV2.private\Set-JcSdkGraphSystemAssociation_SetViaIdentity';
            SetViaIdentityExpanded = 'JumpCloudApiSdkV2.private\Set-JcSdkGraphSystemAssociation_SetViaIdentityExpanded';
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
