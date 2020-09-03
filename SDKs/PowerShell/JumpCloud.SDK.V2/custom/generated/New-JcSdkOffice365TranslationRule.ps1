<#
.Synopsis
This endpoint allows you to create a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```
.Description
This endpoint allows you to create a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V2.Models.IOffice365TranslationRuleRequest
.Outputs
JumpCloud.SDK.V2.Models.IOffice365TranslationRule
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IOffice365TranslationRuleRequest>:
  [BuiltIn <String>]: Built-in translations for Office 365 (Microsoft Graph) export:         * `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user         * `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user         * `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph `user`         * `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft Graph `user`         * `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of Microsoft Graph `user`         * `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones` field of Microsoft Graph `user`         * `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone` field of Microsoft Graph `user`         * `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user`         * `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user`         * `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user`

INPUTOBJECT <IJumpCloudApIsIdentity>:
  [AccountId <String>]:
  [ActivedirectoryId <String>]:
  [AppleMdmId <String>]:
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [DeviceId <String>]:
  [GroupId <String>]: ObjectID of the System Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of the System Group.
  [JobId <String>]:
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: ObjectID of the Policy.
  [ProviderId <String>]:
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkOffice365TranslationRule.md
#>
 Function New-JcSdkOffice365TranslationRule
{
    [OutputType([JumpCloud.SDK.V2.Models.IOffice365TranslationRule])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${Office365Id},

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IOffice365TranslationRuleRequest]
    # Office 365 Translation Rule Request
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Built-in translations for Office 365 (Microsoft Graph) export:* `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user* `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user* `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph `user` * `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft Graph `user` * `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of Microsoft Graph `user` * `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones` field of Microsoft Graph `user` * `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone` field of Microsoft Graph `user` * `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user` * `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user` * `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user`
    ${BuiltIn}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                # $global:JCHttpResponseContent = If (-not [System.String]::IsNullOrEmpty($ResponseTask.Result.Content)) { $ResponseTask.Result.Content.ReadAsStringAsync() }
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalOffice365TranslationRule @PSBoundParameters
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse','JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}

