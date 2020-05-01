<#
.Synopsis
This endpoint allows you to create a new workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\nCurrently, only one instance is allowed and it must be `Workday Import`.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"name\": \"Workday2\",\n  \"reportUrl\":\"https://workday.com/ccx/service/customreport2/gms/user/reportname?format=json\",\n  \"auth\": {\n    \"basic\": {\n      \"username\": \"someDeveloper\",\n      \"password\": \"notTheRealPassword\"\n    }\n  }\n}'\n```
.Description
This endpoint allows you to create a new workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\nCurrently, only one instance is allowed and it must be `Workday Import`.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"name\": \"Workday2\",\n  \"reportUrl\":\"https://workday.com/ccx/service/customreport2/gms/user/reportname?format=json\",\n  \"auth\": {\n    \"basic\": {\n      \"username\": \"someDeveloper\",\n      \"password\": \"notTheRealPassword\"\n    }\n  }\n}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

#>
Function New-JCWorkdayImportWorkday
{
    #Requires -Modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IWorkdayOutput])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IWorkdayInput]
    # Workday Input
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${BasicPassword},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${BasicUsername},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${OauthCode},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${ReportUrl},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkWorkdayImportWorkday @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
