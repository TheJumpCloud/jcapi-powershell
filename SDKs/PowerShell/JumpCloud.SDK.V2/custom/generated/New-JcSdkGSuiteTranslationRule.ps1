<#
.Synopsis
This endpoint allows you to create a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```
.Description
This endpoint allows you to create a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IGSuiteTranslationRuleRequest
.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloud.SDK.V2.Models.IGSuiteTranslationRule
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IGSuiteTranslationRuleRequest>:
  [BuiltIn <String>]: Built-in translations for G Suite export:         * `user_home_addresses` - Translate all JumpCloud user addresses of type `home` to G Suite Directory user addresses of type `home`         * `user_work_addresses` - Translate all JumpCloud user addresses of type `work` to G Suite Directory user addresses of type `work`         * `user_other_addresses` - Translate all JumpCloud user addresses of type `other` to G Suite Directory user addresses of type `other`         * `user_home_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `home` to G Suite Directory user phones of type `home`         * `user_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `mobile` to G Suite Directory user phones of type `mobile`         * `user_other_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `other` to G Suite Directory user phones of type `other`         * `user_work_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work` to G Suite Directory user phones of type `work`         * `user_work_fax_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_fax` to G Suite Directory user phones of type `work_fax`         * `user_work_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_mobile` to G Suite Directory user phones of type `work_mobile`         * `user_primary_organization_cost_center` - Translate JumpCloud user  `costCenter` to G Suite Directory user `costCenter` for `primary` organization         * `user_primary_organization_department` - Translate JumpCloud user  `department` to G Suite Directory user `department` for `primary` organization         * `user_primary_organization_description` - Translate JumpCloud user  `employeeType` to G Suite Directory user `description` for `primary` organization         * `user_primary_organization_employee_id` - Translate JumpCloud user  `employeeIdentifier` to G Suite Directory user `externalIds` element of type `organization`         * `user_primary_organization_title` - Translate JumpCloud user  `jobTitle` to G Suite Directory user `title` for `primary` organization        

INPUTOBJECT <IJumpCloudApIsIdentity>:
  [AccountId <String>]:
  [ActivedirectoryId <String>]:
  [AppleMdmId <String>]:
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [CustomEmailType <String>]:
  [DeviceId <String>]:
  [GroupId <String>]: ObjectID of the System Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of the Policy Template.
  [JobId <String>]:
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: ObjectID of the Policy.
  [ProviderId <String>]:
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SoftwareAppId <String>]: ObjectID of the Software App.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkGSuiteTranslationRule.md
#>
 Function New-JcSdkGSuiteTranslationRule
{
    [OutputType([JumpCloud.SDK.V2.Models.IGSuiteTranslationRule])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${GsuiteId},

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
    [JumpCloud.SDK.V2.Models.IGSuiteTranslationRuleRequest]
    # G Suite Translation Rule Request
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Built-in translations for G Suite export:* `user_home_addresses` - Translate all JumpCloud user addresses of type `home` to G Suite Directory user addresses of type `home`* `user_work_addresses` - Translate all JumpCloud user addresses of type `work` to G Suite Directory user addresses of type `work`* `user_other_addresses` - Translate all JumpCloud user addresses of type `other` to G Suite Directory user addresses of type `other`* `user_home_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `home` to G Suite Directory user phones of type `home`* `user_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `mobile` to G Suite Directory user phones of type `mobile`* `user_other_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `other` to G Suite Directory user phones of type `other`* `user_work_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work` to G Suite Directory user phones of type `work`* `user_work_fax_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_fax` to G Suite Directory user phones of type `work_fax`* `user_work_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_mobile` to G Suite Directory user phones of type `work_mobile`* `user_primary_organization_cost_center` - Translate JumpCloud user `costCenter` to G Suite Directory user `costCenter` for `primary` organization* `user_primary_organization_department` - Translate JumpCloud user `department` to G Suite Directory user `department` for `primary` organization* `user_primary_organization_description` - Translate JumpCloud user `employeeType` to G Suite Directory user `description` for `primary` organization* `user_primary_organization_employee_id` - Translate JumpCloud user `employeeIdentifier` to G Suite Directory user `externalIds` element of type `organization`* `user_primary_organization_title` - Translate JumpCloud user `jobTitle` to G Suite Directory user `title` for `primary` organization
    ${BuiltIn},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
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
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalGSuiteTranslationRule @PSBoundParameters
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

