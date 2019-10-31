namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Chrome Extensions</summary>
    public partial class SystemInsightsChromeExtensions
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
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.ISystemInsightsChromeExtensions.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.ISystemInsightsChromeExtensions.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsChromeExtensions FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new SystemInsightsChromeExtensions(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsChromeExtensions" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsChromeExtensions(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_path = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_description = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_author = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("author"), out var __jsonAuthor) ? (string)__jsonAuthor : (string)Author;}
            {_collectionTime = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_identifier = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("identifier"), out var __jsonIdentifier) ? (string)__jsonIdentifier : (string)Identifier;}
            {_locale = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("locale"), out var __jsonLocale) ? (string)__jsonLocale : (string)Locale;}
            {_permissions = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("permissions"), out var __jsonPermissions) ? (string)__jsonPermissions : (string)Permissions;}
            {_persistent = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("persistent"), out var __jsonPersistent) ? (int?)__jsonPersistent : Persistent;}
            {_systemId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_uid = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("uid"), out var __jsonUid) ? (string)__jsonUid : (string)Uid;}
            {_updateUrl = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("update_url"), out var __jsonUpdateUrl) ? (string)__jsonUpdateUrl : (string)UpdateUrl;}
            {_version = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsChromeExtensions" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsChromeExtensions" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._path)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._path.ToString()) : null, "path" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._author)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._author.ToString()) : null, "author" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._identifier)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._identifier.ToString()) : null, "identifier" ,container.Add );
            AddIf( null != (((object)this._locale)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._locale.ToString()) : null, "locale" ,container.Add );
            AddIf( null != (((object)this._permissions)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._permissions.ToString()) : null, "permissions" ,container.Add );
            AddIf( null != this._persistent ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._persistent) : null, "persistent" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != (((object)this._uid)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._uid.ToString()) : null, "uid" ,container.Add );
            AddIf( null != (((object)this._updateUrl)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._updateUrl.ToString()) : null, "update_url" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}