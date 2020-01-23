namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>SystemUser</summary>
    public partial class Systemuser
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloudApiSdkV2.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloudApiSdkV2.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloudApiSdkV2.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloudApiSdkV2.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.ISystemuser.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.ISystemuser.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemuser FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new Systemuser(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="Systemuser" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Systemuser(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_mfa = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonObject>("mfa"), out var __jsonMfa) ? JumpCloudApiSdkV2.Models.Mfa.FromJson(__jsonMfa) : Mfa;}
            {_description = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_id = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("_id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_accountLocked = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("account_locked"), out var __jsonAccountLocked) ? (bool?)__jsonAccountLocked : AccountLocked;}
            {_activated = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("activated"), out var __jsonActivated) ? (bool?)__jsonActivated : Activated;}
            {_allowPublicKey = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("allow_public_key"), out var __jsonAllowPublicKey) ? (bool?)__jsonAllowPublicKey : AllowPublicKey;}
            {_associatedTagCount = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("associatedTagCount"), out var __jsonAssociatedTagCount) ? (int?)__jsonAssociatedTagCount : AssociatedTagCount;}
            {_attributes = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonArray>("attributes"), out var __jsonAttributes) ? If( __jsonAttributes as JumpCloudApiSdkV2.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<JumpCloudApiSdkV2.Models.ISystemuserAttributesItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(JumpCloudApiSdkV2.Models.ISystemuserAttributesItem) (JumpCloudApiSdkV2.Models.SystemuserAttributesItem.FromJson(__u) )) ))() : null : Attributes;}
            {_company = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("company"), out var __jsonCompany) ? (string)__jsonCompany : (string)Company;}
            {_costCenter = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("costCenter"), out var __jsonCostCenter) ? (string)__jsonCostCenter : (string)CostCenter;}
            {_created = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("created"), out var __jsonCreated) ? (string)__jsonCreated : (string)Created;}
            {_department = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("department"), out var __jsonDepartment) ? (string)__jsonDepartment : (string)Department;}
            {_displayname = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("displayname"), out var __jsonDisplayname) ? (string)__jsonDisplayname : (string)Displayname;}
            {_email = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("email"), out var __jsonEmail) ? (string)__jsonEmail : (string)Email;}
            {_employeeIdentifier = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("employeeIdentifier"), out var __jsonEmployeeIdentifier) ? (string)__jsonEmployeeIdentifier : (string)EmployeeIdentifier;}
            {_employeeType = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("employeeType"), out var __jsonEmployeeType) ? (string)__jsonEmployeeType : (string)EmployeeType;}
            {_enableManagedUid = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("enable_managed_uid"), out var __jsonEnableManagedUid) ? (bool?)__jsonEnableManagedUid : EnableManagedUid;}
            {_enableUserPortalMultifactor = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("enable_user_portal_multifactor"), out var __jsonEnableUserPortalMultifactor) ? (bool?)__jsonEnableUserPortalMultifactor : EnableUserPortalMultifactor;}
            {_externalDn = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("external_dn"), out var __jsonExternalDn) ? (string)__jsonExternalDn : (string)ExternalDn;}
            {_externalPasswordExpirationDate = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("external_password_expiration_date"), out var __jsonExternalPasswordExpirationDate) ? (string)__jsonExternalPasswordExpirationDate : (string)ExternalPasswordExpirationDate;}
            {_externalSourceType = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("external_source_type"), out var __jsonExternalSourceType) ? (string)__jsonExternalSourceType : (string)ExternalSourceType;}
            {_externallyManaged = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("externally_managed"), out var __jsonExternallyManaged) ? (bool?)__jsonExternallyManaged : ExternallyManaged;}
            {_firstname = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("firstname"), out var __jsonFirstname) ? (string)__jsonFirstname : (string)Firstname;}
            {_jobTitle = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("jobTitle"), out var __jsonJobTitle) ? (string)__jsonJobTitle : (string)JobTitle;}
            {_lastname = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("lastname"), out var __jsonLastname) ? (string)__jsonLastname : (string)Lastname;}
            {_ldapBindingUser = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("ldap_binding_user"), out var __jsonLdapBindingUser) ? (bool?)__jsonLdapBindingUser : LdapBindingUser;}
            {_location = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)Location;}
            {_middlename = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("middlename"), out var __jsonMiddlename) ? (string)__jsonMiddlename : (string)Middlename;}
            {_passwordExpirationDate = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("password_expiration_date"), out var __jsonPasswordExpirationDate) ? (string)__jsonPasswordExpirationDate : (string)PasswordExpirationDate;}
            {_passwordExpired = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("password_expired"), out var __jsonPasswordExpired) ? (bool?)__jsonPasswordExpired : PasswordExpired;}
            {_passwordNeverExpires = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("password_never_expires"), out var __jsonPasswordNeverExpires) ? (bool?)__jsonPasswordNeverExpires : PasswordNeverExpires;}
            {_passwordlessSudo = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("passwordless_sudo"), out var __jsonPasswordlessSudo) ? (bool?)__jsonPasswordlessSudo : PasswordlessSudo;}
            {_publicKey = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("public_key"), out var __jsonPublicKey) ? (string)__jsonPublicKey : (string)PublicKey;}
            {_sambaServiceUser = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("samba_service_user"), out var __jsonSambaServiceUser) ? (bool?)__jsonSambaServiceUser : SambaServiceUser;}
            {_sshKeys = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonArray>("ssh_keys"), out var __jsonSshKeys) ? If( __jsonSshKeys as JumpCloudApiSdkV2.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<JumpCloudApiSdkV2.Models.ISshkeylist[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(JumpCloudApiSdkV2.Models.ISshkeylist) (JumpCloudApiSdkV2.Models.Sshkeylist.FromJson(__p) )) ))() : null : SshKeys;}
            {_sudo = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("sudo"), out var __jsonSudo) ? (bool?)__jsonSudo : Sudo;}
            {_suspended = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("suspended"), out var __jsonSuspended) ? (bool?)__jsonSuspended : Suspended;}
            {_tags = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonArray>("tags"), out var __jsonTags) ? If( __jsonTags as JumpCloudApiSdkV2.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is JumpCloudApiSdkV2.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : Tags;}
            {_totpEnabled = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonBoolean>("totp_enabled"), out var __jsonTotpEnabled) ? (bool?)__jsonTotpEnabled : TotpEnabled;}
            {_unixGuid = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("unix_guid"), out var __jsonUnixGuid) ? (int?)__jsonUnixGuid : UnixGuid;}
            {_unixUid = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("unix_uid"), out var __jsonUnixUid) ? (int?)__jsonUnixUid : UnixUid;}
            {_username = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("username"), out var __jsonUsername) ? (string)__jsonUsername : (string)Username;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Systemuser" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Systemuser" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloudApiSdkV2.Runtime.Json.JsonNode ToJson(JumpCloudApiSdkV2.Runtime.Json.JsonObject container, JumpCloudApiSdkV2.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloudApiSdkV2.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._mfa ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) this._mfa.ToJson(null,serializationMode) : null, "mfa" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._id.ToString()) : null, "_id" ,container.Add );
            AddIf( null != this._accountLocked ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._accountLocked) : null, "account_locked" ,container.Add );
            AddIf( null != this._activated ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._activated) : null, "activated" ,container.Add );
            AddIf( null != this._allowPublicKey ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._allowPublicKey) : null, "allow_public_key" ,container.Add );
            AddIf( null != this._associatedTagCount ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._associatedTagCount) : null, "associatedTagCount" ,container.Add );
            if (null != this._attributes)
            {
                var __w = new JumpCloudApiSdkV2.Runtime.Json.XNodeArray();
                foreach( var __x in this._attributes )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("attributes",__w);
            }
            AddIf( null != (((object)this._company)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._company.ToString()) : null, "company" ,container.Add );
            AddIf( null != (((object)this._costCenter)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._costCenter.ToString()) : null, "costCenter" ,container.Add );
            AddIf( null != (((object)this._created)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._created.ToString()) : null, "created" ,container.Add );
            AddIf( null != (((object)this._department)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._department.ToString()) : null, "department" ,container.Add );
            AddIf( null != (((object)this._displayname)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._displayname.ToString()) : null, "displayname" ,container.Add );
            AddIf( null != (((object)this._email)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._email.ToString()) : null, "email" ,container.Add );
            AddIf( null != (((object)this._employeeIdentifier)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._employeeIdentifier.ToString()) : null, "employeeIdentifier" ,container.Add );
            AddIf( null != (((object)this._employeeType)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._employeeType.ToString()) : null, "employeeType" ,container.Add );
            AddIf( null != this._enableManagedUid ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._enableManagedUid) : null, "enable_managed_uid" ,container.Add );
            AddIf( null != this._enableUserPortalMultifactor ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._enableUserPortalMultifactor) : null, "enable_user_portal_multifactor" ,container.Add );
            AddIf( null != (((object)this._externalDn)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._externalDn.ToString()) : null, "external_dn" ,container.Add );
            AddIf( null != (((object)this._externalPasswordExpirationDate)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._externalPasswordExpirationDate.ToString()) : null, "external_password_expiration_date" ,container.Add );
            AddIf( null != (((object)this._externalSourceType)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._externalSourceType.ToString()) : null, "external_source_type" ,container.Add );
            AddIf( null != this._externallyManaged ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._externallyManaged) : null, "externally_managed" ,container.Add );
            AddIf( null != (((object)this._firstname)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._firstname.ToString()) : null, "firstname" ,container.Add );
            AddIf( null != (((object)this._jobTitle)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._jobTitle.ToString()) : null, "jobTitle" ,container.Add );
            AddIf( null != (((object)this._lastname)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._lastname.ToString()) : null, "lastname" ,container.Add );
            AddIf( null != this._ldapBindingUser ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._ldapBindingUser) : null, "ldap_binding_user" ,container.Add );
            AddIf( null != (((object)this._location)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._location.ToString()) : null, "location" ,container.Add );
            AddIf( null != (((object)this._middlename)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._middlename.ToString()) : null, "middlename" ,container.Add );
            AddIf( null != (((object)this._passwordExpirationDate)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._passwordExpirationDate.ToString()) : null, "password_expiration_date" ,container.Add );
            AddIf( null != this._passwordExpired ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._passwordExpired) : null, "password_expired" ,container.Add );
            AddIf( null != this._passwordNeverExpires ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._passwordNeverExpires) : null, "password_never_expires" ,container.Add );
            AddIf( null != this._passwordlessSudo ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._passwordlessSudo) : null, "passwordless_sudo" ,container.Add );
            AddIf( null != (((object)this._publicKey)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._publicKey.ToString()) : null, "public_key" ,container.Add );
            AddIf( null != this._sambaServiceUser ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._sambaServiceUser) : null, "samba_service_user" ,container.Add );
            if (null != this._sshKeys)
            {
                var __r = new JumpCloudApiSdkV2.Runtime.Json.XNodeArray();
                foreach( var __s in this._sshKeys )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("ssh_keys",__r);
            }
            AddIf( null != this._sudo ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._sudo) : null, "sudo" ,container.Add );
            AddIf( null != this._suspended ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._suspended) : null, "suspended" ,container.Add );
            if (null != this._tags)
            {
                var __m = new JumpCloudApiSdkV2.Runtime.Json.XNodeArray();
                foreach( var __n in this._tags )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("tags",__m);
            }
            AddIf( null != this._totpEnabled ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonBoolean((bool)this._totpEnabled) : null, "totp_enabled" ,container.Add );
            AddIf( null != this._unixGuid ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._unixGuid) : null, "unix_guid" ,container.Add );
            AddIf( null != this._unixUid ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._unixUid) : null, "unix_uid" ,container.Add );
            AddIf( null != (((object)this._username)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._username.ToString()) : null, "username" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}