namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>OrganizationSettingsPut</summary>
    public partial class Organizationsettingsput
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloudApiSdkV1.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloudApiSdkV1.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloudApiSdkV1.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloudApiSdkV1.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV1.Models.IOrganizationsettingsput.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV1.Models.IOrganizationsettingsput.</returns>
        public static JumpCloudApiSdkV1.Models.IOrganizationsettingsput FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV1.Runtime.Json.JsonObject json ? new Organizationsettingsput(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV1.Runtime.Json.JsonObject into a new instance of <see cref="Organizationsettingsput" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Organizationsettingsput(JumpCloudApiSdkV1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_features = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("features"), out var __jsonFeatures) ? JumpCloudApiSdkV1.Models.OrganizationsettingsputFeatures.FromJson(__jsonFeatures) : Features;}
            {_passwordPolicy = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("passwordPolicy"), out var __jsonPasswordPolicy) ? JumpCloudApiSdkV1.Models.OrganizationsettingsputPasswordPolicy.FromJson(__jsonPasswordPolicy) : PasswordPolicy;}
            {_userPortal = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("userPortal"), out var __jsonUserPortal) ? JumpCloudApiSdkV1.Models.OrganizationsettingsputUserPortal.FromJson(__jsonUserPortal) : UserPortal;}
            {_name = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_contactEmail = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("contactEmail"), out var __jsonContactEmail) ? (string)__jsonContactEmail : (string)ContactEmail;}
            {_contactName = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("contactName"), out var __jsonContactName) ? (string)__jsonContactName : (string)ContactName;}
            {_disableLdap = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("disableLdap"), out var __jsonDisableLdap) ? (bool?)__jsonDisableLdap : DisableLdap;}
            {_disableUm = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("disableUM"), out var __jsonDisableUm) ? (bool?)__jsonDisableUm : DisableUm;}
            {_duplicateLdapGroups = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("duplicateLDAPGroups"), out var __jsonDuplicateLdapGroups) ? (bool?)__jsonDuplicateLdapGroups : DuplicateLdapGroups;}
            {_emailDisclaimer = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("emailDisclaimer"), out var __jsonEmailDisclaimer) ? (string)__jsonEmailDisclaimer : (string)EmailDisclaimer;}
            {_enableManagedUid = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("enableManagedUID"), out var __jsonEnableManagedUid) ? (bool?)__jsonEnableManagedUid : EnableManagedUid;}
            {_logo = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("logo"), out var __jsonLogo) ? (string)__jsonLogo : (string)Logo;}
            {_passwordCompliance = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("passwordCompliance"), out var __jsonPasswordCompliance) ? (string)__jsonPasswordCompliance : (string)PasswordCompliance;}
            {_showIntro = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("showIntro"), out var __jsonShowIntro) ? (bool?)__jsonShowIntro : ShowIntro;}
            {_systemUserPasswordExpirationInDays = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonNumber>("systemUserPasswordExpirationInDays"), out var __jsonSystemUserPasswordExpirationInDays) ? (int?)__jsonSystemUserPasswordExpirationInDays : SystemUserPasswordExpirationInDays;}
            {_systemUsersCanEdit = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("systemUsersCanEdit"), out var __jsonSystemUsersCanEdit) ? (bool?)__jsonSystemUsersCanEdit : SystemUsersCanEdit;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Organizationsettingsput" /> into a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Organizationsettingsput" /> as a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloudApiSdkV1.Runtime.Json.JsonNode ToJson(JumpCloudApiSdkV1.Runtime.Json.JsonObject container, JumpCloudApiSdkV1.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloudApiSdkV1.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._features ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._features.ToJson(null,serializationMode) : null, "features" ,container.Add );
            AddIf( null != this._passwordPolicy ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._passwordPolicy.ToJson(null,serializationMode) : null, "passwordPolicy" ,container.Add );
            AddIf( null != this._userPortal ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._userPortal.ToJson(null,serializationMode) : null, "userPortal" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._contactEmail)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._contactEmail.ToString()) : null, "contactEmail" ,container.Add );
            AddIf( null != (((object)this._contactName)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._contactName.ToString()) : null, "contactName" ,container.Add );
            AddIf( null != this._disableLdap ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._disableLdap) : null, "disableLdap" ,container.Add );
            AddIf( null != this._disableUm ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._disableUm) : null, "disableUM" ,container.Add );
            AddIf( null != this._duplicateLdapGroups ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._duplicateLdapGroups) : null, "duplicateLDAPGroups" ,container.Add );
            AddIf( null != (((object)this._emailDisclaimer)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._emailDisclaimer.ToString()) : null, "emailDisclaimer" ,container.Add );
            AddIf( null != this._enableManagedUid ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._enableManagedUid) : null, "enableManagedUID" ,container.Add );
            AddIf( null != (((object)this._logo)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._logo.ToString()) : null, "logo" ,container.Add );
            AddIf( null != (((object)this._passwordCompliance)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._passwordCompliance.ToString()) : null, "passwordCompliance" ,container.Add );
            AddIf( null != this._showIntro ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._showIntro) : null, "showIntro" ,container.Add );
            AddIf( null != this._systemUserPasswordExpirationInDays ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonNumber((int)this._systemUserPasswordExpirationInDays) : null, "systemUserPasswordExpirationInDays" ,container.Add );
            AddIf( null != this._systemUsersCanEdit ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._systemUsersCanEdit) : null, "systemUsersCanEdit" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}