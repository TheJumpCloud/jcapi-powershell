function Get-JcSdkEvent
{
    [OutputType([JumpCloud.SDK.DirectoryInsights.Models.IPost200ApplicationJsonItemsItem], [System.String])]
    [CmdletBinding(PositionalBinding = $false)]
    # [PowerShell.Cmdlets.JumpCloud.SDK.DirectoryInsights.Description('...')]
    param(
        [Parameter(Mandatory = $false)]
        # [Parameter(ParameterSetName = 'Get')]
        # [Parameter(ParameterSetName = 'GetExpanded')]
        [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
        [System.Boolean]
        # Set to $true to return all results. Default is $true.
        ${Paginate}
    )
    process
    {
        if ($PSBoundParameters.ContainsKey("Paginate"))
        {
            # Do something with the -Paginate parameter

            # If necessary, remove the -Paginate parameter from the dictionary of bound parameters
            $null = $PSBoundParameters.Remove("Paginate")
        }
        # Perform action

        # If this variant should call back to the original cmdlet, use splatting to pass the existing set of parameters
        JumpCloud.SDK.DirectoryInsights\Get-JcSdkEvent @PSBoundParameters

        #     # By default set the value to be true
        #     Write-Host ('Hello!!!') -BackgroundColor Cyan -ForegroundColor Black
        #     Write-Debug ('Hello!!!')
        #     Write-Warning ('Hello!!!')
        #     If (-not $PSBoundParameters.ContainsKey("Paginate"))
        #     {
        #         $PSBoundParameters = $true
        #     }
        #     If ($PSBoundParameters.ContainsKey("Paginate") -and $PSBoundParameters.Paginate)
        #     {
        #         # Remove the -Paginate parameter from the dictionary of bound parameters
        #         $null = $PSBoundParameters.Remove("Paginate")
        #         # Add code for HttpPipelineAppend
        #         $PSBoundParameters.Add('HttpPipelineAppend', {
        #                 param($req, $callback, $next)
        #                 # call the next step in the Pipeline
        #                 $ResponseTask = $next.SendAsync($req, $callback)
        #                 $global:JCHttpRequest = $req
        #                 $global:JCHttpRequestContent = $req.Content.ReadAsStringAsync()
        #                 $global:JCHttpResponse = $ResponseTask
        #                 Return $ResponseTask
        #             }
        #         )
        #         # Use splatting to pass the existing set of parameters
        #         Do
        #         {
        #             $Result = JumpCloud.SDK.DirectoryInsights\Get-JcSdkEvent @PSBoundParameters
        #             If (-not [System.String]::IsNullOrEmpty($Result))
        #             {
        #                 $XResultSearchAfter = ($JCHttpResponse.Result.Headers.GetValues('X-Search_after') | ConvertFrom-Json);
        #                 If ([System.String]::IsNullOrEmpty($PSBoundParameters.SearchAfter))
        #                 {
        #                     If ([System.String]::IsNullOrEmpty($PSBoundParameters.EventQueryBody))
        #                     {
        #                         $PSBoundParameters.Add('SearchAfter', $XResultSearchAfter)
        #                     }
        #                     Else
        #                     {
        #                         $PSBoundParameters.EventQueryBody.SearchAfter = $XResultSearchAfter
        #                     }
        #                 }
        #                 Else
        #                 {
        #                     $PSBoundParameters.SearchAfter = $XResultSearchAfter
        #                 }
        #                 $XResultCount = $JCHttpResponse.Result.Headers.GetValues('X-Result-Count')
        #                 $XLimit = $JCHttpResponse.Result.Headers.GetValues('X-Limit')
        #                 $Results += ($Result).ToJsonString() | ConvertFrom-Json;
        #             }
        #             Write-Debug ("ResultCount: $($XResultCount); Limit: $($XLimit); XResultSearchAfter: $($XResultSearchAfter); ");
        #             Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        #             Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        #         }
        #         While ($XResultCount -eq $XLimit -and $Result)
        #     }
        #     Else
        #     {
        #         # Remove the -Paginate parameter from the dictionary of bound parameters
        #         $null = $PSBoundParameters.Remove("Paginate")
        #         $Result = JumpCloud.SDK.DirectoryInsights\Get-JcSdkEvent @PSBoundParameters
        #         Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        #         Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        #         If (-not [System.String]::IsNullOrEmpty($Result))
        #         {
        #             $Results += ($Result).ToJsonString() | ConvertFrom-Json;
        #         }
        #     }
        #     # Clean up global variables
        #     $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse')
        #     $GlobalVars | ForEach-Object {
        #         If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        #     }
        #     Return $Results
    }
}
