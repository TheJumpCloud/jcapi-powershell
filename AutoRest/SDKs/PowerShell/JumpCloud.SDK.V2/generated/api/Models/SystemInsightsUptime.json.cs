namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Uptime</summary>
    public partial class SystemInsightsUptime
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
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.ISystemInsightsUptime.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.ISystemInsightsUptime.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsUptime FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new SystemInsightsUptime(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsUptime" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsUptime(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_collectionTime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_days = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("days"), out var __jsonDays) ? (int?)__jsonDays : Days;}
            {_hours = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("hours"), out var __jsonHours) ? (int?)__jsonHours : Hours;}
            {_minutes = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("minutes"), out var __jsonMinutes) ? (int?)__jsonMinutes : Minutes;}
            {_seconds = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("seconds"), out var __jsonSeconds) ? (int?)__jsonSeconds : Seconds;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_totalSeconds = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("total_seconds"), out var __jsonTotalSeconds) ? (string)__jsonTotalSeconds : (string)TotalSeconds;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsUptime" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsUptime" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != this._days ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._days) : null, "days" ,container.Add );
            AddIf( null != this._hours ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._hours) : null, "hours" ,container.Add );
            AddIf( null != this._minutes ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._minutes) : null, "minutes" ,container.Add );
            AddIf( null != this._seconds ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._seconds) : null, "seconds" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != (((object)this._totalSeconds)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._totalSeconds.ToString()) : null, "total_seconds" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}