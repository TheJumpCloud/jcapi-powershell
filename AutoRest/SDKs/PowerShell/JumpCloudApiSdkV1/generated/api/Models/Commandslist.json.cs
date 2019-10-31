namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>CommandsList</summary>
    public partial class Commandslist
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
        /// Deserializes a JumpCloudApiSdkV1.Runtime.Json.JsonObject into a new instance of <see cref="Commandslist" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Commandslist(JumpCloudApiSdkV1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_results = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonArray>("results"), out var __jsonResults) ? If( __jsonResults as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<JumpCloudApiSdkV1.Models.ICommandslistResultsItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(JumpCloudApiSdkV1.Models.ICommandslistResultsItem) (JumpCloudApiSdkV1.Models.CommandslistResultsItem.FromJson(__u) )) ))() : null : Results;}
            {_totalCount = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonNumber>("totalCount"), out var __jsonTotalCount) ? (int?)__jsonTotalCount : TotalCount;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV1.Models.ICommandslist.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV1.Models.ICommandslist.</returns>
        public static JumpCloudApiSdkV1.Models.ICommandslist FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV1.Runtime.Json.JsonObject json ? new Commandslist(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Commandslist" /> into a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Commandslist" /> as a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
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
            if (null != this._results)
            {
                var __w = new JumpCloudApiSdkV1.Runtime.Json.XNodeArray();
                foreach( var __x in this._results )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("results",__w);
            }
            AddIf( null != this._totalCount ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonNumber((int)this._totalCount) : null, "totalCount" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}