<#
.Synopsis
This endpoint allows you to create a new system user.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"username\":\"{username}\",\n\t\"email\":\"{email_address}\",\n\t\"firstname\":\"{Name}\",\n\t\"lastname\":\"{Name}\"\n}'\n```
.Description
This endpoint allows you to create a new system user.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"username\":\"{username}\",\n\t\"email\":\"{email_address}\",\n\t\"firstname\":\"{Name}\",\n\t\"lastname\":\"{Name}\"\n}'\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdksystemuser
.Inputs
JumpCloudApiSdkV1.Models.ISystemuserputpost
.Outputs
JumpCloudApiSdkV1.Models.ISystemuserreturn
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ADDRESSES <ISystemuserputpostAddressesItem[]>: HELP MESSAGE MISSING
  [Country <String>]: 
  [ExtendedAddress <String>]: 
  [Locality <String>]: 
  [PoBox <String>]: 
  [PostalCode <String>]: 
  [Region <String>]: 
  [StreetAddress <String>]: 
  [Type <String>]: 

BODY <ISystemuserputpost>: SystemUserPost
  Email <String>: 
  Username <String>: 
  [AccountLocked <Boolean?>]: 
  [Activated <Boolean?>]: 
  [Addresses <ISystemuserputpostAddressesItem[]>]: 
    [Country <String>]: 
    [ExtendedAddress <String>]: 
    [Locality <String>]: 
    [PoBox <String>]: 
    [PostalCode <String>]: 
    [Region <String>]: 
    [StreetAddress <String>]: 
    [Type <String>]: 
  [AllowPublicKey <Boolean?>]: 
  [Attributes <ISystemuserputpostAttributesItem[]>]: 
  [Company <String>]: 
  [CostCenter <String>]: 
  [Department <String>]: 
  [Description <String>]: 
  [Displayname <String>]: 
  [EmployeeIdentifier <String>]: Must be unique per user. 
  [EmployeeType <String>]: 
  [EnableManagedUid <Boolean?>]: 
  [EnableUserPortalMultifactor <Boolean?>]: 
  [ExternalDn <String>]: 
  [ExternalPasswordExpirationDate <String>]: 
  [ExternalSourceType <String>]: 
  [ExternallyManaged <Boolean?>]: 
  [Firstname <String>]: 
  [JobTitle <String>]: 
  [Lastname <String>]: 
  [LdapBindingUser <Boolean?>]: 
  [Location <String>]: 
  [MfaConfigured <Boolean?>]: 
  [MfaExclusion <Boolean?>]: 
  [MfaExclusionUntil <DateTime?>]: 
  [Middlename <String>]: 
  [Password <String>]: 
  [PasswordNeverExpires <Boolean?>]: 
  [PasswordlessSudo <Boolean?>]: 
  [PhoneNumbers <ISystemuserputpostPhoneNumbersItem[]>]: 
    [Number <String>]: 
    [Type <String>]: 
  [PublicKey <String>]: 
  [Relationships <ISystemuserputpostRelationshipsItem[]>]: 
  [SambaServiceUser <Boolean?>]: 
  [Sudo <Boolean?>]: 
  [Suspended <Boolean?>]: 
  [Tags <String[]>]: 
  [UnixGuid <Int32?>]: 
  [UnixUid <Int32?>]: 

PHONENUMBERS <ISystemuserputpostPhoneNumbersItem[]>: HELP MESSAGE MISSING
  [Number <String>]: 
  [Type <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdksystemuser
#>
function New-JcSdkSystemUser {
[OutputType([JumpCloudApiSdkV1.Models.ISystemuserreturn])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.ISystemuserputpost]
    # SystemUserPost
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Email},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Username},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${AccountLocked},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${Activated},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.ISystemuserputpostAddressesItem[]]
    # HELP MESSAGE MISSING
    # To construct, see NOTES section for ADDRESSES properties and create a hash table.
    ${Addresses},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${AllowPublicKey},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.ISystemuserputpostAttributesItem[]]
    # HELP MESSAGE MISSING
    ${Attributes},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Company},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${CostCenter},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Department},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Description},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Displayname},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # Must be unique per user.
    ${EmployeeIdentifier},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${EmployeeType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${EnableManagedUid},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${EnableUserPortalMultifactor},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${ExternalDn},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${ExternalPasswordExpirationDate},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${ExternalSourceType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${ExternallyManaged},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Firstname},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${JobTitle},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Lastname},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${LdapBindingUser},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Location},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${MfaConfigured},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${MfaExclusion},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.DateTime]
    # HELP MESSAGE MISSING
    ${MfaExclusionUntil},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Middlename},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Password},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${PasswordNeverExpires},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${PasswordlessSudo},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.ISystemuserputpostPhoneNumbersItem[]]
    # HELP MESSAGE MISSING
    # To construct, see NOTES section for PHONENUMBERS properties and create a hash table.
    ${PhoneNumbers},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${PublicKey},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.ISystemuserputpostRelationshipsItem[]]
    # HELP MESSAGE MISSING
    ${Relationships},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${SambaServiceUser},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${Sudo},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${Suspended},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String[]]
    # HELP MESSAGE MISSING
    ${Tags},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Int32]
    # HELP MESSAGE MISSING
    ${UnixGuid},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Int32]
    # HELP MESSAGE MISSING
    ${UnixUid},

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
            Create = 'JumpCloudApiSdkV1.private\New-JcSdkSystemUser_Create';
            CreateExpanded = 'JumpCloudApiSdkV1.private\New-JcSdkSystemUser_CreateExpanded';
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
