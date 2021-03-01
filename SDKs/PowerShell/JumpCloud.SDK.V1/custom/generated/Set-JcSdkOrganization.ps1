<#
.Synopsis
This endpoint allows you to update an Organization.\n\nNote: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.\n\n`hasStripeCustomerId` is deprecated and will be removed.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"settings\": {\n    \"contactName\": \"Admin Name\",\n    \"contactEmail\": \"admin@company.com\",\n    \"systemUsersCanEdit\":true,\n    \"passwordPolicy\": {\n      \"enableMaxHistory\": true,\n      \"maxHistory\": 3\n    }\n  }\n}'\n```
.Description
This endpoint allows you to update an Organization.\n\nNote: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.\n\n`hasStripeCustomerId` is deprecated and will be removed.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"settings\": {\n    \"contactName\": \"Admin Name\",\n    \"contactEmail\": \"admin@company.com\",\n    \"systemUsersCanEdit\":true,\n    \"passwordPolicy\": {\n      \"enableMaxHistory\": true,\n      \"maxHistory\": 3\n    }\n  }\n}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V1.Models.IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema
.Outputs
JumpCloud.SDK.V1.Models.IOrganization
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema>:
  [Settings <IOrganizationsettingsput>]: OrganizationSettingsPut
    [ContactEmail <String>]:
    [ContactName <String>]:
    [DeviceIdentificationEnabled <Boolean?>]:
    [DirectoryInsightEnabled <Boolean?>]:
    [DirectoryInsightPremiumEnabled <Boolean?>]:
    [DisableGoogleLogin <Boolean?>]:
    [DisableLdap <Boolean?>]:
    [DisableUm <Boolean?>]:
    [DuplicateLdapGroups <Boolean?>]:
    [EmailDisclaimer <String>]:
    [EnableManagedUid <Boolean?>]:
    [Logo <String>]:
    [Name <String>]:
    [PasswordCompliance <String>]:
    [PasswordPolicyAllowUsernameSubstring <Boolean?>]:
    [PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]: Deprecated field used for the legacy grace period feature.
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
    [SystemInsightEnableNewDarwin <Boolean?>]:
    [SystemInsightEnableNewLinux <Boolean?>]:
    [SystemInsightEnableNewWindows <Boolean?>]:
    [SystemInsightEnabled <Boolean?>]:
    [SystemUserPasswordExpirationInDays <Int32?>]:
    [SystemUsersCanEdit <Boolean?>]:
    [UserPortalIdleSessionDurationMinutes <Int32?>]:

INPUTOBJECT <IJumpCloudApIsIdentity>:
  [Id <String>]:
  [SystemId <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:

SETTINGS <IOrganizationsettingsput>:
  [ContactEmail <String>]:
  [ContactName <String>]:
  [DeviceIdentificationEnabled <Boolean?>]:
  [DirectoryInsightEnabled <Boolean?>]:
  [DirectoryInsightPremiumEnabled <Boolean?>]:
  [DisableGoogleLogin <Boolean?>]:
  [DisableLdap <Boolean?>]:
  [DisableUm <Boolean?>]:
  [DuplicateLdapGroups <Boolean?>]:
  [EmailDisclaimer <String>]:
  [EnableManagedUid <Boolean?>]:
  [Logo <String>]:
  [Name <String>]:
  [PasswordCompliance <String>]:
  [PasswordPolicyAllowUsernameSubstring <Boolean?>]:
  [PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]: Deprecated field used for the legacy grace period feature.
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
  [SystemInsightEnableNewDarwin <Boolean?>]:
  [SystemInsightEnableNewLinux <Boolean?>]:
  [SystemInsightEnableNewWindows <Boolean?>]:
  [SystemInsightEnabled <Boolean?>]:
  [SystemUserPasswordExpirationInDays <Int32?>]:
  [SystemUsersCanEdit <Boolean?>]:
  [UserPortalIdleSessionDurationMinutes <Int32?>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkOrganization.md
#>
 Function Set-JcSdkOrganization
{
    [OutputType([JumpCloud.SDK.V1.Models.IOrganization])]
    [CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IOrganizationsettingsput]
    # OrganizationSettingsPut
    # To construct, see NOTES section for SETTINGS properties and create a hash table.
    ${Settings},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [JumpCloud.SDK.V1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [JumpCloud.SDK.V1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                # $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                # $global:JCHttpResponseContent = If (-not [System.String]::IsNullOrEmpty($ResponseTask.Result.Content)) { $ResponseTask.Result.Content.ReadAsStringAsync() }
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalOrganization @PSBoundParameters
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        # Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse', 'JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}

