Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the SDK to publish.')][ValidateSet('JumpCloud.SDK', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2', 'JumpCloud.SDK.DirectoryInsights')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
)
Set-AWSCredential -AccessKey:($env:AWSAccessKey) -SecretKey:($env:AWSSecretKey)
$CARepoEndpoint = "$(Get-CARepositoryEndpoint -Domain powershell-domain -Region us-west-2 -Repository powershell-team-repository -Format nuget)v3/index.json"
dotnet nuget add source $CARepoEndpoint --name CircleCI-Source --password (Get-CAAuthorizationToken -Domain:("powershell-domain") -Region:("us-west-2")).AuthorizationToken --username aws
ForEach ($SDK in $SDKName)
{
    $NupkgPath = (Get-ChildItem -Path:("./SDKs/PowerShell/$($SDK)/bin/$($SDK)*.nupkg")).FullName
    dotnet nuget push "$($NupkgPath)" --source CircleCI-Source
}
