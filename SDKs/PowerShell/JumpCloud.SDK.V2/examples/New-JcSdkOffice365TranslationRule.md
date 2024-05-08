### Example 1: Create an Office365TranslationRule by Office365Id
```powershell
PS C:\> New-JcSdkOffice365TranslationRule -Office365Id:(<string>) -BuiltIn:(<string>) -Direction:(<string>)



----      ----------
BuiltIn   String
Direction String
Id        String


```

This function will Create an Office365TranslationRule by Office365Id. Office365Id is a required parameter.

### Example 2: Create an Office365TranslationRule by Office365Id, and Body
```powershell
PS C:\> New-JcSdkOffice365TranslationRule -Office365Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.Office365TranslationRuleRequest>)



----      ----------
BuiltIn   String
Direction String
Id        String


```

This function will Create an Office365TranslationRule by Office365Id Body. Office365Id, and Body are required parameters.

