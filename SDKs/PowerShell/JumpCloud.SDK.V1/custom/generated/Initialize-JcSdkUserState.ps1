<#
.Synopsis
This endpoint changes the state of a STAGED user to ACTIVATED.
#### Email Flag
Use the \"email\" flag to determine whether or not to send a Welcome or
Activation email to the newly activated user.
Sending an empty body
without the `email` flag, will send an email with default behavior
(see the \"Behavior\" section below)
```
{}
```
Sending `email=true` flag will send an email with default behavior (see `Behavior` below)
```
{ \"email\": true }
```
Populated email will override the default behavior and send to the specified email value
```
{ \"email\": \"example@example.com\" }
```
Sending `email=false` will suppress sending the email
```
{ \"email\": false }
```
#### Behavior
Users with a password will be sent a Welcome email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's primary email address (default behavior)
Users without a password will be sent an Activation email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's alternate email address (default behavior)
  - If no alternate email address, the user's primary email address (default behavior)

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/systemusers/{id}/state/activate \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: <api-key>' \\
  -d '{ \"email\": \"alternate-activation-email@email.com\" }'

```
.Description
This endpoint changes the state of a STAGED user to ACTIVATED.
#### Email Flag
Use the \"email\" flag to determine whether or not to send a Welcome or
Activation email to the newly activated user.
Sending an empty body
without the `email` flag, will send an email with default behavior
(see the \"Behavior\" section below)
```
{}
```
Sending `email=true` flag will send an email with default behavior (see `Behavior` below)
```
{ \"email\": true }
```
Populated email will override the default behavior and send to the specified email value
```
{ \"email\": \"example@example.com\" }
```
Sending `email=false` will suppress sending the email
```
{ \"email\": false }
```
#### Behavior
Users with a password will be sent a Welcome email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's primary email address (default behavior)
Users without a password will be sent an Activation email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's alternate email address (default behavior)
  - If no alternate email address, the user's primary email address (default behavior)

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/systemusers/{id}/state/activate \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: <api-key>' \\
  -d '{ \"email\": \"alternate-activation-email@email.com\" }'

```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
.Inputs
JumpCloud.SDK.V1.Models.IPathsDi9CukSystemusersIdStateActivatePostRequestbodyContentApplicationJsonSchema
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPathsDi9CukSystemusersIdStateActivatePostRequestbodyContentApplicationJsonSchema>:
  [Email <String>]:

INPUTOBJECT <IJumpCloudApiIdentity>:
  [Id <String>]:
  [SystemId <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Initialize-JcSdkUserState.md
#>
 Function Initialize-JcSdkUserState
{
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='ActivateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Activate', Mandatory)]
    [Parameter(ParameterSetName='ActivateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id}, 

    [Parameter(ParameterSetName='ActivateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ActivateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject}, 

    [Parameter(ParameterSetName='Activate', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ActivateViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IPathsDi9CukSystemusersIdStateActivatePostRequestbodyContentApplicationJsonSchema]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='ActivateExpanded')]
    [Parameter(ParameterSetName='ActivateViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Email}, 

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

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru}, 

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
        :retryLoop do {
            $resultCounter++
            try {
                $Results = JumpCloud.SDK.V1.internal\Initialize-JcSdkInternalUserState @PSBoundParameters -errorAction SilentlyContinue
                break retryLoop
            } catch {
                If ($JCHttpResponse.Result.StatusCode -eq 503) {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    Write-Warning ("An error occurred: $_.")
                }
            }
            Start-Sleep -Seconds ($resultCounter * 5)
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


