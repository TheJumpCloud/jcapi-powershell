
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
The endpoint adds a new SSO / SAML Applications.
.Description
The endpoint adds a new SSO / SAML Applications.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IApplication
.Outputs
JumpCloud.SDK.V1.Models.IApplication
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IApplication>: Application
  [Beta <Boolean?>]: 
  [Color <String>]: 
  [Config <IApplicationConfig>]: 
    [AcUrlLabel <String>]: 
    [AcUrlOptions <String>]: 
    [AcUrlPosition <Int32?>]: 
    [AcUrlReadOnly <Boolean?>]: 
    [AcUrlRequired <Boolean?>]: 
    [AcUrlToggle <String>]: 
    [AcUrlType <String>]: 
    [AcUrlValue <String>]: 
    [AcUrlVisible <Boolean?>]: 
    [AcsUrlTooltipTemplate <String>]: 
    [AcsUrlTooltipVariablesIcon <String>]: 
    [AcsUrlTooltipVariablesMessage <String>]: 
    [ConstantAttributeLabel <String>]: 
    [ConstantAttributeMutable <Boolean?>]: 
    [ConstantAttributeOptions <String>]: 
    [ConstantAttributePosition <Int32?>]: 
    [ConstantAttributeReadOnly <Boolean?>]: 
    [ConstantAttributeRequired <Boolean?>]: 
    [ConstantAttributeToggle <String>]: 
    [ConstantAttributeType <String>]: 
    [ConstantAttributeValue <IApplicationConfigConstantAttributesValueItem[]>]: 
      [Name <String>]: 
      [ReadOnly <Boolean?>]: 
      [Required <Boolean?>]: 
      [Value <String>]: 
      [Visible <Boolean?>]: 
    [ConstantAttributeVisible <Boolean?>]: 
    [ConstantAttributesTooltipTemplate <String>]: 
    [ConstantAttributesTooltipVariablesIcon <String>]: 
    [ConstantAttributesTooltipVariablesMessage <String>]: 
    [DatabaseAttributePosition <Int32?>]: 
    [IdpCertificateLabel <String>]: 
    [IdpCertificateOptions <String>]: 
    [IdpCertificatePosition <Int32?>]: 
    [IdpCertificateReadOnly <Boolean?>]: 
    [IdpCertificateRequired <Boolean?>]: 
    [IdpCertificateToggle <String>]: 
    [IdpCertificateTooltipTemplate <String>]: 
    [IdpCertificateTooltipVariablesIcon <String>]: 
    [IdpCertificateTooltipVariablesMessage <String>]: 
    [IdpCertificateType <String>]: 
    [IdpCertificateValue <String>]: 
    [IdpCertificateVisible <Boolean?>]: 
    [IdpEntityIdLabel <String>]: 
    [IdpEntityIdOptions <String>]: 
    [IdpEntityIdPosition <Int32?>]: 
    [IdpEntityIdReadOnly <Boolean?>]: 
    [IdpEntityIdRequired <Boolean?>]: 
    [IdpEntityIdToggle <String>]: 
    [IdpEntityIdTooltipTemplate <String>]: 
    [IdpEntityIdTooltipVariablesIcon <String>]: 
    [IdpEntityIdTooltipVariablesMessage <String>]: 
    [IdpEntityIdType <String>]: 
    [IdpEntityIdValue <String>]: 
    [IdpEntityIdVisible <Boolean?>]: 
    [IdpPrivateKeyLabel <String>]: 
    [IdpPrivateKeyOptions <String>]: 
    [IdpPrivateKeyPosition <Int32?>]: 
    [IdpPrivateKeyReadOnly <Boolean?>]: 
    [IdpPrivateKeyRequired <Boolean?>]: 
    [IdpPrivateKeyToggle <String>]: 
    [IdpPrivateKeyTooltipTemplate <String>]: 
    [IdpPrivateKeyTooltipVariablesIcon <String>]: 
    [IdpPrivateKeyTooltipVariablesMessage <String>]: 
    [IdpPrivateKeyType <String>]: 
    [IdpPrivateKeyValue <String>]: 
    [IdpPrivateKeyVisible <Boolean?>]: 
    [SpEntityIdLabel <String>]: 
    [SpEntityIdOptions <String>]: 
    [SpEntityIdPosition <Int32?>]: 
    [SpEntityIdReadOnly <Boolean?>]: 
    [SpEntityIdRequired <Boolean?>]: 
    [SpEntityIdToggle <String>]: 
    [SpEntityIdTooltipTemplate <String>]: 
    [SpEntityIdTooltipVariablesIcon <String>]: 
    [SpEntityIdTooltipVariablesMessage <String>]: 
    [SpEntityIdType <String>]: 
    [SpEntityIdValue <String>]: 
    [SpEntityIdVisible <Boolean?>]: 
  [Created <String>]: 
  [DatabaseAttributes <IApplicationDatabaseAttributesItem[]>]: 
  [Description <String>]: 
  [DisplayLabel <String>]: 
  [DisplayName <String>]: 
  [Id <String>]: 
  [LearnMore <String>]: 
  [LogoColor <String>]: 
  [LogoUrl <String>]: 
  [Name <String>]: 
  [Organization <String>]: 
  [SsoUrl <String>]: 

CONFIG <IApplicationConfig>: .
  [AcUrlLabel <String>]: 
  [AcUrlOptions <String>]: 
  [AcUrlPosition <Int32?>]: 
  [AcUrlReadOnly <Boolean?>]: 
  [AcUrlRequired <Boolean?>]: 
  [AcUrlToggle <String>]: 
  [AcUrlType <String>]: 
  [AcUrlValue <String>]: 
  [AcUrlVisible <Boolean?>]: 
  [AcsUrlTooltipTemplate <String>]: 
  [AcsUrlTooltipVariablesIcon <String>]: 
  [AcsUrlTooltipVariablesMessage <String>]: 
  [ConstantAttributeLabel <String>]: 
  [ConstantAttributeMutable <Boolean?>]: 
  [ConstantAttributeOptions <String>]: 
  [ConstantAttributePosition <Int32?>]: 
  [ConstantAttributeReadOnly <Boolean?>]: 
  [ConstantAttributeRequired <Boolean?>]: 
  [ConstantAttributeToggle <String>]: 
  [ConstantAttributeType <String>]: 
  [ConstantAttributeValue <IApplicationConfigConstantAttributesValueItem[]>]: 
    [Name <String>]: 
    [ReadOnly <Boolean?>]: 
    [Required <Boolean?>]: 
    [Value <String>]: 
    [Visible <Boolean?>]: 
  [ConstantAttributeVisible <Boolean?>]: 
  [ConstantAttributesTooltipTemplate <String>]: 
  [ConstantAttributesTooltipVariablesIcon <String>]: 
  [ConstantAttributesTooltipVariablesMessage <String>]: 
  [DatabaseAttributePosition <Int32?>]: 
  [IdpCertificateLabel <String>]: 
  [IdpCertificateOptions <String>]: 
  [IdpCertificatePosition <Int32?>]: 
  [IdpCertificateReadOnly <Boolean?>]: 
  [IdpCertificateRequired <Boolean?>]: 
  [IdpCertificateToggle <String>]: 
  [IdpCertificateTooltipTemplate <String>]: 
  [IdpCertificateTooltipVariablesIcon <String>]: 
  [IdpCertificateTooltipVariablesMessage <String>]: 
  [IdpCertificateType <String>]: 
  [IdpCertificateValue <String>]: 
  [IdpCertificateVisible <Boolean?>]: 
  [IdpEntityIdLabel <String>]: 
  [IdpEntityIdOptions <String>]: 
  [IdpEntityIdPosition <Int32?>]: 
  [IdpEntityIdReadOnly <Boolean?>]: 
  [IdpEntityIdRequired <Boolean?>]: 
  [IdpEntityIdToggle <String>]: 
  [IdpEntityIdTooltipTemplate <String>]: 
  [IdpEntityIdTooltipVariablesIcon <String>]: 
  [IdpEntityIdTooltipVariablesMessage <String>]: 
  [IdpEntityIdType <String>]: 
  [IdpEntityIdValue <String>]: 
  [IdpEntityIdVisible <Boolean?>]: 
  [IdpPrivateKeyLabel <String>]: 
  [IdpPrivateKeyOptions <String>]: 
  [IdpPrivateKeyPosition <Int32?>]: 
  [IdpPrivateKeyReadOnly <Boolean?>]: 
  [IdpPrivateKeyRequired <Boolean?>]: 
  [IdpPrivateKeyToggle <String>]: 
  [IdpPrivateKeyTooltipTemplate <String>]: 
  [IdpPrivateKeyTooltipVariablesIcon <String>]: 
  [IdpPrivateKeyTooltipVariablesMessage <String>]: 
  [IdpPrivateKeyType <String>]: 
  [IdpPrivateKeyValue <String>]: 
  [IdpPrivateKeyVisible <Boolean?>]: 
  [SpEntityIdLabel <String>]: 
  [SpEntityIdOptions <String>]: 
  [SpEntityIdPosition <Int32?>]: 
  [SpEntityIdReadOnly <Boolean?>]: 
  [SpEntityIdRequired <Boolean?>]: 
  [SpEntityIdToggle <String>]: 
  [SpEntityIdTooltipTemplate <String>]: 
  [SpEntityIdTooltipVariablesIcon <String>]: 
  [SpEntityIdTooltipVariablesMessage <String>]: 
  [SpEntityIdType <String>]: 
  [SpEntityIdValue <String>]: 
  [SpEntityIdVisible <Boolean?>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v1/new-jcsdkinternalapplication
#>
function New-JcSdkInternalApplication {
[OutputType([JumpCloud.SDK.V1.Models.IApplication])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplication]
    # Application
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Beta},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Color},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplicationConfig]
    # .
    # To construct, see NOTES section for CONFIG properties and create a hash table.
    ${Config},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Created},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplicationDatabaseAttributesItem[]]
    # .
    ${DatabaseAttributes},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Description},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayLabel},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LearnMore},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoColor},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoUrl},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Organization},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${SsoUrl},

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
            Create = 'JumpCloud.SDK.V1.private\New-JcSdkInternalApplication_Create';
            CreateExpanded = 'JumpCloud.SDK.V1.private\New-JcSdkInternalApplication_CreateExpanded';
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
