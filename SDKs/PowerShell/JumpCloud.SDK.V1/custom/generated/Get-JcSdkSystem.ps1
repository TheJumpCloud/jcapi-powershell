<#
.Synopsis
This endpoint returns an individual system.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```
.Description
This endpoint returns an individual system.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```
.Example
PS C:\> Get-JcSdkSystem -Search:(<string>) -Sort:(<string>)



----                                 ----------
Active                               Boolean
AgentVersion                         String
AllowMultiFactorAuthentication       Boolean
AllowPublicKeyAuthentication         Boolean
AllowSshPasswordAuthentication       Boolean
AllowSshRootLogin                    Boolean
AmazonInstanceId                     String
Arch                                 String
ArchFamily                           String
AzureAdJoined                        Boolean
BuiltInCommands                      JumpCloud.SDK.V1.Models.JcSystemBuiltInCommandsItem[]
ConnectionHistory                    JumpCloud.SDK.V1.Models.JcSystemConnectionHistoryItem[]
Created                              Datetime
Description                          String
DesktopCapable                       Boolean
DisplayManager                       String
DisplayName                          String
DomainInfoDomainName                 String
DomainInfoPartOfDomain               Boolean
FdeActive                            Boolean
FdeKeyPresent                        Boolean
FileSystem                           String
HasServiceAccount                    Boolean
Hostname                             String
HwVendor                             String
Id                                   String
IsPolicyBound                        Boolean
LastContact                          Datetime
MdmDep                               Boolean
MdmProfileIdentifier                 String
MdmProviderId                        String
MdmUserApproved                      Boolean
MdmVendor                            String
ModifySshdConfig                     Boolean
NetworkInterfaces                    JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItem[]
Organization                         String
OS                                   String
OSFamily                             String
OSVersionDetailDistributionName      String
OSVersionDetailMajor                 String
OSVersionDetailMajorNumber           Int
OSVersionDetailMinor                 String
OSVersionDetailMinorNumber           Int
OSVersionDetailOsname                String
OSVersionDetailPatch                 String
OSVersionDetailPatchNumber           Int
OSVersionDetailReleaseName           String
OSVersionDetailRevision              String
OSVersionDetailVersion               String
PolicyStatDuplicate                  Int
PolicyStatFailed                     Int
PolicyStatPending                    Int
PolicyStatSuccess                    Int
PolicyStatTotal                      Int
PolicyStatUnsupportedOS              Int
ProvisionerId                        String
ProvisionerType                      String
RemoteIP                             String
SecureLoginEnabled                   Boolean
SecureLoginSupported                 Boolean
SerialNumber                         String
ServiceAccountStateHasSecureToken    Boolean
ServiceAccountStatePasswordApfsValid Boolean
ServiceAccountStatePasswordOdValid   Boolean
SshdParams                           JumpCloud.SDK.V1.Models.JcSystemSshdParamsItem[]
SshRootEnabled                       Boolean
SystemInsightState                   String
SystemTimezone                       Int
TemplateName                         String
UserMetrics                          JumpCloud.SDK.V1.Models.JcSystemUserMetricsItem[]
Version                              String
WindowUpn                            String


.Example
PS C:\> Get-JcSdkSystem -Id:(<string>)



----                                 ----------
Active                               Boolean
AgentVersion                         String
AllowMultiFactorAuthentication       Boolean
AllowPublicKeyAuthentication         Boolean
AllowSshPasswordAuthentication       Boolean
AllowSshRootLogin                    Boolean
AmazonInstanceId                     String
Arch                                 String
ArchFamily                           String
AzureAdJoined                        Boolean
BuiltInCommands                      JumpCloud.SDK.V1.Models.JcSystemBuiltInCommandsItem[]
ConnectionHistory                    JumpCloud.SDK.V1.Models.JcSystemConnectionHistoryItem[]
Created                              Datetime
Description                          String
DesktopCapable                       Boolean
DisplayManager                       String
DisplayName                          String
DomainInfoDomainName                 String
DomainInfoPartOfDomain               Boolean
FdeActive                            Boolean
FdeKeyPresent                        Boolean
FileSystem                           String
HasServiceAccount                    Boolean
Hostname                             String
HwVendor                             String
Id                                   String
IsPolicyBound                        Boolean
LastContact                          Datetime
MdmDep                               Boolean
MdmProfileIdentifier                 String
MdmProviderId                        String
MdmUserApproved                      Boolean
MdmVendor                            String
ModifySshdConfig                     Boolean
NetworkInterfaces                    JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItem[]
Organization                         String
OS                                   String
OSFamily                             String
OSVersionDetailDistributionName      String
OSVersionDetailMajor                 String
OSVersionDetailMajorNumber           Int
OSVersionDetailMinor                 String
OSVersionDetailMinorNumber           Int
OSVersionDetailOsname                String
OSVersionDetailPatch                 String
OSVersionDetailPatchNumber           Int
OSVersionDetailReleaseName           String
OSVersionDetailRevision              String
OSVersionDetailVersion               String
PolicyStatDuplicate                  Int
PolicyStatFailed                     Int
PolicyStatPending                    Int
PolicyStatSuccess                    Int
PolicyStatTotal                      Int
PolicyStatUnsupportedOS              Int
ProvisionerId                        String
ProvisionerType                      String
RemoteIP                             String
SecureLoginEnabled                   Boolean
SecureLoginSupported                 Boolean
SerialNumber                         String
ServiceAccountStateHasSecureToken    Boolean
ServiceAccountStatePasswordApfsValid Boolean
ServiceAccountStatePasswordOdValid   Boolean
SshdParams                           JumpCloud.SDK.V1.Models.JcSystemSshdParamsItem[]
SshRootEnabled                       Boolean
SystemInsightState                   String
SystemTimezone                       Int
TemplateName                         String
UserMetrics                          JumpCloud.SDK.V1.Models.JcSystemUserMetricsItem[]
Version                              String
WindowUpn                            String



.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
.Outputs
JumpCloud.SDK.V1.Models.IJcSystem
.Outputs
JumpCloud.SDK.V1.Models.ISystemslist
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IJumpCloudApiIdentity>:
  [Id <String>]:
  [SystemId <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkSystem.md
#>
 Function Get-JcSdkSystem
{
    [OutputType([JumpCloud.SDK.V1.Models.IJcSystem], [JumpCloud.SDK.V1.Models.ISystemslist])]
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
    # Use a space seperated string of field parameters to include the data in the response.
    # If omitted, the default list of fields will be returned.
    ${Fields}, 

    [Parameter()]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String[]]
    # A filter to apply to the query.
    # See the supported operators below.
    # For more complex searches,
    # see the related `/search/<domain>` endpoints,
    # e.g.
    # `/search/systems`.
    # 
    # **Filter structure**: `<field>:<operator>:<value>`.
    # 
    # **field** = Populate with a valid field from an endpoint response.
    # 
    # **operator** = Supported operators are:
    # - `$eq` (equals)
    # - `$ne` (does not equal)
    # - `$gt` (is greater than)
    # - `$gte` (is greater than or equal to)
    # - `$lt` (is less than)
    # - `$lte` (is less than or equal to)
    # 
    # _Note: v1 operators differ from v2 operators._
    # 
    # _Note: For v1 operators, excluding the `$` will result in undefined behavior._
    # 
    # **value** = Populate with the value you want to search for.
    # Is case sensitive.
    # 
    # **Examples**
    # - `GET /users?filter=username:$eq:testuser`
    # - `GET /systemusers?filter=password_expiration_date:$lte:2021-10-24`
    # - `GET /systemusers?filter=department:$ne:Accounting`
    # - `GET /systems?filter[0]=firstname:$eq:foo&filter[1]=lastname:$eq:bar` - this will
    #  AND the filters together.
    # - `GET /systems?filter[or][0]=lastname:$eq:foo&filter[or][1]=lastname:$eq:bar` - this will
    #  OR the filters together.
    ${Filter}, 

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # A nested object containing a `searchTerm` string or array of strings and a list of `fields` to search on.
    ${Search}, 

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # Use space separated sort parameters to sort the collection.
    # Default sort is ascending.
    # Prefix with `-` to sort descending.
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
                    $Result = JumpCloud.SDK.V1.internal\Get-JcSdkInternalSystem @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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
                $Result = JumpCloud.SDK.V1.internal\Get-JcSdkInternalSystem @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


