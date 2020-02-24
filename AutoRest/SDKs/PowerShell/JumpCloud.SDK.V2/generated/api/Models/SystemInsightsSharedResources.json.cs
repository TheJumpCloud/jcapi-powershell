// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Shared Resources</summary>
    public partial class SystemInsightsSharedResources
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloud.SDK.V2.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloud.SDK.V2.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloud.SDK.V2.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloud.SDK.V2.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.ISystemInsightsSharedResources.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.ISystemInsightsSharedResources.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSharedResources FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new SystemInsightsSharedResources(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsSharedResources" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsSharedResources(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_type = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("type"), out var __jsonType) ? (int?)__jsonType : Type;}
            {_path = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_description = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_allowMaximum = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("allow_maximum"), out var __jsonAllowMaximum) ? (int?)__jsonAllowMaximum : AllowMaximum;}
            {_collectionTime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_installDate = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("install_date"), out var __jsonInstallDate) ? (string)__jsonInstallDate : (string)InstallDate;}
            {_maximumAllowed = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("maximum_allowed"), out var __jsonMaximumAllowed) ? (int?)__jsonMaximumAllowed : MaximumAllowed;}
            {_status = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsSharedResources" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsSharedResources" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloud.SDK.V2.Runtime.Json.JsonNode ToJson(JumpCloud.SDK.V2.Runtime.Json.JsonObject container, JumpCloud.SDK.V2.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloud.SDK.V2.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != this._type ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._type) : null, "type" ,container.Add );
            AddIf( null != (((object)this._path)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._path.ToString()) : null, "path" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != this._allowMaximum ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._allowMaximum) : null, "allow_maximum" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._installDate)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._installDate.ToString()) : null, "install_date" ,container.Add );
            AddIf( null != this._maximumAllowed ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._maximumAllowed) : null, "maximum_allowed" ,container.Add );
            AddIf( null != (((object)this._status)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}