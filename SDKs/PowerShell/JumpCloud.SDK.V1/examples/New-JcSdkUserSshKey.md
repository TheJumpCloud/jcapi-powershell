### Example 1: Create an UserSshKey by Id, Name, and PublicKey
```powershell
PS C:\> New-JcSdkUserSshKey -Id:(<string>) -Name:(<string>) -PublicKey:(<string>)



----       ----------
CreateDate String
Id         String
Name       String
PublicKey  String


```

This function will Create an UserSshKey by Id Name PublicKey. Id, Name, and PublicKey are required parameters.

### Example 2: Create an UserSshKey by Id, and Body
```powershell
PS C:\> New-JcSdkUserSshKey -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Sshkeypost>)



----       ----------
CreateDate String
Id         String
Name       String
PublicKey  String


```

This function will Create an UserSshKey by Id Body. Id, and Body are required parameters.

