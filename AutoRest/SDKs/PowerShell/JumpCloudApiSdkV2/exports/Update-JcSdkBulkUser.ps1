<#
.Synopsis
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/1.0/systemusers/update-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"department\":\"{UPDATED_DEPARTMENT}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}\n\t\t]\n\t},\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",\n\t\t\"phoneNumbers\":[\n\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},\n\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}\n\t\t]\n\t}\n]\n```
.Description
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/1.0/systemusers/update-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"department\":\"{UPDATED_DEPARTMENT}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}\n\t\t]\n\t},\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",\n\t\t\"phoneNumbers\":[\n\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},\n\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}\n\t\t]\n\t}\n]\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/update-jcsdkbulkuser
.Inputs
JumpCloudApiSdkV2.Models.IBulkUserUpdate[]
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IBulkUserUpdate[]>: HELP MESSAGE MISSING
  [Attributes <IBulkUserUpdateAttributesItem[]>]: Map of additional attributes.
  [Email <String>]: 
  [Firstname <String>]: 
  [Id <String>]: Object ID of the systemuser being updated
  [Lastname <String>]: 
  [Username <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/update-jcsdkbulkuser
#>
function Update-JcSdkBulkUser {
[OutputType([System.String])]
[CmdletBinding(DefaultParameterSetName='Update', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.IBulkUserUpdate[]]
    # HELP MESSAGE MISSING
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

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
            Update = 'JumpCloudApiSdkV2.private\Update-JcSdkBulkUser_Update';
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
