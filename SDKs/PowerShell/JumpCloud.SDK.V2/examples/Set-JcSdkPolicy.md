### Example 1: Set a Policy by Id, and Body
```powershell
PS C:\> Set-JcSdkPolicy -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.PolicyUpdateRequest>)



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

This function will Set a Policy by Id Body. Id, and Body are required parameters.

### Example 2: Set a Policy by Id, and Name
```powershell
PS C:\> Set-JcSdkPolicy -Id:(<string>) -Name:(<string>) -Notes:(<string>) -Values:(<JumpCloud.SDK.V2.Models.PolicyValue[]>)



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

This function will Set a Policy by Id Name. Id, and Name are required parameters.

