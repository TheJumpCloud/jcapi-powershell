---
Module Name: JumpCloud.SDK.V2
Module Guid: ff397964-2121-4c89-a916-34b5c30d7187
Download Help Link: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v2
Help Version: 1.0.0.0
Locale: en-US
---

# JumpCloud.SDK.V2 Module
## Description
The JumpCloud V2 PowerShell SDK

## JumpCloud.SDK.V2 Cmdlets
### [Clear-JcSdkAppleMdmDevice](Clear-JcSdkAppleMdmDevice.md)
Erases a DEP-enrolled device.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/erase \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

### [Clear-JcSdkAppleMdmDeviceActivationLock](Clear-JcSdkAppleMdmDeviceActivationLock.md)
Clears the activation lock on the specified device.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/clearActivationLock \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

### [Get-JcSdkActiveDirectory](Get-JcSdkActiveDirectory.md)
This endpoint returns a specific Active Directory.

#### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkActiveDirectoryAgent](Get-JcSdkActiveDirectoryAgent.md)
This endpoint returns an Active Directory agent.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/activedirectories/{activedirectory_id}/agents/{agent_id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkActiveDirectoryAssociation](Get-JcSdkActiveDirectoryAssociation.md)
This endpoint returns the direct associations of this Active Directory instance.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Active Directory and Users.


#### Sample Request
```
curl -X GET 'https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID}/associations?targets=user \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkActiveDirectoryTraverseUser](Get-JcSdkActiveDirectoryTraverseUser.md)
This endpoint will return all Users bound to an Active Directory instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Active Directory instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this Active Directory instance.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID}/users \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkActiveDirectoryTraverseUserGroup](Get-JcSdkActiveDirectoryTraverseUserGroup.md)
This endpoint will return all Users Groups bound to an Active Directory instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Active Directory instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this Active Directory instance.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID}/usergroups \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkAppleMdm](Get-JcSdkAppleMdm.md)
Get a list of all Apple MDM configurations.
An empty topic indicates that a signed certificate from Apple has not been provided to the PUT endpoint yet.

Note: currently only one MDM configuration per organization is supported.

#### Sample Request
```
curl https://console.jumpcloud.com/api/v2/applemdms \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkAppleMdmDevice](Get-JcSdkAppleMdmDevice.md)
Gets a single Apple MDM device.

#### Sample Request
```
  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id} \\
  -H 'accept: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkAppleMdmEnrollmentProfile](Get-JcSdkAppleMdmEnrollmentProfile.md)
Get a list of enrollment profiles for an apple mdm.

Note: currently only one enrollment profile is supported.

#### Sample Request
```
 curl https://console.jumpcloud.com/api/v2/applemdms/{APPLE_MDM_ID}/enrollmentprofiles \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkApplicationAssociation](Get-JcSdkApplicationAssociation.md)
This endpoint will return the _direct_ associations of an Application.
A direct association can be a non-homogeneous relationship between 2 different objects, for example Applications and User Groups.


#### Sample Request
```
curl -X GET 'https://console.jumpcloud.com/api/v2/applications/{Application_ID}/associations?targets=user_group \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkApplicationTraverseUser](Get-JcSdkApplicationTraverseUser.md)
This endpoint will return all Users bound to an Application, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Application to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this Application.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/applications/{Application_ID}/users \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkApplicationTraverseUserGroup](Get-JcSdkApplicationTraverseUserGroup.md)
This endpoint will return all Users Groups bound to an Application, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates  each path from this Application to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this Application.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/applications/{Application_ID}/usergroups \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkAuthenticationPolicy](Get-JcSdkAuthenticationPolicy.md)
Return a specific authentication policy.

#### Sample Request
```
curl https://console.jumpcloud.com/api/v2/authn/policies/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkBulkUsersResult](Get-JcSdkBulkUsersResult.md)
This endpoint will return the results of particular user import or update job request.

#### Sample Request
```
curl -X GET \\
  https://console.jumpcloud.com/api/v2/bulk/users/{ImportJobID}/results \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkBulkUserState](Get-JcSdkBulkUserState.md)
The endpoint allows you to list scheduled statechange jobs.
#### Sample Request
```
curl -X GET \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json'
```

### [Get-JcSdkCommandAssociation](Get-JcSdkCommandAssociation.md)
This endpoint will return the _direct_ associations of this Command.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Commands and User Groups.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/commands/{Command_ID}/associations?targets=system_group \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkCommandTraverseSystem](Get-JcSdkCommandTraverseSystem.md)
This endpoint will return all Systems bound to a Command, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Command to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this Command.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/commands/{Command_ID}/systems \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkCommandTraverseSystemGroup](Get-JcSdkCommandTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a Command, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Command to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Command.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/commands/{Command_ID}/systemgroups \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkCustomEmailConfiguration](Get-JcSdkCustomEmailConfiguration.md)
Get the custom email configuration for the specified custom email type

### [Get-JcSdkCustomEmailTemplate](Get-JcSdkCustomEmailTemplate.md)
Get the list of custom email templates

### [Get-JcSdkDirectory](Get-JcSdkDirectory.md)
This endpoint returns all active directories (LDAP, O365 Suite, G-Suite).

#### Sample Request
```
 curl -X GET https://console.jumpcloud.com/api/v2/directories \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkDuoAccount](Get-JcSdkDuoAccount.md)
This endpoint returns a specific Duo account.

#### Sample Request
```
curl https://console.jumpcloud.com/api/v2/duo/accounts/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkDuoApplication](Get-JcSdkDuoApplication.md)
This endpoint returns a specific Duo application that is associated with the specified Duo account.

#### Sample Request
```
  curl https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications/{APPLICATION_ID} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkGroup](Get-JcSdkGroup.md)
This endpoint returns all Groups that exist in your organization.

#### Available filter fields:
  - `name`
  - `disabled`
  - `type`

#### Sample Request

```
  curl -X GET \\
  https://console.jumpcloud.com/api/v2/groups \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkGroupSuggestion](Get-JcSdkGroupSuggestion.md)
This endpoint returns available suggestions for a given group
#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/suggestions \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkGSuite](Get-JcSdkGSuite.md)
This endpoint returns a specific G Suite.

##### Sample Request

```
 curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkGSuiteAssociation](Get-JcSdkGSuiteAssociation.md)
This endpoint returns the _direct_ associations of this G Suite instance.

A direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.


#### Sample Request
```
curl -X GET 'https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations?targets=user_group \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkGSuiteTranslationRule](Get-JcSdkGSuiteTranslationRule.md)
This endpoint returns a specific translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.

###### Sample Request

```
  curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkGSuiteTraverseUser](Get-JcSdkGSuiteTraverseUser.md)
This endpoint will return all Users bound to a G Suite instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this G Suite instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this G Suite instance.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
  curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/users \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkGSuiteTraverseUserGroup](Get-JcSdkGSuiteTraverseUserGroup.md)
This endpoint will return all User Groups bound to an G Suite instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this G Suite instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this G Suite instance.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
  curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{GSuite_ID}/usergroups \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkGSuiteUsersToImport](Get-JcSdkGSuiteUsersToImport.md)
Lists G Suite users available for import.

### [Get-JcSdkIPList](Get-JcSdkIPList.md)
Return a specific IP list.

#### Sample Request
```
curl https://console.jumpcloud.com/api/v2/iplists/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkLdapServer](Get-JcSdkLdapServer.md)
This endpoint returns a specific LDAP server.

##### Sample Request

```
 curl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkLdapServerAssociation](Get-JcSdkLdapServerAssociation.md)
This endpoint returns the _direct_ associations of this LDAP Server.

A direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.

#### Sample Request

```
 curl -X GET 'https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations?targets=user_group \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkLdapServerSambaDomain](Get-JcSdkLdapServerSambaDomain.md)
This endpoint returns a specific samba domain for an LDAP server.

##### Sample Request
```
curl -X GET \\
  https://console.jumpcloud.com/api/v2/ldapservers/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkLdapServerTraverseUser](Get-JcSdkLdapServerTraverseUser.md)
This endpoint will return all Users bound to an LDAP Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this LDAP server instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this LDAP server instance.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkLdapServerTraverseUserGroup](Get-JcSdkLdapServerTraverseUserGroup.md)
This endpoint will return all Users Groups bound to a LDAP Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this LDAP server instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this LDAP server instance.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkNextScheduledBulkUserState](Get-JcSdkNextScheduledBulkUserState.md)
This endpoint is used to lookup the next upcoming scheduled state change for each user in the
given list.
The users parameter is limited to 100 items per request.
#### Sample Request
```
curl -X GET \"https://console.jumpcloud.com/api/v2/bulk/userstates/eventlist/next?users={UserID1},{UserID2},{UserID3}\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json'
```

### [Get-JcSdkOffice365](Get-JcSdkOffice365.md)
This endpoint returns a specific Office 365 instance.

#####

Sample Request

```
curl -X GET https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkOffice365Association](Get-JcSdkOffice365Association.md)
This endpoint returns _direct_ associations of an Office 365 instance.


A direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.

#### Sample Request
```
curl -X GET 'https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID}/associations?targets=user_group' \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkOffice365TranslationRule](Get-JcSdkOffice365TranslationRule.md)
This endpoint returns a specific translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.

###### Sample Request

```
  curl -X GET https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkOffice365TraverseUser](Get-JcSdkOffice365TraverseUser.md)
This endpoint will return all Users bound to an Office 365 instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Office 365 instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this Office 365 instance.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID}/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkOffice365TraverseUserGroup](Get-JcSdkOffice365TraverseUserGroup.md)
This endpoint will return all Users Groups bound to an Office 365 instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Office 365 instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this Office 365 instance.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
  curl -X GET https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkOffice365UsersToImport](Get-JcSdkOffice365UsersToImport.md)
Lists Office 365 users available for import.

### [Get-JcSdkOrganizationPolicyResult](Get-JcSdkOrganizationPolicyResult.md)
This endpoint returns all policy results for an organization.

##### Sample Request

```
 curl -X GET https://console.jumpcloud.com/api/v2/policyresults \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkPolicy](Get-JcSdkPolicy.md)
This endpoint returns a specific policy.

###### Sample Request

```
  curl -X GET https://console.jumpcloud.com/api/v2/policies/{PolicyID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkPolicyAssociation](Get-JcSdkPolicyAssociation.md)
This endpoint returns the _direct_ associations of a Policy.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Policies and Systems.

#### Sample Request
```
curl -X GET 'https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/associations?targets=system_group \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkPolicyGroup](Get-JcSdkPolicyGroup.md)
This endpoint returns the details of a Policy Group.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policygroups/{GroupID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkPolicyGroupAssociation](Get-JcSdkPolicyGroupAssociation.md)
This endpoint returns the _direct_ associations of this Policy Group.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Policy Groups and Policies.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policygroups/{GroupID}/associations?targets=system \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkPolicyGroupMember](Get-JcSdkPolicyGroupMember.md)
This endpoint returns all the Policy Groups a Policy is a member of.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/memberof \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkPolicyGroupMembership](Get-JcSdkPolicyGroupMembership.md)
This endpoint returns all Policy members that are a member of this Policy Group.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policygroups/{GroupID}/membership \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkPolicyGroupTraverseSystem](Get-JcSdkPolicyGroupTraverseSystem.md)
This endpoint will return all Systems bound to a Policy Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Policy Group to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this Policy Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policygroups/{GroupID}/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkPolicyGroupTraverseSystemGroup](Get-JcSdkPolicyGroupTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a Policy Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Policy Group to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Policy Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policygroups/{GroupID}/systemgroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkPolicyResult](Get-JcSdkPolicyResult.md)
This endpoint will return the policy results for a specific policy.

##### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policyresults/{Policy_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkPolicyStatus](Get-JcSdkPolicyStatus.md)
This endpoint returns the latest policy results for a specific policy.

##### Sample Request

```
 curl -X GET https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/policystatuses \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkPolicyTemplate](Get-JcSdkPolicyTemplate.md)
This endpoint returns a specific policy template.

#### Sample Request
```
 curl -X GET https://console.jumpcloud.com/api/v2/policytemplates/{Policy_Template_ID}\\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkPolicyTraverseSystem](Get-JcSdkPolicyTraverseSystem.md)
This endpoint will return all Systems bound to a Policy, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Policy to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this Policy.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkPolicyTraverseSystemGroup](Get-JcSdkPolicyTraverseSystemGroup.md)
This endpoint will return all Systems Groups bound to a Policy, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Policy to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Policy.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET  https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/systemgroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkRadiusServerAssociation](Get-JcSdkRadiusServerAssociation.md)
This endpoint returns the _direct_ associations of a Radius Server.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Radius Servers and Users.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/radiusservers/{RADIUS_ID}/associations?targets=user_group \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkRadiusServerTraverseUser](Get-JcSdkRadiusServerTraverseUser.md)
This endpoint will return all Users bound to a RADIUS Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this RADIUS server instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this RADIUS server instance.

See `/members` and `/associations` endpoints to manage those collections.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkRadiusServerTraverseUserGroup](Get-JcSdkRadiusServerTraverseUserGroup.md)
This endpoint will return all Users Groups bound to a RADIUS Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this RADIUS server instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this RADIUS server instance.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/radiusservers/{RADIUS_ID}/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSoftwareApp](Get-JcSdkSoftwareApp.md)
Retrieves a Software Application.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/softwareapps/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSoftwareAppAssociation](Get-JcSdkSoftwareAppAssociation.md)
This endpoint will return the _direct_ associations of a Software Application.
A direct association can be a non-homogeneous relationship between 2 different objects, for example Software Application and System Groups.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/associations?targets=system_group \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSoftwareAppStatus](Get-JcSdkSoftwareAppStatus.md)
This endpoint allows you to get the status of the provided Software Application on associated JumpCloud systems.

#### Sample Request
```
$ curl -X GET https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/statuses \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
```

### [Get-JcSdkSoftwareAppTraverseSystem](Get-JcSdkSoftwareAppTraverseSystem.md)
This endpoint will return all Systems bound to a Software App, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Software App to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this Software App.

See `/associations` endpoint to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSoftwareAppTraverseSystemGroup](Get-JcSdkSoftwareAppTraverseSystemGroup.md)
This endpoint will return all Systems Groups bound to a Software App, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Software App to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Software App.

See `/associations` endpoint to manage those collections.

#### Sample Request
```
curl -X GET  https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/systemgroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSubscription](Get-JcSdkSubscription.md)
This endpoint returns all pricing & packaging subscriptions.

##### Sample Request

```
 curl -X GET  https://console.jumpcloud.com/api/v2/subscriptions \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkSystemAssociation](Get-JcSdkSystemAssociation.md)
This endpoint returns the _direct_ associations of a System.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations?targets=user \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemFdeKey](Get-JcSdkSystemFdeKey.md)
This endpoint will return the current (latest) fde key saved for a system.

### [Get-JcSdkSystemGroup](Get-JcSdkSystemGroup.md)
This endpoint returns the details of a System Group.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSystemGroupAssociation](Get-JcSdkSystemGroupAssociation.md)
This endpoint returns the _direct_ associations of a System Group.

A direct association can be a non-homogeneous relationship between 2 different objects, for example System Groups and Users.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/associations?targets=user \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSystemGroupMember](Get-JcSdkSystemGroupMember.md)
This endpoint returns the system members of a System Group.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemGroupMembership](Get-JcSdkSystemGroupMembership.md)
This endpoint returns all Systems that are a member of this System Group.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID/membership \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemGroupTraverseCommand](Get-JcSdkSystemGroupTraverseCommand.md)
This endpoint will return all Commands bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the group's type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System Group to the corresponding Command; this array represents all grouping and/or associations that would have to be removed to deprovision the Command from this System Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/commands \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSystemGroupTraversePolicy](Get-JcSdkSystemGroupTraversePolicy.md)
This endpoint will return all Policies bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System Group to the corresponding Policy; this array represents all grouping and/or associations that would have to be removed to deprovision the Policy from this System Group.

See `/members` and `/associations` endpoints to manage those collections.

This endpoint is not public yet as we haven't finished the code.

##### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/policies \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSystemGroupTraversePolicyGroup](Get-JcSdkSystemGroupTraversePolicyGroup.md)
This endpoint will return all Policy Groups bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System Group to the corresponding Policy Group; this array represents all grouping and/or associations that would have to be removed to deprovision the Policy Group from this System Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/policygroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemGroupTraverseUser](Get-JcSdkSystemGroupTraverseUser.md)
This endpoint will return all Users bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System Group to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this System Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkSystemGroupTraverseUserGroup](Get-JcSdkSystemGroupTraverseUserGroup.md)
This endpoint will return all User Groups bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System Group to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this System Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

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
This endpoint returns all the System Groups a System is a member of.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/memberof \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemPolicyStatus](Get-JcSdkSystemPolicyStatus.md)
This endpoint returns the policy results for a particular system.

##### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/policystatuses \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemTraverseCommand](Get-JcSdkSystemTraverseCommand.md)
This endpoint will return all Commands bound to a System, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System to the corresponding Command; this array represents all grouping and/or associations that would have to be removed to deprovision the Command from this System.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/commands \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemTraversePolicy](Get-JcSdkSystemTraversePolicy.md)
This endpoint will return all Policies bound to a System, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System to the corresponding Policy; this array represents all grouping and/or associations that would have to be removed to deprovision the Policy from this System.

See `/members` and `/associations` endpoints to manage those collections.

This endpoint is not yet public as we have finish the code.

##### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/v2/{System_ID}/policies \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemTraversePolicyGroup](Get-JcSdkSystemTraversePolicyGroup.md)
This endpoint will return all Policy Groups bound to a System, either directly or indirectly essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System to the corresponding Policy Group; this array represents all grouping and/or associations that would have to be removed to deprovision the Policy Group from this System.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/policygroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemTraverseUser](Get-JcSdkSystemTraverseUser.md)
This endpoint will return all Users bound to a System, either directly or indirectly essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this System.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkSystemTraverseUserGroup](Get-JcSdkSystemTraverseUserGroup.md)
This endpoint will return all User Groups bound to a System, either directly or indirectly essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this System to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this System.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkUserAssociation](Get-JcSdkUserAssociation.md)
This endpoint returns the _direct_ associations of a User.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Users and Systems.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/associations?targets=system_group \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkUserGroup](Get-JcSdkUserGroup.md)
This endpoint returns the details of a User Group.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserGroupAssociation](Get-JcSdkUserGroupAssociation.md)
This endpoint returns the _direct_ associations of this User Group.

A direct association can be a non-homogeneous relationship between 2 different objects, for example User Groups and Users.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/associations?targets=system \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserGroupMember](Get-JcSdkUserGroupMember.md)
This endpoint returns the user members of a User Group.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/members \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserGroupMembership](Get-JcSdkUserGroupMembership.md)
This endpoint returns all users members that are a member of this User Group.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/membership \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserGroupTraverseActiveDirectory](Get-JcSdkUserGroupTraverseActiveDirectory.md)
This endpoint will return all Active Directory Instances bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User Group to the corresponding Active Directory; this array represents all grouping and/or associations that would have to be removed to deprovision the Active Directory from this User Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/activedirectories \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserGroupTraverseApplication](Get-JcSdkUserGroupTraverseApplication.md)
This endpoint will return all Applications bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User Group to the corresponding Application; this array represents all grouping and/or associations that would have to be removed to deprovision the Application from this User Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/applications \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserGroupTraverseDirectory](Get-JcSdkUserGroupTraverseDirectory.md)
This endpoint will return all Directories bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User Group to the corresponding Directory; this array represents all grouping and/or associations that would have to be removed to deprovision the Directories from this User Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/directories \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkUserGroupTraverseGSuite](Get-JcSdkUserGroupTraverseGSuite.md)
This endpoint will return all G Suite Instances bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User Group to the corresponding G Suite instance; this array represents all grouping and/or associations that would have to be removed to deprovision the G Suite instance from this User Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID/gsuites \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkUserGroupTraverseLdapServer](Get-JcSdkUserGroupTraverseLdapServer.md)
This endpoint will return all LDAP Servers bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User Group to the corresponding LDAP Server; this array represents all grouping and/or associations that would have to be removed to deprovision the LDAP Server from this User Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/ldapservers \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserGroupTraverseOffice365](Get-JcSdkUserGroupTraverseOffice365.md)
This endpoint will return all Office 365 instances bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User Group to the corresponding Office 365 instance; this array represents all grouping and/or associations that would have to be removed to deprovision the Office 365 instance from this User Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/office365s \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserGroupTraverseRadiusServer](Get-JcSdkUserGroupTraverseRadiusServer.md)
This endpoint will return all RADIUS servers bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User Group to the corresponding RADIUS Server; this array represents all grouping and/or associations that would have to be removed to deprovision the RADIUS Server from this User Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/radiusservers \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Get-JcSdkUserGroupTraverseSystem](Get-JcSdkUserGroupTraverseSystem.md)
This endpoint will return all Systems bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User Group to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this User Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserGroupTraverseSystemGroup](Get-JcSdkUserGroupTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User Group to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this User Group.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/systemgroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserMember](Get-JcSdkUserMember.md)
This endpoint returns all the User Groups a User is a member of.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/memberof \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserPushEndpoint](Get-JcSdkUserPushEndpoint.md)
This endpoint will retrieve a push endpoint associated with a user.

### [Get-JcSdkUserTraverseActiveDirectory](Get-JcSdkUserTraverseActiveDirectory.md)
This endpoint will return all Active Directory Instances bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User to the corresponding Active Directory instance; this array represents all grouping and/or associations that would have to be removed to deprovision the Active Directory instance from this User.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/activedirectories \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserTraverseApplication](Get-JcSdkUserTraverseApplication.md)
This endpoint will return all Applications bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User to the corresponding Application; this array represents all grouping and/or associations that would have to be removed to deprovision the Application from this User.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/applications \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserTraverseDirectory](Get-JcSdkUserTraverseDirectory.md)
This endpoint will return all Directories bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User to the corresponding Directory; this array represents all grouping and/or associations that would have to be removed to deprovision the Directory from this User.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/directories \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserTraverseGSuite](Get-JcSdkUserTraverseGSuite.md)
This endpoint will return all G-Suite Instances bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User to the corresponding G Suite instance; this array represents all grouping and/or associations that would have to be removed to deprovision the G Suite instance from this User.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/gsuites \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserTraverseLdapServer](Get-JcSdkUserTraverseLdapServer.md)
This endpoint will return all LDAP Servers bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User to the corresponding LDAP Server; this array represents all grouping and/or associations that would have to be removed to deprovision the LDAP Server from this User.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/ldapservers \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserTraverseOffice365](Get-JcSdkUserTraverseOffice365.md)
This endpoint will return all Office 365 Instances bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User to the corresponding Office 365 instance; this array represents all grouping and/or associations that would have to be removed to deprovision the Office 365 instance from this User.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/office365s \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserTraverseRadiusServer](Get-JcSdkUserTraverseRadiusServer.md)
This endpoint will return all RADIUS Servers bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User to the corresponding RADIUS Server; this array represents all grouping and/or associations that would have to be removed to deprovision the RADIUS Server from this User.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/radiusservers \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserTraverseSystem](Get-JcSdkUserTraverseSystem.md)
This endpoint will return all Systems bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this User.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/systems\\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkUserTraverseSystemGroup](Get-JcSdkUserTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this User to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this User.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/systemgroups\\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Get-JcSdkWorkday](Get-JcSdkWorkday.md)
This endpoint will return  all the available information about an instance of Workday.

#### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/v2/workdays/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Get-JcSdkWorkdayWorker](Get-JcSdkWorkdayWorker.md)
This endpoint will return all of the data in your WorkDay Custom Report that has been associated with your WorkDay Instance in JumpCloud.

##### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/workers \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'


```

### [Grant-JcSdkWorkday](Grant-JcSdkWorkday.md)
This endpoint adds an authorization method to a workday instance.

You must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.

Currently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"auth\":{
\t  \"basic\": {
\t\t\"username\": \"someDeveloper\",\t  
\t\t\"password\": \"notTheRealPassword\"

\t  }
\t}
}'

```

### [Import-JcSdkWorkday](Import-JcSdkWorkday.md)
The endpoint allows you to create a Workday Import request.

#### Sample Request 
```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t\t\"email\":\"{email}\",
\t\t\"firstname\":\"{firstname}\",
\t\t\"lastname\":\"{firstname}\",
\t\t\"username\":\"{username}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},
\t\t\t{\"name\":\"WorkdayID\",\"value\":\"name.name\"}
\t\t\t]
\t\t
\t}
]
```

### [Import-JcSdkWorkdayResult](Import-JcSdkWorkdayResult.md)
This endpoint provides a list of job results from the workday import and will contain all imported data from Workday.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import/{ImportJobID}/results \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Invoke-JcSdkReclaimSoftwareAppLicense](Invoke-JcSdkReclaimSoftwareAppLicense.md)
This endpoint allows you to reclaim the licenses from a software app associated with devices that are deleted.
#### Sample Request
```
$ curl -X POST https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/reclaim-licenses \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{}'
```

### [Lock-JcSdkAppleMdmDevice](Lock-JcSdkAppleMdmDevice.md)
Locks a DEP-enrolled device.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/lock \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

### [New-JcSdkActiveDirectory](New-JcSdkActiveDirectory.md)
This endpoint allows you to create a new Active Directory.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/activedirectories/ \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"domain\": \"{DC=AD_domain_name;DC=com}\"
  }'
```

### [New-JcSdkActiveDirectoryAgent](New-JcSdkActiveDirectoryAgent.md)
This endpoint allows you to create a new Active Directory Agent.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/activedirectories/{activedirectory_id}/agents \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

### [New-JcSdkAuthenticationPolicy](New-JcSdkAuthenticationPolicy.md)
Create an authentication policy.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/authn/policies \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Sample Policy\",
    \"disabled\": false,
    \"effect\": {
      \"action\": \"allow\"
    },
    \"targets\": {
      \"users\": {
        \"inclusions\": [\"ALL\"]
      },
      \"userGroups\": {
        \"exclusions\": [{USER_GROUP_ID}]
      },
      \"resources\": [ {\"type\": \"user_portal\" } ]
    },
    \"conditions\":{
      \"ipAddressIn\": [{IP_LIST_ID}]
    }
  }'
```

### [New-JcSdkBulkUser](New-JcSdkBulkUser.md)
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.

#### Sample Request 
```
curl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t\t\"email\":\"{email}\",
\t\t\"firstname\":\"{firstname}\",
\t\t\"lastname\":\"{firstname}\",
\t\t\"username\":\"{username}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},
\t\t\t{\"name\":\"Custom\",\"value\":\"attribute\"}
\t\t]
\t}
]
```

### [New-JcSdkBulkUserState](New-JcSdkBulkUserState.md)
This endpoint allows you to create scheduled statechange jobs.
#### Sample Request
```
curl -X POST \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json' \\
  -d '{
    \"user_ids\": [\"{User_ID_1}\", \"{User_ID_2}\", \"{User_ID_3}\"],
    \"state\": \"SUSPENDED\",
    \"start_date\": \"2000-01-01T00:00:00.000Z\"
  }'
```

### [New-JcSdkCustomEmailConfiguration](New-JcSdkCustomEmailConfiguration.md)
Create the custom email configuration for the specified custom email type

### [New-JcSdkDuoAccount](New-JcSdkDuoAccount.md)
Registers a Duo account for an organization.
Only one Duo account will be allowed,
in case an organization has a Duo account already a 409 (Conflict) code will be returned.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

### [New-JcSdkDuoApplication](New-JcSdkDuoApplication.md)
Creates a Duo application for your organization and the specified account.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Application Name\",
    \"apiHost\": \"api-1234.duosecurity.com\",
    \"integrationKey\": \"1234\",
    \"secretKey\": \"5678\"
  }'
```

### [New-JcSdkGSuiteTranslationRule](New-JcSdkGSuiteTranslationRule.md)
This endpoint allows you to create a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Translation Rule Parameters}
  }'
```

### [New-JcSdkIPList](New-JcSdkIPList.md)
Create an IP list.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/iplists \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Sample IP List\",
    \"ips\": [
      \"192.168.10.12\",
      \"192.168.10.20 - 192.168.10.30\",
      \"123.225.10.0/32\"
    ]
  }'
```

### [New-JcSdkLdapServerSambaDomain](New-JcSdkLdapServerSambaDomain.md)
This endpoint allows you to create a samba domain for an LDAP server.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"sid\":\"{SID_ID}\",
    \"name\":\"{WORKGROUP_NAME}\"
  }'
```

### [New-JcSdkOffice365TranslationRule](New-JcSdkOffice365TranslationRule.md)
This endpoint allows you to create a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Translation Rule Parameters}
  }'
```

### [New-JcSdkPolicy](New-JcSdkPolicy.md)
This endpoint allows you to create a policy.
Given the amount of configurable parameters required to create a Policy, we suggest you use the JumpCloud Admin Console to create new policies.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/policies \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Policy_Parameters}
  }'
```

### [New-JcSdkPolicyGroup](New-JcSdkPolicyGroup.md)
This endpoint allows you to create a new Policy Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/policygroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{Group_Name}\"
  }'
```

### [New-JcSdkSoftwareApp](New-JcSdkSoftwareApp.md)
This endpoint allows you to create a Software Application that will be managed by JumpCloud on associated JumpCloud systems.

#### Sample Request
```
$ curl -X POST https://console.jumpcloud.com/api/v2/softwareapps \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{
  \"displayName\": \"Adobe Reader\",
  \"settings\": [{\"packageId\": \"adobereader\"}]
}'
```

### [New-JcSdkSystemGroup](New-JcSdkSystemGroup.md)
This endpoint allows you to create a new System Group.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/systemgroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{Group_Name}\"
  }'
```

### [New-JcSdkUserGroup](New-JcSdkUserGroup.md)
This endpoint allows you to create a new User Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{Group_Name}\"
  }'
```

### [New-JcSdkWorkday](New-JcSdkWorkday.md)
This endpoint allows you to create a new workday instance.

You must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.

Currently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.

Currently, only one instance is allowed and it must be `Workday Import`.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Workday2\",
    \"reportUrl\":\"https://workday.com/ccx/service/customreport2/gms/user/reportname?format=json\",
    \"auth\": {
      \"basic\": {
        \"username\": \"someDeveloper\",
        \"password\": \"notTheRealPassword\"
      }
    }
  }'
```

### [Remove-JcSdkActiveDirectory](Remove-JcSdkActiveDirectory.md)
This endpoint allows you to delete an Active Directory Instance.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY'
  ```

### [Remove-JcSdkActiveDirectoryAgent](Remove-JcSdkActiveDirectoryAgent.md)
This endpoint deletes an Active Directory agent.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/activedirectories/{activedirectory_id}/agents/{agent_id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Remove-JcSdkAppleMdm](Remove-JcSdkAppleMdm.md)
Removes an Apple MDM configuration.

Warning: This is a destructive operation and will remove your Apple Push Certificates.
We will no longer be able to manage your devices and the only recovery option is to re-register all devices into MDM.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/applemdms/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Remove-JcSdkAppleMdmDevice](Remove-JcSdkAppleMdmDevice.md)
Remove a single Apple MDM device from MDM enrollment.

#### Sample Request
```
  curl -X DELETE https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id} \\
  -H 'accept: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Remove-JcSdkApplicationLogo](Remove-JcSdkApplicationLogo.md)
Deletes the specified image from an application

### [Remove-JcSdkAuthenticationPolicy](Remove-JcSdkAuthenticationPolicy.md)
Delete the specified authentication policy.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/authn/policies/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Remove-JcSdkBulkUserState](Remove-JcSdkBulkUserState.md)
This endpoint deletes a scheduled statechange job.
#### Sample Request
```
curl -X DELETE \"https://console.jumpcloud.com/api/v2/bulk/userstates/{ScheduledJob_ID}\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json'
```

### [Remove-JcSdkCustomEmailConfiguration](Remove-JcSdkCustomEmailConfiguration.md)
Delete the custom email configuration for the specified custom email type

### [Remove-JcSdkDuoAccount](Remove-JcSdkDuoAccount.md)
Removes the specified Duo account, an error will be returned if the account has some Duo application used in a protected resource.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/duo/accounts/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Remove-JcSdkDuoApplication](Remove-JcSdkDuoApplication.md)
Deletes the specified Duo application, an error will be returned if the application is used in a protected resource.

#### Sample Request
```
  curl -X DELETE https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications/{APPLICATION_ID} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}''
```

### [Remove-JcSdkGSuiteTranslationRule](Remove-JcSdkGSuiteTranslationRule.md)
This endpoint allows you to delete a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.

#### Sample Request

```
curl -X DELETE https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Remove-JcSdkIPList](Remove-JcSdkIPList.md)
Delete a specific IP list.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/iplists/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Remove-JcSdkLdapServerSambaDomain](Remove-JcSdkLdapServerSambaDomain.md)
This endpoint allows you to delete a samba domain from an LDAP server.

##### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Remove-JcSdkOffice365TranslationRule](Remove-JcSdkOffice365TranslationRule.md)
This endpoint allows you to delete a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.

#### Sample Request

```
curl -X DELETE https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Remove-JcSdkPolicy](Remove-JcSdkPolicy.md)
This endpoint allows you to delete a policy.

#### Sample Request

```
curl -X DELETE https://console.jumpcloud.com/api/v2/policies/5a837ecd232e110d4291e6b9 \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

### [Remove-JcSdkPolicyGroup](Remove-JcSdkPolicyGroup.md)
This endpoint allows you to delete a Policy Group.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/policygroups/{GroupID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Remove-JcSdkSoftwareApp](Remove-JcSdkSoftwareApp.md)
Removes a Software Application configuration.

Warning: This is a destructive operation and will unmanage the application on all affected systems.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/softwareapps/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Remove-JcSdkSystemGroup](Remove-JcSdkSystemGroup.md)
This endpoint allows you to delete a System Group.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Remove-JcSdkUserGroup](Remove-JcSdkUserGroup.md)
This endpoint allows you to delete a User Group.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/usergroups/{GroupID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

### [Remove-JcSdkUserPushEndpoint](Remove-JcSdkUserPushEndpoint.md)
This endpoint will delete a push endpoint associated with a user.

### [Remove-JcSdkWorkdayAuthorization](Remove-JcSdkWorkdayAuthorization.md)
Removes any and all authorization methods from the workday instance

##### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

### [Restart-JcSdkAppleMdmDevice](Restart-JcSdkAppleMdmDevice.md)
Restarts a DEP-enrolled device.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/restart \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

### [Set-JcSdkActiveDirectoryAssociation](Set-JcSdkActiveDirectoryAssociation.md)
This endpoint allows you to manage the _direct_ associations of an Active Directory instance.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Active Directory and Users.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/activedirectories/{AD_Instance_ID}/associations \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"user\",
    \"id\": \"{User_ID}\"
  }'
```

### [Set-JcSdkAppleMdm](Set-JcSdkAppleMdm.md)
Updates an Apple MDM configuration.
This endpoint is used to supply JumpCloud with a signed certificate from Apple in order to finalize the setup and allow JumpCloud to manage your devices.
It may also be used to update the DEP Settings.

#### Sample Request
```
  curl -X PUT https://console.jumpcloud.com/api/v2/applemdms/{ID} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"MDM name\",
    \"appleSignedCert\": \"{CERTIFICATE}\",
    \"encryptedDepServerToken\": \"{SERVER_TOKEN}\",
    \"dep\": {
      \"welcomeScreen\": {
        \"title\": \"Welcome\",
        \"paragraph\": \"In just a few steps, you will be working securely from your Mac.\",
        \"button\": \"continue\",
      },
    },
  }'
```

### [Set-JcSdkApplicationAssociation](Set-JcSdkApplicationAssociation.md)
This endpoint allows you to manage the _direct_ associations of an Application.
A direct association can be a non-homogeneous relationship between 2 different objects, for example Application and User Groups.

#### Sample Request
```
curl -X POST 'https://console.jumpcloud.com/api/v2/applications/{Application_ID}/associations' \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"user_group\",
    \"id\": \"{Group_ID}\"
  }'
```

### [Set-JcSdkCommandAssociation](Set-JcSdkCommandAssociation.md)
This endpoint will allow you to manage the _direct_ associations of this Command.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Commands and User Groups.


#### Sample Request
```
 curl -X POST https://console.jumpcloud.com/api/v2/commands/{Command_ID}/associations \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"system_group\",
    \"id\": \"Group_ID\"
  }'
```

### [Set-JcSdkCustomEmailConfiguration](Set-JcSdkCustomEmailConfiguration.md)
Update the custom email configuration for the specified custom email type

### [Set-JcSdkDuoApplication](Set-JcSdkDuoApplication.md)
Updates the specified Duo application.

#### Sample Request
```
  curl -X PUT https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications/{APPLICATION_ID} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Application Name\",
    \"apiHost\": \"api-1234.duosecurity.com\",
    \"integrationKey\": \"1234\",
    \"secretKey\": \"5678\"
  }'
```

### [Set-JcSdkGSuiteAssociation](Set-JcSdkGSuiteAssociation.md)
This endpoint returns the _direct_ associations of this G Suite instance.

A direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"user_group\",
    \"id\": \"{Group_ID}\"
  }'
```

### [Set-JcSdkIPList](Set-JcSdkIPList.md)
Replace a specific IP list.

#### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/iplists/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Sample IP List\",
    \"ips\": [
      \"192.168.10.10\"
    ]
  }'
```

### [Set-JcSdkLdapServerAssociation](Set-JcSdkLdapServerAssociation.md)
This endpoint allows you to manage the _direct_ associations of a LDAP Server.

A direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"user\",
    \"id\": \"{User_ID}\"
  }'
```

### [Set-JcSdkLdapServerSambaDomain](Set-JcSdkLdapServerSambaDomain.md)
This endpoint allows you to update the samba domain information for an LDAP server.

##### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"sid\":\"{SID_ID}\",
    \"name\":\"{WORKGROUP_NAME}\"
  }'
```

### [Set-JcSdkOffice365Association](Set-JcSdkOffice365Association.md)
This endpoint allows you to manage the _direct_ associations of a Office 365 instance.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID}/associations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"user_group\",
    \"id\": \"{Group_ID}\"
  }'
```

### [Set-JcSdkPolicy](Set-JcSdkPolicy.md)
This endpoint allows you to update a policy.
Given the amount of configurable parameters required to update a Policy, we suggest you use the JumpCloud Admin Console to create new policies.


##### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY' \\
  -d '{
    {Policy_Parameters}
  }'
```

### [Set-JcSdkPolicyAssociation](Set-JcSdkPolicyAssociation.md)
This endpoint allows you to manage the _direct_ associations of a Policy.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Policies and Systems.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/associations/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"system_group\",
    \"id\": \"{Group_ID}\"
  }'
```

### [Set-JcSdkPolicyGroup](Set-JcSdkPolicyGroup.md)
This endpoint allows you to do a full update of the Policy Group.

#### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/policygroups/{Group_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY' \\
  -d '{
    \"name\": \"group_update\"
  }'
```

### [Set-JcSdkPolicyGroupAssociation](Set-JcSdkPolicyGroupAssociation.md)
This endpoint manages the _direct_ associations of this Policy Group.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Policy Groups and Policies.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/policygroups/{GroupID}/associations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"system\",
    \"id\": \"{SystemID}\"
  }'
```

### [Set-JcSdkPolicyGroupMember](Set-JcSdkPolicyGroupMember.md)
This endpoint allows you to manage the Policy members of a Policy Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/policygroups/{GroupID}/members \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"policy\",
    \"id\": \"{Policy_ID}\"
  }'
```

### [Set-JcSdkRadiusServerAssociation](Set-JcSdkRadiusServerAssociation.md)
This endpoint allows you to manage the _direct_ associations of a Radius Server.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Radius Servers and Users.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/radiusservers/{RADIUS_ID}/associations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t
\"type\":\"user\", 
\"id\":\"{USER_ID}\", 
\"op\":\"add\"
\t
}'
```

### [Set-JcSdkSoftwareApp](Set-JcSdkSoftwareApp.md)
This endpoint updates a specific Software Application configuration for the organization.
Only displayName can be changed.

#### Sample Request
```
 curl -X PUT https://console.jumpcloud.com/api/v2/softwareapps/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"displayName\": \"Adobe Reader\"
  }'
```

### [Set-JcSdkSoftwareAppAssociation](Set-JcSdkSoftwareAppAssociation.md)
This endpoint allows you to associate or disassociate a software application to a system or system group.

#### Sample Request
```
$ curl -X POST https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/associations \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{
  \"id\": \"\<object_id\>\",
  \"op\": \"add\",
  \"type\": \"system\"
 }'
```

### [Set-JcSdkSystemAssociation](Set-JcSdkSystemAssociation.md)
This endpoint allows you to manage the _direct_ associations of a System.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"attributes\": {
      \"sudo\": {
        \"enabled\": true,
        \"withoutPassword\": false
      }
    },
    \"op\": \"add\",
    \"type\": \"user\",
    \"id\": \"UserID\"
  }'
```

### [Set-JcSdkSystemGroup](Set-JcSdkSystemGroup.md)
This endpoint allows you to do a full update of the System Group.

#### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Name_Update\"
  }'
```

### [Set-JcSdkSystemGroupAssociation](Set-JcSdkSystemGroupAssociation.md)
This endpoint allows you to manage the _direct_ associations of a System Group.

A direct association can be a non-homogeneous relationship between 2 different objects, for example System Groups and Users.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/associations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"user\",
    \"id\": \"{UserID}\"
  }'
```

### [Set-JcSdkSystemGroupMember](Set-JcSdkSystemGroupMember.md)
This endpoint allows you to manage the system members of a System Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"system\",
    \"id\": \"{System_ID}\"
  }'
```

### [Set-JcSdkUserAssociation](Set-JcSdkUserAssociation.md)
This endpoint allows you to manage the _direct_ associations of a User.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Users and Systems.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/users/{UserID}/associations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"attributes\": {
      \"sudo\": {
      \"enabled\": true,
        \"withoutPassword\": false
      }
    },
    \"op\": \"add\",
    \"type\": \"system_group\",
    \"id\": \"{GroupID}\"
  }'
```

### [Set-JcSdkUserGroup](Set-JcSdkUserGroup.md)
This endpoint allows you to do a full update of the User Group.

#### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/usergroups/{Group_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY' \\
  -d '{
    \"name\": \"group_update\"
  }'
```

### [Set-JcSdkUserGroupAssociation](Set-JcSdkUserGroupAssociation.md)
This endpoint manages the _direct_ associations of this User Group.

A direct association can be a non-homogeneous relationship between 2 different objects, for example User Groups and Users.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/associations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"system\",
    \"id\": \"{SystemID}\"
  }'
```

### [Set-JcSdkUserGroupMember](Set-JcSdkUserGroupMember.md)
This endpoint allows you to manage the user members of a User Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/members \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"user\",
    \"id\": \"{User_ID}\"
  }'
```

### [Set-JcSdkWorkday](Set-JcSdkWorkday.md)
This endpoint allows you to update the name and Custom Report URL for a Workday Instance.

Currently, the name can not be changed from the default of `Workday Import`.

##### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/workdays/{WorkdayID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"reportUrl\":\"{Report_URL}\",
\t\"name\":\"{Name}\"
}\t'
```

### [Stop-JcSdkAppleMdmDevice](Stop-JcSdkAppleMdmDevice.md)
Shuts down a DEP-enrolled device.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/shutdown \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

### [Sync-JcSdkAppleMdmDevice](Sync-JcSdkAppleMdmDevice.md)
Refreshes the list of devices that a JumpCloud admin has added to their virtual MDM in Apple Business Manager - ABM so that they can be DEP enrolled with JumpCloud.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/refreshdepdevices \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

### [Update-JcSdkAppleMdmDeviceLockInformation](Update-JcSdkAppleMdmDeviceLockInformation.md)
Refreshes the activation lock information for a device

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/refreshActivationLockInformation \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

### [Update-JcSdkAuthenticationPolicy](Update-JcSdkAuthenticationPolicy.md)
Patch the specified authentication policy.

#### Sample Request
```
curl -X PATCH https://console.jumpcloud.com/api/v2/authn/policies/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{ \"disabled\": false }'
```

### [Update-JcSdkBulkUser](Update-JcSdkBulkUser.md)
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/1.0/systemusers/update-a-system-user) for full list of attributes.

#### Sample Request 
```
curl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"department\":\"{UPDATED_DEPARTMENT}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}
\t\t]
\t},
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",
\t\t\"phoneNumbers\":[
\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},
\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}
\t\t]
\t}
]
```

### [Update-JcSdkGSuite](Update-JcSdkGSuite.md)
This endpoint allows updating some attributes of a G Suite.

##### Sample Request

```
curl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"userLockoutAction\": \"suspend\",
    \"userPasswordExpirationAction\": \"maintain\"
  }'
```

### [Update-JcSdkIPList](Update-JcSdkIPList.md)
Update a specific IP list.

#### Sample Request
```
curl -X PATCH https://console.jumpcloud.com/api/v2/iplists/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{\"name\": \"New IP List Name\"}'
```

### [Update-JcSdkLdapServer](Update-JcSdkLdapServer.md)
This endpoint allows updating some attributes of an LDAP server.

Sample Request

```
curl -X PATCH https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"userLockoutAction\": \"remove\",
    \"userPasswordExpirationAction\": \"disable\"
  }'
```

### [Update-JcSdkOffice365](Update-JcSdkOffice365.md)
This endpoint allows updating some attributes of an Office 365 instance.

#####

Sample Request

```
curl -X PATCH https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"userLockoutAction\": \"maintain\",
    \"userPasswordExpirationAction\": \"suspend\"
  }'
```

### [Update-JcSdkUserPushEndpoint](Update-JcSdkUserPushEndpoint.md)
This endpoint will update a push endpoint associated with a user.


