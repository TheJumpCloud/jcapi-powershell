
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Return System Users in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system user.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.
\n\nThis allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the`searchTerm` the record will be returned.\n\n\n#### Sample Request\n\nExact search for a list of system users in a department\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"filter\" : [{\"department\" : \"IT\"}],\n  \"fields\" : \"email username sudo\"\n}'\n```\n\nText search for system users with and email on a domain\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\" : {\n    \"searchTerm\": \"@jumpcloud.com\",\n    \"fields\": [\"email\"]\n  },\n  \"fields\" : \"email username sudo\"\n}'\n```\n\nCombining `filter` and `searchFilter` to text search for system users with and email on a domain who are in a list of departments\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"@jumpcloud.com\",\n    \"fields\": [\"email\"]\n  },\n  \"filter\": {\n    \"or\": [\n      {\"department\" : \"IT\"},\n      {\"department\" : \"Sales\"}\n    ]\n  },\n  \"fields\" : \"email username sudo\"\n}'\n```
.Description
Return System Users in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system user.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.
\n\nThis allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the`searchTerm` the record will be returned.\n\n\n#### Sample Request\n\nExact search for a list of system users in a department\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"filter\" : [{\"department\" : \"IT\"}],\n  \"fields\" : \"email username sudo\"\n}'\n```\n\nText search for system users with and email on a domain\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\" : {\n    \"searchTerm\": \"@jumpcloud.com\",\n    \"fields\": [\"email\"]\n  },\n  \"fields\" : \"email username sudo\"\n}'\n```\n\nCombining `filter` and `searchFilter` to text search for system users with and email on a domain who are in a list of departments\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"@jumpcloud.com\",\n    \"fields\": [\"email\"]\n  },\n  \"filter\": {\n    \"or\": [\n      {\"department\" : \"IT\"},\n      {\"department\" : \"Sales\"}\n    ]\n  },\n  \"fields\" : \"email username sudo\"\n}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.ISearch
.Outputs
JumpCloud.SDK.V1.Models.ISystemuserslist
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISearch>: Search
  [Fields <String>]: 
  [Filter <ISearchFilter>]: 
  [SearchFilter <ISearchFilter1>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v1/search-jcsdkinternalsystemuser
#>
function Search-JcSdkInternalSystemUser {
[OutputType([JumpCloud.SDK.V1.Models.ISystemuserslist])]
[CmdletBinding(DefaultParameterSetName='SearchExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # Use a space seperated string of field parameters to include the data in the response.
    # If omitted, the default list of fields will be returned.
    ${Fields},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # A filter to apply to the query.
    ${Filter},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.Int32]
    # The number of records to return at once.
    # Limited to 100.
    ${Limit},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.Int32]
    # The offset into the records to return.
    ${Skip},

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
    ${Fields1},

    [Parameter(ParameterSetName='SearchExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISearchFilter]
    # .
    ${Filter1},

    [Parameter(ParameterSetName='SearchExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISearchFilter1]
    # .
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

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Search = 'JumpCloud.SDK.V1.private\Search-JcSdkInternalSystemUser_Search';
            SearchExpanded = 'JumpCloud.SDK.V1.private\Search-JcSdkInternalSystemUser_SearchExpanded';
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}