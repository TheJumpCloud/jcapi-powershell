Describe -Tag:('ModuleValidation') 'Help File Tests' {
    $ModuleRoot = (Get-Item -Path:($PSScriptRoot)).Parent.Parent.Parent
    $ModuleRootFullName = $ModuleRoot.FullName
    $Regex_FillInThe = '(\{\{)(.*?)(\}\})'
    #$Regex_FillInThePester = [regex]('{{.*?}}')
    Context ('Validating help file fields have been populated') {
        Get-ChildItem -Path:($ModuleRootFullName + '/JumpCloud.SDK.V1/Docs/*.md') -Recurse | Select-String -Pattern:($Regex_FillInThe) | ForEach-Object {
            #-Pattern:($Regex_FillInThe)
            # It ('The file "' + $_.Path + '" needs to be populated on line number "' + $_.LineNumber + '" where "' + $_.Line + '" exists.') {
            #     $_.Path | Should -Not -FileContentMatch ($Regex_FillInThePester)
            # }
            Write-Host("##vso[task.logissue type=warning;]" + 'The file "' + $_.Path + '" needs to be populated on line number "' + $_.LineNumber + '" where "' + $_.Line + '" exists.')
            Write-Warning ('The file "' + $_.Path + '" needs to be populated on line number "' + $_.LineNumber + '" where "' + $_.Line + '" exists.')
        }
    }
}