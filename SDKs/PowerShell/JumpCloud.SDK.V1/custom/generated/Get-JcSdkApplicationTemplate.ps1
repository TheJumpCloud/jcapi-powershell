<#
.Synopsis
The endpoint returns a specific SSO / SAML Application Template.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/application-templates/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```
.Description
The endpoint returns a specific SSO / SAML Application Template.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/application-templates/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```
.Example
PS C:\> Get-JcSdkApplicationTemplate



----                        ----------
Active                      Boolean
Beta                        Boolean
Color                       String
Config                      JumpCloud.SDK.V1.Models.ApplicationtemplateConfig
DisplayLabel                String
DisplayName                 String
Id                          String
IsConfigured                Boolean
JitAttributes               JumpCloud.SDK.V1.Models.ApplicationtemplateJitAttributes
JitCreateOnly               Boolean
Keywords                    String
LearnMore                   String
LogoUrl                     String
Name                        String
OidcGrantTypes              String
OidcRedirectUris            String
OidcSsoUrl                  String
OidcTokenEndpointAuthMethod String
ProvisionBeta               Boolean
ProvisionGroupsSupported    Boolean
ProvisionType               String
SsoBeta                     Boolean
SsoHidden                   Boolean
SsoIdpCertExpirationAt      Datetime
SsoIdpCertificateUpdatedAt  Datetime
SsoIdpPrivateKeyUpdatedAt   Datetime
SsoJit                      Boolean
SsoSpCertificateUpdatedAt   Datetime
SsoType                     String
SsoUrl                      String
Status                      String
Test                        String


.Example
PS C:\> Get-JcSdkApplicationTemplate -Id:(<string>)



----                        ----------
Active                      Boolean
Beta                        Boolean
Color                       String
Config                      JumpCloud.SDK.V1.Models.ApplicationtemplateConfig
DisplayLabel                String
DisplayName                 String
Id                          String
IsConfigured                Boolean
JitAttributes               JumpCloud.SDK.V1.Models.ApplicationtemplateJitAttributes
JitCreateOnly               Boolean
Keywords                    String
LearnMore                   String
LogoUrl                     String
Name                        String
OidcGrantTypes              String
OidcRedirectUris            String
OidcSsoUrl                  String
OidcTokenEndpointAuthMethod String
ProvisionBeta               Boolean
ProvisionGroupsSupported    Boolean
ProvisionType               String
SsoBeta                     Boolean
SsoHidden                   Boolean
SsoIdpCertExpirationAt      Datetime
SsoIdpCertificateUpdatedAt  Datetime
SsoIdpPrivateKeyUpdatedAt   Datetime
SsoJit                      Boolean
SsoSpCertificateUpdatedAt   Datetime
SsoType                     String
SsoUrl                      String
Status                      String
Test                        String



.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
.Outputs
JumpCloud.SDK.V1.Models.IApplicationtemplate
.Outputs
JumpCloud.SDK.V1.Models.IApplicationtemplateslist
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IJumpCloudApiIdentity>:
  [Id <String>]:
  [SystemId <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkApplicationTemplate.md
#>
 Function Get-JcSdkApplicationTemplate
{
    [OutputType([JumpCloud.SDK.V1.Models.IApplicationtemplate], [JumpCloud.SDK.V1.Models.IApplicationtemplateslist])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id}, 

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject}, 

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # The space separated fields included in the returned records.
    # If omitted the default list of fields will be returned.
    ${Fields}, 

    [Parameter()]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String[]]
    # A filter to apply to the query.
    # Populate with a valid field from an endpoint response.
    ${Filter}, 

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # The space separated fields used to sort the collection.
    # Default sort is ascending, prefix with - to sort descending.
    ${Sort}, 

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
                    $Result = JumpCloud.SDK.V1.internal\Get-JcSdkInternalApplicationTemplate @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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
                $Result = JumpCloud.SDK.V1.internal\Get-JcSdkInternalApplicationTemplate @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


