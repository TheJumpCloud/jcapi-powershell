#Requires -modules JumpCloud.SDK.V2
Function Set-JCGSuiteGraphGSuiteAssociation
{
    [CmdletBinding(DefaultParameterSetName = 'SetExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'SetExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'Set',
			Mandatory = $true
		)]
		[System.String]$GsuiteId,
		[Parameter(
			ParameterSetName = 'SetViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'SetViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(
			ParameterSetName = 'SetViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'Set',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.IGraphManagementReq]$Body,
		[Parameter(
			ParameterSetName = 'SetViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'SetExpanded',
			Mandatory = $true
		)]
		[System.String]$Id,
		[Parameter(
			ParameterSetName = 'SetViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'SetExpanded',
			Mandatory = $true
		)]
		[System.String]$Op,
		[Parameter(
			ParameterSetName = 'SetViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'SetExpanded',
			Mandatory = $true
		)]
		[System.String]$Type,
		[Parameter(ParameterSetName = 'SetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'SetExpanded')]
		[JumpCloud.SDK.V2.Models.IGraphManagementReqAttributes]$Attributes,
		[Parameter(ParameterSetName = 'SetExpanded')]
		[Parameter(ParameterSetName = 'Set')]
		[Parameter(ParameterSetName = 'SetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'SetViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'SetExpanded')]
		[Parameter(ParameterSetName = 'Set')]
		[Parameter(ParameterSetName = 'SetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'SetViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkGSuiteGraphGSuiteAssociation @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
