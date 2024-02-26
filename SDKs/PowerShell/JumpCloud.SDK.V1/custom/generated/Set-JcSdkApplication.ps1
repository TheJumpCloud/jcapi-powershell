<#
.Synopsis
The endpoint updates a SSO / SAML Application.
Any fields not provided will be reset or created with default values.
.Description
The endpoint updates a SSO / SAML Application.
Any fields not provided will be reset or created with default values.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IApplication
.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
.Outputs
JumpCloud.SDK.V1.Models.IApplication
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IApplication>:
  Config <IApplicationConfig>:
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
    [SignAssertionLabel <String>]:
    [SignAssertionPosition <Int32?>]:
    [SignAssertionReadOnly <Boolean?>]:
    [SignAssertionRequired <Boolean?>]:
    [SignAssertionTooltipTemplate <String>]:
    [SignAssertionTooltipVariablesIcon <String>]:
    [SignAssertionTooltipVariablesMessage <String>]:
    [SignAssertionType <String>]:
    [SignAssertionValue <Boolean?>]:
    [SignAssertionVisible <Boolean?>]:
    [SignResponseLabel <String>]:
    [SignResponsePosition <Int32?>]:
    [SignResponseReadOnly <Boolean?>]:
    [SignResponseRequired <Boolean?>]:
    [SignResponseTooltipTemplate <String>]:
    [SignResponseTooltipVariablesIcon <String>]:
    [SignResponseTooltipVariablesMessage <String>]:
    [SignResponseType <String>]:
    [SignResponseValue <Boolean?>]:
    [SignResponseVisible <Boolean?>]:
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
    [SpErrorFlowLabel <String>]:
    [SpErrorFlowPosition <Int32?>]:
    [SpErrorFlowReadOnly <Boolean?>]:
    [SpErrorFlowRequired <Boolean?>]:
    [SpErrorFlowTooltipTemplate <String>]:
    [SpErrorFlowTooltipVariablesIcon <String>]:
    [SpErrorFlowTooltipVariablesMessage <String>]:
    [SpErrorFlowType <String>]:
    [SpErrorFlowValue <Boolean?>]:
    [SpErrorFlowVisible <Boolean?>]:
  Name <String>:
  SsoUrl <String>:
  [Active <Boolean?>]:
  [Beta <Boolean?>]:
  [Color <String>]:
  [Created <String>]:
  [DatabaseAttributes <IApplicationDatabaseAttributesItem[]>]:
  [Description <String>]:
  [DisplayLabel <String>]:
  [DisplayName <String>]:
  [Id <String>]:
  [LearnMore <String>]:
  [LogoColor <String>]:
  [LogoUrl <String>]:
  [Organization <String>]:
  [SsoBeta <Boolean?>]:
  [SsoHidden <Boolean?>]:
  [SsoIdpCertExpirationAt <DateTime?>]:
  [SsoJit <Boolean?>]:
  [SsoType <String>]:

CONFIG <IApplicationConfig>:
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
  [SignAssertionLabel <String>]:
  [SignAssertionPosition <Int32?>]:
  [SignAssertionReadOnly <Boolean?>]:
  [SignAssertionRequired <Boolean?>]:
  [SignAssertionTooltipTemplate <String>]:
  [SignAssertionTooltipVariablesIcon <String>]:
  [SignAssertionTooltipVariablesMessage <String>]:
  [SignAssertionType <String>]:
  [SignAssertionValue <Boolean?>]:
  [SignAssertionVisible <Boolean?>]:
  [SignResponseLabel <String>]:
  [SignResponsePosition <Int32?>]:
  [SignResponseReadOnly <Boolean?>]:
  [SignResponseRequired <Boolean?>]:
  [SignResponseTooltipTemplate <String>]:
  [SignResponseTooltipVariablesIcon <String>]:
  [SignResponseTooltipVariablesMessage <String>]:
  [SignResponseType <String>]:
  [SignResponseValue <Boolean?>]:
  [SignResponseVisible <Boolean?>]:
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
  [SpErrorFlowLabel <String>]:
  [SpErrorFlowPosition <Int32?>]:
  [SpErrorFlowReadOnly <Boolean?>]:
  [SpErrorFlowRequired <Boolean?>]:
  [SpErrorFlowTooltipTemplate <String>]:
  [SpErrorFlowTooltipVariablesIcon <String>]:
  [SpErrorFlowTooltipVariablesMessage <String>]:
  [SpErrorFlowType <String>]:
  [SpErrorFlowValue <Boolean?>]:
  [SpErrorFlowVisible <Boolean?>]:

INPUTOBJECT <IJumpCloudApiIdentity>:
  [Id <String>]:
  [SystemId <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkApplication.md
#>
 Function Set-JcSdkApplication
{
    [OutputType([JumpCloud.SDK.V1.Models.IApplication])]
    [CmdletBinding(DefaultParameterSetName='Set', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id}, 

    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject}, 

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplication]
    # Application
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplicationConfig]
    # .
    # To construct, see NOTES section for CONFIG properties and create a hash table.
    ${Config}, 

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Name}, 

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${SsoUrl}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Active}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Beta}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Color}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Created}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplicationDatabaseAttributesItem[]]
    # .
    ${DatabaseAttributes}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Description}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayLabel}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayName}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Id1}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LearnMore}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoColor}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoUrl}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Organization}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SsoBeta}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SsoHidden}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.DateTime]
    # .
    ${SsoIdpCertExpirationAt}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SsoJit}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${SsoType}, 

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
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                # $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                # $global:JCHttpResponseContent = If (-not [System.String]::IsNullOrEmpty($ResponseTask.Result.Content)) { $ResponseTask.Result.Content.ReadAsStringAsync() }
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $maxRetries = 4
        $resultCounter = 0
        do {
            $resultCounter++
            $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalApplication @PSBoundParameters
            If ($JCHttpResponse.Result.StatusCode -eq 503) {
                Write-Debug ("StatusCode: " + "$($JCHttpResponse.Result.StatusCode)")
            } else {
                break
            }
            if ($resultCounter -eq $maxRetries) {
                break
            } else {
                Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds")
                Start-Sleep -Seconds ($resultCounter * 5)
            }
        } while ($resultCounter -lt $maxRetries)
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        # Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse', 'JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) {
                Remove-Variable -Name:($_) -Scope:('Global')
            }
        }
        Return $Results
    }
}


