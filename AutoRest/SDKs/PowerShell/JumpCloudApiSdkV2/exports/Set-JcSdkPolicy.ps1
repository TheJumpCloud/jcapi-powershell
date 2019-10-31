<#
.Synopsis
This endpoint allows you to update a policy.
Given the amount of configurable parameters required to update a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY' \\\n  -d '{\n    {Policy_Parameters}\n}'\n```
.Description
This endpoint allows you to update a policy.
Given the amount of configurable parameters required to update a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY' \\\n  -d '{\n    {Policy_Parameters}\n}'\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/set-jcsdkpolicy
.Inputs
JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloudApiSdkV2.Models.IPolicyRequest
.Outputs
JumpCloudApiSdkV2.Models.IPolicy
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPolicyRequest>: An instance of a policy template.
  Name <String>: The description for this specific Policy.
  [TemplateId <String>]: ObjectId uniquely identifying a Policy instance; only allowed on POST requests.
  [Values <IPolicyValue[]>]: 
    [ConfigFieldId <String>]: The ObjectId of the corresponding Policy Template configuration field.
    [Value <String>]: The value for the configuration field for this Policy instance.

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

VALUES <IPolicyValue[]>: HELP MESSAGE MISSING
  [ConfigFieldId <String>]: The ObjectId of the corresponding Policy Template configuration field.
  [Value <String>]: The value for the configuration field for this Policy instance.
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/set-jcsdkpolicy
#>
function Set-JcSdkPolicy {
[OutputType([JumpCloudApiSdkV2.Models.IPolicy])]
[CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Path')]
    [System.String]
    # ObjectID of the Policy object.
    ${Id},

    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Path')]
    [JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.IPolicyRequest]
    # An instance of a policy template.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # The description for this specific Policy.
    ${Name},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # ObjectId uniquely identifying a Policy instance; only allowed on POST requests.
    ${TemplateId},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.IPolicyValue[]]
    # HELP MESSAGE MISSING
    # To construct, see NOTES section for VALUES properties and create a hash table.
    ${Values},

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
            Put = 'JumpCloudApiSdkV2.private\Set-JcSdkPolicy_Put';
            PutExpanded = 'JumpCloudApiSdkV2.private\Set-JcSdkPolicy_PutExpanded';
            PutViaIdentity = 'JumpCloudApiSdkV2.private\Set-JcSdkPolicy_PutViaIdentity';
            PutViaIdentityExpanded = 'JumpCloudApiSdkV2.private\Set-JcSdkPolicy_PutViaIdentityExpanded';
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
