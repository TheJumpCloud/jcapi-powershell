<#
.Synopsis
This endpoint returns the association links between an Administrator and Organizations.
.Description
This endpoint returns the association links between an Administrator and Organizations.
.Example
PS C:\> Get-JcSdkAdministratorOrganization



----          ----------
Administrator String
Organization  String


.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IAdministratorOrganizationLink
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkAdministratorOrganization.md
#>
 Function Get-JcSdkAdministratorOrganization
{
    [OutputType([JumpCloud.SDK.V2.Models.IAdministratorOrganizationLink])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${Id}, 

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
                    $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalAdministratorOrganization @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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
                $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalAdministratorOrganization @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


