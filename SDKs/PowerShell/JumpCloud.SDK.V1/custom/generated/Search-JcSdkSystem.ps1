<#
.Synopsis
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.

To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.

The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.

This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.

The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the `searchTerm` the record will be returned.


#### Sample Request

Exact search for a list of hostnames
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\": {
    \"or\": [
      {\"hostname\" : \"my-hostname\"},
      {\"hostname\" : \"other-hostname\"}
    ]
  },
  \"fields\" : \"os hostname displayName\"
}'
```

Text search for a hostname or display name
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Text search for a multiple hostnames.
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": [\"my-host\", \"my-other-host\"],
    \"fields\": [\"hostname\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Combining `filter` and `searchFilter` to search for names that match a given OS
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"filter\": {
    \"or\": [
      {\"os\" : \"Ubuntu\"},
      {\"os\" : \"Mac OS X\"}
    ]
  },
  \"fields\": \"os hostname displayName\"
}'
```
.Description
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.

To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.

The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.

This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.

The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the `searchTerm` the record will be returned.


#### Sample Request

Exact search for a list of hostnames
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\": {
    \"or\": [
      {\"hostname\" : \"my-hostname\"},
      {\"hostname\" : \"other-hostname\"}
    ]
  },
  \"fields\" : \"os hostname displayName\"
}'
```

Text search for a hostname or display name
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Text search for a multiple hostnames.
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": [\"my-host\", \"my-other-host\"],
    \"fields\": [\"hostname\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Combining `filter` and `searchFilter` to search for names that match a given OS
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"filter\": {
    \"or\": [
      {\"os\" : \"Ubuntu\"},
      {\"os\" : \"Mac OS X\"}
    ]
  },
  \"fields\": \"os hostname displayName\"
}'
```
.Example
PS C:\> Search-JcSdkSystem -Body:(<JumpCloud.SDK.V1.Models.Search>)



----       ----------
Results    JumpCloud.SDK.V1.Models.JcSystem[]
TotalCount Int


.Example
PS C:\> Search-JcSdkSystem -Fields:(<string>) -Filter:(<hashtable>) -SearchFilter:(<hashtable>)



----       ----------
Results    JumpCloud.SDK.V1.Models.JcSystem[]
TotalCount Int



.Inputs
JumpCloud.SDK.V1.Models.ISearch
.Outputs
JumpCloud.SDK.V1.Models.ISystemslist
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISearch>:
  [Fields <String>]:
  [Filter <ISearchFilter>]: Dictionary of <any>
    [(Any) <Object>]: This indicates any property can be added to this object.
  [SearchFilter <ISearchFilter1>]: Dictionary of <any>
    [(Any) <Object>]: This indicates any property can be added to this object.
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Search-JcSdkSystem.md
#>
 Function Search-JcSdkSystem
{
    [OutputType([JumpCloud.SDK.V1.Models.ISystemslist])]
    [CmdletBinding(DefaultParameterSetName='SearchExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Search', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISearch]
    # Search
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='SearchExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Fields}, 

    [Parameter(ParameterSetName='SearchExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Runtime.Info(PossibleTypes=([JumpCloud.SDK.V1.Models.ISearchFilter]))]
    [System.Collections.Hashtable]
    # Dictionary of <any>
    ${Filter}, 

    [Parameter(ParameterSetName='SearchExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Runtime.Info(PossibleTypes=([JumpCloud.SDK.V1.Models.ISearchFilter1]))]
    [System.Collections.Hashtable]
    # Dictionary of <any>
    ${SearchFilter}, 

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
        If ($Paginate -and $PSCmdlet.ParameterSetName -in ('SearchExpanded')) {
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
                    $Result = JumpCloud.SDK.V1.internal\Search-JcSdkInternalSystem @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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
                $Result = JumpCloud.SDK.V1.internal\Search-JcSdkInternalSystem @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


