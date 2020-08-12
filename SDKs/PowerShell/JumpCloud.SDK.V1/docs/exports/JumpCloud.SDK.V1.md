---
Module Name: JumpCloud.SDK.V1
Module Guid: deb3e994-aca4-4aec-b0ae-11c312d838a5
Download Help Link: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v1
Help Version: 1.0.0.0
Locale: en-US
---

# JumpCloud.SDK.V1 Module
## Description
The JumpCloud V1 PowerShell SDK

## JumpCloud.SDK.V1 Cmdlets
### [Get-JcSdkApplication](Get-JcSdkApplication.md)
The endpoint retrieves an SSO / SAML Application.

### [Get-JcSdkApplicationTemplate](Get-JcSdkApplicationTemplate.md)
The endpoint returns a specific SSO / SAML Application Template.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/application-templates/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n\n```

### [Get-JcSdkCommand](Get-JcSdkCommand.md)
This endpoint returns a specific command based on the command ID.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/commands/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n```

### [Get-JcSdkCommandFile](Get-JcSdkCommandFile.md)
This endpoint returns the uploaded file(s) associated with a specific command.\n\n#### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/files/command/{commandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n  ```

### [Get-JcSdkCommandResult](Get-JcSdkCommandResult.md)
This endpoint returns a specific command result.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/commandresults/{CommandResultID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n  ```

### [Get-JcSdkOrganization](Get-JcSdkOrganization.md)
This endpoint returns a particular Organization.\n\n#### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkRadiusServer](Get-JcSdkRadiusServer.md)
This endpoint allows you to get a RADIUS server in your organization.\n\n#### \n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n```

### [Get-JcSdkSystem](Get-JcSdkSystem.md)
This endpoint returns an individual system.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/systems/{SystemID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n  ```

### [Get-JcSdkSystemUser](Get-JcSdkSystemUser.md)
This endpoint returns a particular System User.\n\n#### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/systemusers/{UserID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkSystemUserSshKey](Get-JcSdkSystemUserSshKey.md)
This endpoint will return a specific System User's public SSH key.

### [Invoke-JcSdkCommandTrigger](Invoke-JcSdkCommandTrigger.md)
This endpoint allows you to launch a command based on a defined trigger.\n\n#### Sample Requests\n\n**Launch a Command via a Trigger**\n\n```\ncurl --silent \\\n     -X 'POST' \\\n     -H \"x-api-key: {API_KEY}\" \\\n     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"\n```\n**Launch a Command via a Trigger passing a JSON object to the command**\n```\ncurl --silent \\\n     -X 'POST' \\\n     -H \"x-api-key: {API_KEY}\" \\\n     -H 'Accept: application/json' \\\n     -H 'Content-Type: application/json' \\\n     -d '{ \"srcip\":\"192.168.2.32\", \"attack\":\"Cross Site Scripting Attempt\" }' \\\n     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"\n```

### [Invoke-JcSdkExpireSystemUserPassword](Invoke-JcSdkExpireSystemUserPassword.md)
This endpoint allows you to expire a user's password.

### [Invoke-JcSdkInvokeCommand](Invoke-JcSdkInvokeCommand.md)
This endpoint allows you to run a command.

### [New-JcSdkApplication](New-JcSdkApplication.md)
The endpoint adds a new SSO / SAML Applications.

### [New-JcSdkCommand](New-JcSdkCommand.md)
This endpoint allows you to create a new command.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/commands/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"name\":\"Test API Command\",\n\t\"command\":\"String\",\n\t\"user\":\"{UserID}\",\n\t\"schedule\":\"\",\n\t\"timeout\":\"100\"\n}'\n\n```

### [New-JcSdkRadiusServer](New-JcSdkRadiusServer.md)
This endpoint allows you to create RADIUS servers in your organization.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/radiusservers/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{test_radius}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"sharedSecret\":\"{secretpassword}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```

### [New-JcSdkSystemUser](New-JcSdkSystemUser.md)
This endpoint allows you to create a new system user.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"username\":\"{username}\",\n\t\"email\":\"{email_address}\",\n\t\"firstname\":\"{Name}\",\n\t\"lastname\":\"{Name}\"\n}'\n```

### [New-JcSdkSystemUserSshKey](New-JcSdkSystemUserSshKey.md)
This endpoint will create a specific System User's Public SSH Key.

### [Remove-JcSdkApplication](Remove-JcSdkApplication.md)
The endpoint deletes an SSO / SAML Application.

### [Remove-JcSdkCommand](Remove-JcSdkCommand.md)
This endpoint deletes a specific command based on the Command ID.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/commands/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Remove-JcSdkCommandResult](Remove-JcSdkCommandResult.md)
This endpoint deletes a specific command result.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/commandresults/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n  ````

### [Remove-JcSdkRadiusServer](Remove-JcSdkRadiusServer.md)
This endpoint allows you to delete RADIUS servers in your organization.\n```\ncurl -X DELETE https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n```

### [Remove-JcSdkSystem](Remove-JcSdkSystem.md)
This endpoint allows you to delete a system.
This command will cause the system to uninstall the JumpCloud agent from its self which can can take about a minute.
If the system is not connected to JumpCloud the system record will simply be removed.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/systems/{SystemID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Remove-JcSdkSystemUser](Remove-JcSdkSystemUser.md)
This endpoint allows you to delete a particular system user.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/systemusers/{UserID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n```

### [Remove-JcSdkSystemUserSshKey](Remove-JcSdkSystemUserSshKey.md)
This endpoint will delete a specific System User's SSH Key.

### [Reset-JcSdkSystemUserMfa](Reset-JcSdkSystemUserMfa.md)
This endpoint allows you to reset the TOTP key for a specified system user and put them in an TOTP MFA enrollment period.
This will result in the user being prompted to setup TOTP MFA when logging into userportal.
Please be aware that if the user does not complete TOTP MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require TOTP MFA.\n\nPlease refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.
\n\n#### Sample Request \n```\ncurl -X POST \\\n  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'\n  \n\n```

### [Search-JcSdkOrganization](Search-JcSdkOrganization.md)
This endpoint will return Organization data based on your search parameters.
This endpoint WILL NOT allow you to add a new Organization.\n\nYou can use the supported parameters and pass those in the body of request.
\n\nThe parameters must be passed as Content-Type application/json.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/search/organizations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"search\":{\n    \"fields\" : [\"settings.name\"],\n    \"searchTerm\": \"Second\"\n    },\n  \"fields\": [\"_id\", \"displayName\", \"logoUrl\"],\n  \"limit\" : 0,\n  \"skip\" : 0\n}'\n```

### [Search-JcSdkSystem](Search-JcSdkSystem.md)
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.
\n\nThis allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the`searchTerm` the record will be returned.\n\n\n#### Sample Request\n\nExact search for a list of hostnames\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"filter\": {\n    \"or\": [\n      {\"hostname\" : \"my-hostname\"},\n      {\"hostname\" : \"other-hostname\"}\n    ]\n  },\n  \"fields\" : \"os hostname displayName\"\n}'\n```\n\nText search for a hostname or display name\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```\n\nCombining `filter` and `searchFilter` to search for names that match a given OS\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"filter\": {\n    \"or\": [\n      {\"os\" : \"Ubuntu\"},\n      {\"os\" : \"Mac OS X\"}\n    ]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```

### [Search-JcSdkSystemUser](Search-JcSdkSystemUser.md)
Return System Users in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system user.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.
\n\nThis allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the`searchTerm` the record will be returned.\n\n\n#### Sample Request\n\nExact search for a list of system users in a department\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"filter\" : [{\"department\" : \"IT\"}],\n  \"fields\" : \"email username sudo\"\n}'\n```\n\nText search for system users with and email on a domain\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\" : {\n    \"searchTerm\": \"@jumpcloud.com\",\n    \"fields\": [\"email\"]\n  },\n  \"fields\" : \"email username sudo\"\n}'\n```\n\nCombining `filter` and `searchFilter` to text search for system users with and email on a domain who are in a list of departments\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"@jumpcloud.com\",\n    \"fields\": [\"email\"]\n  },\n  \"filter\": {\n    \"or\": [\n      {\"department\" : \"IT\"},\n      {\"department\" : \"Sales\"}\n    ]\n  },\n  \"fields\" : \"email username sudo\"\n}'\n```

### [Set-JcSdkApplication](Set-JcSdkApplication.md)
The endpoint updates a SSO / SAML Application.

### [Set-JcSdkCommand](Set-JcSdkCommand.md)
This endpoint Updates a command based on the command ID and returns the modified command record.\n\n#### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/commands/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"name\":\"Test API Command\",\n\t\"command\":\"String\",\n\t\"user\":\"{UserID}\",\n\t\"schedule\":\"\",\n\t\"timeout\":\"100\"\n}'\n\n```

### [Set-JcSdkOrganization](Set-JcSdkOrganization.md)
This endpoint allows you to update an Organization.\n\nNote: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.\n\n`hasStripeCustomerId` is deprecated and will be removed.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"settings\": {\n    \"contactName\": \"Admin Name\",\n    \"contactEmail\": \"admin@company.com\",\n    \"systemUsersCanEdit\":true,\n    \"passwordPolicy\": {\n      \"enableMaxHistory\": true,\n      \"maxHistory\": 3\n    }\n  }\n}'\n```

### [Set-JcSdkRadiusServer](Set-JcSdkRadiusServer.md)
This endpoint allows you to update RADIUS servers in your organization.\n\n#### \n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{name_update}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"sharedSecret\": \"{secret_password}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```

### [Set-JcSdkSystem](Set-JcSdkSystem.md)
This endpoint allows you to update a system.\n\n#### Sample Request \n```\ncurl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"displayName\":\"Name_Update\",\n\t\"allowSshPasswordAuthentication\":\"true\",\n\t\"allowSshRootLogin\":\"true\",\n\t\"allowMultiFactorAuthentication\":\"true\",\n\t\"allowPublicKeyAuthentication\":\"false\"\n}'\n```

### [Set-JcSdkSystemUser](Set-JcSdkSystemUser.md)
This endpoint allows you to update a system user.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/systemusers/{UserID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"email\":\"{email_address}\",\n\t\"firstname\":\"{Name}\",\n\t\"lastname\":\"{Name}\"\n}'\n```

### [Unlock-JcSdkSystemUser](Unlock-JcSdkSystemUser.md)
This endpoint allows you to unlock a user's account.

