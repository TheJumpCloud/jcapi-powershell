<#
.Synopsis
The endpoint allows you to list scheduled statechange jobs.
#### Sample Request
```
curl -X GET \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json'
```
.Description
The endpoint allows you to list scheduled statechange jobs.
#### Sample Request
```
curl -X GET \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json'
```
.Example
PS C:\> Get-JcSdkBulkUserState



----           ----------
ScheduledDate  String
ScheduledJobId String
State          String
SystemUserId   String


.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IScheduledUserstateResult
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkBulkUserState.md
#>
 Function Get-JcSdkBulkUserState
{
    [OutputType([JumpCloud.SDK.V2.Models.IScheduledUserstateResult])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter()]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # A filter to apply to the query.
    # 
    # **Filter structure**: `<field>:<operator>:<value>`.
    # 
    # **field** = Populate with a valid field from an endpoint response.
    # 
    # **operator** = Supported operators are: eq, ne, gt, ge, lt, le, between, search, in.
    # _Note: v1 operators differ from v2 operators._
    # 
    # **value** = Populate with the value you want to search for.
    # Is case sensitive.
    # Supports wild cards.
    # 
    # **EX:** `GET /api/v2/groups?filter=name:eq:Test+Group`
    ${Filter}, 

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String]
    # The systemuser id to filter by.
    ${Userid}, 

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
    ${ProxyUseDefaultCredentials}, 

    [Parameter(DontShow)]
    [System.Boolean]
    # Set to $true to return all results. This will overwrite any skip and limit parameter.
    $Paginate = $true
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
        If ($Paginate -and $PSCmdlet.ParameterSetName -in ('List')) {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            If ([System.String]::IsNullOrEmpty($PSBoundParameters.Limit)) {
                $PSBoundParameters.Add('Limit', 100)
            }
            If ([System.String]::IsNullOrEmpty($PSBoundParameters.Skip)) {
                $PSBoundParameters.Add('Skip', 0)
            }
            Do {
                Write-Debug ("Limit: $($PSBoundParameters.Limit); ");
                Write-Debug ("Skip: $($PSBoundParameters.Skip); ");
                $maxRetries = 4
                $resultCounter = 0
                :retryLoop do {
                    $resultCounter++
                    $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalBulkUserState @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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
                Write-Debug ('HttpRequest: ' + $JCHttpRequest);
                Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
                Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
                # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
                $Result = If ('Results' -in $Result.PSObject.Properties.Name) {
                    $Result.results
                } Else {
                    $Result
                }
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result | Measure-Object).Count;
                    $Results += $Result;
                    $PSBoundParameters.Skip += $ResultCount
                }
        }
            While ($ResultCount -eq $PSBoundParameters.Limit -and -not [System.String]::IsNullOrEmpty($Result))
        } Else {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $maxRetries = 4
            $resultCounter = 0
            :retryLoop do {
                $resultCounter++
                $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalBulkUserState @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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
            Write-Debug ('HttpRequest: ' + $JCHttpRequest);
            Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
            Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
            # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
            $Result = If ('Results' -in $Result.PSObject.Properties.Name) {
                $Result.results
            } Else {
                $Result
            }
            If (-not [System.String]::IsNullOrEmpty($Result)) {
                $Results += $Result;
            }
        }
    }
    End
    {
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse','JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}


