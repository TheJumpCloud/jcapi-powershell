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
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

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
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
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
        If ($Paginate -and $PSCmdlet.ParameterSetName -in ('List'))
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            If ([System.String]::IsNullOrEmpty($PSBoundParameters.Limit))
            {
                $PSBoundParameters.Add('Limit', 100)
            }
            If ([System.String]::IsNullOrEmpty($PSBoundParameters.Skip))
            {
                $PSBoundParameters.Add('Skip', 0)
            }
            Do
            {
                Write-Debug ("Limit: $($PSBoundParameters.Limit); ");
                Write-Debug ("Skip: $($PSBoundParameters.Skip); ");
                $Result = JumpCloud.SDK.V1.internal\Get-JcSdkInternalApplicationTemplate @PSBoundParameters
                Write-Debug ('HttpRequest: ' + $JCHttpRequest);
                Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
                Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
                # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
                $Result = If ('Results' -in $Result.PSObject.Properties.Name)
                {
                    $Result.results
                }
                Else
                {
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
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = JumpCloud.SDK.V1.internal\Get-JcSdkInternalApplicationTemplate @PSBoundParameters
            Write-Debug ('HttpRequest: ' + $JCHttpRequest);
            Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
            Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
            # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
            $Result = If ('Results' -in $Result.PSObject.Properties.Name)
            {
                $Result.results
            }
            Else
            {
                $Result
            }
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
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


