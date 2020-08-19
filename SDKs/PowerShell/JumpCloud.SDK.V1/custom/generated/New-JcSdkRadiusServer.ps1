<#
.Synopsis
This endpoint allows you to create RADIUS servers in your organization.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/radiusservers/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{test_radius}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"sharedSecret\":\"{secretpassword}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```
.Description
This endpoint allows you to create RADIUS servers in your organization.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/radiusservers/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{test_radius}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"sharedSecret\":\"{secretpassword}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IRadiusserverpost
.Outputs
JumpCloud.SDK.V1.Models.IRadiusserver
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IRadiusserverpost>:
  Name <String>:
  NetworkSourceIP <String>:
  SharedSecret <String>: RADIUS shared secret between the server and client.
  [Mfa <String>]:
  [TagNames <String[]>]:
  [UserLockoutAction <String>]:
  [UserPasswordExpirationAction <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkRadiusServer.md
#>
 Function New-JcSdkRadiusServer
{
    [OutputType([JumpCloud.SDK.V1.Models.IRadiusserver])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IRadiusserverpost]
    # RadiusServerPost
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${NetworkSourceIP},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # RADIUS shared secret between the server and client.
    ${SharedSecret},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Mfa},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String[]]
    # .
    ${TagNames},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${UserLockoutAction},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${UserPasswordExpirationAction}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                $global:JCHttpRequestContent = $req.Content.ReadAsStringAsync()
                $global:JCHttpResponse = $ResponseTask
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $Results = JumpCloud.SDK.V1.internal\New-JcSdkInternalRadiusServer @PSBoundParameters
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}

