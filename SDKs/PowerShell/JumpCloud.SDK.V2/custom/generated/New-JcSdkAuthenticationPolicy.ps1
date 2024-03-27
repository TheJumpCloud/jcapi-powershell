<#
.Synopsis
Create an authentication policy.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/authn/policies \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Sample Policy\",
    \"disabled\": false,
    \"effect\": {
      \"action\": \"allow\"
    },
    \"targets\": {
      \"users\": {
        \"inclusions\": [\"ALL\"]
      },
      \"userGroups\": {
        \"exclusions\": [{USER_GROUP_ID}]
      },
      \"resources\": [ {\"type\": \"user_portal\" } ]
    },
    \"conditions\":{
      \"ipAddressIn\": [{IP_LIST_ID}]
    }
  }'
```
.Description
Create an authentication policy.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/authn/policies \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Sample Policy\",
    \"disabled\": false,
    \"effect\": {
      \"action\": \"allow\"
    },
    \"targets\": {
      \"users\": {
        \"inclusions\": [\"ALL\"]
      },
      \"userGroups\": {
        \"exclusions\": [{USER_GROUP_ID}]
      },
      \"resources\": [ {\"type\": \"user_portal\" } ]
    },
    \"conditions\":{
      \"ipAddressIn\": [{IP_LIST_ID}]
    }
  }'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IAuthnPolicy
.Outputs
JumpCloud.SDK.V2.Models.IAuthnPolicy
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IAuthnPolicy>:
  [Conditions <IAuthnPolicyConditions>]: Dictionary of <any>
    [(Any) <Object>]: This indicates any property can be added to this object.
  [Description <String>]:
  [Disabled <Boolean?>]:
  [EffectAction <String>]:
  [MfaRequired <Boolean?>]:
  [Name <String>]:
  [TargetResources <IAuthnPolicyResourceTarget[]>]:
    Type <String>:
    [Id <String>]: Object ID of the resource target. If undefined, then all resources of the given type are targeted.
  [Type <String>]: AuthnPolicyType
  [UserAttributeExclusions <IAuthnPolicyUserAttributeFilter[]>]:
    [Field <String>]: The only field that is currently supported is ldap_binding_user
    [Operator <String>]:
    [Value <IAny>]: Any object
  [UserAttributeInclusions <IAuthnPolicyUserAttributeFilter[]>]:
  [UserGroupExclusions <String[]>]:
  [UserGroupInclusions <String[]>]:
  [UserInclusions <String[]>]:
  [UserVerificationRequirement <String>]:

TARGETRESOURCES <IAuthnPolicyResourceTarget[]>:
  Type <String>:
  [Id <String>]: Object ID of the resource target. If undefined, then all resources of the given type are targeted.

USERATTRIBUTEEXCLUSIONS <IAuthnPolicyUserAttributeFilter[]>:
  [Field <String>]: The only field that is currently supported is ldap_binding_user
  [Operator <String>]:
  [Value <IAny>]: Any object

USERATTRIBUTEINCLUSIONS <IAuthnPolicyUserAttributeFilter[]>:
  [Field <String>]: The only field that is currently supported is ldap_binding_user
  [Operator <String>]:
  [Value <IAny>]: Any object
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkAuthenticationPolicy.md
#>
 Function New-JcSdkAuthenticationPolicy
{
    [OutputType([JumpCloud.SDK.V2.Models.IAuthnPolicy])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthnPolicy]
    # This represents an authentication policy.
    # See the details of each field for valid values and restrictions.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Runtime.Info(PossibleTypes=([JumpCloud.SDK.V2.Models.IAuthnPolicyConditions]))]
    [System.Collections.Hashtable]
    # Dictionary of <any>
    ${Conditions}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Description}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Disabled}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${EffectAction}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${MfaRequired}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Name}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthnPolicyResourceTarget[]]
    # .
    # To construct, see NOTES section for TARGETRESOURCES properties and create a hash table.
    ${TargetResources}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # AuthnPolicyType
    ${Type}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthnPolicyUserAttributeFilter[]]
    # .
    # To construct, see NOTES section for USERATTRIBUTEEXCLUSIONS properties and create a hash table.
    ${UserAttributeExclusions}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthnPolicyUserAttributeFilter[]]
    # .
    # To construct, see NOTES section for USERATTRIBUTEINCLUSIONS properties and create a hash table.
    ${UserAttributeInclusions}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # .
    ${UserGroupExclusions}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # .
    ${UserGroupInclusions}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # .
    ${UserInclusions}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${UserVerificationRequirement}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.PSCredential]
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
        $maxRetries = 4
        $resultCounter = 0
        :retryLoop do {
            $resultCounter++
            $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalAuthenticationPolicy @PSBoundParameters -ErrorVariable StopVar
            If ($stopVar){
                If ($JCHttpResponse.Result.StatusCode -eq 503) {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    break retryLoop
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


