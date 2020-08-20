<#
.Synopsis
This endpoint will return a specific System User's public SSH key.
.Description
This endpoint will return a specific System User's public SSH key.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V1.Models.IPathsCh5U08SystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema
.Outputs
JumpCloud.SDK.V1.Models.ISshkeylist
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkSystemUserSshKey.md
#>
 Function Get-JcSdkSystemUserSshKey
{
    [OutputType([JumpCloud.SDK.V1.Models.ISshkeylist], [JumpCloud.SDK.V1.Models.IPathsCh5U08SystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $Result = JumpCloud.SDK.V1.internal\Get-JcSdkInternalSystemUserSshKey @PSBoundParameters
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        $Result = If ('Results' -in $Result.PSObject.Properties.Name)
        {
            $Result.results
        }
        Else
        {
            $Result
        }
        If (-not [System.String]::IsNullOrEmpty($Result))
        {
            $Results += $Result;
        }
    }
    End
    {
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}

