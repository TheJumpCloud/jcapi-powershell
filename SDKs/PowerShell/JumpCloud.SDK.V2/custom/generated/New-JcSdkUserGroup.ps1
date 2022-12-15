<#
.Synopsis
This endpoint allows you to create a new User Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{Group_Name}\"
  }'
```
.Description
This endpoint allows you to create a new User Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{Group_Name}\"
  }'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IUserGroupPost
.Outputs
JumpCloud.SDK.V2.Models.IUserGroup
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IUserGroupPost>:
  Name <String>: Display name of a User Group.
  [Attributes <IGroupAttributesUserGroup>]: The graph attributes for a UserGroup.
    [(Any) <Object>]: This indicates any property can be added to this object.
    [SudoEnabled <Boolean?>]: Enables sudo
    [SudoWithoutPassword <Boolean?>]: Enable sudo without password (requires 'enabled' to be true)
    [LdapGroups <ILdapGroup[]>]:
      [Name <String>]:
    [PosixGroups <IGraphAttributePosixGroupsItem[]>]:
      Id <Int32>:
      Name <String>:
    [RadiusReply <IGraphAttributeRadiusReplyItem[]>]:
      Name <String>:
      Value <String>:
    [SambaEnabled <Boolean?>]:
  [Description <String>]: Description of a User Group
  [Email <String>]: Email address of a User Group
  [MemberQueryExemptions <IGraphObject[]>]: Array of GraphObjects exempted from the query
    Id <String>: The ObjectID of the graph object.
    Type <String>: The type of graph object.
    [Attributes <IGraphAttributes>]: The graph attributes.
      [(Any) <Object>]: This indicates any property can be added to this object.
  [MemberQueryFilters <IFilter[]>]:
    Field <String>: Name of field in filter target object.
    Operator <String>: Filter comparison operator.
    Value <String>: Filter comparison value.
  [MemberSuggestionsNotify <Boolean?>]: True if notification emails are to be sent for membership suggestions.
  [MembershipAutomated <Boolean?>]: True if membership of this group is automatically updated based on the Member Query and Member Query Exemptions, if configured

MEMBERQUERYEXEMPTIONS <IGraphObject[]>:
  Id <String>: The ObjectID of the graph object.
  Type <String>: The type of graph object.
  [Attributes <IGraphAttributes>]: The graph attributes.
    [(Any) <Object>]: This indicates any property can be added to this object.

MEMBERQUERYFILTERS <IFilter[]>:
  Field <String>: Name of field in filter target object.
  Operator <String>: Filter comparison operator.
  Value <String>: Filter comparison value.
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkUserGroup.md
#>
 Function New-JcSdkUserGroup
{
    [OutputType([JumpCloud.SDK.V2.Models.IUserGroup])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IUserGroupPost]
    # UserGroupPost
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Display name of a User Group.
    ${Name}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Runtime.Info(PossibleTypes=([JumpCloud.SDK.V2.Models.IGroupAttributesUserGroup]))]
    [System.Collections.Hashtable]
    # The graph attributes for a UserGroup.
    ${Attributes}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Description of a User Group
    ${Description}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Email address of a User Group
    ${Email}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IGraphObject[]]
    # Array of GraphObjects exempted from the query
    # To construct, see NOTES section for MEMBERQUERYEXEMPTIONS properties and create a hash table.
    ${MemberQueryExemptions}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IFilter[]]
    # .
    # To construct, see NOTES section for MEMBERQUERYFILTERS properties and create a hash table.
    ${MemberQueryFilters}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if notification emails are to be sent for membership suggestions.
    ${MemberSuggestionsNotify}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if membership of this group is automatically updated based on the Member Query and Member Query Exemptions, if configured
    ${MembershipAutomated}, 

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
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalUserGroup @PSBoundParameters
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


