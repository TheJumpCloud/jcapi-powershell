#Requires -PSEdition Core
#Requires -Modules @{ ModuleName="Pester"; ModuleVersion="4.10.1" }
Param(
    [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'API key used for pester tests.')][ValidateNotNullOrEmpty()][System.String]$JCApiKey
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'OrgId used for pester tests.')][ValidateNotNullOrEmpty()][System.String]$JCOrgId
    , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Path to test-module.ps1')]
    [ValidateNotNullOrEmpty()]
    [System.IO.FileInfo]
    [ValidateScript( {
            If (-Not ($_ | Test-Path) )
            {
                Throw "File or folder does not exist: '$_'"
            }
            If (-Not ($_ | Test-Path -PathType Leaf) )
            {
                Throw "The Path argument must be a file. Folder paths are not allowed: $_"
            }
            If ($_ -notmatch "(test-module\.ps1)")
            {
                Throw "The file specified in the path argument must be test-module.ps1: $_"
            }
            Return $true
        })]$testModulePath
)
# Create environmental variable so that they can be used by the pester tests
$env:JCApiKey = $JCApiKey
$env:JCOrgId = $JCOrgId
If (-not [System.String]::IsNullOrEmpty($env:JCApiKey) -and -not [System.String]::IsNullOrEmpty($env:JCOrgId))
{
    Write-Host ('[VALIDATION] JCApiKey AND JCOrgId have been populated.') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
    # ./test-module.ps1 -Isolated # Not sure when to use this yet
    # ./test-module.ps1 -Record # Run to create playback files
    # ./test-module.ps1 -Playback # Run once playback files have been created
    # ./test-module.ps1 -Live # Run to query against real API
    Invoke-Expression -Command:("$testModulePath -Live")
    # Throw error if there were any failed tests
    $PesterTestResultPath = (Get-ChildItem -Path:("$($testModulePath.Directory.FullName)/test/results")).FullName
    If (Test-Path -Path:($PesterTestResultPath))
    {
        [xml]$PesterResults = Get-Content -Path:($PesterTestResultPath)
        If ([int]$PesterResults.'testsuites'.failures -gt 0)
        {
            Write-Error ("Test Failures: $($PesterResults.'testsuites'.failures)")
        }
        If ([int]$PesterResults.'testsuites'.errors -gt 0)
        {
            Write-Error ("Test Errors: $($PesterResults.'testsuites'.errors)")
        }
    }
    Else
    {
        Write-Error ("Unable to find file path: $PesterTestResultPath")
    }
}
Else
{
    Write-Error ("Unable to test because JCApiKey and JCOrgId have not been set.")
}
