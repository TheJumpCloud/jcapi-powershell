<#
.Synopsis
This endpoint allows you to create scheduled statechange jobs.
#### Sample Request
```
curl -X POST \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json' \\
  -d '{
    \"user_ids\": [\"{User_ID_1}\", \"{User_ID_2}\", \"{User_ID_3}\"],
    \"state\": \"SUSPENDED\",
    \"start_date\": \"2000-01-01T00:00:00.000Z\"
  }'
```
.Description
This endpoint allows you to create scheduled statechange jobs.
#### Sample Request
```
curl -X POST \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json' \\
  -d '{
    \"user_ids\": [\"{User_ID_1}\", \"{User_ID_2}\", \"{User_ID_3}\"],
    \"state\": \"SUSPENDED\",
    \"start_date\": \"2000-01-01T00:00:00.000Z\"
  }'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IBulkScheduledStatechangeCreate
.Outputs
JumpCloud.SDK.V2.Models.IScheduledUserstateResult
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IBulkScheduledStatechangeCreate>:
  StartDate <DateTime>: Date and time that scheduled action should occur
  State <String>: The state to move the user(s) to
  UserIds <String[]>: Array of system user ids to schedule for a state change
  [ActivationEmailOverride <String>]: Send the activation or welcome email to the specified email address upon activation. Can only be used with a single user_id and scheduled activation. This field will be ignored if `send_activation_emails` is explicitly set to false.
  [SendActivationEmails <Boolean?>]: Set to true to send activation or welcome email(s) to each user_id upon activation. Set to false to suppress emails. Can only be used with scheduled activation(s).
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkBulkUserState.md
#>
 Function New-JcSdkBulkUserState
{
    [OutputType([JumpCloud.SDK.V2.Models.IScheduledUserstateResult])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IBulkScheduledStatechangeCreate]
    # Model to support bulk scheduling of a state change for one or more users
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.DateTime]
    # Date and time that scheduled action should occur
    ${StartDate}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The state to move the user(s) to
    ${State}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # Array of system user ids to schedule for a state change
    ${UserIds}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Send the activation or welcome email to the specified email address upon activation.
    # Can only be used with a single user_id and scheduled activation.
    # This field will be ignored if `send_activation_emails` is explicitly set to false.
    ${ActivationEmailOverride}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Set to true to send activation or welcome email(s) to each user_id upon activation.
    # Set to false to suppress emails.
    # Can only be used with scheduled activation(s).
    ${SendActivationEmails}, 

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
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalBulkUserState @PSBoundParameters
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


