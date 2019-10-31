<#
.Synopsis
This endpoint allows you to update RADIUS servers in your organization.\n\n#### \n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{name_update}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```
.Description
This endpoint allows you to update RADIUS servers in your organization.\n\n#### \n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{name_update}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdkradiusserver
.Inputs
JumpCloudApiSdkV1.Models.IBodyParameterRadiusServerPutRequestBody
.Inputs
JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloudApiSdkV1.Models.IRadiusserverput
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IBodyParameterRadiusServerPutRequestBody>: HELP MESSAGE MISSING
  Name <String>: 
  NetworkSourceIP <String>: 
  [Mfa <String>]: 
  [Tags <String[]>]: 
  [UserLockoutAction <String>]: 
  [UserPasswordExpirationAction <String>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdkradiusserver
#>
function Set-JcSdkRadiusServer {
[OutputType([JumpCloudApiSdkV1.Models.IRadiusserverput])]
[CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Path')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Id},

    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Path')]
    [JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.IBodyParameterRadiusServerPutRequestBody]
    # HELP MESSAGE MISSING
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Name},

    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${NetworkSourceIP},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Mfa},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String[]]
    # HELP MESSAGE MISSING
    ${Tags},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${UserLockoutAction},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${UserPasswordExpirationAction},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [JumpCloudApiSdkV1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [JumpCloudApiSdkV1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
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
            Put = 'JumpCloudApiSdkV1.private\Set-JcSdkRadiusServer_Put';
            PutExpanded = 'JumpCloudApiSdkV1.private\Set-JcSdkRadiusServer_PutExpanded';
            PutViaIdentity = 'JumpCloudApiSdkV1.private\Set-JcSdkRadiusServer_PutViaIdentity';
            PutViaIdentityExpanded = 'JumpCloudApiSdkV1.private\Set-JcSdkRadiusServer_PutViaIdentityExpanded';
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
