
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
This endpoint allows you to get a RADIUS server in your organization.\n\n#### \n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n```
.Description
This endpoint allows you to get a RADIUS server in your organization.\n\n#### \n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/get-jcsdkradiusserver
.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloud.SDK.V1.Models.IRadiusserver
.Outputs
JumpCloud.SDK.V1.Models.IRadiusserverslist
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/get-jcsdkradiusserver
#>
function Get-JcSdkRadiusServer {
[OutputType([JumpCloud.SDK.V1.Models.IRadiusserver], [JumpCloud.SDK.V1.Models.IRadiusserverslist])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # Use a space seperated string of field parameters to include the data in the response.
    # If omitted, the default list of fields will be returned.
    ${Fields},

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # A filter to apply to the query.
    ${Filter},

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.Int32]
    # The number of records to return at once.
    # Limited to 100.
    ${Limit},

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.Int32]
    # The offset into the records to return.
    ${Skip},

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
            Get = 'JumpCloud.SDK.V1.private\Get-JcSdkRadiusServer_Get';
            GetViaIdentity = 'JumpCloud.SDK.V1.private\Get-JcSdkRadiusServer_GetViaIdentity';
            List = 'JumpCloud.SDK.V1.private\Get-JcSdkRadiusServer_List';
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
