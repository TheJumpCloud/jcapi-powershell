
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
This endpoint returns _direct_ associations of an Office 365 instance.\n\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/office365s/{O365_ID}/associations?targets=user_group' \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```
.Description
This endpoint returns _direct_ associations of an Office 365 instance.\n\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/office365s/{O365_ID}/associations?targets=user_group' \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IGraphConnection
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/get-jcsdkgraphoffice365association
#>
function Get-JcSdkGraphOffice365Association {
[OutputType([JumpCloud.SDK.V2.Models.IGraphConnection])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the Office 365 instance.
    ${Office365Id},

    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # .
    ${Targets},

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
            List = 'JumpCloud.SDK.V2.custom\Get-JcSdkGraphOffice365Association';
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
