<#
.Synopsis
This endpoint allows you to run a command.
#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/runCommand \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  -d '{\"_id\":\"{commandID}\", \"systemIds\":[\"systemId\"]}'
```
.Description
This endpoint allows you to run a command.
#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/runCommand \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  -d '{\"_id\":\"{commandID}\", \"systemIds\":[\"systemId\"]}'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IPathsPnxbyeRuncommandPostRequestbodyContentApplicationJsonSchema
.Outputs
JumpCloud.SDK.V1.Models.IPaths3Rrc57RuncommandPostResponses200ContentApplicationJsonSchema
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPathsPnxbyeRuncommandPostRequestbodyContentApplicationJsonSchema>:
  [Id <String>]: The ID of the command.
  [SystemIds <String[]>]: An optional list of device IDs to run the command on. If omitted, the command will run on devices bound to the command.
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Start-JcSdkCommand.md
#>
 Function Start-JcSdkCommand
{
    [OutputType([JumpCloud.SDK.V1.Models.IPaths3Rrc57RuncommandPostResponses200ContentApplicationJsonSchema])]
    [CmdletBinding(DefaultParameterSetName='RunExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Run', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IPathsPnxbyeRuncommandPostRequestbodyContentApplicationJsonSchema]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='RunExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The ID of the command.
    ${Id}, 

    [Parameter(ParameterSetName='RunExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String[]]
    # An optional list of device IDs to run the command on.
    # If omitted, the command will run on devices bound to the command.
    ${SystemIds}, 

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
                $Results = (JumpCloud.SDK.V1.internal\Start-JcSdkInternalCommand -ErrorAction SilentlyContinue @PSBoundParameters).ToJsonString() | ConvertFrom-Json;
                break retryLoop
            } catch {
                If ($JCHttpResponse.Result.StatusCode -eq 503) {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    Write-Warning ("An error occurred: $_.")
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


