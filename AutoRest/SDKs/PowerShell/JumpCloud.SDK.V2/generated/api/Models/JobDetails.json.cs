namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Job Details</summary>
    public partial class JobDetails
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
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.IJobDetails.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.IJobDetails.</returns>
        public static JumpCloud.SDK.V2.Models.IJobDetails FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new JobDetails(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="JobDetails" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal JobDetails(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_adminId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("adminId"), out var __jsonAdminId) ? (string)__jsonAdminId : (string)AdminId;}
            {_createdAt = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("createdAt"), out var __jsonCreatedAt) ? (string)__jsonCreatedAt : (string)CreatedAt;}
            {_id = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_meta = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonObject>("meta"), out var __jsonMeta) ? JumpCloud.SDK.V2.Models.JobDetailsMeta.FromJson(__jsonMeta) : Meta;}
            {_persistedFields = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonArray>("persistedFields"), out var __jsonPersistedFields) ? If( __jsonPersistedFields as JumpCloud.SDK.V2.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is JumpCloud.SDK.V2.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : PersistedFields;}
            {_status = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_updatedAt = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("updatedAt"), out var __jsonUpdatedAt) ? (string)__jsonUpdatedAt : (string)UpdatedAt;}
            {_workUnitsCount = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("workUnitsCount"), out var __jsonWorkUnitsCount) ? (int?)__jsonWorkUnitsCount : WorkUnitsCount;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="JobDetails" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="JobDetails" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._adminId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._adminId.ToString()) : null, "adminId" ,container.Add );
            AddIf( null != (((object)this._createdAt)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._createdAt.ToString()) : null, "createdAt" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != this._meta ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) this._meta.ToJson(null,serializationMode) : null, "meta" ,container.Add );
            if (null != this._persistedFields)
            {
                var __w = new JumpCloud.SDK.V2.Runtime.Json.XNodeArray();
                foreach( var __x in this._persistedFields )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("persistedFields",__w);
            }
            AddIf( null != (((object)this._status)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            AddIf( null != (((object)this._updatedAt)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._updatedAt.ToString()) : null, "updatedAt" ,container.Add );
            AddIf( null != this._workUnitsCount ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._workUnitsCount) : null, "workUnitsCount" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}