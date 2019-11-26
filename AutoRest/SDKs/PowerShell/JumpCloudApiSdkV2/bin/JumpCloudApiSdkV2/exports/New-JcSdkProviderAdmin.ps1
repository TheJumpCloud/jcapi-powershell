<#
.Synopsis
This endpoint allows you to create a provider administrator.
You must be associated to the provider to use this route.\n\n**Sample Request**\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n    -H 'Accept: application/json' \\\n    -H 'Context-Type: application/json' \\\n    -H 'x-api-key: {API_KEY}' \\\n    -d '{\n      \"email\":\"{ADMIN_EMAIL}\"\n    }'\n```
.Description
This endpoint allows you to create a provider administrator.
You must be associated to the provider to use this route.\n\n**Sample Request**\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n    -H 'Accept: application/json' \\\n    -H 'Context-Type: application/json' \\\n    -H 'x-api-key: {API_KEY}' \\\n    -d '{\n      \"email\":\"{ADMIN_EMAIL}\"\n    }'\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkprovideradmin
.Inputs
JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloudApiSdkV2.Models.IProviderAdminReq
.Outputs
JumpCloudApiSdkV2.Models.IAdministrator
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IProviderAdminReq>: ProviderAdminReq
  Email <String>: 
  [EnableMultiFactor <Boolean?>]: 
  [Firstname <String>]: 
  [Lastname <String>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [AccountId <String>]: 
  [ActivedirectoryId <String>]: ObjectID of the Active Directory instance.
  [ApplicationId <String>]: 
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
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkprovideradmin
#>
function New-JcSdkProviderAdmin {
[OutputType([JumpCloudApiSdkV2.Models.IAdministrator], [System.String])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Path')]
    [System.String]
    # HELP MESSAGE MISSING
    ${ProviderId},

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Path')]
    [JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.IProviderAdminReq]
    # ProviderAdminReq
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Email},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${EnableMultiFactor},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Firstname},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Lastname},

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
            Create = 'JumpCloudApiSdkV2.private\New-JcSdkProviderAdmin_Create';
            CreateExpanded = 'JumpCloudApiSdkV2.private\New-JcSdkProviderAdmin_CreateExpanded';
            CreateViaIdentity = 'JumpCloudApiSdkV2.private\New-JcSdkProviderAdmin_CreateViaIdentity';
            CreateViaIdentityExpanded = 'JumpCloudApiSdkV2.private\New-JcSdkProviderAdmin_CreateViaIdentityExpanded';
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
