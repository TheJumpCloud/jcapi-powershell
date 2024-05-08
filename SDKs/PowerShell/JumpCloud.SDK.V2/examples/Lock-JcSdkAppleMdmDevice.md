### Example 1: Lock an AppleMdmDevice by AppleMdmId, and DeviceId
```powershell
PS C:\> Lock-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -DeviceId:(<string>) -Pin:(<string>)


```

This function will Lock an AppleMdmDevice by AppleMdmId DeviceId. AppleMdmId, and DeviceId are required parameters.

### Example 2: Lock an AppleMdmDevice by AppleMdmId, DeviceId, and Body
```powershell
PS C:\> Lock-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -DeviceId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.PathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema>)


```

This function will Lock an AppleMdmDevice by AppleMdmId DeviceId Body. AppleMdmId, DeviceId, and Body are required parameters.

