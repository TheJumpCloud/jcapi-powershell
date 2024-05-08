### Example 1: List Office365TranslationRules
```powershell
PS C:\> Get-JcSdkOffice365TranslationRule -Office365Id:(<string>) -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----      ----------
BuiltIn   String
Direction String
Id        String


```

This function will return a list of all Office365TranslationRules. Fields, Filter, and Sort are optional parameters.

### Example 2: Get an Office365TranslationRule by Office365Id, and Id
```powershell
PS C:\> Get-JcSdkOffice365TranslationRule -Office365Id:(<string>) -Id:(<string>)



----      ----------
BuiltIn   String
Direction String
Id        String


```

This function will Get an Office365TranslationRule by Office365Id Id. Office365Id, and Id are required parameters.

