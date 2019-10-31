namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights System Controls</summary>
    public partial class SystemInsightsSystemControls
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
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.ISystemInsightsSystemControls.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.ISystemInsightsSystemControls.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsSystemControls FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new SystemInsightsSystemControls(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsSystemControls" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsSystemControls(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_type = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_collectionTime = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_configValue = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("config_value"), out var __jsonConfigValue) ? (string)__jsonConfigValue : (string)ConfigValue;}
            {_currentValue = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("current_value"), out var __jsonCurrentValue) ? (string)__jsonCurrentValue : (string)CurrentValue;}
            {_fieldName = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("field_name"), out var __jsonFieldName) ? (string)__jsonFieldName : (string)FieldName;}
            {_oid = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("oid"), out var __jsonOid) ? (string)__jsonOid : (string)Oid;}
            {_subsystem = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("subsystem"), out var __jsonSubsystem) ? (string)__jsonSubsystem : (string)Subsystem;}
            {_systemId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsSystemControls" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsSystemControls" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._type)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._configValue)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._configValue.ToString()) : null, "config_value" ,container.Add );
            AddIf( null != (((object)this._currentValue)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._currentValue.ToString()) : null, "current_value" ,container.Add );
            AddIf( null != (((object)this._fieldName)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._fieldName.ToString()) : null, "field_name" ,container.Add );
            AddIf( null != (((object)this._oid)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._oid.ToString()) : null, "oid" ,container.Add );
            AddIf( null != (((object)this._subsystem)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._subsystem.ToString()) : null, "subsystem" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}