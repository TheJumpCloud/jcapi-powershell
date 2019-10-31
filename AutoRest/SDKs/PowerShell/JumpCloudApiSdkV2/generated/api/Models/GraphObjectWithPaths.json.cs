namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>GraphObjectWithPaths</summary>
    public partial class GraphObjectWithPaths
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
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.IGraphObjectWithPaths.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.IGraphObjectWithPaths.</returns>
        public static JumpCloudApiSdkV2.Models.IGraphObjectWithPaths FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new GraphObjectWithPaths(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="GraphObjectWithPaths" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal GraphObjectWithPaths(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_type = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_compiledAttributes = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonObject>("compiledAttributes"), out var __jsonCompiledAttributes) ? JumpCloudApiSdkV2.Models.GraphObjectWithPathsCompiledAttributes.FromJson(__jsonCompiledAttributes) : CompiledAttributes;}
            {_id = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_paths = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonArray>("paths"), out var __jsonPaths) ? If( __jsonPaths as JumpCloudApiSdkV2.Runtime.Json.JsonArray, out var __u) ? new global::System.Func<JumpCloudApiSdkV2.Models.IGraphConnection[][]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__u, (__t)=>(JumpCloudApiSdkV2.Models.IGraphConnection[]) (If( __t as JumpCloudApiSdkV2.Runtime.Json.JsonArray, out var __s) ? new global::System.Func<JumpCloudApiSdkV2.Models.IGraphConnection[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__s, (__r)=>(JumpCloudApiSdkV2.Models.IGraphConnection) (JumpCloudApiSdkV2.Models.GraphConnection.FromJson(__r) )) ))() : null /* arrayOf */)) ))() : null : Paths;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="GraphObjectWithPaths" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GraphObjectWithPaths" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._type)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != this._compiledAttributes ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) this._compiledAttributes.ToJson(null,serializationMode) : null, "compiledAttributes" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            if (null != this._paths)
            {
                var __w = new JumpCloudApiSdkV2.Runtime.Json.XNodeArray();
                foreach( var __x in this._paths )
                {
                    AddIf(null != __x ? new JumpCloudApiSdkV2.Runtime.Json.XNodeArray(global::System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select(__x, (__v) => __v?.ToJson(null, serializationMode)))) : null ,__w.Add);
                }
                container.Add("paths",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}