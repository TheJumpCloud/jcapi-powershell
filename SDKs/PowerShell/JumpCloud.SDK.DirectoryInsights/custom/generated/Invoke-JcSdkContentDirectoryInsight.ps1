<#
.Synopsis
Download a report by report ID and artifact ID
.Description
Download a report by report ID and artifact ID
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.DirectoryInsights.Models.IDirectoryInsightsApiIdentity
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDirectoryInsightsApiIdentity>:
  [ArtifactId <String>]: Artifact ID
  [ReportId <String>]: Report ID
  [ReportType <ReportType1?>]: Report Type
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Invoke-JcSdkContentDirectoryInsight.md
#>
 Function Invoke-JcSdkContentDirectoryInsight
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Content', PositionalBinding=$false)]
    Param(
    [Parameter(ParameterSetName='Content', Mandatory)]
    [JumpCloud.SDK.DirectoryInsights.Category('Path')]
    [System.String]
    # Artifact ID
    ${ArtifactId}, 

    [Parameter(ParameterSetName='Content', Mandatory)]
    [JumpCloud.SDK.DirectoryInsights.Category('Path')]
    [System.String]
    # Report ID
    ${ReportId}, 

    [Parameter(ParameterSetName='ContentViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.DirectoryInsights.Category('Path')]
    [JumpCloud.SDK.DirectoryInsights.Models.IDirectoryInsightsApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
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
        $Results = JumpCloud.SDK.DirectoryInsights.internal\Invoke-JcSdkInternalContentDirectoryInsight @PSBoundParameters
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

