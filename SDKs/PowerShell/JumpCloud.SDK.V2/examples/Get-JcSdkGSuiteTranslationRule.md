### Example 1: List GSuiteTranslationRules
```powershell
PS C:\> Get-JcSdkGSuiteTranslationRule -GsuiteId:(<string>) -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----      ----------
BuiltIn   String
Direction String
Id        String


```

This function will return a list of all GSuiteTranslationRules. Fields, Filter, and Sort are optional parameters.

### Example 2: Get a GSuiteTranslationRule by GsuiteId, and Id
```powershell
PS C:\> Get-JcSdkGSuiteTranslationRule -GsuiteId:(<string>) -Id:(<string>)



----      ----------
BuiltIn   String
Direction String
Id        String


```

This function will Get a GSuiteTranslationRule by GsuiteId Id. GsuiteId, and Id are required parameters.

