<#
.Synopsis
This endpoint deletes an existing Office 365 instance.

#####

Sample Request
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
curl -X DELETE https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```
.Description
This endpoint deletes an existing Office 365 instance.

#####

Sample Request

.Inputs
curl -X DELETE https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [CustomEmailType <String>]:
  [DeviceId <String>]:
  [GroupId <String>]: ObjectID of the System Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of this Active Directory instance.
  [JobId <String>]:
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: ObjectID of the Policy.
  [ProviderId <String>]:
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SoftwareAppId <String>]: ObjectID of the Software App.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Remove-JcSdkOffice365.md
#>
Function Remove-JcSdkOffice365
{
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName = 'Delete', PositionalBinding = $false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
    Param(
        [Parameter(ParameterSetName = 'Delete', Mandatory)]
        [JumpCloud.SDK.V2.Category('Path')]
        [System.String]
        # ObjectID of the Office 365 instance.
        ${Office365Id},

        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory, ValueFromPipeline)]
        [JumpCloud.SDK.V2.Category('Path')]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
        # Identity Parameter
        # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
        ${InputObject},

        [Parameter(DontShow)]
        [JumpCloud.SDK.V2.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        https: / / github.com / TheJumpCloud / jcapi-powershell / tree / master / SDKs / PowerShell / JumpCloud.SDK.V2 / docs / exports / Remove-JcSdkOffice365.md
        #>
        Function Remove-JcSdkOffice365
        {
            [OutputType([System.Boolean])]
            [CmdletBinding(DefaultParameterSetName = 'Delete', PositionalBinding = $false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
            Param(
                [Parameter(ParameterSetName = 'Delete', Mandatory)]
                [System.Management.Automation.SwitchParameter]
                # Returns true when the command succeeds
                ${PassThru},

                [Parameter(DontShow)]
                [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory, ValueFromPipeline)]

                [Parameter(DontShow)]
                [JumpCloud.SDK.V2.Category('Runtime')]
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
            Get-Process
            {
                $Results = JumpCloud.SDK.V2.internal\Remove-JcSdkInternalOffice365 @PSBoundParameters
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


    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
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
        $Results = JumpCloud.SDK.V2.internal\Remove-JcSdkInternalOffice365 @PSBoundParameters
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
