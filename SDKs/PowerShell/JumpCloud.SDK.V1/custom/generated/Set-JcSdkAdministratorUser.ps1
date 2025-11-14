<#
.Synopsis
This endpoint allows you to set a user.
.Description
This endpoint allows you to set a user.
.Example
PS C:\> Set-JcSdkAdministratorUser -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Userput>)



----                       ----------
ApiKeyAllowed              Boolean
ApiKeySet                  Boolean
ApiKeyUpdatedAt            Datetime
Created                    Datetime
DisableIntroduction        Boolean
Email                      String
EnableMultiFactor          Boolean
Firstname                  String
GrowthDataExperimentStates JumpCloud.SDK.V1.Models.UserreturnGrowthDataExperimentStates
GrowthDataOnboardingState  JumpCloud.SDK.V1.Models.UserreturnGrowthDataOnboardingState
Id                         String
Lastname                   String
LastWhatsNewChecked        Datetime
Organization               String
PasswordUpdatedAt          Datetime
Provider                   String
Role                       String
RoleName                   String
SessionCount               Int
Suspended                  Boolean
TotpEnrolled               Boolean
TotpUpdatedAt              Datetime
UsersTimeZone              String


.Example
PS C:\> Set-JcSdkAdministratorUser -Id:(<string>) -ApiKeyAllowed:(<switch>) -Email:(<string>) -EnableMultiFactor:(<switch>) -Firstname:(<string>) -GrowthData:(<hashtable>) -LastWhatsNewChecked:(<datetime>) -Lastname:(<string>) -RoleName:(<string>)



----                       ----------
ApiKeyAllowed              Boolean
ApiKeySet                  Boolean
ApiKeyUpdatedAt            Datetime
Created                    Datetime
DisableIntroduction        Boolean
Email                      String
EnableMultiFactor          Boolean
Firstname                  String
GrowthDataExperimentStates JumpCloud.SDK.V1.Models.UserreturnGrowthDataExperimentStates
GrowthDataOnboardingState  JumpCloud.SDK.V1.Models.UserreturnGrowthDataOnboardingState
Id                         String
Lastname                   String
LastWhatsNewChecked        Datetime
Organization               String
PasswordUpdatedAt          Datetime
Provider                   String
Role                       String
RoleName                   String
SessionCount               Int
Suspended                  Boolean
TotpEnrolled               Boolean
TotpUpdatedAt              Datetime
UsersTimeZone              String



.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
.Inputs
JumpCloud.SDK.V1.Models.IUserput
.Outputs
JumpCloud.SDK.V1.Models.IUserreturn
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IUserput>:
  [ApiKeyAllowed <Boolean?>]:
  [Email <String>]:
  [EnableMultiFactor <Boolean?>]:
  [Firstname <String>]:
  [GrowthData <IUserputGrowthData>]: Dictionary of <any>
    [(Any) <Object>]: This indicates any property can be added to this object.
  [LastWhatsNewChecked <DateTime?>]:
  [Lastname <String>]:
  [RoleName <String>]:

INPUTOBJECT <IJumpCloudApiIdentity>:
  [Id <String>]:
  [SystemId <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkAdministratorUser.md
#>
 Function Set-JcSdkAdministratorUser
{
    [OutputType([JumpCloud.SDK.V1.Models.IUserreturn])]
    [CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V1.Category('Uri')]
    [System.String]
    # Region for JumpCloud API host.
    # Use 'console' for US or 'console.eu' for EU.
    ${ConsoleHost}, 

    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id}, 

    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    ${InputObject}, 

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IUserput]
    # UserPut
    ${Body}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${ApiKeyAllowed}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Email}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${EnableMultiFactor}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Firstname}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Runtime.Info(PossibleTypes=([JumpCloud.SDK.V1.Models.IUserputGrowthData]))]
    [System.Collections.Hashtable]
    # Dictionary of <any>
    ${GrowthData}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.DateTime]
    # .
    ${LastWhatsNewChecked}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Lastname}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${RoleName}, 

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
        :retryLoop do {
            $resultCounter++
            $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalAdministratorUser @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
            If ($sdkError){
                If ($resultCounter -eq $maxRetries){
                    throw $sdkError
                }
                If ($JCHttpResponse.Result.StatusCode -eq "503") {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    throw $sdkError
                }
            } else {
                break retryLoop
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


