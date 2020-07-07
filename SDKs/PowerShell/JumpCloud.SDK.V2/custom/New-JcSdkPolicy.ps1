<#
.Synopsis
This endpoint allows you to create a policy.
Given the amount of configurable parameters required to create a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Policy_Parameters}\n}'\n\n```
.Description
This endpoint allows you to create a policy.
Given the amount of configurable parameters required to create a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Policy_Parameters}\n}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IPolicyRequest
.Outputs
JumpCloud.SDK.V2.Models.IPolicyWithDetails
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPolicyRequest>: 
  Name <String>: The description for this specific Policy.
  [TemplateId <String>]: ObjectId uniquely identifying a Policy instance; only allowed on POST requests.
  [Values <IPolicyValue[]>]: 
    [ConfigFieldId <String>]: The ObjectId of the corresponding Policy Template configuration field.
    [Value <String>]: The value for the configuration field for this Policy instance.

VALUES <IPolicyValue[]>: 
  [ConfigFieldId <String>]: The ObjectId of the corresponding Policy Template configuration field.
  [Value <String>]: The value for the configuration field for this Policy instance.
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/new-jcsdkpolicy
#>
 Function New-JcSdkPolicy
{
    [OutputType([JumpCloud.SDK.V2.Models.IPolicyWithDetails])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IPolicyRequest]
    # An instance of a policy template.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The description for this specific Policy.
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # ObjectId uniquely identifying a Policy instance; only allowed on POST requests.
    ${TemplateId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IPolicyValue[]]
    # .
    # To construct, see NOTES section for VALUES properties and create a hash table.
    ${Values}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalPolicy @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

