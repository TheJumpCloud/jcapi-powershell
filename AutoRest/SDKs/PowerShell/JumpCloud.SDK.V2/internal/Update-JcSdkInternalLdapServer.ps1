
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
This endpoint allows updating some attributes of an LDAP server.\n\nSample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"remove\",\n    \"userPasswordExpirationAction\": \"disable\"\n  }'\n```
.Description
This endpoint allows updating some attributes of an LDAP server.\n\nSample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"remove\",\n    \"userPasswordExpirationAction\": \"disable\"\n  }'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V2.Models.IPaths1Ka5IlhLdapserversIdPatchRequestbodyContentApplicationJsonSchema
.Outputs
JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPaths1Ka5IlhLdapserversIdPatchRequestbodyContentApplicationJsonSchema>: .
  [Id <String>]: 
  [UserLockoutAction <String>]: LDAP Server Action
  [UserPasswordExpirationAction <String>]: LDAP Server Action

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [AccountId <String>]: 
  [ActivedirectoryId <String>]: 
  [AppleMdmId <String>]: 
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [DeviceId <String>]: 
  [GroupId <String>]: ObjectID of the System Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of the System Group.
  [JobId <String>]: 
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: ObjectID of the Policy.
  [ProviderId <String>]: 
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/update-jcsdkinternalldapserver
#>
function Update-JcSdkInternalLdapServer {
[OutputType([JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema], [System.String])]
[CmdletBinding(DefaultParameterSetName='PatchExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Patch', Mandatory)]
    [Parameter(ParameterSetName='PatchExpanded', Mandatory)]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # Unique identifier of the LDAP server.
    ${Id},

    [Parameter(ParameterSetName='PatchViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Patch', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PatchViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IPaths1Ka5IlhLdapserversIdPatchRequestbodyContentApplicationJsonSchema]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PatchExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Id1},

    [Parameter(ParameterSetName='PatchExpanded')]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # LDAP Server Action
    ${UserLockoutAction},

    [Parameter(ParameterSetName='PatchExpanded')]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # LDAP Server Action
    ${UserPasswordExpirationAction},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
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
            Patch = 'JumpCloud.SDK.V2.private\Update-JcSdkInternalLdapServer_Patch';
            PatchExpanded = 'JumpCloud.SDK.V2.private\Update-JcSdkInternalLdapServer_PatchExpanded';
            PatchViaIdentity = 'JumpCloud.SDK.V2.private\Update-JcSdkInternalLdapServer_PatchViaIdentity';
            PatchViaIdentityExpanded = 'JumpCloud.SDK.V2.private\Update-JcSdkInternalLdapServer_PatchViaIdentityExpanded';
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
