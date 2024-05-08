### Example 1: List Policys
```powershell
PS C:\> Get-JcSdkPolicy -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----                   ----------
Id                     String
Name                   String
TemplateActivation     String
TemplateAlert          String
TemplateBehavior       String
TemplateDeliveryTypes  String
TemplateDescription    String
TemplateDisplayName    String
TemplateId             String
TemplateName           String
TemplateOSMetaFamily   String
TemplateOSRestrictions JumpCloud.SDK.V2.Models.OSRestriction[]
TemplateReference      String
TemplateState          String


```

This function will return a list of all Policys. Fields, Filter, and Sort are optional parameters.

### Example 2: Get a Policy by Id
```powershell
PS C:\> Get-JcSdkPolicy -Id:(<string>)



----                   ----------
Id                     String
Name                   String
TemplateActivation     String
TemplateAlert          String
TemplateBehavior       String
TemplateDeliveryTypes  String
TemplateDescription    String
TemplateDisplayName    String
TemplateId             String
TemplateName           String
TemplateOSMetaFamily   String
TemplateOSRestrictions JumpCloud.SDK.V2.Models.OSRestriction[]
TemplateReference      String
TemplateState          String


```

This function will Get a Policy by Id. Id is a required parameter.

