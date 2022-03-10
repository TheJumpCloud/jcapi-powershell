## JumpCloud.SDK.DirectoryInsights-0.0.15

Release Date: March 10, 2022
#### RELEASE NOTES
```
{{Fill in the Release Notes}}
```
#### FEATURES:
{{Fill in the Features}}
#### IMPROVEMENTS:
{{Fill in the Improvements}}
#### BUG FIXES:
{{Fill in the Bug Fixes}}
#### DIFF:
diff --git a/.circleci/config.yml b/.circleci/config.yml
index 5925cd0a..c12700fc 100644
--- a/.circleci/config.yml
+++ b/.circleci/config.yml
@@ -26,23 +26,31 @@ build-sdks: &build-sdks
       requires:
         - Build and Test JumpCloud SDK V1
       context: aws-credentials
+  - Create GitHub Release Draft:
+      requires:
+      - Build and Test JumpCloud SDK DirectoryInsights
+      - Build and Test JumpCloud SDK V1
+      - Build and Test JumpCloud SDK V2
   - Commit Changes:
       requires:
         - Build and Test JumpCloud SDK DirectoryInsights
         - Build and Test JumpCloud SDK V1
         - Build and Test JumpCloud SDK V2
+        - Create GitHub Release Draft
   - CodeArtifact Approval:
       type: approval
       requires:
           - Build and Test JumpCloud SDK DirectoryInsights
           - Build and Test JumpCloud SDK V1
           - Build and Test JumpCloud SDK V2
+          - Create GitHub Release Draft
           - Commit Changes
   - Pack and Deploy To CodeArtifact:
       requires:
         - Build and Test JumpCloud SDK DirectoryInsights
         - Build and Test JumpCloud SDK V1
         - Build and Test JumpCloud SDK V2
+        - Create GitHub Release Draft
         - Commit Changes
         - CodeArtifact Approval
       context: aws-credentials
@@ -51,6 +59,7 @@ build-sdks: &build-sdks
         - Build and Test JumpCloud SDK DirectoryInsights
         - Build and Test JumpCloud SDK V1
         - Build and Test JumpCloud SDK V2
+        - Create GitHub Release Draft
         - Commit Changes
         - CodeArtifact Approval
         - Pack and Deploy To CodeArtifact
@@ -61,6 +70,7 @@ build-sdks: &build-sdks
         - Build and Test JumpCloud SDK DirectoryInsights
         - Build and Test JumpCloud SDK V1
         - Build and Test JumpCloud SDK V2
+        - Create GitHub Release Draft
         - Commit Changes
         - Pack and Deploy To CodeArtifact
       filters:
@@ -72,6 +82,7 @@ build-sdks: &build-sdks
         - Build and Test JumpCloud SDK DirectoryInsights
         - Build and Test JumpCloud SDK V1
         - Build and Test JumpCloud SDK V2
+        - Create GitHub Release Draft
         - Commit Changes
         - Pack and Deploy To CodeArtifact
         - PSGallery Approval
@@ -138,6 +149,24 @@ jobs:
           ManualModuleVersion: ''
           RunApiTransform: true
           TestModule: true
+  Create GitHub Release Draft:
+    docker:
+      - image: cibuilds/github:0.13
+    steps:
+      - attach_workspace:
+          at: .
+      - run:
+          name: "Draft Release on GitHub"
+          command: |
+            # Module Version
+            VERSION=$(grep -o '\d\+\.\d\+\.\d\+' https://github.com/TheJumpCloud/support/blob/master/PowerShell/JumpCloud%20Module/JumpCloud.psd1)
+            TITLE="JumpCloud PowerShell Module v$VERSION"
+            # Get the changelog text between the latest release # and the next sequential "## SemanticVersionNumber"
+            CHANGELOG=$(cat /root/project/PowerShell/ModuleChangelog.md |awk "/^## $VERSION/{ f = 1; next } /## [0-9]+.[0-9]+.[0-9]+/{ f = 0 } f")
+            TAG="v$VERSION"
+            BODY="$TITLE $CHANGELOG"
+            # Post Draft Release
+            ghr -t ${GITHUB_TOKEN} -u ${CIRCLE_PROJECT_USERNAME} -r ${CIRCLE_PROJECT_REPONAME} -c ${CIRCLE_SHA1} -n "$TITLE" -b "$BODY" -delete -draft "$TAG" /root/project/PowerShell/
   Commit Changes:
     executor: win/default
     steps:
diff --git a/SDKs/PowerShell/Deploy/Build-SdkChangelog.ps1 b/SDKs/PowerShell/Deploy/Build-SdkChangelog.ps1
new file mode 100755
index 00000000..489cf264
--- /dev/null
+++ b/SDKs/PowerShell/Deploy/Build-SdkChangelog.ps1
@@ -0,0 +1,29 @@
+[CmdletBinding()]
+param (
+    [Parameter()]
+    [String]
+    $SdkName
+)
+#curl -H "Accept: application/vnd.github.v3+json" https://api.github.com/repos/TheJumpCloud/jcapi-powershell/releases | jq '.[] | {tag_name,target_commitish,published_at}'
+
+$release = Invoke-WebRequest -Uri 'https://api.github.com/repos/TheJumpCloud/jcapi-powershell/releases'  -Method 'GET'
+$releaseVersions =$release | ConvertFrom-Json -Depth 4
+
+$v1LatestVersion = $releaseVersions.tag_name -match "JumpCloud.SDK.v1"
+$v2LatestVersion = $releaseVersions.tag_name -match "JumpCloud.SDK.V2"
+$DiLatestVersion = $releaseVersions.tag_name -match "JumpCloud.SDK.DirectoryInsights"
+
+#Write-Host $DiLatestVersion | Out-String
+# $test | Select tag_name
+
+#Write-Host $test | ConvertFrom-Json -Depth 100
+#TODO: Populate SdkChangelog.md
+#TODO: Call New-SdkChangelog to populate data
+$SdkChangelog = Get-Content -Path:("SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/DiChangelog.md")
+$NewSdkChangelogRecord = New-SdkChangelog -LatestVersion:($DiLatestVersion | Out-String) -ReleaseNotes:('{{Fill in the Release Notes}}') -Features:('{{Fill in the Features}}') -Improvements:('{{Fill in the Improvements}}') -BugFixes('{{Fill in the Bug Fixes}}')
+
+If ((($SdkChangelog | Select-Object -First 1) -match $DiLatestVersion)){
+    ($NewSdkChangelogRecord + ($SdkChangelog | Out-String)).Trim() | Set-Content -Path:("SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/DiChangelog.md") -Force
+}
+
+
diff --git a/SDKs/PowerShell/Deploy/Functions/New-SdkChangelog.ps1 b/SDKs/PowerShell/Deploy/Functions/New-SdkChangelog.ps1
new file mode 100644
index 00000000..15551126
--- /dev/null
+++ b/SDKs/PowerShell/Deploy/Functions/New-SdkChangelog.ps1
@@ -0,0 +1,24 @@
+Function Global:New-SdkChangelog
+{
+    Param(
+        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 0)][ValidateNotNullOrEmpty()][System.String]$LatestVersion
+        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 1)][ValidateNotNullOrEmpty()][System.String]$ReleaseNotes
+        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 2)][ValidateNotNullOrEmpty()][System.String]$Features
+        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 3)][ValidateNotNullOrEmpty()][System.String]$Improvements
+        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 4)][ValidateNotNullOrEmpty()][System.String]$BugFixes
+    )
+    $Content = "## {0}
+Release Date: $(Get-Date -UFormat:('%B %d, %Y'))
+#### RELEASE NOTES
+```````
+{1}
+```````
+#### FEATURES:
+{2}
+#### IMPROVEMENTS:
+{3}
+#### BUG FIXES:
+{4}
+"
+    Return ($Content -f $LatestVersion, $ReleaseNotes, $Features, $Improvements, $BugFixes)
+}
\ No newline at end of file
diff --git a/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/DiChangelog.md b/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/DiChangelog.md
new file mode 100644
index 00000000..e92b1f78
--- /dev/null
+++ b/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/DiChangelog.md
@@ -0,0 +1,78 @@
+## JumpCloud.SDK.DirectoryInsights-0.0.15
+
+Release Date: March 10, 2022
+#### RELEASE NOTES
+```
+{{Fill in the Release Notes}}
+```
+#### FEATURES:
+{{Fill in the Features}}
+#### IMPROVEMENTS:
+{{Fill in the Improvements}}
+#### BUG FIXES:
+{{Fill in the Bug Fixes}}
+## JumpCloud.SDK.DirectoryInsights-0.0.15
+
+Release Date: March 10, 2022
+#### RELEASE NOTES
+```
+{{Fill in the Release Notes}}
+```
+#### FEATURES:
+{{Fill in the Features}}
+#### IMPROVEMENTS:
+{{Fill in the Improvements}}
+#### BUG FIXES:
+{{Fill in the Bug Fixes}}
+## JumpCloud.SDK.DirectoryInsights-0.0.15
+
+Release Date: March 10, 2022
+#### RELEASE NOTES
+```
+{{Fill in the Release Notes}}
+```
+#### FEATURES:
+{{Fill in the Features}}
+#### IMPROVEMENTS:
+{{Fill in the Improvements}}
+#### BUG FIXES:
+{{Fill in the Bug Fixes}}
+## JumpCloud.SDK.DirectoryInsights-0.0.16
+
+Release Date: March 10, 2022
+#### RELEASE NOTES
+```
+{{Fill in the Release Notes}}
+```
+#### FEATURES:
+{{Fill in the Features}}
+#### IMPROVEMENTS:
+{{Fill in the Improvements}}
+#### BUG FIXES:
+{{Fill in the Bug Fixes}}
+## JumpCloud.SDK.DirectoryInsights-0.0.16
+
+Release Date: March 10, 2022
+#### RELEASE NOTES
+```
+{{Fill in the Release Notes}}
+```
+#### FEATURES:
+{{Fill in the Features}}
+#### IMPROVEMENTS:
+{{Fill in the Improvements}}
+#### BUG FIXES:
+{{Fill in the Bug Fixes}}
+## JumpCloud.SDK.DirectoryInsights-0.0.15
+
+Release Date: March 10, 2022
+#### RELEASE NOTES
+```
+{{Fill in the Release Notes}}
+```
+#### FEATURES:
+{{Fill in the Features}}
+#### IMPROVEMENTS:
+{{Fill in the Improvements}}
+#### BUG FIXES:
+{{Fill in the Bug Fixes}}
diff --git a/SDKs/PowerShell/JumpCloud.SDK.V1/v1Changelog.md b/SDKs/PowerShell/JumpCloud.SDK.V1/v1Changelog.md
new file mode 100644
index 00000000..e69de29b
diff --git a/SDKs/PowerShell/JumpCloud.SDK.V2/v2Changelog.md b/SDKs/PowerShell/JumpCloud.SDK.V2/v2Changelog.md
new file mode 100644
index 00000000..e69de29b
diff --git a/Tools/latestversion.sh b/Tools/latestversion.sh
new file mode 100755
index 00000000..b3644e7d
--- /dev/null
+++ b/Tools/latestversion.sh
@@ -0,0 +1,11 @@
+#!/bin/bash
+echo "Printing the releases"
+curl -H "Accept: application/vnd.github.v3+json" https://api.github.com/repos/TheJumpCloud/jcapi-powershell/releases | jq '.[] | {tag_name,target_commitish,published_at}'
+
+
+# echo "The Following Files have been added:"
+# git diff HEAD^ 6f3748d672abfdebcefbd69c6451da1ee687a1f3 --compact-summary --diff-filter=A | Grep "generated"
+# echo "The Following Files have been modified:"
+# git diff HEAD^ 6f3748d672abfdebcefbd69c6451da1ee687a1f3 --compact-summary --diff-filter=M | Grep "generated"
+# echo "The Following Files have been deleted:"
+# git diff HEAD^ 6f3748d672abfdebcefbd69c6451da1ee687a1f3 --compact-summary --diff-filter=D | Grep "generated"
\ No newline at end of file
diff --git a/test b/test
new file mode 100644
index 00000000..aae0cb7c
--- /dev/null
+++ b/test
@@ -0,0 +1,14 @@
+## JumpCloud.SDK.DirectoryInsights-0.0.15
+
+Release Date: March 10, 2022
+#### RELEASE NOTES
+```
+{{Fill in the Release Notes}}
+```
+#### FEATURES:
+{{Fill in the Features}}
+#### IMPROVEMENTS:
+{{Fill in the Improvements}}
+#### BUG FIXES:
+{{Fill in the Bug Fixes}}
+test

## JumpCloud.SDK.DirectoryInsights-0.0.15

Release Date: March 10, 2022
#### RELEASE NOTES
```
{{Fill in the Release Notes}}
```
#### FEATURES:
{{Fill in the Features}}
#### IMPROVEMENTS:
{{Fill in the Improvements}}
#### BUG FIXES:
{{Fill in the Bug Fixes}}
## JumpCloud.SDK.DirectoryInsights-0.0.15

Release Date: March 10, 2022
#### RELEASE NOTES
```
{{Fill in the Release Notes}}
```
#### FEATURES:
{{Fill in the Features}}
#### IMPROVEMENTS:
{{Fill in the Improvements}}
#### BUG FIXES:
{{Fill in the Bug Fixes}}
## JumpCloud.SDK.DirectoryInsights-0.0.15

Release Date: March 10, 2022
#### RELEASE NOTES
```
{{Fill in the Release Notes}}
```
#### FEATURES:
{{Fill in the Features}}
#### IMPROVEMENTS:
{{Fill in the Improvements}}
#### BUG FIXES:
{{Fill in the Bug Fixes}}
## JumpCloud.SDK.DirectoryInsights-0.0.16

Release Date: March 10, 2022
#### RELEASE NOTES
```
{{Fill in the Release Notes}}
```
#### FEATURES:
{{Fill in the Features}}
#### IMPROVEMENTS:
{{Fill in the Improvements}}
#### BUG FIXES:
{{Fill in the Bug Fixes}}
## JumpCloud.SDK.DirectoryInsights-0.0.16

Release Date: March 10, 2022
#### RELEASE NOTES
```
{{Fill in the Release Notes}}
```
#### FEATURES:
{{Fill in the Features}}
#### IMPROVEMENTS:
{{Fill in the Improvements}}
#### BUG FIXES:
{{Fill in the Bug Fixes}}
## JumpCloud.SDK.DirectoryInsights-0.0.15

Release Date: March 10, 2022
#### RELEASE NOTES
```
{{Fill in the Release Notes}}
```
#### FEATURES:
{{Fill in the Features}}
#### IMPROVEMENTS:
{{Fill in the Improvements}}
#### BUG FIXES:
{{Fill in the Bug Fixes}}
