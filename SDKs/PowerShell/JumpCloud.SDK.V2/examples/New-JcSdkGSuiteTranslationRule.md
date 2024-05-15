### Example 1: Create a GSuiteTranslationRule by GsuiteId
```powershell
PS C:\> New-JcSdkGSuiteTranslationRule -GsuiteId:(<string>) -BuiltIn:(<string>) -Direction:(<string>)



----      ----------
BuiltIn   String
Direction String
Id        String


```

This function will Create a GSuiteTranslationRule by GsuiteId. GsuiteId is a required parameter.

### Example 2: Create a GSuiteTranslationRule by GsuiteId, and Body
```powershell
PS C:\> New-JcSdkGSuiteTranslationRule -GsuiteId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.GSuiteTranslationRuleRequest>)



----      ----------
BuiltIn   String
Direction String
Id        String


```

This function will Create a GSuiteTranslationRule by GsuiteId Body. GsuiteId, and Body are required parameters.

