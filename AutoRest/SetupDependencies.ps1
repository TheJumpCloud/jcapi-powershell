$RequiredModules = ('powershell-yaml')
ForEach ($RequiredModule In $RequiredModules)
{
    # Check to see if the module is installed
    If (Get-InstalledModule -Name:($RequiredModule) -ErrorAction:('SilentlyContinue'))
    {
        Update-Module -Name:($RequiredModule) -Force
    }
    # Check to see if the module exists on the PSGallery
    ElseIf (Find-Module -Name:($RequiredModule))
    {
        Install-Module -Name:($RequiredModule) -Force
    }
    Import-Module -Name:($RequiredModule) -Force
}