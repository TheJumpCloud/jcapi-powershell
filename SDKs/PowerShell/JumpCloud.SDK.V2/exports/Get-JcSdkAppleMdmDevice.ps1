
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
Lists all Apple MDM devices.\n\nThe filter and sort queries will allow the following fields:\n`createdAt`\n`depRegistered`\n`enrolled`\n`id`\n`osVersion`\n`serialNumber`\n`udid`\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices \\\n  -H 'accept: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```
.Description
Lists all Apple MDM devices.\n\nThe filter and sort queries will allow the following fields:\n`createdAt`\n`depRegistered`\n`enrolled`\n`id`\n`osVersion`\n`serialNumber`\n`udid`\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices \\\n  -H 'accept: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IAppleMdmDevice
.Outputs
System.String
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/get-jcsdkapplemdmdevice
#>
function Get-JcSdkAppleMdmDevice {
[OutputType([JumpCloud.SDK.V2.Models.IAppleMdmDevice], [System.String])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${AppleMdmId},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # Supported operators are: eq, ne, gt, ge, lt, le, between, search, in
    ${Filter},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Int32]
    # The number of records to return at once.
    # Limited to 100.
    ${Limit},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Int32]
    # The offset into the records to return.
    ${Skip},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # The comma separated fields used to sort the collection.
    # Default sort is ascending, prefix with `-` to sort descending.
    ${Sort},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Header')]
    [System.Int32]
    # .
    ${XTotalCount},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Boolean]
    # Set to $true to return all results.
    # This will overwrite any skip and limit parameter.
    ${Paginate}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'JumpCloud.SDK.V2.custom\Get-JcSdkAppleMdmDevice';
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
