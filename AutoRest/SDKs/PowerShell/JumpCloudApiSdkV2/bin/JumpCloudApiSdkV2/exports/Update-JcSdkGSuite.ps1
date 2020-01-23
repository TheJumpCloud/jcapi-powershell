<#
.Synopsis
This endpoint allows updating some attributes of a G Suite.\n\n##### Sample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"suspend\",\n    \"userPasswordExpirationAction\": \"maintain\"\n  }'\n```
.Description
This endpoint allows updating some attributes of a G Suite.\n\n##### Sample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"suspend\",\n    \"userPasswordExpirationAction\": \"maintain\"\n  }'\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/update-jcsdkgsuite
.Inputs
JumpCloudApiSdkV2.Models.IGsuitePatchInput
.Inputs
JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloudApiSdkV2.Models.IGsuiteOutput
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IGsuitePatchInput>: GSuite Patch Input
  [UserLockoutAction <String>]: 
  [UserPasswordExpirationAction <String>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [AccountId <String>]: 
  [ActivedirectoryId <String>]: ObjectID of the Active Directory instance.
  [ApplicationId <String>]: 
  [CommandId <String>]: ObjectID of the Command.
  [GroupId <String>]: ObjectID of the User Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of the User Group.
  [JobId <String>]: 
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: 
  [ProviderId <String>]: 
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/update-jcsdkgsuite
#>
function Update-JcSdkGSuite {
[OutputType([JumpCloudApiSdkV2.Models.IGsuiteOutput])]
[CmdletBinding(DefaultParameterSetName='PatchExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Patch', Mandatory)]
    [Parameter(ParameterSetName='PatchExpanded', Mandatory)]
    [JumpCloudApiSdkV2.Category('Path')]
    [System.String]
    # Unique identifier of the GSuite.
    ${Id},

    [Parameter(ParameterSetName='PatchViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Path')]
    [JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Patch', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PatchViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV2.Category('Body')]
    [JumpCloudApiSdkV2.Models.IGsuitePatchInput]
    # GSuite Patch Input
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PatchExpanded')]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${UserLockoutAction},

    [Parameter(ParameterSetName='PatchExpanded')]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded')]
    [JumpCloudApiSdkV2.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${UserPasswordExpirationAction},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [JumpCloudApiSdkV2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [JumpCloudApiSdkV2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV2.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV2.Category('Runtime')]
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
            Patch = 'JumpCloudApiSdkV2.private\Update-JcSdkGSuite_Patch';
            PatchExpanded = 'JumpCloudApiSdkV2.private\Update-JcSdkGSuite_PatchExpanded';
            PatchViaIdentity = 'JumpCloudApiSdkV2.private\Update-JcSdkGSuite_PatchViaIdentity';
            PatchViaIdentityExpanded = 'JumpCloudApiSdkV2.private\Update-JcSdkGSuite_PatchViaIdentityExpanded';
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
