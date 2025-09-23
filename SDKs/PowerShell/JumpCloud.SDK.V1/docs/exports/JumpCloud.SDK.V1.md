---
Module Name: JumpCloud.SDK.V1
Module Guid: 85e70ace-c640-4638-89eb-e4b30362d95d
Download Help Link: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v1
Help Version: 1.0.0.0
Locale: en-US
---

# JumpCloud.SDK.V1 Module
## Description
The JumpCloud V1 PowerShell SDK

## JumpCloud.SDK.V1 Cmdlets
### [Clear-JcSdkSystem](Clear-JcSdkSystem.md)
This endpoint allows you to run the erase command on the specified device.
If a device is offline, the command will be run when the device becomes available.
Only supported on Linux and Windows devices.
Use Apple MDM security commands for macOS devices.

#### Sample Request
```
curl -X POST \\
  https://console.jumpcloud.com/api/systems/{system_id}/command/builtin/erase \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d {}
```

### [Get-JcSdkApplication](Get-JcSdkApplication.md)
The endpoint retrieves an SSO / SAML Application.

### [Get-JcSdkApplicationTemplate](Get-JcSdkApplicationTemplate.md)
The endpoint returns a specific SSO / SAML Application Template.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/application-templates/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkCommand](Get-JcSdkCommand.md)
This endpoint returns a specific command based on the command ID.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/commands/{CommandID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkCommandFile](Get-JcSdkCommandFile.md)
This endpoint returns the uploaded file(s) associated with a specific command.

#### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/files/command/{commandID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkCommandResult](Get-JcSdkCommandResult.md)
This endpoint returns a specific command result.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/commandresults/{CommandResultID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkCommandResultByCommandId](Get-JcSdkCommandResultByCommandId.md)
This endpoint returns results for a specific command.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/commands/{id}/results \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ````

### [Get-JcSdkOrganization](Get-JcSdkOrganization.md)
This endpoint returns a particular Organization.

#### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/organizations/{OrganizationID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkRadiusServer](Get-JcSdkRadiusServer.md)
This endpoint allows you to get a RADIUS server in your organization.

####
```
curl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
```

### [Get-JcSdkSystem](Get-JcSdkSystem.md)
This endpoint returns an individual system.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkUser](Get-JcSdkUser.md)
This endpoint returns a particular System User.

#### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/systemusers/{UserID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserSshKey](Get-JcSdkUserSshKey.md)
This endpoint will return a specific System User's public SSH key.

### [Get-JcSdkUserTotp](Get-JcSdkUserTotp.md)
This endpoint will return info for a specific System User's TOTP enrollment.

### [Initialize-JcSdkUserState](Initialize-JcSdkUserState.md)
This endpoint changes the state of a STAGED user to ACTIVATED.
#### Email Flag
Use the \"email\" flag to determine whether or not to send a Welcome or
Activation email to the newly activated user.
Sending an empty body
without the `email` flag, will send an email with default behavior
(see the \"Behavior\" section below)
```
{}
```
Sending `email=true` flag will send an email with default behavior (see `Behavior` below)
```
{ \"email\": true }
```
Populated email will override the default behavior and send to the specified email value
```
{ \"email\": \"example@example.com\" }
```
Sending `email=false` will suppress sending the email
```
{ \"email\": false }
```
#### Behavior
Users with a password will be sent a Welcome email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's primary email address (default behavior)
Users without a password will be sent an Activation email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's alternate email address (default behavior)
  - If no alternate email address, the user's primary email address (default behavior)

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/systemusers/{id}/state/activate \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: \<api-key\>' \\
  -d '{ \"email\": \"alternate-activation-email@email.com\" }'

```

### [Invoke-JcSdkCommandTrigger](Invoke-JcSdkCommandTrigger.md)
This endpoint allows you to launch a command based on a defined trigger.

#### Sample Requests

**Launch a Command via a Trigger**

```
curl --silent \\
     -X 'POST' \\
     -H \"x-api-key: {API_KEY}\" \\
     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"
```
**Launch a Command via a Trigger passing a JSON object to the command**
```
curl --silent \\
     -X 'POST' \\
     -H \"x-api-key: {API_KEY}\" \\
     -H 'Accept: application/json' \\
     -H 'Content-Type: application/json' \\
     -d '{ \"srcip\":\"192.168.2.32\", \"attack\":\"Cross Site Scripting Attempt\" }' \\
     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"
```

### [Invoke-JcSdkExpireUserPassword](Invoke-JcSdkExpireUserPassword.md)
This endpoint allows you to expire a user's password.

### [Lock-JcSdkSystem](Lock-JcSdkSystem.md)
This endpoint allows you to run the lock command on the specified device.
If a device is offline, the command will be run when the device becomes available.
Only supported on Linux and Windows devices.
Use Apple MDM security commands for macOS devices.

#### Sample Request
```
curl -X POST \\
  https://console.jumpcloud.com/api/systems/{system_id}/command/builtin/lock \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d {}
```

### [New-JcSdkApplication](New-JcSdkApplication.md)
The endpoint adds a new SSO / SAML Applications.

### [New-JcSdkCommand](New-JcSdkCommand.md)
This endpoint allows you to create a new command.

NOTE: the system property in the command is not used.
Use a POST to /api/v2/commands/{id}/associations to bind a command to a system.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/commands/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json'
  -H 'x-api-key: {API_KEY}'
  -d '{\"name\":\"Test API Command\", \"command\":\"String\", \"user\":\"{UserID}\", \"schedule\":\"\", \"timeout\":\"100\"}'
```

### [New-JcSdkRadiusServer](New-JcSdkRadiusServer.md)
This endpoint allows you to create RADIUS servers in your organization.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/radiusservers/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{test_radius}\",
    \"networkSourceIp\": \"{0.0.0.0}\",
    \"sharedSecret\":\"{secretpassword}\",
    \"userLockoutAction\": \"REMOVE\",
    \"userPasswordExpirationAction\": \"MAINTAIN\"
}'
```

### [New-JcSdkUser](New-JcSdkUser.md)
\"This endpoint allows you to create a new system user.

#### Default User State
The `state` of the user can be explicitly passed in or omitted.
If
`state` is omitted from the request, then the user will get created
using the value returned from the
[Get an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organizations_get)
endpoint.
The default user state for manually created users is stored in
`settings.newSystemUserStateDefaults.manualEntry`

These default state values can be changed in the admin portal settings
or by using the
[Update an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organization_put)
endpoint.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/systemusers \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{
      \"username\":\"{username}\",
      \"email\":\"{email_address}\",
      \"firstname\":\"{Name}\",
      \"lastname\":\"{Name}\"
    }'
```

### [New-JcSdkUserSshKey](New-JcSdkUserSshKey.md)
This endpoint will create a specific System User's Public SSH Key.

### [Remove-JcSdkApplication](Remove-JcSdkApplication.md)
The endpoint deletes an SSO / SAML Application.

### [Remove-JcSdkCommand](Remove-JcSdkCommand.md)
This endpoint deletes a specific command based on the Command ID.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/commands/{CommandID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Remove-JcSdkCommandResult](Remove-JcSdkCommandResult.md)
This endpoint deletes a specific command result.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/commandresults/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ````

### [Remove-JcSdkRadiusServer](Remove-JcSdkRadiusServer.md)
This endpoint allows you to delete RADIUS servers in your organization.
```
curl -X DELETE https://console.jumpcloud.com/api/radiusservers/{ServerID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
```

### [Remove-JcSdkSystem](Remove-JcSdkSystem.md)
This endpoint allows you to delete a system.
This command will cause the system to uninstall the JumpCloud agent from its self which can can take about a minute.
If the system is not connected to JumpCloud the system record will simply be removed.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Remove-JcSdkUser](Remove-JcSdkUser.md)
This endpoint allows you to delete a particular system user.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/systemusers/{UserID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Remove-JcSdkUserSshKey](Remove-JcSdkUserSshKey.md)
This endpoint will delete a specific System User's SSH Key.

### [Reset-JcSdkAdministratorUserActivation](Reset-JcSdkAdministratorUserActivation.md)
This endpoint triggers the sending of a reactivation e-mail to an administrator.

### [Reset-JcSdkAdministratorUserTotp](Reset-JcSdkAdministratorUserTotp.md)
This endpoint initiates a TOTP reset for an admin.
This request does not accept a body.

### [Reset-JcSdkUserMfa](Reset-JcSdkUserMfa.md)
This endpoint resets the user's TOTP key and initiates a new MFA enrollment period.
The user will be prompted to set up MFA at their next login.
If `Unified MFA is enabled`, this action will also delete the user's existing Push Notification endpoint.
Warning: The user must complete the setup before the `exclusionUntil` date to avoid being locked out of MFA-protected resources.

Please refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.

#### Sample Request
```
curl -X POST \\
  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'

```

### [Restart-JcSdkSystem](Restart-JcSdkSystem.md)
This endpoint allows you to run the restart command on the specified device.
If a device is offline, the command will be run when the device becomes available.
Only supported on Linux and Windows devices.
Use Apple MDM security commands for macOS devices.

#### Sample Request
```
curl -X POST \\
  https://console.jumpcloud.com/api/systems/{system_id}/command/builtin/restart \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d {}
```

### [Search-JcSdkCommand](Search-JcSdkCommand.md)
Return Commands in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new command.
To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.
The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.
This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.
The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the `searchTerm` the record will be returned.

#### Sample Request
Exact search for a list of commands in a launchType
```
curl -X POST https://console.jumpcloud.com/api/search/commands \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\" : [{\"launchType\" : \"repeated\"}],
  \"fields\" : \"name launchType sudo\"
}'
```
Text search for commands with name
```
curl -X POST https://console.jumpcloud.com/api/search/commands \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\" : {
    \"searchTerm\": \"List\",
    \"fields\": [\"name\"]
  },
  \"fields\" : \"name launchType sudo\"
}'
```
Text search for multiple commands
```
curl -X POST https://console.jumpcloud.com/api/search/commands \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\" : {
    \"searchTerm\": [\"List\", \"Log\"],
    \"fields\": [\"name\"]
  },
  \"fields\" : \"name launchType sudo\"
}'
```
Combining `filter` and `searchFilter` to text search for commands with name who are in a list of launchType
```
curl -X POST https://console.jumpcloud.com/api/search/commands \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"List\",
    \"fields\": [\"name\"]
  },
  \"filter\": {
    \"or\": [
      {\"launchType\" : \"repeated\"},
      {\"launchType\" : \"one-time\"}
    ]
  },
  \"fields\" : \"name launchType sudo\"
}'
```

### [Search-JcSdkCommandResult](Search-JcSdkCommandResult.md)
Return Command Results in multi-record format allowing for the passing of the `filter` parameter.

To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/commandresults route.
The `filter` parameter must be passed as Content-Type application/json.

The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.

This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.


#### Sample Request

Exact search for a specific command result
```
curl -X POST https://console.jumpcloud.com/api/search/commandresults \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\" : \"workflowInstanceId:$eq:62f3c599ec4e928499069c7f\",
  \"fields\" : \"name workflowId sudo\"
}'
```

### [Search-JcSdkOrganization](Search-JcSdkOrganization.md)
This endpoint will return Organization data based on your search parameters.
This endpoint WILL NOT allow you to add a new Organization.

You can use the supported parameters and pass those in the body of request.

The parameters must be passed as Content-Type application/json.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/search/organizations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"search\":{
    \"fields\" : [\"settings.name\"],
    \"searchTerm\": \"Second\"
    },
  \"fields\": [\"_id\", \"displayName\", \"logoUrl\"],
  \"limit\" : 0,
  \"skip\" : 0
}'
```

### [Search-JcSdkSystem](Search-JcSdkSystem.md)
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.

To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.

The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.

This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.

The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the `searchTerm` the record will be returned.


#### Sample Request

Exact search for a list of hostnames
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\": {
    \"or\": [
      {\"hostname\" : \"my-hostname\"},
      {\"hostname\" : \"other-hostname\"}
    ]
  },
  \"fields\" : \"os hostname displayName\"
}'
```

Text search for a hostname or display name
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Text search for a multiple hostnames.
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": [\"my-host\", \"my-other-host\"],
    \"fields\": [\"hostname\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Combining `filter` and `searchFilter` to search for names that match a given OS
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"filter\": {
    \"or\": [
      {\"os\" : \"Ubuntu\"},
      {\"os\" : \"Mac OS X\"}
    ]
  },
  \"fields\": \"os hostname displayName\"
}'
```

### [Search-JcSdkUser](Search-JcSdkUser.md)
Return System Users in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system user.

To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.

The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.

This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.

The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the `searchTerm` the record will be returned.


#### Sample Request

Exact search for a list of system users in a department
```
curl -X POST https://console.jumpcloud.com/api/search/systemusers \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\" : [{\"department\" : \"IT\"}],
  \"fields\" : \"email username sudo\"
}'
```

Text search for system users with and email on a domain
```
curl -X POST https://console.jumpcloud.com/api/search/systemusers \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\" : {
    \"searchTerm\": \"@jumpcloud.com\",
    \"fields\": [\"email\"]
  },
  \"fields\" : \"email username sudo\"
}'
```

Text search for multiple system users
```
curl -X POST https://console.jumpcloud.com/api/search/systemusers \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\" : {
    \"searchTerm\": [\"john\", \"sarah\"],
    \"fields\": [\"username\"]
  },
  \"fields\" : \"email username sudo\"
}'
```

Combining `filter` and `searchFilter` to text search for system users with and email on a domain who are in a list of departments
```
curl -X POST https://console.jumpcloud.com/api/search/systemusers \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"@jumpcloud.com\",
    \"fields\": [\"email\"]
  },
  \"filter\": {
    \"or\": [
      {\"department\" : \"IT\"},
      {\"department\" : \"Sales\"}
    ]
  },
  \"fields\" : \"email username sudo\"
}'
```

### [Set-JcSdkAdministratorUser](Set-JcSdkAdministratorUser.md)
This endpoint allows you to update a user.

### [Set-JcSdkApplication](Set-JcSdkApplication.md)
The endpoint updates a SSO / SAML Application.
Any fields not provided will be reset or created with default values.

### [Set-JcSdkCommand](Set-JcSdkCommand.md)
This endpoint Updates a command based on the command ID and returns the modified command record.

#### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/commands/{CommandID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"name\":\"Test API Command\",
\t\"command\":\"String\",
\t\"user\":\"{UserID}\",
\t\"schedule\":\"\",
\t\"timeout\":\"100\"
}'

```

### [Set-JcSdkOrganization](Set-JcSdkOrganization.md)
This endpoint allows you to update an Organization.

Note: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.

`emailDisclaimer` can only be modified by paying customers.

`hasStripeCustomerId` is deprecated and will be removed.

#### Sample Request

```
curl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"settings\": {
    \"contactName\": \"Admin Name\",
    \"contactEmail\": \"admin@company.com\",
    \"systemUsersCanEdit\":true,
    \"passwordPolicy\": {
      \"enableMaxHistory\": true,
      \"maxHistory\": 3
    }
  }
}'
```

### [Set-JcSdkRadiusServer](Set-JcSdkRadiusServer.md)
This endpoint allows you to update RADIUS servers in your organization.

####
```
curl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{name_update}\",
    \"networkSourceIp\": \"{0.0.0.0}\",
    \"sharedSecret\": \"{secret_password}\",
    \"userLockoutAction\": \"REMOVE\",
    \"userPasswordExpirationAction\": \"MAINTAIN\"
}'
```

### [Set-JcSdkSystem](Set-JcSdkSystem.md)
This endpoint allows you to update a system.

#### Sample Request 
```
curl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"displayName\":\"Name_Update\",
\t\"allowSshPasswordAuthentication\":\"true\",
\t\"allowSshRootLogin\":\"true\",
\t\"allowMultiFactorAuthentication\":\"true\",
\t\"allowPublicKeyAuthentication\":\"false\"
}'
```

### [Set-JcSdkUser](Set-JcSdkUser.md)
This endpoint allows you to update a system user.

#### Sample Request

```
curl -X PUT https://console.jumpcloud.com/api/systemusers/{UserID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"email\":\"{email_address}\",
\t\"firstname\":\"{Name}\",
\t\"lastname\":\"{Name}\"
}'
```

### [Start-JcSdkCommand](Start-JcSdkCommand.md)
This endpoint allows you to run a command.
#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/runCommand \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  -d '{\"_id\":\"{commandID}\", \"systemIds\":[\"systemId\"]}'
```

### [Stop-JcSdkSystem](Stop-JcSdkSystem.md)
This endpoint allows you to run the shutdown command on the specified device.
If a device is offline, the command will be run when the device becomes available.
Only supported on Linux and Windows devices.
Use Apple MDM security commands for macOS devices.

#### Sample Request
```
curl -X POST \\
  https://console.jumpcloud.com/api/systems/{system_id}/command/builtin/shutdown \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d {}
```

### [Sync-JcSdkUserMfa](Sync-JcSdkUserMfa.md)
This endpoint allows you to re-sync a user's mfa enrollment status

#### Sample Request
```
curl -X POST \\
  https://console.jumpcloud.com/api/systemusers/{UserID}/mfasync \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\

```

### [Unlock-JcSdkUser](Unlock-JcSdkUser.md)
This endpoint allows you to unlock a user's account.


