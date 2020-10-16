---
Module Name: JumpCloud.SDK.V2
Module Guid: 3b4a63aa-c392-495c-bfd9-7733c8467906
Download Help Link: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v2
Help Version: 1.0.0.0
Locale: en-US
---

# JumpCloud.SDK.V2 Module
## Description
The JumpCloud V2 PowerShell SDK

## JumpCloud.SDK.V2 Cmdlets
### [Clear-JcSdkAppleMdmDevice](Clear-JcSdkAppleMdmDevice.md)
Erases a DEP-enrolled device.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/erase \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

### [Get-JcSdkActiveDirectory](Get-JcSdkActiveDirectory.md)
This endpoint returns a specific Active Directory.\n\n#### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkActiveDirectoryAssociation](Get-JcSdkActiveDirectoryAssociation.md)
This endpoint returns the direct associations of this Active Directory instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Active Directory and Users.\n\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID}/associations?targets=user \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkActiveDirectoryTraverseUserGroup](Get-JcSdkActiveDirectoryTraverseUserGroup.md)
This endpoint will return all Users Groups bound to an Active Directory instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Active Directory instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this Active Directory instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID}/usergroups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkAppleMdm](Get-JcSdkAppleMdm.md)
Get a list of all Apple MDM configurations.
An empty topic indicates that a signed certificate from Apple has not been provided to the PUT endpoint yet.\n\nNote: currently only one MDM configuration per organization is supported.\n\n#### Sample Request\n```\ncurl https://console.jumpcloud.com/api/v2/applemdms \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkAppleMdmCsr](Get-JcSdkAppleMdmCsr.md)
Retrieves an Apple MDM signed CSR Plist for an organization.
The user must supply the returned plist to Apple for signing, and then provide the certificate provided by Apple back into the PUT API.\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{APPLE_MDM_ID}/csr \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkAppleMdmDepKey](Get-JcSdkAppleMdmDepKey.md)
Retrieves an Apple MDM DEP Public Key.

### [Get-JcSdkAppleMdmDevice](Get-JcSdkAppleMdmDevice.md)
Lists all Apple MDM devices.\n\nThe filter and sort queries will allow the following fields:\n`createdAt`\n`depRegistered`\n`enrolled`\n`id`\n`osVersion`\n`serialNumber`\n`udid`\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices \\\n  -H 'accept: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

### [Get-JcSdkAppleMdmEnrollmentProfile](Get-JcSdkAppleMdmEnrollmentProfile.md)
Get an enrollment profile\n\nCurrently only requesting the mobileconfig is supported.\n\n#### Sample Request\n\n```\ncurl https://console.jumpcloud.com/api/v2/applemdms/{APPLE_MDM_ID}/enrollmentprofiles/{ID} \\\n  -H 'accept: application/x-apple-aspen-config' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkApplication](Get-JcSdkApplication.md)
The endpoint retrieves an Application.

### [Get-JcSdkApplicationAssociation](Get-JcSdkApplicationAssociation.md)
This endpoint will return the _direct_ associations of an Application.
A direct association can be a non-homogeneous relationship between 2 different objects, for example Applications and User Groups.\n\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/applications/{Application_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkApplicationTraverseUser](Get-JcSdkApplicationTraverseUser.md)
This endpoint will return all Users bound to an Application, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Application to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this Application.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/applications/{Application_ID}/users \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkApplicationTraverseUserGroup](Get-JcSdkApplicationTraverseUserGroup.md)
This endpoint will return all Users Groups bound to an Application, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates  each path from this Application to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this Application.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/applications/{Application_ID}/usergroups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkBulkUserResult](Get-JcSdkBulkUserResult.md)
This endpoint will return the results of particular user import or update job request.\n\n#### Sample Request\n```\ncurl -X GET \\\n  https://console.jumpcloud.com/api/v2/bulk/users/{ImportJobID}/results \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkCommandAssociation](Get-JcSdkCommandAssociation.md)
This endpoint will return the _direct_ associations of this Command.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Commands and User Groups.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/commands/{Command_ID}/associations?targets=system_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkCommandTraverseSystem](Get-JcSdkCommandTraverseSystem.md)
This endpoint will return all Systems bound to a Command, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Command to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this Command.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/commands/{Command_ID}/systems \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkCommandTraverseSystemGroup](Get-JcSdkCommandTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a Command, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Command to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Command.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/commands/{Command_ID}/systemgroups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkDirectory](Get-JcSdkDirectory.md)
This endpoint returns all active directories (LDAP, O365 Suite, G-Suite).\n\n#### Sample Request\n```\n curl -X GET https://console.jumpcloud.com/api/v2/directories \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkDuoAccount](Get-JcSdkDuoAccount.md)
This endpoint returns a specific Duo account.\n\n#### Sample Request\n```\ncurl https://console.jumpcloud.com/api/v2/duo/accounts/{id} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkDuoApplication](Get-JcSdkDuoApplication.md)
This endpoint returns a specific Duo application that is associated with the specified Duo account.\n\n#### Sample Request\n```\n  curl https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications/{APPLICATION_ID} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGroup](Get-JcSdkGroup.md)
This endpoint returns all Groups that exist in your organization.\n\n#### Available filter fields:\n  - `name`\n  - `disabled`\n  - `type`\n\n#### Sample Request\n\n```\n  curl -X GET \\\n  https://console.jumpcloud.com/api/v2/groups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGSuite](Get-JcSdkGSuite.md)
This endpoint returns a specific G Suite.\n\n##### Sample Request\n\n```\n curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGSuiteAssociation](Get-JcSdkGSuiteAssociation.md)
This endpoint returns the _direct_ associations of this G Suite instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.\n\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGSuiteTranslationRule](Get-JcSdkGSuiteTranslationRule.md)
This endpoint returns a specific translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.\n\n###### Sample Request\n\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkGSuiteTraverseUser](Get-JcSdkGSuiteTraverseUser.md)
This endpoint will return all Users bound to a G Suite instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this G Suite instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this G Suite instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/users \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGSuiteTraverseUserGroup](Get-JcSdkGSuiteTraverseUserGroup.md)
This endpoint will return all User Groups bound to an G Suite instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this G Suite instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this G Suite instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{GSuite_ID}/usergroups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGSuiteUserToImport](Get-JcSdkGSuiteUserToImport.md)
Lists G Suite users available for import.

### [Get-JcSdkLdapServer](Get-JcSdkLdapServer.md)
This endpoint returns a specific LDAP server.\n\n##### Sample Request\n\n```\n curl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkLdapServerAssociation](Get-JcSdkLdapServerAssociation.md)
This endpoint returns the _direct_ associations of this LDAP Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.\n\n#### Sample Request\n\n```\n curl -X GET 'https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkLdapServerSambaDomain](Get-JcSdkLdapServerSambaDomain.md)
This endpoint returns a specific samba domain for an LDAP server.\n\n##### Sample Request\n```\ncurl -X GET \\\n  https://console.jumpcloud.com/api/v2/ldapservers/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkLdapServerTraverseUser](Get-JcSdkLdapServerTraverseUser.md)
This endpoint will return all Users bound to an LDAP Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this LDAP server instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this LDAP server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkLdapServerTraverseUserGroup](Get-JcSdkLdapServerTraverseUserGroup.md)
This endpoint will return all Users Groups bound to a LDAP Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this LDAP server instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this LDAP server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkOffice365](Get-JcSdkOffice365.md)
This endpoint returns a specific Office 365 instance.\n\n#####\n\nSample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkOffice365Association](Get-JcSdkOffice365Association.md)
This endpoint returns _direct_ associations of an Office 365 instance.\n\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID}/associations?targets=user_group' \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkOffice365TranslationRule](Get-JcSdkOffice365TranslationRule.md)
This endpoint returns a specific translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n###### Sample Request\n\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkOffice365TraverseUser](Get-JcSdkOffice365TraverseUser.md)
This endpoint will return all Users bound to an Office 365 instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Office 365 instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this Office 365 instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkOffice365TraverseUserGroup](Get-JcSdkOffice365TraverseUserGroup.md)
This endpoint will return all Users Groups bound to an Office 365 instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Office 365 instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this Office 365 instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkPolicy](Get-JcSdkPolicy.md)
This endpoint returns a specific policy.\n\n###### Sample Request\n\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/policies/{PolicyID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkPolicyAssociation](Get-JcSdkPolicyAssociation.md)
This endpoint returns the _direct_ associations of a Policy.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Policies and Systems.\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/associations?targets=system_group \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkPolicyResult](Get-JcSdkPolicyResult.md)
This endpoint will return the policy results for a specific policy.\n\n##### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/policyresults/{Policy_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkPolicyStatus](Get-JcSdkPolicyStatus.md)
This endpoint returns the policy results for a particular system.\n\n##### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/policystatuses \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkPolicyTemplate](Get-JcSdkPolicyTemplate.md)
This endpoint returns a specific policy template.\n\n#### Sample Request\n```\n curl -X GET https://console.jumpcloud.com/api/v2/policies/{Policy_ID}\\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkPolicyTraverseSystem](Get-JcSdkPolicyTraverseSystem.md)
This endpoint will return all Systems bound to a Policy, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Policy to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this Policy.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkPolicyTraverseSystemGroup](Get-JcSdkPolicyTraverseSystemGroup.md)
This endpoint will return all Systems Groups bound to a Policy, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Policy to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Policy.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET  https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkProviderAdministrator](Get-JcSdkProviderAdministrator.md)
This endpoint returns a list of the Administrators associated with the Provider.
You must be associated with the provider to use this route.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkRadiusServerAssociation](Get-JcSdkRadiusServerAssociation.md)
This endpoint returns the _direct_ associations of a Radius Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Radius Servers and Users.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/radiusservers/{RADIUS_ID}/associations?targets=user_group \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkRadiusServerTraverseUser](Get-JcSdkRadiusServerTraverseUser.md)
This endpoint will return all Users bound to a RADIUS Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this RADIUS server instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this RADIUS server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkRadiusServerTraverseUserGroup](Get-JcSdkRadiusServerTraverseUserGroup.md)
This endpoint will return all Users Groups bound to a RADIUS Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this RADIUS server instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this RADIUS server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/radiusservers/{RADIUS_ID}/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkSystemAssociation](Get-JcSdkSystemAssociation.md)
This endpoint returns the _direct_ associations of a System.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations?targets=user \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkSystemFdeKey](Get-JcSdkSystemFdeKey.md)
This endpoint will return the current (latest) fde key saved for a system.

### [Get-JcSdkSystemGroup](Get-JcSdkSystemGroup.md)
This endpoint returns the details of a System Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkSystemGroupAssociation](Get-JcSdkSystemGroupAssociation.md)
This endpoint returns the _direct_ associations of a System Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example System Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/associations?targets=user \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkSystemGroupMember](Get-JcSdkSystemGroupMember.md)
This endpoint returns the system members of a System Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkSystemGroupMembership](Get-JcSdkSystemGroupMembership.md)
This endpoint returns all Systems that are a member of this System Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID/membership \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkSystemGroupTraverseCommand](Get-JcSdkSystemGroupTraverseCommand.md)
This endpoint will return all Commands bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding Command; this array represents all grouping and/or associations that would have to be removed to deprovision the Command from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/commands \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkSystemGroupTraversePolicy](Get-JcSdkSystemGroupTraversePolicy.md)
This endpoint will return all Policies bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding Policy; this array represents all grouping and/or associations that would have to be removed to deprovision the Policy from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\nThis endpoint is not public yet as we haven't finished the code.\n\n##### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkSystemGroupTraverseUser](Get-JcSdkSystemGroupTraverseUser.md)
This endpoint will return all Users bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkSystemGroupTraverseUserGroup](Get-JcSdkSystemGroupTraverseUserGroup.md)
This endpoint will return all User Groups bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkSystemInsightAlf](Get-JcSdkSystemInsightAlf.md)
Valid filter fields are `system_id` and `global_state`.

### [Get-JcSdkSystemInsightAlfException](Get-JcSdkSystemInsightAlfException.md)
Valid filter fields are `system_id` and `state`.

### [Get-JcSdkSystemInsightAlfExplicitAuth](Get-JcSdkSystemInsightAlfExplicitAuth.md)
Valid filter fields are `system_id` and `process`.

### [Get-JcSdkSystemInsightApp](Get-JcSdkSystemInsightApp.md)
Valid filter fields are `system_id` and `bundle_name`.

### [Get-JcSdkSystemInsightAppCompatShim](Get-JcSdkSystemInsightAppCompatShim.md)
Valid filter fields are `system_id` and `enabled`.

### [Get-JcSdkSystemInsightAuthorizedKey](Get-JcSdkSystemInsightAuthorizedKey.md)
Valid filter fields are `system_id` and `uid`.

### [Get-JcSdkSystemInsightBattery](Get-JcSdkSystemInsightBattery.md)
Valid filter fields are `system_id` and `health`.

### [Get-JcSdkSystemInsightBitlockerInfo](Get-JcSdkSystemInsightBitlockerInfo.md)
Valid filter fields are `system_id` and `protection_status`.

### [Get-JcSdkSystemInsightBrowserPlugin](Get-JcSdkSystemInsightBrowserPlugin.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightCertificate](Get-JcSdkSystemInsightCertificate.md)
Valid filter fields are `system_id` and `common_name`.

### [Get-JcSdkSystemInsightChromeExtension](Get-JcSdkSystemInsightChromeExtension.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightConnectivity](Get-JcSdkSystemInsightConnectivity.md)
The only valid filter field is `system_id`.

### [Get-JcSdkSystemInsightCrash](Get-JcSdkSystemInsightCrash.md)
Valid filter fields are `system_id` and `identifier`.

### [Get-JcSdkSystemInsightCupDestination](Get-JcSdkSystemInsightCupDestination.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightDiskEncryption](Get-JcSdkSystemInsightDiskEncryption.md)
Valid filter fields are `system_id` and `encryption_status`.

### [Get-JcSdkSystemInsightDiskInfo](Get-JcSdkSystemInsightDiskInfo.md)
Valid filter fields are `system_id` and `disk_index`.

### [Get-JcSdkSystemInsightDnsResolver](Get-JcSdkSystemInsightDnsResolver.md)
Valid filter fields are `system_id` and `type`.

### [Get-JcSdkSystemInsightEtcHost](Get-JcSdkSystemInsightEtcHost.md)
Valid filter fields are `system_id` and `address`.

### [Get-JcSdkSystemInsightFirefoxAddon](Get-JcSdkSystemInsightFirefoxAddon.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightGroup](Get-JcSdkSystemInsightGroup.md)
Valid filter fields are `system_id` and `groupname`.

### [Get-JcSdkSystemInsightIeExtension](Get-JcSdkSystemInsightIeExtension.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightInterfaceAddress](Get-JcSdkSystemInsightInterfaceAddress.md)
Valid filter fields are `system_id` and `address`.

### [Get-JcSdkSystemInsightInterfaceDetail](Get-JcSdkSystemInsightInterfaceDetail.md)
Valid filter fields are `system_id` and `interface`.

### [Get-JcSdkSystemInsightKernelInfo](Get-JcSdkSystemInsightKernelInfo.md)
Valid filter fields are `system_id` and `version`.

### [Get-JcSdkSystemInsightLaunchd](Get-JcSdkSystemInsightLaunchd.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightLoggedinUser](Get-JcSdkSystemInsightLoggedinUser.md)
Valid filter fields are `system_id` and `user`.

### [Get-JcSdkSystemInsightLogicalDrive](Get-JcSdkSystemInsightLogicalDrive.md)
Valid filter fields are `system_id` and `device_id`.

### [Get-JcSdkSystemInsightManagedPolicy](Get-JcSdkSystemInsightManagedPolicy.md)
Valid filter fields are `system_id` and `domain`.

### [Get-JcSdkSystemInsightMount](Get-JcSdkSystemInsightMount.md)
Valid filter fields are `system_id` and `path`.

### [Get-JcSdkSystemInsightOSVersion](Get-JcSdkSystemInsightOSVersion.md)
Valid filter fields are `system_id` and `version`.

### [Get-JcSdkSystemInsightPatch](Get-JcSdkSystemInsightPatch.md)
Valid filter fields are `system_id` and `hotfix_id`.

### [Get-JcSdkSystemInsightProgram](Get-JcSdkSystemInsightProgram.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightPythonPackage](Get-JcSdkSystemInsightPythonPackage.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSafariExtension](Get-JcSdkSystemInsightSafariExtension.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightScheduledTask](Get-JcSdkSystemInsightScheduledTask.md)
Valid filter fields are `system_id` and `enabled`.

### [Get-JcSdkSystemInsightService](Get-JcSdkSystemInsightService.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightShadow](Get-JcSdkSystemInsightShadow.md)
Valid filter fields are `system_id` and `username`.

### [Get-JcSdkSystemInsightSharedFolder](Get-JcSdkSystemInsightSharedFolder.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSharedResource](Get-JcSdkSystemInsightSharedResource.md)
Valid filter fields are `system_id` and `type`.

### [Get-JcSdkSystemInsightSharingPreference](Get-JcSdkSystemInsightSharingPreference.md)
Only valid filed field is `system_id`.

### [Get-JcSdkSystemInsightSipConfig](Get-JcSdkSystemInsightSipConfig.md)
Valid filter fields are `system_id` and `enabled`.

### [Get-JcSdkSystemInsightStartupItem](Get-JcSdkSystemInsightStartupItem.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSystemControl](Get-JcSdkSystemInsightSystemControl.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSystemInfo](Get-JcSdkSystemInsightSystemInfo.md)
Valid filter fields are `system_id` and `cpu_subtype`.

### [Get-JcSdkSystemInsightUptime](Get-JcSdkSystemInsightUptime.md)
Valid filter fields are `system_id` and `days`.

### [Get-JcSdkSystemInsightUsbDevice](Get-JcSdkSystemInsightUsbDevice.md)
Valid filter fields are `system_id` and `model`.

### [Get-JcSdkSystemInsightUser](Get-JcSdkSystemInsightUser.md)
Valid filter fields are `system_id` and `username`.

### [Get-JcSdkSystemInsightUserGroup](Get-JcSdkSystemInsightUserGroup.md)
Only valid filter field is `system_id`.

### [Get-JcSdkSystemInsightUserSshKey](Get-JcSdkSystemInsightUserSshKey.md)
Valid filter fields are `system_id` and `uid`.

### [Get-JcSdkSystemInsightWifiNetwork](Get-JcSdkSystemInsightWifiNetwork.md)
Valid filter fields are `system_id` and `security_type`.

### [Get-JcSdkSystemInsightWifiStatus](Get-JcSdkSystemInsightWifiStatus.md)
Valid filter fields are `system_id` and `security_type`.

### [Get-JcSdkSystemInsightWindowSecurityProduct](Get-JcSdkSystemInsightWindowSecurityProduct.md)
Valid filter fields are `system_id` and `state`.

### [Get-JcSdkSystemMember](Get-JcSdkSystemMember.md)
This endpoint returns all the System Groups a System is a member of.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/memberof \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkSystemTraverseCommand](Get-JcSdkSystemTraverseCommand.md)
This endpoint will return all Commands bound to a System, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System to the corresponding Command; this array represents all grouping and/or associations that would have to be removed to deprovision the Command from this System.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/commands \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkSystemTraversePolicy](Get-JcSdkSystemTraversePolicy.md)
This endpoint will return all Policies bound to a System, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System to the corresponding Policy; this array represents all grouping and/or associations that would have to be removed to deprovision the Policy from this System.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\nThis endpoint is not yet public as we have finish the code.\n\n##### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/{System_ID}/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkSystemTraverseUser](Get-JcSdkSystemTraverseUser.md)
This endpoint will return all Users bound to a System, either directly or indirectly essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this System.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkSystemTraverseUserGroup](Get-JcSdkSystemTraverseUserGroup.md)
This endpoint will return all User Groups bound to a System, either directly or indirectly essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this System.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkUserAssociation](Get-JcSdkUserAssociation.md)
This endpoint returns the _direct_ associations of a User.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Users and Systems.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/associations?targets=system_group \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkUserGroup](Get-JcSdkUserGroup.md)
This endpoint returns the details of a User Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserGroupAssociation](Get-JcSdkUserGroupAssociation.md)
This endpoint returns the _direct_ associations of this User Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example User Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/associations?targets=system \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserGroupMember](Get-JcSdkUserGroupMember.md)
This endpoint returns the user members of a User Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserGroupMembership](Get-JcSdkUserGroupMembership.md)
This endpoint returns all users members that are a member of this User Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/membership \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserGroupTraverseApplication](Get-JcSdkUserGroupTraverseApplication.md)
This endpoint will return all Applications bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding Application; this array represents all grouping and/or associations that would have to be removed to deprovision the Application from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/applications \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserGroupTraverseDirectory](Get-JcSdkUserGroupTraverseDirectory.md)
This endpoint will return all Directories bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding Directory; this array represents all grouping and/or associations that would have to be removed to deprovision the Directories from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/directories \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkUserGroupTraverseGSuite](Get-JcSdkUserGroupTraverseGSuite.md)
This endpoint will return all G Suite Instances bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding G Suite instance; this array represents all grouping and/or associations that would have to be removed to deprovision the G Suite instance from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID/gsuites \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkUserGroupTraverseLdapServer](Get-JcSdkUserGroupTraverseLdapServer.md)
This endpoint will return all LDAP Servers bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding LDAP Server; this array represents all grouping and/or associations that would have to be removed to deprovision the LDAP Server from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/ldapservers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserGroupTraverseOffice365](Get-JcSdkUserGroupTraverseOffice365.md)
This endpoint will return all Office 365 instances bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding Office 365 instance; this array represents all grouping and/or associations that would have to be removed to deprovision the Office 365 instance from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/office365s \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserGroupTraverseRadiusServer](Get-JcSdkUserGroupTraverseRadiusServer.md)
This endpoint will return all RADIUS servers bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding RADIUS Server; this array represents all grouping and/or associations that would have to be removed to deprovision the RADIUS Server from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/radiusservers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkUserGroupTraverseSystem](Get-JcSdkUserGroupTraverseSystem.md)
This endpoint will return all Systems bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserGroupTraverseSystemGroup](Get-JcSdkUserGroupTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserMember](Get-JcSdkUserMember.md)
This endpoint returns all the User Groups a User is a member of.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/memberof \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserTraverseApplication](Get-JcSdkUserTraverseApplication.md)
This endpoint will return all Applications bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding Application; this array represents all grouping and/or associations that would have to be removed to deprovision the Application from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/applications \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserTraverseDirectory](Get-JcSdkUserTraverseDirectory.md)
This endpoint will return all Directories bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding Directory; this array represents all grouping and/or associations that would have to be removed to deprovision the Directory from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/directories \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserTraverseGSuite](Get-JcSdkUserTraverseGSuite.md)
This endpoint will return all G-Suite Instances bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding G Suite instance; this array represents all grouping and/or associations that would have to be removed to deprovision the G Suite instance from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/gsuites \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserTraverseLdapServer](Get-JcSdkUserTraverseLdapServer.md)
This endpoint will return all LDAP Servers bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding LDAP Server; this array represents all grouping and/or associations that would have to be removed to deprovision the LDAP Server from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/ldapservers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserTraverseOffice365](Get-JcSdkUserTraverseOffice365.md)
This endpoint will return all Office 365 Instances bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding Office 365 instance; this array represents all grouping and/or associations that would have to be removed to deprovision the Office 365 instance from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/office365s \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserTraverseRadiusServer](Get-JcSdkUserTraverseRadiusServer.md)
This endpoint will return all RADIUS Servers bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding RADIUS Server; this array represents all grouping and/or associations that would have to be removed to deprovision the RADIUS Server from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/radiusservers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserTraverseSystem](Get-JcSdkUserTraverseSystem.md)
This endpoint will return all Systems bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/systems\\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkUserTraverseSystemGroup](Get-JcSdkUserTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/systemgroups\\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkWorkday](Get-JcSdkWorkday.md)
This endpoint will return  all the available information about an instance of Workday.\n\n#### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/workdays/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkWorkdayWorker](Get-JcSdkWorkdayWorker.md)
This endpoint will return all of the data in your WorkDay Custom Report that has been associated with your WorkDay Instance in JumpCloud.\n\n##### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/workers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n\n```

### [Grant-JcSdkWorkday](Grant-JcSdkWorkday.md)
This endpoint adds an authorization method to a workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"auth\":{\n\t  \"basic\": {\n\t\t\"username\": \"someDeveloper\",\t  \n\t\t\"password\": \"notTheRealPassword\"\n\n\t  }\n\t}\n}'\n\n```

### [Import-JcSdkWorkday](Import-JcSdkWorkday.md)
The endpoint allows you to create a Workday Import request.\n\n#### Sample Request \n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t\t\"email\":\"{email}\",\n\t\t\"firstname\":\"{firstname}\",\n\t\t\"lastname\":\"{firstname}\",\n\t\t\"username\":\"{username}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},\n\t\t\t{\"name\":\"WorkdayID\",\"value\":\"name.name\"}\n\t\t\t]\n\t\t\n\t}\n]\n```

### [Import-JcSdkWorkdayResult](Import-JcSdkWorkdayResult.md)
This endpoint provides a list of job results from the workday import and will contain all imported data from Workday.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import/{ImportJobID}/results \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Lock-JcSdkAppleMdmDevice](Lock-JcSdkAppleMdmDevice.md)
Locks a DEP-enrolled device.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/lock \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

### [New-JcSdkBulkUser](New-JcSdkBulkUser.md)
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t\t\"email\":\"{email}\",\n\t\t\"firstname\":\"{firstname}\",\n\t\t\"lastname\":\"{firstname}\",\n\t\t\"username\":\"{username}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},\n\t\t\t{\"name\":\"Custom\",\"value\":\"attribute\"}\n\t\t]\n\t}\n]\n```

### [New-JcSdkDuoAccount](New-JcSdkDuoAccount.md)
Registers a Duo account for an organization.
Only one Duo account will be allowed,\nin case an organization has a Duo account already a 409 (Conflict) code will be returned.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

### [New-JcSdkDuoApplication](New-JcSdkDuoApplication.md)
Creates a Duo application for your organization and the specified account.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"Application Name\",\n    \"apiHost\": \"api-1234.duosecurity.com\",\n    \"integrationKey\": \"1234\",\n    \"secretKey\": \"5678\"\n  }'\n```

### [New-JcSdkGSuiteTranslationRule](New-JcSdkGSuiteTranslationRule.md)
This endpoint allows you to create a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```

### [New-JcSdkLdapServerSambaDomain](New-JcSdkLdapServerSambaDomain.md)
This endpoint allows you to create a samba domain for an LDAP server.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\"sid\":\"{SID_ID}\",\n\"name\":\"{WORKGROUP_NAME}\"\n}'\n```

### [New-JcSdkOffice365TranslationRule](New-JcSdkOffice365TranslationRule.md)
This endpoint allows you to create a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```

### [New-JcSdkPolicy](New-JcSdkPolicy.md)
This endpoint allows you to create a policy.
Given the amount of configurable parameters required to create a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Policy_Parameters}\n}'\n\n```

### [New-JcSdkProviderAdmin](New-JcSdkProviderAdmin.md)
This endpoint allows you to create a provider administrator.
You must be associated with the provider to use this route.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"email\":\"{ADMIN_EMAIL}\"\n  }'\n```

### [New-JcSdkSystemGroup](New-JcSdkSystemGroup.md)
This endpoint allows you to create a new System Group.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```

### [New-JcSdkUserGroup](New-JcSdkUserGroup.md)
This endpoint allows you to create a new User Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```

### [New-JcSdkWorkday](New-JcSdkWorkday.md)
This endpoint allows you to create a new workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\nCurrently, only one instance is allowed and it must be `Workday Import`.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"name\": \"Workday2\",\n  \"reportUrl\":\"https://workday.com/ccx/service/customreport2/gms/user/reportname?format=json\",\n  \"auth\": {\n    \"basic\": {\n      \"username\": \"someDeveloper\",\n      \"password\": \"notTheRealPassword\"\n    }\n  }\n}'\n```

### [Remove-JcSdkAppleMdm](Remove-JcSdkAppleMdm.md)
Removes an Apple MDM configuration.\n\nWarning: This is a destructive operation and will remove your Apple Push Certificates.
We will no longer be able to manage your devices and the only recovery option is to re-register all devices into MDM.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/applemdms/{id} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Remove-JcSdkDuoAccount](Remove-JcSdkDuoAccount.md)
Removes the specified Duo account, an error will be returned if the account has some Duo application used in a protected resource.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/duo/accounts/{id} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Remove-JcSdkDuoApplication](Remove-JcSdkDuoApplication.md)
Deletes the specified Duo application, an error will be returned if the application is used in a protected resource.\n\n#### Sample Request\n```\n  curl -X DELETE https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications/{APPLICATION_ID} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}''\n```

### [Remove-JcSdkGSuiteTranslationRule](Remove-JcSdkGSuiteTranslationRule.md)
This endpoint allows you to delete a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.\n\n#### Sample Request\n\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Remove-JcSdkLdapServerSambaDomain](Remove-JcSdkLdapServerSambaDomain.md)
This endpoint allows you to delete a samba domain from an LDAP server.\n\n##### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Remove-JcSdkOffice365TranslationRule](Remove-JcSdkOffice365TranslationRule.md)
This endpoint allows you to delete a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n#### Sample Request\n\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Remove-JcSdkPolicy](Remove-JcSdkPolicy.md)
This endpoint allows you to delete a policy.\n\n#### Sample Request\n\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/policies/5a837ecd232e110d4291e6b9 \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Remove-JcSdkSystemGroup](Remove-JcSdkSystemGroup.md)
This endpoint allows you to delete a System Group.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Remove-JcSdkUserGroup](Remove-JcSdkUserGroup.md)
This endpoint allows you to delete a User Group.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/usergroups/{GroupID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Remove-JcSdkWorkdayAuthorization](Remove-JcSdkWorkdayAuthorization.md)
Removes any and all authorization methods from the workday instance\n\n##### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Restart-JcSdkAppleMdmDevice](Restart-JcSdkAppleMdmDevice.md)
Restarts a DEP-enrolled device.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/restart \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

### [Set-JcSdkAppleMdm](Set-JcSdkAppleMdm.md)
Updates an Apple MDM configuration.
This endpoint is used to supply JumpCloud with a signed certificate from Apple in order to finalize the setup and allow JumpCloud to manage your devices.
It may also be used to update the DEP Settings.\n\n#### Sample Request\n```\n  curl -X PUT https://console.jumpcloud.com/api/v2/applemdms/{ID} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"MDM name\",\n    \"appleSignedCert\": \"{CERTIFICATE}\",\n    \"encryptedDepServerToken\": \"{SERVER_TOKEN}\",\n    \"dep\": {\n      \"welcomeScreen\": {\n        \"title\": \"Welcome\",\n        \"paragraph\": \"In just a few steps, you will be working securely from your Mac.\",\n        \"button\": \"continue\",\n      },\n    },\n  }'\n```

### [Set-JcSdkApplicationAssociation](Set-JcSdkApplicationAssociation.md)
This endpoint allows you to manage the _direct_ associations of an Application.
A direct association can be a non-homogeneous relationship between 2 different objects, for example Application and User Groups.\n\n#### Sample Request\n```\ncurl -X POST 'https://console.jumpcloud.com/api/v2/applications/{Application_ID}/associations' \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```

### [Set-JcSdkCommandAssociation](Set-JcSdkCommandAssociation.md)
This endpoint will allow you to manage the _direct_ associations of this Command.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Commands and User Groups.\n\n\n#### Sample Request\n```\n curl -X POST https://console.jumpcloud.com/api/v2/commands/{Command_ID}/associations \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system_group\",\n    \"id\": \"Group_ID\"\n}'\n```

### [Set-JcSdkDuoApplication](Set-JcSdkDuoApplication.md)
Updates the specified Duo application.\n\n#### Sample Request\n```\n  curl -X PUT https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications/{APPLICATION_ID} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"Application Name\",\n    \"apiHost\": \"api-1234.duosecurity.com\",\n    \"integrationKey\": \"1234\",\n    \"secretKey\": \"5678\"\n  }'\n```

### [Set-JcSdkGSuiteAssociation](Set-JcSdkGSuiteAssociation.md)
This endpoint returns the _direct_ associations of this G Suite instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```

### [Set-JcSdkLdapServerAssociation](Set-JcSdkLdapServerAssociation.md)
This endpoint allows you to manage the _direct_ associations of a LDAP Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"{User_ID}\"\n}'\n```

### [Set-JcSdkLdapServerSambaDomain](Set-JcSdkLdapServerSambaDomain.md)
This endpoint allows you to update the samba domain information for an LDAP server.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\"sid\":\"{SID_ID}\",\n\"name\":\"{WORKGROUP_NAME}\"\n}'\n\n```

### [Set-JcSdkOffice365Association](Set-JcSdkOffice365Association.md)
This endpoint allows you to manage the _direct_ associations of a Office 365 instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```

### [Set-JcSdkPolicy](Set-JcSdkPolicy.md)
This endpoint allows you to update a policy.
Given the amount of configurable parameters required to update a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY' \\\n  -d '{\n    {Policy_Parameters}\n}'\n```

### [Set-JcSdkPolicyAssociation](Set-JcSdkPolicyAssociation.md)
This endpoint allows you to manage the _direct_ associations of a Policy.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Policies and Systems.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/associations/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```

### [Set-JcSdkRadiusServerAssociation](Set-JcSdkRadiusServerAssociation.md)
This endpoint allows you to manage the _direct_ associations of a Radius Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Radius Servers and Users.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/radiusservers/{RADIUS_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\n\"type\":\"user\", \n\"id\":\"{USER_ID}\", \n\"op\":\"add\"\n\t\n}'\n```

### [Set-JcSdkSystemAssociation](Set-JcSdkSystemAssociation.md)
This endpoint allows you to manage the _direct_ associations of a System.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n   \"attributes\": {\n      \"sudo\": {\n         \"enabled\": true,\n         \"withoutPassword\": false\n      }\n   },\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"UserID\"\n}'\n\n```

### [Set-JcSdkSystemGroup](Set-JcSdkSystemGroup.md)
This endpoint allows you to do a full update of the System Group.\n\n#### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"Name_Update\"\n}'\n```

### [Set-JcSdkSystemGroupAssociation](Set-JcSdkSystemGroupAssociation.md)
This endpoint allows you to manage the _direct_ associations of a System Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example System Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"{UserID}\"\n}'\n\n```

### [Set-JcSdkSystemGroupMember](Set-JcSdkSystemGroupMember.md)
This endpoint allows you to manage the system members of a System Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system\",\n    \"id\": \"{System_ID}\"\n}'\n```

### [Set-JcSdkUserAssociation](Set-JcSdkUserAssociation.md)
This endpoint allows you to manage the _direct_ associations of a User.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Users and Systems.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/users/{UserID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n   \"attributes\": {\n      \"sudo\": {\n         \"enabled\": true,\n         \"withoutPassword\": false\n      }\n   },\n   \"op\": \"add\",\n   \"type\": \"system_group\",\n   \"id\": \"{GroupID}\"\n}'

### [Set-JcSdkUserGroup](Set-JcSdkUserGroup.md)
This endpoint allows you to do a full update of the User Group.\n\n#### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/usergroups/{Group_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY' \\\n  -d '{\n \"name\": \"group_update\"\n}'\n\n```

### [Set-JcSdkUserGroupAssociation](Set-JcSdkUserGroupAssociation.md)
This endpoint manages the _direct_ associations of this User Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example User Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system\",\n    \"id\": \"{SystemID}\"\n}'\n\n```

### [Set-JcSdkUserGroupMember](Set-JcSdkUserGroupMember.md)
This endpoint allows you to manage the user members of a User Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"{User_ID}\"\n}'\n```

### [Set-JcSdkWorkday](Set-JcSdkWorkday.md)
This endpoint allows you to update the name and Custom Report URL for a Workday Instance.\n\nCurrently, the name can not be changed from the default of `Workday Import`.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/workdays/{WorkdayID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"reportUrl\":\"{Report_URL}\",\n\t\"name\":\"{Name}\"\n}\t'\n```

### [Stop-JcSdkAppleMdmDevice](Stop-JcSdkAppleMdmDevice.md)
Shuts down a DEP-enrolled device.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/shutdown \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

### [Sync-JcSdkAppleMdmDevice](Sync-JcSdkAppleMdmDevice.md)
Refreshes the list of devices that a JumpCloud admin has added to their virtual MDM in Apple Business Manager - ABM so that they can be DEP enrolled with JumpCloud.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/refreshdepdevices \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

### [Update-JcSdkBulkUser](Update-JcSdkBulkUser.md)
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/1.0/systemusers/update-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"department\":\"{UPDATED_DEPARTMENT}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}\n\t\t]\n\t},\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",\n\t\t\"phoneNumbers\":[\n\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},\n\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}\n\t\t]\n\t}\n]\n```

### [Update-JcSdkGSuite](Update-JcSdkGSuite.md)
This endpoint allows updating some attributes of a G Suite.\n\n##### Sample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"suspend\",\n    \"userPasswordExpirationAction\": \"maintain\"\n  }'\n```

### [Update-JcSdkLdapServer](Update-JcSdkLdapServer.md)
This endpoint allows updating some attributes of an LDAP server.\n\nSample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"remove\",\n    \"userPasswordExpirationAction\": \"disable\"\n  }'\n```

### [Update-JcSdkOffice365](Update-JcSdkOffice365.md)
This endpoint allows updating some attributes of an Office 365 instance.\n\n#####\n\nSample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"maintain\",\n    \"userPasswordExpirationAction\": \"suspend\"\n  }'\n\n```

