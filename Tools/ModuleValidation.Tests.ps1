Describe 'Validate Module versions' -Tag:("Module_Version"){

    It ('Validates Module Versions'){
        [version]$v1GalleryVersion = Find-Module -name JumpCloud.SDK.V1 | Select-Object -Property Version | ForEach-Object { $_.Version }
        # Compare the versions to SDKs/PowerShell/JumpCloud.SDK.V1/JumpCloud.SDK.V1.psd1
        [version]$V1LocalVersion = Get-Content -Path "./SDKs/PowerShell/JumpCloud.SDK.V1/JumpCloud.SDK.V1.psd1" | Select-String -Pattern "ModuleVersion = '(.*)'" | ForEach-Object { $_.Matches.Groups[1].Value }

        # Compare the versions to SDKs/PowerShell/JumpCloud.SDK.V2/JumpCloud.SDK.V2.psd1
        [version]$v2GalleryVersion = Find-Module -name JumpCloud.SDK.V2 | Select-Object -Property Version | ForEach-Object { $_.Version }
        [version]$V2LocalVersion = Get-Content -Path "./SDKs/PowerShell/JumpCloud.SDK.V2/JumpCloud.SDK.V2.psd1" | Select-String -Pattern "ModuleVersion = '(.*)'" | ForEach-Object { $_.Matches.Groups[1].Value }

        # Compare the versions to SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/JumpCloud.SDK.DirectoryInsights.psd1
        [version]$DiGalleryVersion = Find-Module -name JumpCloud.SDK.DirectoryInsights | Select-Object -Property Version | ForEach-Object { $_.Version }
        [version]$DiLocalVersion = Get-Content -Path "./SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/JumpCloud.SDK.DirectoryInsights.psd1" | Select-String -Pattern "ModuleVersion = '(.*)'" | ForEach-Object { $_.Matches.Groups[1].Value }


        switch ($env:RELEASE_TYPE) {
            'major' {
                $V1LocalVersion.Major | Should -Be ($v1GalleryVersion.Major + 1)
                $V2LocalVersion.Major | Should -Be ($v2GalleryVersion.Major + 1)
                $DiLocalVersion.Major | Should -Be ($DiGalleryVersion.Major + 1)

                $V1LocalVersion | Should -BeGreaterThan $v1GalleryVersion
                $V2LocalVersion | Should -BeGreaterThan $v2GalleryVersion
                $DiGalleryVersion | Should -BeGreaterThan $DiGalleryVersion
            }
            'minor' {
                $V1LocalVersion.Minor | Should -Be ($v1GalleryVersion.Minor + 1)
                $V2LocalVersion.Minor | Should -Be ($v2GalleryVersion.Minor + 1)
                $DiLocalVersion.Minor | Should -Be ($DiGalleryVersion.Minor + 1)

                $V1LocalVersion | Should -BeGreaterThan $v1GalleryVersion
                $V2LocalVersion | Should -BeGreaterThan $v2GalleryVersion
                $DiGalleryVersion | Should -BeGreaterThan $DiGalleryVersion
            }
            'patch' {
                #Test
                $V1LocalVersion.Build | Should -Be ($v1GalleryVersion.Build + 1)
                $V2LocalVersion.Build | Should -Be ($v2GalleryVersion.Build + 1)
                $DiLocalVersion.Build | Should -Be ($DiGalleryVersion.Build + 1)

                $V1LocalVersion | Should -BeGreaterThan $v1GalleryVersion
                $V2LocalVersion | Should -BeGreaterThan $v2GalleryVersion
                $DiLocalVersion | Should -BeGreaterThan $DiGalleryVersion


            }
        }
    }
}