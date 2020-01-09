<#
.Synopsis
This endpoint allows you to update an Organization.\n\nNote: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.\n\n`hasStripeCustomerId` is deprecated and will be removed.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"settings\": {\n    \"contactName\": \"Admin Name\",\n    \"contactEmail\": \"admin@company.com\",\n    \"systemUsersCanEdit\":true,\n    \"passwordPolicy\": {\n      \"enableMaxHistory\": true,\n      \"maxHistory\": 3\n    }\n  }\n}'\n```
.Description
This endpoint allows you to update an Organization.\n\nNote: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.\n\n`hasStripeCustomerId` is deprecated and will be removed.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"settings\": {\n    \"contactName\": \"Admin Name\",\n    \"contactEmail\": \"admin@company.com\",\n    \"systemUsersCanEdit\":true,\n    \"passwordPolicy\": {\n      \"enableMaxHistory\": true,\n      \"maxHistory\": 3\n    }\n  }\n}'\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdkorganization
.Inputs
JumpCloudApiSdkV1.Models.IBodyParameterOrganizationPutRequestBody
.Inputs
JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloudApiSdkV1.Models.IOrganization
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IBodyParameterOrganizationPutRequestBody>: HELP MESSAGE MISSING
  [Settings <IOrganizationsettingsput>]: OrganizationSettingsPut
    [ContactEmail <String>]: 
    [ContactName <String>]: 
    [DisableLdap <Boolean?>]: 
    [DisableUm <Boolean?>]: 
    [DuplicateLdapGroups <Boolean?>]: 
    [EmailDisclaimer <String>]: 
    [EnableManagedUid <Boolean?>]: 
    [Logo <String>]: 
    [Name <String>]: 
    [PasswordCompliance <String>]: 
    [PasswordPolicyAllowUsernameSubstring <Boolean?>]: 
    [PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]: 
    [PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]: 
    [PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]: 
    [PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]: 
    [PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]: 
    [PasswordPolicyEnableMaxHistory <Boolean?>]: 
    [PasswordPolicyEnableMaxLoginAttempts <Boolean?>]: 
    [PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]: 
    [PasswordPolicyEnableMinLength <Boolean?>]: 
    [PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]: 
    [PasswordPolicyLockoutTimeInSeconds <Int32?>]: 
    [PasswordPolicyMaxHistory <Int32?>]: 
    [PasswordPolicyMaxLoginAttempts <Int32?>]: 
    [PasswordPolicyMinChangePeriodInDays <Int32?>]: 
    [PasswordPolicyMinLength <Int32?>]: 
    [PasswordPolicyNeedsLowercase <Boolean?>]: 
    [PasswordPolicyNeedsNumeric <Boolean?>]: 
    [PasswordPolicyNeedsSymbolic <Boolean?>]: 
    [PasswordPolicyNeedsUppercase <Boolean?>]: 
    [PasswordPolicyPasswordExpirationInDays <Int32?>]: 
    [ShowIntro <Boolean?>]: 
    [SystemInsightEnabled <Boolean?>]: 
    [SystemUserPasswordExpirationInDays <Int32?>]: 
    [SystemUsersCanEdit <Boolean?>]: 
    [UserPortalIdleSessionDurationMinutes <Int32?>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 

SETTINGS <IOrganizationsettingsput>: OrganizationSettingsPut
  [ContactEmail <String>]: 
  [ContactName <String>]: 
  [DisableLdap <Boolean?>]: 
  [DisableUm <Boolean?>]: 
  [DuplicateLdapGroups <Boolean?>]: 
  [EmailDisclaimer <String>]: 
  [EnableManagedUid <Boolean?>]: 
  [Logo <String>]: 
  [Name <String>]: 
  [PasswordCompliance <String>]: 
  [PasswordPolicyAllowUsernameSubstring <Boolean?>]: 
  [PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]: 
  [PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]: 
  [PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]: 
  [PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]: 
  [PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]: 
  [PasswordPolicyEnableMaxHistory <Boolean?>]: 
  [PasswordPolicyEnableMaxLoginAttempts <Boolean?>]: 
  [PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]: 
  [PasswordPolicyEnableMinLength <Boolean?>]: 
  [PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]: 
  [PasswordPolicyLockoutTimeInSeconds <Int32?>]: 
  [PasswordPolicyMaxHistory <Int32?>]: 
  [PasswordPolicyMaxLoginAttempts <Int32?>]: 
  [PasswordPolicyMinChangePeriodInDays <Int32?>]: 
  [PasswordPolicyMinLength <Int32?>]: 
  [PasswordPolicyNeedsLowercase <Boolean?>]: 
  [PasswordPolicyNeedsNumeric <Boolean?>]: 
  [PasswordPolicyNeedsSymbolic <Boolean?>]: 
  [PasswordPolicyNeedsUppercase <Boolean?>]: 
  [PasswordPolicyPasswordExpirationInDays <Int32?>]: 
  [ShowIntro <Boolean?>]: 
  [SystemInsightEnabled <Boolean?>]: 
  [SystemUserPasswordExpirationInDays <Int32?>]: 
  [SystemUsersCanEdit <Boolean?>]: 
  [UserPortalIdleSessionDurationMinutes <Int32?>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdkorganization
#>
function Set-JcSdkOrganization {
[OutputType([JumpCloudApiSdkV1.Models.IOrganization])]
[CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Path')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Id},

    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Path')]
    [JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.IBodyParameterOrganizationPutRequestBody]
    # HELP MESSAGE MISSING
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.IOrganizationsettingsput]
    # OrganizationSettingsPut
    # To construct, see NOTES section for SETTINGS properties and create a hash table.
    ${Settings},

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
            Put = 'JumpCloudApiSdkV1.private\Set-JcSdkOrganization_Put';
            PutExpanded = 'JumpCloudApiSdkV1.private\Set-JcSdkOrganization_PutExpanded';
            PutViaIdentity = 'JumpCloudApiSdkV1.private\Set-JcSdkOrganization_PutViaIdentity';
            PutViaIdentityExpanded = 'JumpCloudApiSdkV1.private\Set-JcSdkOrganization_PutViaIdentityExpanded';
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
