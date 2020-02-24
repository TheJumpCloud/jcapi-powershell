// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>UserReturn</summary>
    public partial class Userreturn
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
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.IUserreturn.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.IUserreturn.</returns>
        public static JumpCloud.SDK.V1.Models.IUserreturn FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new Userreturn(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Userreturn" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Userreturn" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._id.ToString()) : null, "_id" ,container.Add );
            AddIf( null != (((object)this._created)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._created.ToString()) : null, "created" ,container.Add );
            AddIf( null != this._disableIntroduction ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._disableIntroduction) : null, "disableIntroduction" ,container.Add );
            AddIf( null != (((object)this._email)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._email.ToString()) : null, "email" ,container.Add );
            AddIf( null != this._enableMultiFactor ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableMultiFactor) : null, "enableMultiFactor" ,container.Add );
            AddIf( null != this._enableWhatsNew ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableWhatsNew) : null, "enableWhatsNew" ,container.Add );
            AddIf( null != (((object)this._firstname)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._firstname.ToString()) : null, "firstname" ,container.Add );
            AddIf( null != (((object)this._lastWhatsNewChecked)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._lastWhatsNewChecked.ToString()) : null, "lastWhatsNewChecked" ,container.Add );
            AddIf( null != (((object)this._lastname)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._lastname.ToString()) : null, "lastname" ,container.Add );
            AddIf( null != (((object)this._organization)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._organization.ToString()) : null, "organization" ,container.Add );
            AddIf( null != (((object)this._provider)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._provider.ToString()) : null, "provider" ,container.Add );
            AddIf( null != (((object)this._role)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._role.ToString()) : null, "role" ,container.Add );
            AddIf( null != (((object)this._roleName)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._roleName.ToString()) : null, "roleName" ,container.Add );
            AddIf( null != (((object)this._usersTimeZone)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._usersTimeZone.ToString()) : null, "usersTimeZone" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="Userreturn" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Userreturn(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_id = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("_id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_created = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("created"), out var __jsonCreated) ? (string)__jsonCreated : (string)Created;}
            {_disableIntroduction = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("disableIntroduction"), out var __jsonDisableIntroduction) ? (bool?)__jsonDisableIntroduction : DisableIntroduction;}
            {_email = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("email"), out var __jsonEmail) ? (string)__jsonEmail : (string)Email;}
            {_enableMultiFactor = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableMultiFactor"), out var __jsonEnableMultiFactor) ? (bool?)__jsonEnableMultiFactor : EnableMultiFactor;}
            {_enableWhatsNew = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableWhatsNew"), out var __jsonEnableWhatsNew) ? (bool?)__jsonEnableWhatsNew : EnableWhatsNew;}
            {_firstname = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("firstname"), out var __jsonFirstname) ? (string)__jsonFirstname : (string)Firstname;}
            {_lastWhatsNewChecked = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("lastWhatsNewChecked"), out var __jsonLastWhatsNewChecked) ? (string)__jsonLastWhatsNewChecked : (string)LastWhatsNewChecked;}
            {_lastname = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("lastname"), out var __jsonLastname) ? (string)__jsonLastname : (string)Lastname;}
            {_organization = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("organization"), out var __jsonOrganization) ? (string)__jsonOrganization : (string)Organization;}
            {_provider = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("provider"), out var __jsonProvider) ? (string)__jsonProvider : (string)Provider;}
            {_role = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("role"), out var __jsonRole) ? (string)__jsonRole : (string)Role;}
            {_roleName = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("roleName"), out var __jsonRoleName) ? (string)__jsonRoleName : (string)RoleName;}
            {_usersTimeZone = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("usersTimeZone"), out var __jsonUsersTimeZone) ? (string)__jsonUsersTimeZone : (string)UsersTimeZone;}
            AfterFromJson(json);
        }
    }
}