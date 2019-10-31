<#
.Synopsis
This endpoint returns the _direct_ associations of this LDAP Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.\n\n#### Sample Request\n\n```\n curl -X GET 'https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Description
This endpoint returns the _direct_ associations of this LDAP Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.\n\n#### Sample Request\n\n```\n curl -X GET 'https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/get-jcsdkgraphldapservergraphldapserverassociation
.Outputs
JumpCloudApiSdkV2.Models.IGraphConnection
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/get-jcsdkgraphldapservergraphldapserverassociation
#>
function Get-JcSdkGraphLdapServerGraphLdapServerAssociation {
[OutputType([JumpCloudApiSdkV2.Models.IGraphConnection])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [JumpCloudApiSdkV2.Category('Path')]
    [System.String]
    # ObjectID of the LDAP Server.
    ${LdapserverId},

    [Parameter(Mandatory)]
    [JumpCloudApiSdkV2.Category('Query')]
    [System.String[]]
    # HELP MESSAGE MISSING
    ${Targets},

    [Parameter()]
    [JumpCloudApiSdkV2.Category('Query')]
    [System.Int32]
    # The number of records to return at once.
    # Limited to 100.
    ${Limit},

    [Parameter()]
    [JumpCloudApiSdkV2.Category('Query')]
    [System.Int32]
    # The offset into the records to return.
    ${Skip},

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
            List = 'JumpCloudApiSdkV2.private\Get-JcSdkGraphLdapServerGraphLdapServerAssociation_List';
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
