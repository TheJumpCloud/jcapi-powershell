
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
This endpoint allows you to do a full update of the User Group.\n\n#### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/usergroups/{Group_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY' \\\n  -d '{\n \"name\": \"group_update\"\n}'\n\n```
.Description
This endpoint allows you to do a full update of the User Group.\n\n#### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/usergroups/{Group_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY' \\\n  -d '{\n \"name\": \"group_update\"\n}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V2.Models.IUserGroupPut
.Outputs
JumpCloud.SDK.V2.Models.IUserGroup
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ATTRIBUTEPOSIXGROUPS <IUserGroupAttributesPosixGroupsItem[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 

BODY <IUserGroupPut>: UserGroupPut
  Name <String>: Display name of a User Group.
  [AttributePosixGroups <IUserGroupAttributesPosixGroupsItem[]>]: 
    [Id <Int32?>]: 
    [Name <String>]: 
  [AttributeSambaEnabled <Boolean?>]: 

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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/set-jcsdkinternalusergroup
#>
function Set-JcSdkInternalUserGroup {
[OutputType([JumpCloud.SDK.V2.Models.IUserGroup])]
[CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the User Group.
    ${Id},

    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IUserGroupPut]
    # UserGroupPut
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Display name of a User Group.
    ${Name},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[]]
    # .
    # To construct, see NOTES section for ATTRIBUTEPOSIXGROUPS properties and create a hash table.
    ${AttributePosixGroups},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AttributeSambaEnabled},

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
            Put = 'JumpCloud.SDK.V2.private\Set-JcSdkInternalUserGroup_Put';
            PutExpanded = 'JumpCloud.SDK.V2.private\Set-JcSdkInternalUserGroup_PutExpanded';
            PutViaIdentity = 'JumpCloud.SDK.V2.private\Set-JcSdkInternalUserGroup_PutViaIdentity';
            PutViaIdentityExpanded = 'JumpCloud.SDK.V2.private\Set-JcSdkInternalUserGroup_PutViaIdentityExpanded';
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