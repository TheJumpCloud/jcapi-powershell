<#
.Synopsis
The endpoint deletes an SSO / SAML Application.
.Description
The endpoint deletes an SSO / SAML Application.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

#>
Function Remove-JCApplication
{
    #Requires -Modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.IApplication])]
    [CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Header')]
    [System.String]
    # .
    ${Accept},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Header')]
    [System.String]
    # .
    ${ContentType},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Header')]
    [System.String]
    # .
    ${XOrgId}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Remove-JcSdkApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
