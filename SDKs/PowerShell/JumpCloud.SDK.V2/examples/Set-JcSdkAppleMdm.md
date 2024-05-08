### Example 1: Set an AppleMdm by Id, and Body
```powershell
PS C:\> Set-JcSdkAppleMdm -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.AppleMdmPatch>)



----                                  ----------
AllowMobileUserEnrollment             Boolean
ApnsCertExpiry                        String
ApnsPushTopic                         String
AppleCertCreatorAppleId               String
AppleCertSerialNumber                 String
DefaultIosUserEnrollmentDeviceGroupId String
DefaultSystemGroupId                  String
DepAccessTokenExpiry                  String
DepEnableZeroTouchEnrollment          Boolean
DepServerTokenState                   String
DepSetupAssistantOptions              JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
Id                                    String
IoDefaultDeviceGroupObjectIds         String
IoEnableZeroTouchEnrollment           Boolean
IoSetupAssistantOptions               JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
IoSetupOptions                        String
IosWelcomeScreenButton                String
IosWelcomeScreenParagraph             String
IosWelcomeScreenTitle                 String
MacoDefaultDeviceGroupObjectIds       String
MacoEnableZeroTouchEnrollment         Boolean
MacoSetupAssistantOptions             JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
MacoSetupOptions                      String
MacosWelcomeScreenButton              String
MacosWelcomeScreenParagraph           String
MacosWelcomeScreenTitle               String
Name                                  String
Organization                          String
WelcomeScreenButton                   String
WelcomeScreenParagraph                String
WelcomeScreenTitle                    String


```

This function will Set an AppleMdm by Id Body. Id, and Body are required parameters.

### Example 2: Set an AppleMdm by Id
```powershell
PS C:\> Set-JcSdkAppleMdm -Id:(<string>) -AllowMobileUserEnrollment:(<switch>) -AppleCertCreatorAppleId:(<string>) -AppleSignedCert:(<string>) -DefaultIosUserEnrollmentDeviceGroupId:(<string>) -DefaultSystemGroupId:(<string>) -DepEnableZeroTouchEnrollment:(<switch>) -DepSetupAssistantOptions:(<JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]>) -EncryptedDepServerToken:(<string>) -IoDefaultDeviceGroupObjectIds:(<string[]>) -IoEnableZeroTouchEnrollment:(<switch>) -IoSetupAssistantOptions:(<JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]>) -IoSetupOptions:(<string[]>) -IosWelcomeScreenButton:(<string>) -IosWelcomeScreenParagraph:(<string>) -IosWelcomeScreenTitle:(<string>) -MacoDefaultDeviceGroupObjectIds:(<string[]>) -MacoEnableZeroTouchEnrollment:(<switch>) -MacoSetupAssistantOptions:(<JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]>) -MacoSetupOptions:(<string[]>) -MacosWelcomeScreenButton:(<string>) -MacosWelcomeScreenParagraph:(<string>) -MacosWelcomeScreenTitle:(<string>) -Name:(<string>) -WelcomeScreenButton:(<string>) -WelcomeScreenParagraph:(<string>) -WelcomeScreenTitle:(<string>)



----                                  ----------
AllowMobileUserEnrollment             Boolean
ApnsCertExpiry                        String
ApnsPushTopic                         String
AppleCertCreatorAppleId               String
AppleCertSerialNumber                 String
DefaultIosUserEnrollmentDeviceGroupId String
DefaultSystemGroupId                  String
DepAccessTokenExpiry                  String
DepEnableZeroTouchEnrollment          Boolean
DepServerTokenState                   String
DepSetupAssistantOptions              JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
Id                                    String
IoDefaultDeviceGroupObjectIds         String
IoEnableZeroTouchEnrollment           Boolean
IoSetupAssistantOptions               JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
IoSetupOptions                        String
IosWelcomeScreenButton                String
IosWelcomeScreenParagraph             String
IosWelcomeScreenTitle                 String
MacoDefaultDeviceGroupObjectIds       String
MacoEnableZeroTouchEnrollment         Boolean
MacoSetupAssistantOptions             JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
MacoSetupOptions                      String
MacosWelcomeScreenButton              String
MacosWelcomeScreenParagraph           String
MacosWelcomeScreenTitle               String
Name                                  String
Organization                          String
WelcomeScreenButton                   String
WelcomeScreenParagraph                String
WelcomeScreenTitle                    String


```

This function will Set an AppleMdm by Id. Id is a required parameter.

