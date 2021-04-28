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

BODY <IApplication>:
  [Beta <Boolean?>]:
  [Color <String>]:
  [Config <IApplicationConfig>]:
    [AcsUrl <IApplicationConfigAcsUrl>]:
      [Label <String>]:
      [Options <String>]:
      [Position <Int32?>]:
      [ReadOnly <Boolean?>]:
      [Required <Boolean?>]:
      [Toggle <String>]:
      [Tooltip <IApplicationConfigAcsUrlTooltip>]:
        [Template <String>]:
        [Variables <IApplicationConfigAcsUrlTooltipVariables>]:
          [Icon <String>]:
          [Message <String>]:
      [Type <String>]:
      [Value <String>]:
      [Visible <Boolean?>]:
    [ConstantAttributes <IApplicationConfigConstantAttributes>]:
      [Label <String>]:
      [Mutable <Boolean?>]:
      [Options <String>]:
      [Position <Int32?>]:
      [ReadOnly <Boolean?>]:
      [Required <Boolean?>]:
      [Toggle <String>]:
      [Tooltip <IApplicationConfigConstantAttributesTooltip>]:
        [Template <String>]:
        [Variables <IApplicationConfigConstantAttributesTooltipVariables>]:
          [Icon <String>]:
          [Message <String>]:
      [Type <String>]:
      [Value <IApplicationConfigConstantAttributesValueItem[]>]:
        [Name <String>]:
        [ReadOnly <Boolean?>]:
        [Required <Boolean?>]:
        [Value <String>]:
        [Visible <Boolean?>]:
      [Visible <Boolean?>]:
    [DatabaseAttributes <IApplicationConfigDatabaseAttributes>]:
      [Position <Int32?>]:
    [IdpCertificate <IApplicationConfigIdpCertificate>]:
      [Label <String>]:
      [Options <String>]:
      [Position <Int32?>]:
      [ReadOnly <Boolean?>]:
      [Required <Boolean?>]:
      [Toggle <String>]:
      [Tooltip <IApplicationConfigIdpCertificateTooltip>]:
        [Template <String>]:
        [Variables <IApplicationConfigIdpCertificateTooltipVariables>]:
          [Icon <String>]:
          [Message <String>]:
      [Type <String>]:
      [Value <String>]:
      [Visible <Boolean?>]:
    [IdpEntityId <IApplicationConfigIdpEntityId>]:
      [Label <String>]:
      [Options <String>]:
      [Position <Int32?>]:
      [ReadOnly <Boolean?>]:
      [Required <Boolean?>]:
      [Toggle <String>]:
      [Tooltip <IApplicationConfigIdpEntityIdTooltip>]:
        [Template <String>]:
        [Variables <IApplicationConfigIdpEntityIdTooltipVariables>]:
          [Icon <String>]:
          [Message <String>]:
      [Type <String>]:
      [Value <String>]:
      [Visible <Boolean?>]:
    [IdpPrivateKey <IApplicationConfigIdpPrivateKey>]:
      [Label <String>]:
      [Options <String>]:
      [Position <Int32?>]:
      [ReadOnly <Boolean?>]:
      [Required <Boolean?>]:
      [Toggle <String>]:
      [Tooltip <IApplicationConfigIdpPrivateKeyTooltip>]:
        [Template <String>]:
        [Variables <IApplicationConfigIdpPrivateKeyTooltipVariables>]:
          [Icon <String>]:
          [Message <String>]:
      [Type <String>]:
      [Value <String>]:
      [Visible <Boolean?>]:
    [SpEntityId <IApplicationConfigSpEntityId>]:
      [Label <String>]:
      [Options <String>]:
      [Position <Int32?>]:
      [ReadOnly <Boolean?>]:
      [Required <Boolean?>]:
      [Toggle <String>]:
      [Tooltip <IApplicationConfigSpEntityIdTooltip>]:
        [Template <String>]:
        [Variables <IApplicationConfigSpEntityIdTooltipVariables>]:
          [Icon <String>]:
          [Message <String>]:
      [Type <String>]:
      [Value <String>]:
      [Visible <Boolean?>]:
  [Created <String>]:
  [DatabaseAttributes <IApplicationDatabaseAttributesItem[]>]:
  [Description <String>]:
  [DisplayLabel <String>]:
  [DisplayName <String>]:
  [Id <String>]:
  [LearnMore <String>]:
  [Logo <IApplicationLogo>]:
    [Color <String>]:
    [Url <String>]:
  [Name <String>]:
  [Organization <String>]:
  [Sso <IApplicationSso>]:
    [Beta <Boolean?>]:
    [Jit <Boolean?>]:
    [Type <String>]:
  [SsoUrl <String>]:

CONFIG <IApplicationConfig>:
  [AcsUrl <IApplicationConfigAcsUrl>]:
    [Label <String>]:
    [Options <String>]:
    [Position <Int32?>]:
    [ReadOnly <Boolean?>]:
    [Required <Boolean?>]:
    [Toggle <String>]:
    [Tooltip <IApplicationConfigAcsUrlTooltip>]:
      [Template <String>]:
      [Variables <IApplicationConfigAcsUrlTooltipVariables>]:
        [Icon <String>]:
        [Message <String>]:
    [Type <String>]:
    [Value <String>]:
    [Visible <Boolean?>]:
  [ConstantAttributes <IApplicationConfigConstantAttributes>]:
    [Label <String>]:
    [Mutable <Boolean?>]:
    [Options <String>]:
    [Position <Int32?>]:
    [ReadOnly <Boolean?>]:
    [Required <Boolean?>]:
    [Toggle <String>]:
    [Tooltip <IApplicationConfigConstantAttributesTooltip>]:
      [Template <String>]:
      [Variables <IApplicationConfigConstantAttributesTooltipVariables>]:
        [Icon <String>]:
        [Message <String>]:
    [Type <String>]:
    [Value <IApplicationConfigConstantAttributesValueItem[]>]:
      [Name <String>]:
      [ReadOnly <Boolean?>]:
      [Required <Boolean?>]:
      [Value <String>]:
      [Visible <Boolean?>]:
    [Visible <Boolean?>]:
  [DatabaseAttributes <IApplicationConfigDatabaseAttributes>]:
    [Position <Int32?>]:
  [IdpCertificate <IApplicationConfigIdpCertificate>]:
    [Label <String>]:
    [Options <String>]:
    [Position <Int32?>]:
    [ReadOnly <Boolean?>]:
    [Required <Boolean?>]:
    [Toggle <String>]:
    [Tooltip <IApplicationConfigIdpCertificateTooltip>]:
      [Template <String>]:
      [Variables <IApplicationConfigIdpCertificateTooltipVariables>]:
        [Icon <String>]:
        [Message <String>]:
    [Type <String>]:
    [Value <String>]:
    [Visible <Boolean?>]:
  [IdpEntityId <IApplicationConfigIdpEntityId>]:
    [Label <String>]:
    [Options <String>]:
    [Position <Int32?>]:
    [ReadOnly <Boolean?>]:
    [Required <Boolean?>]:
    [Toggle <String>]:
    [Tooltip <IApplicationConfigIdpEntityIdTooltip>]:
      [Template <String>]:
      [Variables <IApplicationConfigIdpEntityIdTooltipVariables>]:
        [Icon <String>]:
        [Message <String>]:
    [Type <String>]:
    [Value <String>]:
    [Visible <Boolean?>]:
  [IdpPrivateKey <IApplicationConfigIdpPrivateKey>]:
    [Label <String>]:
    [Options <String>]:
    [Position <Int32?>]:
    [ReadOnly <Boolean?>]:
    [Required <Boolean?>]:
    [Toggle <String>]:
    [Tooltip <IApplicationConfigIdpPrivateKeyTooltip>]:
      [Template <String>]:
      [Variables <IApplicationConfigIdpPrivateKeyTooltipVariables>]:
        [Icon <String>]:
        [Message <String>]:
    [Type <String>]:
    [Value <String>]:
    [Visible <Boolean?>]:
  [SpEntityId <IApplicationConfigSpEntityId>]:
    [Label <String>]:
    [Options <String>]:
    [Position <Int32?>]:
    [ReadOnly <Boolean?>]:
    [Required <Boolean?>]:
    [Toggle <String>]:
    [Tooltip <IApplicationConfigSpEntityIdTooltip>]:
      [Template <String>]:
      [Variables <IApplicationConfigSpEntityIdTooltipVariables>]:
        [Icon <String>]:
        [Message <String>]:
    [Type <String>]:
    [Value <String>]:
    [Visible <Boolean?>]:

LOGO <IApplicationLogo>:
  [Color <String>]:
  [Url <String>]:

SSO <IApplicationSso>:
  [Beta <Boolean?>]:
  [Jit <Boolean?>]:
  [Type <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkApplication.md
#>
 Function New-JcSdkApplication
{
    [OutputType([JumpCloud.SDK.V1.Models.IApplication])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
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
    [JumpCloud.SDK.V1.Models.IApplicationLogo]
    # .
    # To construct, see NOTES section for LOGO properties and create a hash table.
    ${Logo},

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
    [JumpCloud.SDK.V1.Models.IApplicationSso]
    # .
    # To construct, see NOTES section for SSO properties and create a hash table.
    ${Sso},

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
        $Results = JumpCloud.SDK.V1.internal\New-JcSdkInternalApplication @PSBoundParameters
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
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}


