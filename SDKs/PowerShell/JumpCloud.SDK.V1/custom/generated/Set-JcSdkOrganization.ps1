<#
.Synopsis
This endpoint allows you to set an Organization.

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
This endpoint allows you to set an Organization.

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
PS C:\> Set-JcSdkOrganization -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Paths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema>)



----                             ----------
AccessRestriction                String
AccountsReceivable               String
Created                          String
DisplayName                      String
EntitlementBillingModel          String
EntitlementIsManuallyBilled      Boolean
EntitlementPricePerUserSum       Int
EntitlementProducts              JumpCloud.SDK.V1.Models.OrganizationentitlementEntitlementProductsItem[]
HasCreditCard                    Boolean
HasStripeCustomerId              Boolean
Id                               String
LastEstimateCalculationTimeStamp String
LastSfdcSyncStatus               JumpCloud.SDK.V1.Models.OrganizationLastSfdcSyncStatus
LogoUrl                          String
Provider                         String
Settings                         JumpCloud.SDK.V1.Models.Organizationsettings
TotalBillingEstimate             Int


.Example
PS C:\> Set-JcSdkOrganization -Id:(<string>) -Settings:(<JumpCloud.SDK.V1.Models.Organizationsettingsput>)



----                             ----------
AccessRestriction                String
AccountsReceivable               String
Created                          String
DisplayName                      String
EntitlementBillingModel          String
EntitlementIsManuallyBilled      Boolean
EntitlementPricePerUserSum       Int
EntitlementProducts              JumpCloud.SDK.V1.Models.OrganizationentitlementEntitlementProductsItem[]
HasCreditCard                    Boolean
HasStripeCustomerId              Boolean
Id                               String
LastEstimateCalculationTimeStamp String
LastSfdcSyncStatus               JumpCloud.SDK.V1.Models.OrganizationLastSfdcSyncStatus
LogoUrl                          String
Provider                         String
Settings                         JumpCloud.SDK.V1.Models.Organizationsettings
TotalBillingEstimate             Int



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
    [PasswordPolicy <IOrganizationsettingsputPasswordPolicy>]:
      [AllowUnenrolledMfaPasswordReset <Boolean?>]:
      [AllowUsernameSubstring <Boolean?>]:
      [DaysAfterExpirationToSelfRecover <Int32?>]: Deprecated field used for the legacy grace period feature.
      [DaysBeforeExpirationToForceReset <Int32?>]:
      [DisallowCommonlyUsedPasswords <Boolean?>]:
      [DisallowSequentialOrRepetitiveChars <Boolean?>]:
      [EffectiveDate <String>]:
      [EnableDaysAfterExpirationToSelfRecover <Boolean?>]:
      [EnableDaysBeforeExpirationToForceReset <Boolean?>]:
      [EnableLockoutTimeInSeconds <Boolean?>]:
      [EnableMaxHistory <Boolean?>]:
      [EnableMaxLoginAttempts <Boolean?>]:
      [EnableMinChangePeriodInDays <Boolean?>]:
      [EnableMinLength <Boolean?>]:
      [EnablePasswordExpirationInDays <Boolean?>]:
      [GracePeriodDate <String>]:
      [LockoutTimeInSeconds <Int32?>]:
      [MaxHistory <Int32?>]:
      [MaxLoginAttempts <Int32?>]:
      [MinChangePeriodInDays <Int32?>]:
      [MinLength <Int32?>]:
      [NeedsLowercase <Boolean?>]:
      [NeedsNumeric <Boolean?>]:
      [NeedsSymbolic <Boolean?>]:
      [NeedsUppercase <Boolean?>]:
      [PasswordExpirationInDays <Int32?>]:
    [ShowIntro <Boolean?>]:
    [SystemInsightCreatedAt <String>]:
    [SystemInsightEnableNewDarwin <Boolean?>]:
    [SystemInsightEnableNewLinux <Boolean?>]:
    [SystemInsightEnableNewWindows <Boolean?>]:
    [SystemInsightEnabled <Boolean?>]:
    [SystemInsightUpdatedAt <String>]:
    [SystemUserDefaultRestrictedFields <List<IRestrictedField1>>]:
      [Field <String>]:
      [Id <String>]:
      [Type <String>]:
    [SystemUserPasswordExpirationInDays <Int32?>]:
    [SystemUsersCanEdit <Boolean?>]:
    [TrustedAppConfigTrustedApps <List<ITrustedappConfigPutTrustedAppsItem>>]: List of authorized apps for the organization
      Name <String>: Name of the trusted application
      [Path <String>]: Absolute path for the app's location in user's device
      [Teamid <String>]: App's Team ID
    [UserPortalCookieExpirationType <String>]:
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
  [PasswordPolicy <IOrganizationsettingsputPasswordPolicy>]:
    [AllowUnenrolledMfaPasswordReset <Boolean?>]:
    [AllowUsernameSubstring <Boolean?>]:
    [DaysAfterExpirationToSelfRecover <Int32?>]: Deprecated field used for the legacy grace period feature.
    [DaysBeforeExpirationToForceReset <Int32?>]:
    [DisallowCommonlyUsedPasswords <Boolean?>]:
    [DisallowSequentialOrRepetitiveChars <Boolean?>]:
    [EffectiveDate <String>]:
    [EnableDaysAfterExpirationToSelfRecover <Boolean?>]:
    [EnableDaysBeforeExpirationToForceReset <Boolean?>]:
    [EnableLockoutTimeInSeconds <Boolean?>]:
    [EnableMaxHistory <Boolean?>]:
    [EnableMaxLoginAttempts <Boolean?>]:
    [EnableMinChangePeriodInDays <Boolean?>]:
    [EnableMinLength <Boolean?>]:
    [EnablePasswordExpirationInDays <Boolean?>]:
    [GracePeriodDate <String>]:
    [LockoutTimeInSeconds <Int32?>]:
    [MaxHistory <Int32?>]:
    [MaxLoginAttempts <Int32?>]:
    [MinChangePeriodInDays <Int32?>]:
    [MinLength <Int32?>]:
    [NeedsLowercase <Boolean?>]:
    [NeedsNumeric <Boolean?>]:
    [NeedsSymbolic <Boolean?>]:
    [NeedsUppercase <Boolean?>]:
    [PasswordExpirationInDays <Int32?>]:
  [ShowIntro <Boolean?>]:
  [SystemInsightCreatedAt <String>]:
  [SystemInsightEnableNewDarwin <Boolean?>]:
  [SystemInsightEnableNewLinux <Boolean?>]:
  [SystemInsightEnableNewWindows <Boolean?>]:
  [SystemInsightEnabled <Boolean?>]:
  [SystemInsightUpdatedAt <String>]:
  [SystemUserDefaultRestrictedFields <List<IRestrictedField1>>]:
    [Field <String>]:
    [Id <String>]:
    [Type <String>]:
  [SystemUserPasswordExpirationInDays <Int32?>]:
  [SystemUsersCanEdit <Boolean?>]:
  [TrustedAppConfigTrustedApps <List<ITrustedappConfigPutTrustedAppsItem>>]: List of authorized apps for the organization
    Name <String>: Name of the trusted application
    [Path <String>]: Absolute path for the app's location in user's device
    [Teamid <String>]: App's Team ID
  [UserPortalCookieExpirationType <String>]:
  [UserPortalIdleSessionDurationMinutes <Int32?>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkOrganization.md
#>
 Function Set-JcSdkOrganization
{
    [OutputType([JumpCloud.SDK.V1.Models.IOrganization])]
    [CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V1.Category('Uri')]
    [System.String]
    # Region for JumpCloud API host.
    # Use 'console' for US or 'console.eu' for EU.
    ${HostEnv}, 

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
    ${InputObject}, 

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema]
    # .
    ${Body}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IOrganizationsettingsput]
    # OrganizationSettingsPut
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
            $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalOrganization @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
            If ($sdkError){
                If ($resultCounter -eq $maxRetries){
                    throw $sdkError
                }
                If ($JCHttpResponse.Result.StatusCode -eq "503") {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    throw $sdkError
                }
            } else {
                break retryLoop
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


