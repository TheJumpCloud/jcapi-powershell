### Example 1: Update an UserPushEndpoint by PushEndpointId, UserId, and Body
```powershell
PS C:\> Update-JcSdkUserPushEndpoint -PushEndpointId:(<string>) -UserId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.PathsO4Si39UsersUserIdPushendpointsPushEndpointIdPatchRequestbodyContentApplicationJsonSchema>)



----             ----------
DeviceAppVersion String
DeviceMake       String
DeviceModel      String
DeviceOS         String
DeviceOSVersion  String
DeviceUvEnabled  Boolean
EnrollmentDate   Datetime
Id               String
LastUsedDate     Datetime
Name             String
State            String


```

This function will Update an UserPushEndpoint by PushEndpointId UserId Body. PushEndpointId, UserId, and Body are required parameters.

### Example 2: Update an UserPushEndpoint by PushEndpointId, and UserId
```powershell
PS C:\> Update-JcSdkUserPushEndpoint -PushEndpointId:(<string>) -UserId:(<string>) -Name:(<string>) -State:(<string>)



----             ----------
DeviceAppVersion String
DeviceMake       String
DeviceModel      String
DeviceOS         String
DeviceOSVersion  String
DeviceUvEnabled  Boolean
EnrollmentDate   Datetime
Id               String
LastUsedDate     Datetime
Name             String
State            String


```

This function will Update an UserPushEndpoint by PushEndpointId UserId. PushEndpointId, and UserId are required parameters.

