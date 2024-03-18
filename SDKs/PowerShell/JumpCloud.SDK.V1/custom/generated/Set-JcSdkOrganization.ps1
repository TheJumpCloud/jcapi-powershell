<#
.Synopsis
This endpoint allows you to update an Organization.

Note: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.

`emailDisclaimer` can only be modified by paying customers.

`hasStripeCustomerId` is deprecated and will be removed.

#### Sample Request

```
curl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"settings\": {
    \"contactName\": \"Admin Name\",
    \"contactEmail\": \"admin@company.com\",
    \"systemUsersCanEdit\":true,
    \"passwordPolicy\": {
      \"enableMaxHistory\": true,
      \"maxHistory\": 3
    }
  }
}'
```
.Description
This endpoint allows you to update an Organization.

Note: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.

`emailDisclaimer` can only be modified by paying customers.

`hasStripeCustomerId` is deprecated and will be removed.

#### Sample Request

```
curl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"settings\": {
    \"contactName\": \"Admin Name\",
    \"contactEmail\": \"admin@company.com\",
    \"systemUsersCanEdit\":true,
    \"passwordPolicy\": {
      \"enableMaxHistory\": true,
      \"maxHistory\": 3
    }
  }
}'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
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
    [DirectoryInsightPremiumCreatedAt <String>]:
    [DirectoryInsightPremiumEnabled <Boolean?>]:
    [DirectoryInsightPremiumUpdatedAt <String>]:
    [DisableGoogleLogin <Boolean?>]:
    [DisableLdap <Boolean?>]:
    [DisableUm <Boolean?>]:
    [DuplicateLdapGroups <Boolean?>]:
    [EmailDisclaimer <String>]:
    [EnableManagedUid <Boolean?>]:
    [GrowthData <IOrganizationsettingsputGrowthData>]: Object containing Optimizely experimentIds and states corresponding to them
      [(Any) <Object>]: This indicates any property can be added to this object.
    [Logo <String>]:
    [MaxSystemUsers <Int32?>]:
    [Name <String>]:
    [NewSystemUserStateDefaultApplicationImport <String>]:
    [NewSystemUserStateDefaultCsvImport <String>]:
    [NewSystemUserStateDefaultManualEntry <String>]:
    [PasswordCompliance <String>]:
    [PasswordPolicyAllowUsernameSubstring <Boolean?>]:
    [PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]: Deprecated field used for the legacy grace period feature.
    [PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]:
    [PasswordPolicyEffectiveDate <String>]:
    [PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]:
    [PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]:
    [PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]:
    [PasswordPolicyEnableMaxHistory <Boolean?>]:
    [PasswordPolicyEnableMaxLoginAttempts <Boolean?>]:
    [PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]:
    [PasswordPolicyEnableMinLength <Boolean?>]:
    [PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]:
    [PasswordPolicyGracePeriodDate <String>]:
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
    [SystemInsightCreatedAt <String>]:
    [SystemInsightEnableNewDarwin <Boolean?>]:
    [SystemInsightEnableNewLinux <Boolean?>]:
    [SystemInsightEnableNewWindows <Boolean?>]:
    [SystemInsightEnabled <Boolean?>]:
    [SystemInsightUpdatedAt <String>]:
    [SystemUserDefaultRestrictedFields <IRestrictedFields[]>]:
      [Field <String>]:
      [Id <String>]:
      [Type <String>]:
    [SystemUserPasswordExpirationInDays <Int32?>]:
    [SystemUsersCanEdit <Boolean?>]:
    [TrustedAppConfigTrustedApps <ITrustedappConfigPutTrustedAppsItem[]>]: List of authorized apps for the organization
      Name <String>: Name of the trusted application
      [Path <String>]: Absolute path for the app's location in user's device
      [Teamid <String>]: App's Team ID
    [UserPortalIdleSessionDurationMinutes <Int32?>]:

INPUTOBJECT <IJumpCloudApiIdentity>:
  [Id <String>]:
  [SystemId <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:

SETTINGS <IOrganizationsettingsput>:
  [ContactEmail <String>]:
  [ContactName <String>]:
  [DeviceIdentificationEnabled <Boolean?>]:
  [DirectoryInsightEnabled <Boolean?>]:
  [DirectoryInsightPremiumCreatedAt <String>]:
  [DirectoryInsightPremiumEnabled <Boolean?>]:
  [DirectoryInsightPremiumUpdatedAt <String>]:
  [DisableGoogleLogin <Boolean?>]:
  [DisableLdap <Boolean?>]:
  [DisableUm <Boolean?>]:
  [DuplicateLdapGroups <Boolean?>]:
  [EmailDisclaimer <String>]:
  [EnableManagedUid <Boolean?>]:
  [GrowthData <IOrganizationsettingsputGrowthData>]: Object containing Optimizely experimentIds and states corresponding to them
    [(Any) <Object>]: This indicates any property can be added to this object.
  [Logo <String>]:
  [MaxSystemUsers <Int32?>]:
  [Name <String>]:
  [NewSystemUserStateDefaultApplicationImport <String>]:
  [NewSystemUserStateDefaultCsvImport <String>]:
  [NewSystemUserStateDefaultManualEntry <String>]:
  [PasswordCompliance <String>]:
  [PasswordPolicyAllowUsernameSubstring <Boolean?>]:
  [PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]: Deprecated field used for the legacy grace period feature.
  [PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]:
  [PasswordPolicyEffectiveDate <String>]:
  [PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]:
  [PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]:
  [PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]:
  [PasswordPolicyEnableMaxHistory <Boolean?>]:
  [PasswordPolicyEnableMaxLoginAttempts <Boolean?>]:
  [PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]:
  [PasswordPolicyEnableMinLength <Boolean?>]:
  [PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]:
  [PasswordPolicyGracePeriodDate <String>]:
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
  [SystemInsightCreatedAt <String>]:
  [SystemInsightEnableNewDarwin <Boolean?>]:
  [SystemInsightEnableNewLinux <Boolean?>]:
  [SystemInsightEnableNewWindows <Boolean?>]:
  [SystemInsightEnabled <Boolean?>]:
  [SystemInsightUpdatedAt <String>]:
  [SystemUserDefaultRestrictedFields <IRestrictedFields[]>]:
    [Field <String>]:
    [Id <String>]:
    [Type <String>]:
  [SystemUserPasswordExpirationInDays <Int32?>]:
  [SystemUsersCanEdit <Boolean?>]:
  [TrustedAppConfigTrustedApps <ITrustedappConfigPutTrustedAppsItem[]>]: List of authorized apps for the organization
    Name <String>: Name of the trusted application
    [Path <String>]: Absolute path for the app's location in user's device
    [Teamid <String>]: App's Team ID
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
    [JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity]
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
        $maxRetries = 4
        $resultCounter = 0
        :retryLoop do {
            $resultCounter++
            try {
                $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalOrganization @PSBoundParameters -ErrorAction Stop
                break retryLoop
            } catch {
                If (($JCHttpResponse.Result.StatusCode -ne 503) -or ($resultCounter -eq $maxRetries)) {
                    throw $_
                } else {
                    Write-Warning ("An error occurred: $_.")
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                }
            }
            Start-Sleep -Seconds ($resultCounter * 5)
        } while ($resultCounter -lt $maxRetries)
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
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) {
                Remove-Variable -Name:($_) -Scope:('Global')
            }
        }
        Return $Results
    }
}


