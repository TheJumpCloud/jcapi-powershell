VERSION=$(grep -o “‘\d\+\.\d\+\.\d\+‘” ./JumpCloud.SDK.DirectoryInsights.psd1 | Head -1) 
VERSION="0.0.16"
TITLE="JumpCloud SDK DI Module v$VERSION"
echo $VERSION
# Get the changelog text between the latest release # and the next sequential "## SemanticVersionNumber"
CHANGELOG=$(cat ./sdkDiChangelog.md | awk "/^## JumpCloud.SDK.DirectoryInsights-$VERSION/{ f = 1; next } /## JumpCloud.SDK.DirectoryInsights-[0-9]+.[0-9]+.[0-9]+/{ f = 0 } f")
TAG="v$VERSION"
BODY="$TITLE $CHANGELOG"
echo $BODY
echo $TAG

#ghr -t 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 -u TheJumpCloud -r jcapi-powershell -c SA-2318-Automate-Changelog -n "$TITLE" -b "$BODY" -delete -draft $TAG 
