Param(
    [Parameter(Mandatory=$false)]
    [string[]] $SDKs=@("JumpCloud.SDK.DirectoryInsights", "JumpCloud.SDK.V1", "JumpCloud.SDK.V2")
)
Set-AWSCredential -AccessKey:($env:AWSAccessKey) -SecretKey:($env:AWSSecretKey)
$CARepoEndpoint = "$(Get-CARepositoryEndpoint -Domain powershell-domain -Region us-west-2 -Repository powershell-team-repository -Format nuget)v3/index.json"
dotnet nuget add source $CARepoEndpoint --name CircleCI-Source --password (Get-CAAuthorizationToken -Domain:("powershell-domain") -Region:("us-west-2")).AuthorizationToken --username aws

ForEach ($SDK in $SDKs){
    $NupkgPath = (Get-ChildItem -Path:("./SDKs/PowerShell/$($SDK)/bin/$($SDK)*.nupkg")).FullName
    dotnet nuget push "$($NupkgPath)" --source CircleCI-Source
}

