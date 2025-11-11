<#
.Synopsis
Request a JumpCloud report to be generated asynchronously
.Description
Request a JumpCloud report to be generated asynchronously
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
JumpCloud.SDK.DirectoryInsights.Models.IDirectoryInsightsApiIdentity
.Outputs
JumpCloud.SDK.DirectoryInsights.Models.IPathsE6Q3GdReportsReportTypePostResponses202ContentApplicationJsonSchema
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDirectoryInsightsApiIdentity>:
  [ArtifactId <String>]: Artifact ID
  [ReportId <String>]: Report ID
  [ReportType <String>]: Report Type
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/New-JcSdkReport.md
#>
 Function New-JcSdkReport
{
    [OutputType([JumpCloud.SDK.DirectoryInsights.Models.IPathsE6Q3GdReportsReportTypePostResponses202ContentApplicationJsonSchema])]
    [CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.DirectoryInsights.Category('Uri')]
    [System.String]
    # Region for JumpCloud API host.
    # Use 'api' for US or 'api.eu' for EU.
    ${HostEnv}, 

    [Parameter(ParameterSetName='Create', Mandatory)]
    [JumpCloud.SDK.DirectoryInsights.PSArgumentCompleterAttribute("browser-patch-policy", "os-patch-policy", "os-version", "software-inventory", "user-account-health", "users-to-devices", "users-to-directories", "users-to-ldap-servers", "users-to-radius-servers", "users-to-sso-applications", "users-to-user-groups")]
    [JumpCloud.SDK.DirectoryInsights.Category('Path')]
    [System.String]
    # Report Type
    ${ReportType}, 

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.DirectoryInsights.Category('Path')]
    [JumpCloud.SDK.DirectoryInsights.Models.IDirectoryInsightsApiIdentity]
    # Identity Parameter
    ${InputObject}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
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
            $Results = (JumpCloud.SDK.DirectoryInsights.internal\New-JcSdkInternalReport -ErrorAction SilentlyContinue -errorVariable sdkError @PSBoundParameters); if (-not [System.String]::IsNullOrEmpty($Result)) { $Result = $Result.ToJsonString() | ConvertFrom-Json };
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


