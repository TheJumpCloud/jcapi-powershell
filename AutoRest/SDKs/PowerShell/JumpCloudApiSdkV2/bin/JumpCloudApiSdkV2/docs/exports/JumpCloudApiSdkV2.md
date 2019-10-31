---
Module Name: JumpCloudApiSdkV2
Module Guid: 6015f0f2-c617-4998-b749-02bdf80272c9
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2
Help Version: 1.0.0.0
Locale: en-US
---

# JumpCloudApiSdkV2 Module
## Description
The JumpCloud PowerShell SDK

## JumpCloudApiSdkV2 Cmdlets
### [Get-JcSdkDirectory](Get-JcSdkDirectory.md)
This endpoint returns all active directories (LDAP, O365 Suite, G-Suite).\n\n#### Sample Request\n```\n curl -X GET https://console.jumpcloud.com/api/v2/directories \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkFdeSystemFdeKey](Get-JcSdkFdeSystemFdeKey.md)
This endpoint will return the current (latest) fde key saved for a system.

### [Get-JcSdkGraphActiveDirectoryGraphActiveDirectoryTraverseUserGroup](Get-JcSdkGraphActiveDirectoryGraphActiveDirectoryTraverseUserGroup.md)
This endpoint will return all Users Groups bound to an Active Directory instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Active Directory instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this Active Directory instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID}/usergroups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphApplicationAssociation](Get-JcSdkGraphApplicationAssociation.md)
This endpoint will return the _direct_ associations of an Application.
A direct association can be a non-homogeneous relationship between 2 different objects, for example Applications and User Groups.\n\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/applications/{Application_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphApplicationTraverseUser](Get-JcSdkGraphApplicationTraverseUser.md)
This endpoint will return all Users bound to an Application, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Application to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this Application.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/applications/{Application_ID}/users \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphApplicationTraverseUserGroup](Get-JcSdkGraphApplicationTraverseUserGroup.md)
This endpoint will return all Users Groups bound to an Application, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates  each path from this Application to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this Application.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/applications/{Application_ID}/usergroups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphCommandAssociation](Get-JcSdkGraphCommandAssociation.md)
This endpoint will return the _direct_ associations of this Command.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Commands and User Groups.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/commands/{Command_ID}/associations?targets=system_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphCommandTraverseSystem](Get-JcSdkGraphCommandTraverseSystem.md)
This endpoint will return all Systems bound to a Command, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Command to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this Command.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/commands/{Command_ID}/systems \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphCommandTraverseSystemGroup](Get-JcSdkGraphCommandTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a Command, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Command to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Command.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/commands/{Command_ID}/systemgroups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphGSuiteGraphGSuiteAssociation](Get-JcSdkGraphGSuiteGraphGSuiteAssociation.md)
This endpoint returns the _direct_ associations of this G Suite instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.\n\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphGSuiteGraphGSuiteTraverseUser](Get-JcSdkGraphGSuiteGraphGSuiteTraverseUser.md)
This endpoint will return all Users bound to a G Suite instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this G Suite instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this G Suite instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/users \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphGSuiteGraphGSuiteTraverseUserGroup](Get-JcSdkGraphGSuiteGraphGSuiteTraverseUserGroup.md)
This endpoint will return all User Groups bound to an G Suite instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this G Suite instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this G Suite instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{GSuite_ID}/usergroups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphLdapServerGraphLdapServerAssociation](Get-JcSdkGraphLdapServerGraphLdapServerAssociation.md)
This endpoint returns the _direct_ associations of this LDAP Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.\n\n#### Sample Request\n\n```\n curl -X GET 'https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphLdapServerGraphLdapServerTraverseUser](Get-JcSdkGraphLdapServerGraphLdapServerTraverseUser.md)
This endpoint will return all Users bound to an LDAP Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this LDAP server instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this LDAP server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphLdapServerGraphLdapServerTraverseUserGroup](Get-JcSdkGraphLdapServerGraphLdapServerTraverseUserGroup.md)
This endpoint will return all Users Groups bound to a LDAP Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this LDAP server instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this LDAP server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphOffice365Association](Get-JcSdkGraphOffice365Association.md)
This endpoint returns _direct_ associations of an Office 365 instance.\n\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/office365s/{O365_ID}/associations?targets=user_group \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphOffice365TraverseUser](Get-JcSdkGraphOffice365TraverseUser.md)
This endpoint will return all Users bound to an Office 365 instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Office 365 instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this Office 365 instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/office365s/{O365_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphOffice365TraverseUserGroup](Get-JcSdkGraphOffice365TraverseUserGroup.md)
This endpoint will return all Users Groups bound to an Office 365 instance, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Office 365 instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this Office 365 instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/office365s/{O365_ID/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphPolicyAssociation](Get-JcSdkGraphPolicyAssociation.md)
This endpoint returns the _direct_ associations of a Policy.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Policies and Systems.\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/associations?targets=system_group \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphPolicyStatus](Get-JcSdkGraphPolicyStatus.md)
This endpoint returns the policy results for a particular system.\n\n##### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/policystatuses \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphPolicyTraverseSystem](Get-JcSdkGraphPolicyTraverseSystem.md)
This endpoint will return all Systems bound to a Policy, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Policy to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this Policy.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphPolicyTraverseSystemGroup](Get-JcSdkGraphPolicyTraverseSystemGroup.md)
This endpoint will return all Systems Groups bound to a Policy, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Policy to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Policy.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET  https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphRadiusServerGraphRadiusServerAssociation](Get-JcSdkGraphRadiusServerGraphRadiusServerAssociation.md)
This endpoint returns the _direct_ associations of a Radius Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Radius Servers and Users.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/radiusservers/{RADIUS_ID}/associations?targets=user_group \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphRadiusServerGraphRadiusServerTraverseUser](Get-JcSdkGraphRadiusServerGraphRadiusServerTraverseUser.md)
This endpoint will return all Users bound to a RADIUS Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this RADIUS server instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this RADIUS server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkGraphRadiusServerGraphRadiusServerTraverseUserGroup](Get-JcSdkGraphRadiusServerGraphRadiusServerTraverseUserGroup.md)
This endpoint will return all Users Groups bound to a RADIUS Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this RADIUS server instance to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this RADIUS server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/radiusservers/{RADIUS_ID}/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphSystemAssociation](Get-JcSdkGraphSystemAssociation.md)
This endpoint returns the _direct_ associations of a System.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations?targets=user \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupAssociation](Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupAssociation.md)
This endpoint returns the _direct_ associations of a System Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example System Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/associations?targets=user \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraverseCommand](Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraverseCommand.md)
This endpoint will return all Commands bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding Command; this array represents all grouping and/or associations that would have to be removed to deprovision the Command from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/commands \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraversePolicy](Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraversePolicy.md)
This endpoint will return all Policies bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding Policy; this array represents all grouping and/or associations that would have to be removed to deprovision the Policy from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\nThis endpoint is not public yet as we haven't finished the code.\n\n##### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraverseUser](Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraverseUser.md)
This endpoint will return all Users bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraverseUserGroup](Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraverseUserGroup.md)
This endpoint will return all User Groups bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphSystemGroupMemberMembershipGraphSystemGroupMember](Get-JcSdkGraphSystemGroupMemberMembershipGraphSystemGroupMember.md)
This endpoint returns the system members of a System Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphSystemGroupMemberMembershipGraphSystemGroupMembership](Get-JcSdkGraphSystemGroupMemberMembershipGraphSystemGroupMembership.md)
This endpoint returns all Systems that are a member of this System Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID/membership \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphSystemMember](Get-JcSdkGraphSystemMember.md)
This endpoint returns all the System Groups a System is a member of.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/memberof \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphSystemTraverseCommand](Get-JcSdkGraphSystemTraverseCommand.md)
This endpoint will return all Commands bound to a System, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System to the corresponding Command; this array represents all grouping and/or associations that would have to be removed to deprovision the Command from this System.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/commands \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphSystemTraversePolicy](Get-JcSdkGraphSystemTraversePolicy.md)
This endpoint will return all Policies bound to a System, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System to the corresponding Policy; this array represents all grouping and/or associations that would have to be removed to deprovision the Policy from this System.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\nThis endpoint is not yet public as we have finish the code.\n\n##### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/{System_ID}/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphSystemTraverseUser](Get-JcSdkGraphSystemTraverseUser.md)
This endpoint will return all Users bound to a System, either directly or indirectly essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this System.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphSystemTraverseUserGroup](Get-JcSdkGraphSystemTraverseUserGroup.md)
This endpoint will return all User Groups bound to a System, either directly or indirectly essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System to the corresponding User Group; this array represents all grouping and/or associations that would have to be removed to deprovision the User Group from this System.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphUserAssociation](Get-JcSdkGraphUserAssociation.md)
This endpoint returns the _direct_ associations of a User.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Users and Systems.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/associations?targets=system_group \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphUserGroupAssociationGraphUserGroupAssociation](Get-JcSdkGraphUserGroupAssociationGraphUserGroupAssociation.md)
This endpoint returns the _direct_ associations of this User Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example User Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/associations?targets=system \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseApplication](Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseApplication.md)
This endpoint will return all Applications bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding Application; this array represents all grouping and/or associations that would have to be removed to deprovision the Application from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/applications \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseDirectory](Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseDirectory.md)
This endpoint will return all Directories bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding Directory; this array represents all grouping and/or associations that would have to be removed to deprovision the Directories from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/directories \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraversegSuite](Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraversegSuite.md)
This endpoint will return all G Suite Instances bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding G Suite instance; this array represents all grouping and/or associations that would have to be removed to deprovision the G Suite instance from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID/gsuites \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseldapServer](Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseldapServer.md)
This endpoint will return all LDAP Servers bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding LDAP Server; this array represents all grouping and/or associations that would have to be removed to deprovision the LDAP Server from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/ldapservers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseOffice365](Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseOffice365.md)
This endpoint will return all Office 365 instances bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding Office 365 instance; this array represents all grouping and/or associations that would have to be removed to deprovision the Office 365 instance from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/office365s \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseRadiusServer](Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseRadiusServer.md)
This endpoint will return all RADIUS servers bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding RADIUS Server; this array represents all grouping and/or associations that would have to be removed to deprovision the RADIUS Server from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/radiusservers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

### [Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseSystem](Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseSystem.md)
This endpoint will return all Systems bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseSystemGroup](Get-JcSdkGraphUserGroupAssociationGraphUserGroupTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserGroupMemberMembershipGraphUserGroupMember](Get-JcSdkGraphUserGroupMemberMembershipGraphUserGroupMember.md)
This endpoint returns the user members of a User Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserGroupMemberMembershipGraphUserGroupMembership](Get-JcSdkGraphUserGroupMemberMembershipGraphUserGroupMembership.md)
This endpoint returns all users members that are a member of this User Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/membership \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserMember](Get-JcSdkGraphUserMember.md)
This endpoint returns all the User Groups a User is a member of.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/memberof \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserTraverseApplication](Get-JcSdkGraphUserTraverseApplication.md)
This endpoint will return all Applications bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding Application; this array represents all grouping and/or associations that would have to be removed to deprovision the Application from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/applications \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserTraverseDirectory](Get-JcSdkGraphUserTraverseDirectory.md)
This endpoint will return all Directories bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding Directory; this array represents all grouping and/or associations that would have to be removed to deprovision the Directory from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/directories \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserTraversegSuite](Get-JcSdkGraphUserTraversegSuite.md)
This endpoint will return all G-Suite Instances bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding G Suite instance; this array represents all grouping and/or associations that would have to be removed to deprovision the G Suite instance from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/gsuites \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserTraverseldapServer](Get-JcSdkGraphUserTraverseldapServer.md)
This endpoint will return all LDAP Servers bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding LDAP Server; this array represents all grouping and/or associations that would have to be removed to deprovision the LDAP Server from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/ldapservers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserTraverseOffice365](Get-JcSdkGraphUserTraverseOffice365.md)
This endpoint will return all Office 365 Instances bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding Office 365 instance; this array represents all grouping and/or associations that would have to be removed to deprovision the Office 365 instance from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/office365s \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserTraverseRadiusServer](Get-JcSdkGraphUserTraverseRadiusServer.md)
This endpoint will return all RADIUS Servers bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding RADIUS Server; this array represents all grouping and/or associations that would have to be removed to deprovision the RADIUS Server from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/radiusservers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserTraverseSystem](Get-JcSdkGraphUserTraverseSystem.md)
This endpoint will return all Systems bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/systems\\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGraphUserTraverseSystemGroup](Get-JcSdkGraphUserTraverseSystemGroup.md)
This endpoint will return all System Groups bound to a User, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this User.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/systemgroups\\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGroup](Get-JcSdkGroup.md)
This endpoint returns all Groups that exist in your organization.\n\n#### Available filter fields:\n  - `name`\n  - `disabled`\n  - `type`\n\n#### Sample Request\n\n```\n  curl -X GET \\\n  https://console.jumpcloud.com/api/v2/groups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGSuite](Get-JcSdkGSuite.md)
This endpoint returns a specific G Suite.\n\n##### Sample Request\n\n```\n curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkGSuiteTranslationRuleGSuite](Get-JcSdkGSuiteTranslationRuleGSuite.md)
This endpoint returns a specific translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.\n\n###### Sample Request\n\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkLdapServer](Get-JcSdkLdapServer.md)
This endpoint returns a specific LDAP server.\n\n##### Sample Request\n\n```\n curl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkOffice365TranslationRuleOffice365](Get-JcSdkOffice365TranslationRuleOffice365.md)
This endpoint returns a specific translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n###### Sample Request\n\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkPolicy](Get-JcSdkPolicy.md)
This endpoint returns a specific policy.\n\n###### Sample Request\n\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/policies/{PolicyID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkPolicyOrgPolicyResult](Get-JcSdkPolicyOrgPolicyResult.md)
This endpoint returns all policies results for an organization.\n\n##### Sample Request\n\n```\n curl -X GET https://console.jumpcloud.com/api/v2/policyresults \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkPolicyResult](Get-JcSdkPolicyResult.md)
This endpoint will return the policy results for a specific policy.\n\n##### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/policyresults/{Policy_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkPolicyStatus](Get-JcSdkPolicyStatus.md)
This endpoint returns the latest policies results for a specific policy.\n\n##### Sample Request\n\n```\n curl -X GET https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/policystatuses \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkPolicytemplatePolicyTemplate](Get-JcSdkPolicytemplatePolicyTemplate.md)
This endpoint returns a specific policy template.\n\n#### Sample Request\n```\n curl -X GET https://console.jumpcloud.com/api/v2/policies/{Policy_ID}\\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkProviderAdministrator](Get-JcSdkProviderAdministrator.md)
This endpoint returns a list of the Administrators associated with the Provider.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkSambaDomainLdapServerSambaDomain](Get-JcSdkSambaDomainLdapServerSambaDomain.md)
This endpoint returns a specific samba domain for an LDAP server.\n\n##### Sample Request\n```\ncurl -X GET \\\n  https://console.jumpcloud.com/api/v2/ldapservers/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkSystemGroupSystem](Get-JcSdkSystemGroupSystem.md)
This endpoint returns all System Groups.\n\nAvailable filter fields:\n  - `name`\n  - `disabled`\n  - `type`\n\n#### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkSystemInsightSysteminsightApp](Get-JcSdkSystemInsightSysteminsightApp.md)
Valid filter fields are `system_id` and `bundle_name`.

### [Get-JcSdkSystemInsightSysteminsightBitlockerInfo](Get-JcSdkSystemInsightSysteminsightBitlockerInfo.md)
Valid filter fields are `system_id` and `protection_status`.

### [Get-JcSdkSystemInsightSysteminsightBrowserPlugin](Get-JcSdkSystemInsightSysteminsightBrowserPlugin.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSysteminsightChromeExtension](Get-JcSdkSystemInsightSysteminsightChromeExtension.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSysteminsightDiskEncryption](Get-JcSdkSystemInsightSysteminsightDiskEncryption.md)
Valid filter fields are `system_id` and `encryption_status`.

### [Get-JcSdkSystemInsightSysteminsightDiskInfo](Get-JcSdkSystemInsightSysteminsightDiskInfo.md)
Valid filter fields are `system_id` and `disk_index`.

### [Get-JcSdkSystemInsightSysteminsightEtcHost](Get-JcSdkSystemInsightSysteminsightEtcHost.md)
Valid filter fields are `system_id` and `address`.

### [Get-JcSdkSystemInsightSysteminsightFirefoxAddon](Get-JcSdkSystemInsightSysteminsightFirefoxAddon.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSysteminsightGroup](Get-JcSdkSystemInsightSysteminsightGroup.md)
Valid filter fields are `system_id` and `groupname`.

### [Get-JcSdkSystemInsightSysteminsightInterfaceAddress](Get-JcSdkSystemInsightSysteminsightInterfaceAddress.md)
Valid filter fields are `system_id` and `address`.

### [Get-JcSdkSystemInsightSysteminsightKernelInfo](Get-JcSdkSystemInsightSysteminsightKernelInfo.md)
Valid filter fields are `system_id` and `version`.

### [Get-JcSdkSystemInsightSysteminsightLogicalDrive](Get-JcSdkSystemInsightSysteminsightLogicalDrive.md)
Valid filter fields are `system_id` and `device_id`.

### [Get-JcSdkSystemInsightSysteminsightMount](Get-JcSdkSystemInsightSysteminsightMount.md)
Valid filter fields are `system_id` and `path`.

### [Get-JcSdkSystemInsightSysteminsightOSVersion](Get-JcSdkSystemInsightSysteminsightOSVersion.md)
Valid filter fields are `system_id` and `version`.

### [Get-JcSdkSystemInsightSysteminsightPatch](Get-JcSdkSystemInsightSysteminsightPatch.md)
Valid filter fields are `system_id` and `hotfix_id`.

### [Get-JcSdkSystemInsightSysteminsightProgram](Get-JcSdkSystemInsightSysteminsightProgram.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSysteminsightSafariExtension](Get-JcSdkSystemInsightSysteminsightSafariExtension.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSysteminsightSystemApp](Get-JcSdkSystemInsightSysteminsightSystemApp.md)
Valid filter fields are `name`.

### [Get-JcSdkSystemInsightSysteminsightSystemBitlockerInfo](Get-JcSdkSystemInsightSysteminsightSystemBitlockerInfo.md)
Valid filter fields are `address`.

### [Get-JcSdkSystemInsightSysteminsightSystemBrowserPlugin](Get-JcSdkSystemInsightSysteminsightSystemBrowserPlugin.md)
Valid filter fields are `name`.

### [Get-JcSdkSystemInsightSysteminsightSystemChromeExtension](Get-JcSdkSystemInsightSysteminsightSystemChromeExtension.md)
Valid filter fields are `path`.

### [Get-JcSdkSystemInsightSysteminsightSystemControl](Get-JcSdkSystemInsightSysteminsightSystemControl.md)
Valid filter fields are `system_id` and `name`.

### [Get-JcSdkSystemInsightSysteminsightSystemDiskEncryption](Get-JcSdkSystemInsightSysteminsightSystemDiskEncryption.md)
Valid filter fields are `device_id`.

### [Get-JcSdkSystemInsightSysteminsightSystemDiskInfo](Get-JcSdkSystemInsightSysteminsightSystemDiskInfo.md)
Valid filter fields are `hotfix_id  `.

### [Get-JcSdkSystemInsightSysteminsightSystemEtcHost](Get-JcSdkSystemInsightSysteminsightSystemEtcHost.md)
Valid filter fields are `name`.

### [Get-JcSdkSystemInsightSysteminsightSystemFirefoxAddon](Get-JcSdkSystemInsightSysteminsightSystemFirefoxAddon.md)
Valid filter fields are `name`.

### [Get-JcSdkSystemInsightSysteminsightSystemGroup](Get-JcSdkSystemInsightSysteminsightSystemGroup.md)
Valid filter fields are `bundle_name`.

### [Get-JcSdkSystemInsightSysteminsightSystemInfo](Get-JcSdkSystemInsightSysteminsightSystemInfo.md)
Valid filter fields are `name`.

### [Get-JcSdkSystemInsightSysteminsightSystemInterfaceAddress](Get-JcSdkSystemInsightSysteminsightSystemInterfaceAddress.md)
Valid filter fields are `encryption_status`.

### [Get-JcSdkSystemInsightSysteminsightSystemKernelInfo](Get-JcSdkSystemInsightSysteminsightSystemKernelInfo.md)
Valid filter fields are `name`.

### [Get-JcSdkSystemInsightSysteminsightSystemLogicalDrive](Get-JcSdkSystemInsightSysteminsightSystemLogicalDrive.md)
Valid filter fields are `version`.

### [Get-JcSdkSystemInsightSysteminsightSystemMount](Get-JcSdkSystemInsightSysteminsightSystemMount.md)
Valid filter fields are `address`.

### [Get-JcSdkSystemInsightSysteminsightSystemOSVersion](Get-JcSdkSystemInsightSysteminsightSystemOSVersion.md)
Valid filter fields are `version`.

### [Get-JcSdkSystemInsightSysteminsightSystemPatch](Get-JcSdkSystemInsightSysteminsightSystemPatch.md)
Valid filter fields are `groupname`.

### [Get-JcSdkSystemInsightSysteminsightSystemProgram](Get-JcSdkSystemInsightSysteminsightSystemProgram.md)
Valid filter fields are `username`.

### [Get-JcSdkSystemInsightSysteminsightSystemSafariExtension](Get-JcSdkSystemInsightSysteminsightSystemSafariExtension.md)
Valid filter fields are `cpu_subtype`.

### [Get-JcSdkSystemInsightSysteminsightSystemUptime](Get-JcSdkSystemInsightSysteminsightSystemUptime.md)
Valid filter fields are `days`.

### [Get-JcSdkSystemInsightSysteminsightSystemUser](Get-JcSdkSystemInsightSysteminsightSystemUser.md)
Valid filter fields are `disk_index`.

### [Get-JcSdkSystemInsightSysteminsightUptime](Get-JcSdkSystemInsightSysteminsightUptime.md)
Valid filter fields are `system_id` and `days`.

### [Get-JcSdkSystemInsightSysteminsightUser](Get-JcSdkSystemInsightSysteminsightUser.md)
Valid filter fields are `system_id` and `username`.

### [Get-JcSdkUserGroupUser](Get-JcSdkUserGroupUser.md)
This endpoint returns all User Groups.\n\nAvailable filter fields:\n  - `name`\n  - `disabled`\n  - `type`\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Get-JcSdkWorkdayImportWorkday](Get-JcSdkWorkdayImportWorkday.md)
This endpoint will return  all the available information about all your instances of Workday.\n\n##### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/workdays/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Get-JcSdkWorkdayImportWorkdayWorker](Get-JcSdkWorkdayImportWorkdayWorker.md)
This endpoint will return all of the data in your WorkDay Custom Report that has been associated with your WorkDay Instance in JumpCloud.\n\n##### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/workers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n\n```

### [Import-JcSdkWorkdayImportWorkday](Import-JcSdkWorkdayImportWorkday.md)
The endpoint allows you to create a Workday Import request.\n\n#### Sample Request \n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t\t\"email\":\"{email}\",\n\t\t\"firstname\":\"{firstname}\",\n\t\t\"lastname\":\"{firstname}\",\n\t\t\"username\":\"{username}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},\n\t\t\t{\"name\":\"WorkdayID\",\"value\":\"name.name\"}\n\t\t\t]\n\t\t\n\t}\n]\n```

### [Import-JcSdkWorkdayImportWorkdayResult](Import-JcSdkWorkdayImportWorkdayResult.md)
This endpoint provides a list of job results from the workday import and will contain all imported data from Workday.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import/{ImportJobID}/results \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [New-JcSdkBulkJobRequestBulkUserJob](New-JcSdkBulkJobRequestBulkUserJob.md)
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t\t\"email\":\"{email}\",\n\t\t\"firstname\":\"{firstname}\",\n\t\t\"lastname\":\"{firstname}\",\n\t\t\"username\":\"{username}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},\n\t\t\t{\"name\":\"Custom\",\"value\":\"attribute\"}\n\t\t]\n\t}\n]\n```

### [New-JcSdkBulkJobRequestBulkUserJobResult](New-JcSdkBulkJobRequestBulkUserJobResult.md)
This endpoint will return the results of particular user import or update job request.\n\n#### Sample Request\n```\ncurl -X GET \\\n  https://console.jumpcloud.com/api/v2/bulk/users/{ImportJobID}/results \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [New-JcSdkGSuiteTranslationRuleGSuite](New-JcSdkGSuiteTranslationRuleGSuite.md)
This endpoint allows you to create a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```

### [New-JcSdkOffice365TranslationRuleOffice365](New-JcSdkOffice365TranslationRuleOffice365.md)
This endpoint allows you to create a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```

### [New-JcSdkPolicy](New-JcSdkPolicy.md)
This endpoint allows you to create a policy.
Given the amount of configurable parameters required to create a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Policy_Parameters}\n}'\n\n```

### [New-JcSdkProviderAdmin](New-JcSdkProviderAdmin.md)
This endpoint allows you to create a provider administrator.
You must be associated to the provider to use this route.\n\n**Sample Request**\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n    -H 'Accept: application/json' \\\n    -H 'Context-Type: application/json' \\\n    -H 'x-api-key: {API_KEY}' \\\n    -d '{\n      \"email\":\"{ADMIN_EMAIL}\"\n    }'\n```

### [New-JcSdkSambaDomainLdapServerSambaDomain](New-JcSdkSambaDomainLdapServerSambaDomain.md)
This endpoint allows you to create a samba domain for an LDAP server.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\"sid\":\"{SID_ID}\",\n\"name\":\"{WORKGROUP_NAME}\"\n}'\n```

### [New-JcSdkSystemGroupSystem](New-JcSdkSystemGroupSystem.md)
This endpoint allows you to create a new System Group.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```

### [New-JcSdkUserGroupUser](New-JcSdkUserGroupUser.md)
This endpoint allows you to create a new User Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```

### [New-JcSdkWorkdayImportWorkday](New-JcSdkWorkdayImportWorkday.md)
This endpoint allows you to create a new workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\nCurrently, only one instance is allowed and it must be `Workday Import`.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"name\": \"Workday2\",\n  \"reportUrl\":\"https://workday.com/ccx/service/customreport2/gms/user/reportname?format=json\",\n  \"auth\": {\n    \"basic\": {\n      \"username\": \"someDeveloper\",\n      \"password\": \"notTheRealPassword\"\n    }\n  }\n}'\n```

### [New-JcSdkWorkdayImportWorkdayAuthorization](New-JcSdkWorkdayImportWorkdayAuthorization.md)
This endpoint adds an authorization method to a workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"auth\":{\n\t  \"basic\": {\n\t\t\"username\": \"someDeveloper\",\t  \n\t\t\"password\": \"notTheRealPassword\"\n\n\t  }\n\t}\n}'\n\n```

### [Remove-JcSdkGSuiteTranslationRuleGSuite](Remove-JcSdkGSuiteTranslationRuleGSuite.md)
This endpoint allows you to delete a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.\n\n#### Sample Request\n\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Remove-JcSdkOffice365TranslationRuleOffice365](Remove-JcSdkOffice365TranslationRuleOffice365.md)
This endpoint allows you to delete a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n#### Sample Request\n\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Remove-JcSdkPolicy](Remove-JcSdkPolicy.md)
This endpoint allows you to delete a policy.\n\n#### Sample Request\n\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/policies/5a837ecd232e110d4291e6b9 \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n  ```

### [Remove-JcSdkSambaDomainLdapServerSambaDomain](Remove-JcSdkSambaDomainLdapServerSambaDomain.md)
This endpoint allows you to delete a samba domain from an LDAP server.\n\n##### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Remove-JcSdkWorkdayImportWorkdayAuthorization](Remove-JcSdkWorkdayImportWorkdayAuthorization.md)
Removes any and all authorization methods from the workday instance\n\n##### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

### [Set-JcSdkGraphApplicationAssociation](Set-JcSdkGraphApplicationAssociation.md)
This endpoint allows you to manage the _direct_ associations of an Application.
A direct association can be a non-homogeneous relationship between 2 different objects, for example Application and User Groups.\n\n#### Sample Request\n```\ncurl -X POST 'https://console.jumpcloud.com/api/v2/applications/{Application_ID}/associations' \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```

### [Set-JcSdkGraphCommandAssociation](Set-JcSdkGraphCommandAssociation.md)
This endpoint will allow you to manage the _direct_ associations of this Command.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Commands and User Groups.\n\n\n#### Sample Request\n```\n curl -X POST https://console.jumpcloud.com/api/v2/commands/{Command_ID}/associations \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system_group\",\n    \"id\": \"Group_ID\"\n}'\n```

### [Set-JcSdkGraphGSuiteGraphGSuiteAssociation](Set-JcSdkGraphGSuiteGraphGSuiteAssociation.md)
This endpoint returns the _direct_ associations of this G Suite instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```

### [Set-JcSdkGraphLdapServerGraphLdapServerAssociation](Set-JcSdkGraphLdapServerGraphLdapServerAssociation.md)
This endpoint allows you to manage the _direct_ associations of a LDAP Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"{User_ID}\"\n}'\n```

### [Set-JcSdkGraphOffice365Association](Set-JcSdkGraphOffice365Association.md)
This endpoint allows you to manage the _direct_ associations of a Office 365 instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/office365s/{O365_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```

### [Set-JcSdkGraphPolicyAssociation](Set-JcSdkGraphPolicyAssociation.md)
This endpoint allows you to manage the _direct_ associations of a Policy.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Policies and Systems.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/associations/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system_group\",\n    \"id\": \"{Group_ID}\"\n}'\n```

### [Set-JcSdkGraphRadiusServerGraphRadiusServerAssociation](Set-JcSdkGraphRadiusServerGraphRadiusServerAssociation.md)
This endpoint allows you to manage the _direct_ associations of a Radius Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Radius Servers and Users.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/radiusservers/{RADIUS_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\n\"type\":\"user\", \n\"id\":\"{USER_ID}\", \n\"op\":\"add\"\n\t\n}'\n```

### [Set-JcSdkGraphSystemAssociation](Set-JcSdkGraphSystemAssociation.md)
This endpoint allows you to manage the _direct_ associations of a System.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n   \"attributes\": {\n      \"sudo\": {\n         \"enabled\": true,\n         \"withoutPassword\": false\n      }\n   },\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"UserID\"\n}'\n\n```

### [Set-JcSdkGraphSystemGroupAssociationGraphSystemGroupAssociation](Set-JcSdkGraphSystemGroupAssociationGraphSystemGroupAssociation.md)
This endpoint allows you to manage the _direct_ associations of a System Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example System Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"{UserID}\"\n}'\n\n```

### [Set-JcSdkGraphSystemGroupMemberMembershipGraphSystemGroupMember](Set-JcSdkGraphSystemGroupMemberMembershipGraphSystemGroupMember.md)
This endpoint allows you to manage the system members of a System Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system\",\n    \"id\": \"{System_ID}\"\n}'\n```

### [Set-JcSdkGraphUserAssociation](Set-JcSdkGraphUserAssociation.md)
This endpoint allows you to manage the _direct_ associations of a User.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Users and Systems.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/users/{UserID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n   \"attributes\": {\n      \"sudo\": {\n         \"enabled\": true,\n         \"withoutPassword\": false\n      }\n   },\n   \"op\": \"add\",\n   \"type\": \"system_group\",\n   \"id\": \"{GroupID}\"\n}'

### [Set-JcSdkGraphUserGroupAssociationGraphUserGroupAssociation](Set-JcSdkGraphUserGroupAssociationGraphUserGroupAssociation.md)
This endpoint manages the _direct_ associations of this User Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example User Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system\",\n    \"id\": \"{SystemID}\"\n}'\n\n```

### [Set-JcSdkGraphUserGroupMemberMembershipGraphUserGroupMember](Set-JcSdkGraphUserGroupMemberMembershipGraphUserGroupMember.md)
This endpoint allows you to manage the user members of a User Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"user\",\n    \"id\": \"{User_ID}\"\n}'\n```

### [Set-JcSdkPolicy](Set-JcSdkPolicy.md)
This endpoint allows you to update a policy.
Given the amount of configurable parameters required to update a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY' \\\n  -d '{\n    {Policy_Parameters}\n}'\n```

### [Set-JcSdkSambaDomainLdapServerSambaDomain](Set-JcSdkSambaDomainLdapServerSambaDomain.md)
This endpoint allows you to update the samba domain information for an LDAP server.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\"sid\":\"{SID_ID}\",\n\"name\":\"{WORKGROUP_NAME}\"\n}'\n\n```

### [Update-JcSdkBulkJobRequestBulkUser](Update-JcSdkBulkJobRequestBulkUser.md)
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/1.0/systemusers/update-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"department\":\"{UPDATED_DEPARTMENT}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}\n\t\t]\n\t},\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",\n\t\t\"phoneNumbers\":[\n\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},\n\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}\n\t\t]\n\t}\n]\n```

### [Update-JcSdkGSuite](Update-JcSdkGSuite.md)
This endpoint allows updating some attributes of a G Suite.\n\n##### Sample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"remove\",\n    \"userPasswordExpirationAction\": \"disable\"\n  }'\n```

### [Update-JcSdkLdapServer](Update-JcSdkLdapServer.md)
This endpoint allows updating some attributes of an LDAP server.\n\nSample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"remove\",\n    \"userPasswordExpirationAction\": \"disable\"\n  }'\n```

