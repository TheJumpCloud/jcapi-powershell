namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class ApplicationConfigConstantAttributes
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
        /// Deserializes a JumpCloudApiSdkV1.Runtime.Json.JsonObject into a new instance of <see cref="ApplicationConfigConstantAttributes" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ApplicationConfigConstantAttributes(JumpCloudApiSdkV1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_tooltip = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("tooltip"), out var __jsonTooltip) ? JumpCloudApiSdkV1.Models.ApplicationConfigConstantAttributesTooltip.FromJson(__jsonTooltip) : Tooltip;}
            {_type = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_label = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("label"), out var __jsonLabel) ? (string)__jsonLabel : (string)Label;}
            {_mutable = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("mutable"), out var __jsonMutable) ? (bool?)__jsonMutable : Mutable;}
            {_options = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("options"), out var __jsonOptions) ? (string)__jsonOptions : (string)Options;}
            {_position = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonNumber>("position"), out var __jsonPosition) ? (int?)__jsonPosition : Position;}
            {_readOnly = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("readOnly"), out var __jsonReadOnly) ? (bool?)__jsonReadOnly : ReadOnly;}
            {_required = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("required"), out var __jsonRequired) ? (bool?)__jsonRequired : Required;}
            {_toggle = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("toggle"), out var __jsonToggle) ? (string)__jsonToggle : (string)Toggle;}
            {_value = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonArray>("value"), out var __jsonValue) ? If( __jsonValue as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesValueItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesValueItem) (JumpCloudApiSdkV1.Models.ApplicationConfigConstantAttributesValueItem.FromJson(__u) )) ))() : null : Value;}
            {_visible = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("visible"), out var __jsonVisible) ? (bool?)__jsonVisible : Visible;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributes.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributes.</returns>
        public static JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributes FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV1.Runtime.Json.JsonObject json ? new ApplicationConfigConstantAttributes(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ApplicationConfigConstantAttributes" /> into a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ApplicationConfigConstantAttributes" /> as a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._tooltip ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._tooltip.ToJson(null,serializationMode) : null, "tooltip" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._label)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._label.ToString()) : null, "label" ,container.Add );
            AddIf( null != this._mutable ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._mutable) : null, "mutable" ,container.Add );
            AddIf( null != (((object)this._options)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._options.ToString()) : null, "options" ,container.Add );
            AddIf( null != this._position ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonNumber((int)this._position) : null, "position" ,container.Add );
            AddIf( null != this._readOnly ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._readOnly) : null, "readOnly" ,container.Add );
            AddIf( null != this._required ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._required) : null, "required" ,container.Add );
            AddIf( null != (((object)this._toggle)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._toggle.ToString()) : null, "toggle" ,container.Add );
            if (null != this._value)
            {
                var __w = new JumpCloudApiSdkV1.Runtime.Json.XNodeArray();
                foreach( var __x in this._value )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("value",__w);
            }
            AddIf( null != this._visible ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._visible) : null, "visible" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}