// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6219, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>OrganizationSettings</summary>
    public partial class Organizationsettings
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
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.IOrganizationsettings.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.IOrganizationsettings.</returns>
        public static JumpCloud.SDK.V1.Models.IOrganizationsettings FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new Organizationsettings(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="Organizationsettings" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Organizationsettings(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_features = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonObject>("features"), out var __jsonFeatures) ? JumpCloud.SDK.V1.Models.OrganizationsettingsFeatures.FromJson(__jsonFeatures) : Features;}
            {_passwordPolicy = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonObject>("passwordPolicy"), out var __jsonPasswordPolicy) ? JumpCloud.SDK.V1.Models.OrganizationsettingsPasswordPolicy.FromJson(__jsonPasswordPolicy) : PasswordPolicy;}
            {_userPortal = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonObject>("userPortal"), out var __jsonUserPortal) ? JumpCloud.SDK.V1.Models.OrganizationsettingsUserPortal.FromJson(__jsonUserPortal) : UserPortal;}
            {_name = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_betaFeatures = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("betaFeatures"), out var __jsonBetaFeatures) ? If( __jsonBetaFeatures as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<bool[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(bool) (__u is JumpCloud.SDK.V1.Runtime.Json.JsonBoolean __t ? (bool)__t : default(bool))) ))() : null : BetaFeatures;}
            {_contactEmail = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("contactEmail"), out var __jsonContactEmail) ? (string)__jsonContactEmail : (string)ContactEmail;}
            {_contactName = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("contactName"), out var __jsonContactName) ? (string)__jsonContactName : (string)ContactName;}
            {_disableLdap = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("disableLdap"), out var __jsonDisableLdap) ? (bool?)__jsonDisableLdap : DisableLdap;}
            {_disableUm = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("disableUM"), out var __jsonDisableUm) ? (bool?)__jsonDisableUm : DisableUm;}
            {_duplicateLdapGroups = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("duplicateLDAPGroups"), out var __jsonDuplicateLdapGroups) ? (bool?)__jsonDuplicateLdapGroups : DuplicateLdapGroups;}
            {_emailDisclaimer = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("emailDisclaimer"), out var __jsonEmailDisclaimer) ? (string)__jsonEmailDisclaimer : (string)EmailDisclaimer;}
            {_enableGoogleApps = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableGoogleApps"), out var __jsonEnableGoogleApps) ? (bool?)__jsonEnableGoogleApps : EnableGoogleApps;}
            {_enableManagedUid = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableManagedUID"), out var __jsonEnableManagedUid) ? (bool?)__jsonEnableManagedUid : EnableManagedUid;}
            {_enableO365 = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableO365"), out var __jsonEnableO365) ? (bool?)__jsonEnableO365 : EnableO365;}
            {_logo = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("logo"), out var __jsonLogo) ? (string)__jsonLogo : (string)Logo;}
            {_passwordCompliance = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("passwordCompliance"), out var __jsonPasswordCompliance) ? (string)__jsonPasswordCompliance : (string)PasswordCompliance;}
            {_showIntro = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("showIntro"), out var __jsonShowIntro) ? (bool?)__jsonShowIntro : ShowIntro;}
            {_systemUserPasswordExpirationInDays = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("systemUserPasswordExpirationInDays"), out var __jsonSystemUserPasswordExpirationInDays) ? (int?)__jsonSystemUserPasswordExpirationInDays : SystemUserPasswordExpirationInDays;}
            {_systemUsersCanEdit = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("systemUsersCanEdit"), out var __jsonSystemUsersCanEdit) ? (bool?)__jsonSystemUsersCanEdit : SystemUsersCanEdit;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Organizationsettings" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Organizationsettings" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._features ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) this._features.ToJson(null,serializationMode) : null, "features" ,container.Add );
            AddIf( null != this._passwordPolicy ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) this._passwordPolicy.ToJson(null,serializationMode) : null, "passwordPolicy" ,container.Add );
            AddIf( null != this._userPortal ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) this._userPortal.ToJson(null,serializationMode) : null, "userPortal" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            if (null != this._betaFeatures)
            {
                var __w = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __x in this._betaFeatures )
                {
                    AddIf((JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean(__x) ,__w.Add);
                }
                container.Add("betaFeatures",__w);
            }
            AddIf( null != (((object)this._contactEmail)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._contactEmail.ToString()) : null, "contactEmail" ,container.Add );
            AddIf( null != (((object)this._contactName)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._contactName.ToString()) : null, "contactName" ,container.Add );
            AddIf( null != this._disableLdap ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._disableLdap) : null, "disableLdap" ,container.Add );
            AddIf( null != this._disableUm ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._disableUm) : null, "disableUM" ,container.Add );
            AddIf( null != this._duplicateLdapGroups ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._duplicateLdapGroups) : null, "duplicateLDAPGroups" ,container.Add );
            AddIf( null != (((object)this._emailDisclaimer)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._emailDisclaimer.ToString()) : null, "emailDisclaimer" ,container.Add );
            AddIf( null != this._enableGoogleApps ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableGoogleApps) : null, "enableGoogleApps" ,container.Add );
            AddIf( null != this._enableManagedUid ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableManagedUid) : null, "enableManagedUID" ,container.Add );
            AddIf( null != this._enableO365 ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableO365) : null, "enableO365" ,container.Add );
            AddIf( null != (((object)this._logo)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._logo.ToString()) : null, "logo" ,container.Add );
            AddIf( null != (((object)this._passwordCompliance)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._passwordCompliance.ToString()) : null, "passwordCompliance" ,container.Add );
            AddIf( null != this._showIntro ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._showIntro) : null, "showIntro" ,container.Add );
            AddIf( null != this._systemUserPasswordExpirationInDays ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._systemUserPasswordExpirationInDays) : null, "systemUserPasswordExpirationInDays" ,container.Add );
            AddIf( null != this._systemUsersCanEdit ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._systemUsersCanEdit) : null, "systemUsersCanEdit" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}