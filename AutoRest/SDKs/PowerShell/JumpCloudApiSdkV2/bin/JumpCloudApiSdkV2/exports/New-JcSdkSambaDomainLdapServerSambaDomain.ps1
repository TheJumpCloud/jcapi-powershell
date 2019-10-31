<#
.Synopsis
This endpoint allows you to create a samba domain for an LDAP server.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\"sid\":\"{SID_ID}\",\n\"name\":\"{WORKGROUP_NAME}\"\n}'\n```
.Description
This endpoint allows you to create a samba domain for an LDAP server.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\"sid\":\"{SID_ID}\",\n\"name\":\"{WORKGROUP_NAME}\"\n}'\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdksambadomainldapserversambadomain
.Inputs
JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloudApiSdkV2.Models.ISambaDomainInput
.Outputs
JumpCloudApiSdkV2.Models.ISambaDomainOutput
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISambaDomainInput>: Samba Domain Input
  Name <String>: Name of this domain's WorkGroup
  Sid <String>: Security identifier of this domain

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
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdksambadomainldapserversambadomain
#>
function New-JcSdkSambaDomainLdapServerSambaDomain {
[OutputType([JumpCloudApiSdkV2.Models.ISambaDomainOutput])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Path')]
    [System.String]
    # Unique identifier of the LDAP server.
    ${LdapserverId},

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Path')]
    [JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [JumpCloudApiSdkV2.Category('Header')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Accept},

    [Parameter()]
    [JumpCloudApiSdkV2.Category('Header')]
    [System.String]
    # HELP MESSAGE MISSING
    ${ContentType},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.ISambaDomainInput]
    # Samba Domain Input
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # Name of this domain's WorkGroup
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # Security identifier of this domain
    ${Sid},

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
            Create = 'JumpCloudApiSdkV2.private\New-JcSdkSambaDomainLdapServerSambaDomain_Create';
            CreateExpanded = 'JumpCloudApiSdkV2.private\New-JcSdkSambaDomainLdapServerSambaDomain_CreateExpanded';
            CreateViaIdentity = 'JumpCloudApiSdkV2.private\New-JcSdkSambaDomainLdapServerSambaDomain_CreateViaIdentity';
            CreateViaIdentityExpanded = 'JumpCloudApiSdkV2.private\New-JcSdkSambaDomainLdapServerSambaDomain_CreateViaIdentityExpanded';
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
