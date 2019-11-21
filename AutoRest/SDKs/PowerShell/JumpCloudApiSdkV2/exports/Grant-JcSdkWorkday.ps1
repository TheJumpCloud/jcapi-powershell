<#
.Synopsis
This endpoint adds an authorization method to a workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"auth\":{\n\t  \"basic\": {\n\t\t\"username\": \"someDeveloper\",\t  \n\t\t\"password\": \"notTheRealPassword\"\n\n\t  }\n\t}\n}'\n\n```
.Description
This endpoint adds an authorization method to a workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"auth\":{\n\t  \"basic\": {\n\t\t\"username\": \"someDeveloper\",\t  \n\t\t\"password\": \"notTheRealPassword\"\n\n\t  }\n\t}\n}'\n\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/grant-jcsdkworkday
.Inputs
JumpCloudApiSdkV2.Models.IAuthInputObject
.Inputs
JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IAuthInputObject>: Auth Input Object
  [BasicPassword <String>]: 
  [BasicUsername <String>]: 
  [OauthCode <String>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [ActivedirectoryId <String>]: ObjectID of the Active Directory instance.
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [GroupId <String>]: ObjectID of the User Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of the User Group.
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
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/grant-jcsdkworkday
#>
function Grant-JcSdkWorkday {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='AuthorizeExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Authorize', Mandatory)]
    [Parameter(ParameterSetName='AuthorizeExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Path')]
    [System.String]
    # HELP MESSAGE MISSING
    ${WorkdayId},

    [Parameter(ParameterSetName='AuthorizeViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='AuthorizeViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Path')]
    [JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Authorize', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='AuthorizeViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.IAuthInputObject]
    # Auth Input Object
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='AuthorizeExpanded')]
    [Parameter(ParameterSetName='AuthorizeViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${BasicPassword},

    [Parameter(ParameterSetName='AuthorizeExpanded')]
    [Parameter(ParameterSetName='AuthorizeViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${BasicUsername},

    [Parameter(ParameterSetName='AuthorizeExpanded')]
    [Parameter(ParameterSetName='AuthorizeViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${OauthCode},

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
            Authorize = 'JumpCloudApiSdkV2.private\Grant-JcSdkWorkday_Authorize';
            AuthorizeExpanded = 'JumpCloudApiSdkV2.private\Grant-JcSdkWorkday_AuthorizeExpanded';
            AuthorizeViaIdentity = 'JumpCloudApiSdkV2.private\Grant-JcSdkWorkday_AuthorizeViaIdentity';
            AuthorizeViaIdentityExpanded = 'JumpCloudApiSdkV2.private\Grant-JcSdkWorkday_AuthorizeViaIdentityExpanded';
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
