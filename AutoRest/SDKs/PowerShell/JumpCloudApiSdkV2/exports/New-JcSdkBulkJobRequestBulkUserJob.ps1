<#
.Synopsis
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t\t\"email\":\"{email}\",\n\t\t\"firstname\":\"{firstname}\",\n\t\t\"lastname\":\"{firstname}\",\n\t\t\"username\":\"{username}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},\n\t\t\t{\"name\":\"Custom\",\"value\":\"attribute\"}\n\t\t]\n\t}\n]\n```
.Description
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t\t\"email\":\"{email}\",\n\t\t\"firstname\":\"{firstname}\",\n\t\t\"lastname\":\"{firstname}\",\n\t\t\"username\":\"{username}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},\n\t\t\t{\"name\":\"Custom\",\"value\":\"attribute\"}\n\t\t]\n\t}\n]\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkbulkjobrequestbulkuserjob
.Inputs
JumpCloudApiSdkV2.Models.IBulkUserCreate[]
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IBulkUserCreate[]>: HELP MESSAGE MISSING
  [Attributes <IBulkUserCreateAttributesItem[]>]: Map of additional attributes.
  [Email <String>]: 
  [Firstname <String>]: 
  [Lastname <String>]: 
  [Username <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkbulkjobrequestbulkuserjob
#>
function New-JcSdkBulkJobRequestBulkUserJob {
[OutputType([System.String])]
[CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.IBulkUserCreate[]]
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
            Create = 'JumpCloudApiSdkV2.private\New-JcSdkBulkJobRequestBulkUserJob_Create';
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
