### Example 1: Create a Policy by Name, and TemplateId
```powershell
PS C:\> New-JcSdkPolicy -Name:(<string>) -TemplateId:(<string>) -Notes:(<string>) -Values:(<JumpCloud.SDK.V2.Models.PolicyValue[]>)



----                   ----------
ConfigFields           JumpCloud.SDK.V2.Models.PolicyTemplateConfigField[]
Id                     String
Name                   String
Notes                  String
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
Values                 JumpCloud.SDK.V2.Models.PolicyValue[]


```

This function will Create a Policy by Name TemplateId. Name, and TemplateId are required parameters.

### Example 2: Create a Policy by Body
```powershell
PS C:\> New-JcSdkPolicy -Body:(<JumpCloud.SDK.V2.Models.PolicyCreateRequest>)



----                   ----------
ConfigFields           JumpCloud.SDK.V2.Models.PolicyTemplateConfigField[]
Id                     String
Name                   String
Notes                  String
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
Values                 JumpCloud.SDK.V2.Models.PolicyValue[]


```

This function will Create a Policy by Body. Body is a required parameter.

