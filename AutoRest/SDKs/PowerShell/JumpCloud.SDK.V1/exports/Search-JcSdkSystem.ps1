
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
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.
\n\nThis allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the`searchTerm` the record will be returned.\n\n\n#### Sample Request\n\nExact search for a list of hostnames\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"filter\": {\n    \"or\": [\n      {\"hostname\" : \"my-hostname\"},\n      {\"hostname\" : \"other-hostname\"}\n    ]\n  },\n  \"fields\" : \"os hostname displayName\"\n}'\n```\n\nText search for a hostname or display name\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```\n\nCombining `filter` and `searchFilter` to search for names that match a given OS\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"filter\": {\n    \"or\": [\n      {\"os\" : \"Ubuntu\"},\n      {\"os\" : \"Mac OS X\"}\n    ]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```
.Description
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.
\n\nThis allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the`searchTerm` the record will be returned.\n\n\n#### Sample Request\n\nExact search for a list of hostnames\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"filter\": {\n    \"or\": [\n      {\"hostname\" : \"my-hostname\"},\n      {\"hostname\" : \"other-hostname\"}\n    ]\n  },\n  \"fields\" : \"os hostname displayName\"\n}'\n```\n\nText search for a hostname or display name\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```\n\nCombining `filter` and `searchFilter` to search for names that match a given OS\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"filter\": {\n    \"or\": [\n      {\"os\" : \"Ubuntu\"},\n      {\"os\" : \"Mac OS X\"}\n    ]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.ISearch
.Outputs
JumpCloud.SDK.V1.Models.ISystemslist
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISearch>: Search
  [Fields <String>]: 
  [Filter <ISearchFilter>]: 
  [SearchFilter <ISearchFilter1>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v1/search-jcsdksystem
#>
function Search-JcSdkSystem {
[OutputType([JumpCloud.SDK.V1.Models.ISystemslist])]
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
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Boolean]
    # Set to $true to return all results.
    # This will overwrite any skip and limit parameter.
    ${Paginate},

    [Parameter(ParameterSetName='Search', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISearch]
    # Search
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            SearchExpanded = 'JumpCloud.SDK.V1.custom\Search-JcSdkSystem';
            Search = 'JumpCloud.SDK.V1.custom\Search-JcSdkSystem';
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
