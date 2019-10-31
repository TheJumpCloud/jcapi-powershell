namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>An instance of a policy template.</summary>
    public partial class PolicyWithDetails
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
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.IPolicyWithDetails.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.IPolicyWithDetails.</returns>
        public static JumpCloudApiSdkV2.Models.IPolicyWithDetails FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new PolicyWithDetails(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="PolicyWithDetails" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PolicyWithDetails(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_template = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonObject>("template"), out var __jsonTemplate) ? JumpCloudApiSdkV2.Models.PolicyTemplate.FromJson(__jsonTemplate) : Template;}
            {_name = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_configFields = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonArray>("configFields"), out var __jsonConfigFields) ? If( __jsonConfigFields as JumpCloudApiSdkV2.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<JumpCloudApiSdkV2.Models.IPolicyTemplateConfigField[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(JumpCloudApiSdkV2.Models.IPolicyTemplateConfigField) (JumpCloudApiSdkV2.Models.PolicyTemplateConfigField.FromJson(__u) )) ))() : null : ConfigFields;}
            {_id = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_values = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonArray>("values"), out var __jsonValues) ? If( __jsonValues as JumpCloudApiSdkV2.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<JumpCloudApiSdkV2.Models.IPolicyValue[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(JumpCloudApiSdkV2.Models.IPolicyValue) (JumpCloudApiSdkV2.Models.PolicyValue.FromJson(__p) )) ))() : null : Values;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PolicyWithDetails" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PolicyWithDetails" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._template ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) this._template.ToJson(null,serializationMode) : null, "template" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            if (null != this._configFields)
            {
                var __w = new JumpCloudApiSdkV2.Runtime.Json.XNodeArray();
                foreach( var __x in this._configFields )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("configFields",__w);
            }
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            if (null != this._values)
            {
                var __r = new JumpCloudApiSdkV2.Runtime.Json.XNodeArray();
                foreach( var __s in this._values )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("values",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}