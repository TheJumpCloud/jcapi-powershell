namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>SystemUserPut</summary>
    public partial class Systemuserput
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloud.SDK.V1.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloud.SDK.V1.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloud.SDK.V1.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloud.SDK.V1.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.ISystemuserput.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.ISystemuserput.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserput FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new Systemuserput(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="Systemuserput" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Systemuserput(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_mfa = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonObject>("mfa"), out var __jsonMfa) ? JumpCloud.SDK.V1.Models.Mfa.FromJson(__jsonMfa) : Mfa;}
            {_description = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_accountLocked = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("account_locked"), out var __jsonAccountLocked) ? (bool?)__jsonAccountLocked : AccountLocked;}
            {_addresses = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("addresses"), out var __jsonAddresses) ? If( __jsonAddresses as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<JumpCloud.SDK.V1.Models.ISystemuserputAddressesItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(JumpCloud.SDK.V1.Models.ISystemuserputAddressesItem) (JumpCloud.SDK.V1.Models.SystemuserputAddressesItem.FromJson(__u) )) ))() : null : Addresses;}
            {_allowPublicKey = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allow_public_key"), out var __jsonAllowPublicKey) ? (bool?)__jsonAllowPublicKey : AllowPublicKey;}
            {_attributes = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("attributes"), out var __jsonAttributes) ? If( __jsonAttributes as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<JumpCloud.SDK.V1.Models.ISystemuserputAttributesItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(JumpCloud.SDK.V1.Models.ISystemuserputAttributesItem) (JumpCloud.SDK.V1.Models.SystemuserputAttributesItem.FromJson(__p) )) ))() : null : Attributes;}
            {_company = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("company"), out var __jsonCompany) ? (string)__jsonCompany : (string)Company;}
            {_costCenter = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("costCenter"), out var __jsonCostCenter) ? (string)__jsonCostCenter : (string)CostCenter;}
            {_department = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("department"), out var __jsonDepartment) ? (string)__jsonDepartment : (string)Department;}
            {_displayname = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("displayname"), out var __jsonDisplayname) ? (string)__jsonDisplayname : (string)Displayname;}
            {_email = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("email"), out var __jsonEmail) ? (string)__jsonEmail : (string)Email;}
            {_employeeIdentifier = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("employeeIdentifier"), out var __jsonEmployeeIdentifier) ? (string)__jsonEmployeeIdentifier : (string)EmployeeIdentifier;}
            {_employeeType = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("employeeType"), out var __jsonEmployeeType) ? (string)__jsonEmployeeType : (string)EmployeeType;}
            {_enableManagedUid = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enable_managed_uid"), out var __jsonEnableManagedUid) ? (bool?)__jsonEnableManagedUid : EnableManagedUid;}
            {_enableUserPortalMultifactor = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enable_user_portal_multifactor"), out var __jsonEnableUserPortalMultifactor) ? (bool?)__jsonEnableUserPortalMultifactor : EnableUserPortalMultifactor;}
            {_externalDn = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("external_dn"), out var __jsonExternalDn) ? (string)__jsonExternalDn : (string)ExternalDn;}
            {_externalPasswordExpirationDate = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("external_password_expiration_date"), out var __jsonExternalPasswordExpirationDate) ? (string)__jsonExternalPasswordExpirationDate : (string)ExternalPasswordExpirationDate;}
            {_externalSourceType = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("external_source_type"), out var __jsonExternalSourceType) ? (string)__jsonExternalSourceType : (string)ExternalSourceType;}
            {_externallyManaged = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("externally_managed"), out var __jsonExternallyManaged) ? (bool?)__jsonExternallyManaged : ExternallyManaged;}
            {_firstname = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("firstname"), out var __jsonFirstname) ? (string)__jsonFirstname : (string)Firstname;}
            {_jobTitle = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("jobTitle"), out var __jsonJobTitle) ? (string)__jsonJobTitle : (string)JobTitle;}
            {_lastname = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("lastname"), out var __jsonLastname) ? (string)__jsonLastname : (string)Lastname;}
            {_ldapBindingUser = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("ldap_binding_user"), out var __jsonLdapBindingUser) ? (bool?)__jsonLdapBindingUser : LdapBindingUser;}
            {_location = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)Location;}
            {_middlename = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("middlename"), out var __jsonMiddlename) ? (string)__jsonMiddlename : (string)Middlename;}
            {_password = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("password"), out var __jsonPassword) ? (string)__jsonPassword : (string)Password;}
            {_passwordNeverExpires = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("password_never_expires"), out var __jsonPasswordNeverExpires) ? (bool?)__jsonPasswordNeverExpires : PasswordNeverExpires;}
            {_phoneNumbers = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("phoneNumbers"), out var __jsonPhoneNumbers) ? If( __jsonPhoneNumbers as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<JumpCloud.SDK.V1.Models.ISystemuserputPhoneNumbersItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(JumpCloud.SDK.V1.Models.ISystemuserputPhoneNumbersItem) (JumpCloud.SDK.V1.Models.SystemuserputPhoneNumbersItem.FromJson(__k) )) ))() : null : PhoneNumbers;}
            {_publicKey = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("public_key"), out var __jsonPublicKey) ? (string)__jsonPublicKey : (string)PublicKey;}
            {_relationships = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("relationships"), out var __jsonRelationships) ? If( __jsonRelationships as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<JumpCloud.SDK.V1.Models.ISystemuserputRelationshipsItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(JumpCloud.SDK.V1.Models.ISystemuserputRelationshipsItem) (JumpCloud.SDK.V1.Models.SystemuserputRelationshipsItem.FromJson(__f) )) ))() : null : Relationships;}
            {_sambaServiceUser = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("samba_service_user"), out var __jsonSambaServiceUser) ? (bool?)__jsonSambaServiceUser : SambaServiceUser;}
            {_sshKeys = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("ssh_keys"), out var __jsonSshKeys) ? If( __jsonSshKeys as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<JumpCloud.SDK.V1.Models.ISshkeypost[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(JumpCloud.SDK.V1.Models.ISshkeypost) (JumpCloud.SDK.V1.Models.Sshkeypost.FromJson(__a) )) ))() : null : SshKeys;}
            {_sudo = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("sudo"), out var __jsonSudo) ? (bool?)__jsonSudo : Sudo;}
            {_suspended = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("suspended"), out var __jsonSuspended) ? (bool?)__jsonSuspended : Suspended;}
            {_tags = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("tags"), out var __jsonTags) ? If( __jsonTags as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___w, (___v)=>(string) (___v is JumpCloud.SDK.V1.Runtime.Json.JsonString ___u ? (string)(___u.ToString()) : null)) ))() : null : Tags;}
            {_unixGuid = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("unix_guid"), out var __jsonUnixGuid) ? (int?)__jsonUnixGuid : UnixGuid;}
            {_unixUid = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("unix_uid"), out var __jsonUnixUid) ? (int?)__jsonUnixUid : UnixUid;}
            {_username = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("username"), out var __jsonUsername) ? (string)__jsonUsername : (string)Username;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Systemuserput" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Systemuserput" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloud.SDK.V1.Runtime.Json.JsonNode ToJson(JumpCloud.SDK.V1.Runtime.Json.JsonObject container, JumpCloud.SDK.V1.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloud.SDK.V1.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._mfa ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) this._mfa.ToJson(null,serializationMode) : null, "mfa" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != this._accountLocked ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._accountLocked) : null, "account_locked" ,container.Add );
            if (null != this._addresses)
            {
                var __w = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __x in this._addresses )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("addresses",__w);
            }
            AddIf( null != this._allowPublicKey ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowPublicKey) : null, "allow_public_key" ,container.Add );
            if (null != this._attributes)
            {
                var __r = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __s in this._attributes )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("attributes",__r);
            }
            AddIf( null != (((object)this._company)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._company.ToString()) : null, "company" ,container.Add );
            AddIf( null != (((object)this._costCenter)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._costCenter.ToString()) : null, "costCenter" ,container.Add );
            AddIf( null != (((object)this._department)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._department.ToString()) : null, "department" ,container.Add );
            AddIf( null != (((object)this._displayname)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._displayname.ToString()) : null, "displayname" ,container.Add );
            AddIf( null != (((object)this._email)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._email.ToString()) : null, "email" ,container.Add );
            AddIf( null != (((object)this._employeeIdentifier)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._employeeIdentifier.ToString()) : null, "employeeIdentifier" ,container.Add );
            AddIf( null != (((object)this._employeeType)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._employeeType.ToString()) : null, "employeeType" ,container.Add );
            AddIf( null != this._enableManagedUid ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableManagedUid) : null, "enable_managed_uid" ,container.Add );
            AddIf( null != this._enableUserPortalMultifactor ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableUserPortalMultifactor) : null, "enable_user_portal_multifactor" ,container.Add );
            AddIf( null != (((object)this._externalDn)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._externalDn.ToString()) : null, "external_dn" ,container.Add );
            AddIf( null != (((object)this._externalPasswordExpirationDate)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._externalPasswordExpirationDate.ToString()) : null, "external_password_expiration_date" ,container.Add );
            AddIf( null != (((object)this._externalSourceType)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._externalSourceType.ToString()) : null, "external_source_type" ,container.Add );
            AddIf( null != this._externallyManaged ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._externallyManaged) : null, "externally_managed" ,container.Add );
            AddIf( null != (((object)this._firstname)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._firstname.ToString()) : null, "firstname" ,container.Add );
            AddIf( null != (((object)this._jobTitle)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._jobTitle.ToString()) : null, "jobTitle" ,container.Add );
            AddIf( null != (((object)this._lastname)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._lastname.ToString()) : null, "lastname" ,container.Add );
            AddIf( null != this._ldapBindingUser ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._ldapBindingUser) : null, "ldap_binding_user" ,container.Add );
            AddIf( null != (((object)this._location)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._location.ToString()) : null, "location" ,container.Add );
            AddIf( null != (((object)this._middlename)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._middlename.ToString()) : null, "middlename" ,container.Add );
            AddIf( null != (((object)this._password)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._password.ToString()) : null, "password" ,container.Add );
            AddIf( null != this._passwordNeverExpires ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._passwordNeverExpires) : null, "password_never_expires" ,container.Add );
            if (null != this._phoneNumbers)
            {
                var __m = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __n in this._phoneNumbers )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("phoneNumbers",__m);
            }
            AddIf( null != (((object)this._publicKey)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._publicKey.ToString()) : null, "public_key" ,container.Add );
            if (null != this._relationships)
            {
                var __h = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __i in this._relationships )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("relationships",__h);
            }
            AddIf( null != this._sambaServiceUser ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._sambaServiceUser) : null, "samba_service_user" ,container.Add );
            if (null != this._sshKeys)
            {
                var __c = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __d in this._sshKeys )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("ssh_keys",__c);
            }
            AddIf( null != this._sudo ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._sudo) : null, "sudo" ,container.Add );
            AddIf( null != this._suspended ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._suspended) : null, "suspended" ,container.Add );
            if (null != this._tags)
            {
                var ___x = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var ___y in this._tags )
                {
                    AddIf(null != (((object)___y)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(___y.ToString()) : null ,___x.Add);
                }
                container.Add("tags",___x);
            }
            AddIf( null != this._unixGuid ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._unixGuid) : null, "unix_guid" ,container.Add );
            AddIf( null != this._unixUid ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._unixUid) : null, "unix_uid" ,container.Add );
            AddIf( null != (((object)this._username)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._username.ToString()) : null, "username" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}