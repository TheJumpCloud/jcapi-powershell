// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6219, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>PolicyTemplateConfigField</summary>
    public partial class PolicyTemplateConfigField
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
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField.</returns>
        public static JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new PolicyTemplateConfigField(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="PolicyTemplateConfigField" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PolicyTemplateConfigField(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_tooltip = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonObject>("tooltip"), out var __jsonTooltip) ? JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTooltip.FromJson(__jsonTooltip) : Tooltip;}
            {_name = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_defaultValue = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("defaultValue"), out var __jsonDefaultValue) ? (string)__jsonDefaultValue : (string)DefaultValue;}
            {_displayOptions = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonObject>("displayOptions"), out var __jsonDisplayOptions) ? JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldDisplayOptions.FromJson(__jsonDisplayOptions) : DisplayOptions;}
            {_displayType = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("displayType"), out var __jsonDisplayType) ? (string)__jsonDisplayType : (string)DisplayType;}
            {_id = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_label = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("label"), out var __jsonLabel) ? (string)__jsonLabel : (string)Label;}
            {_position = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("position"), out var __jsonPosition) ? (float?)__jsonPosition : Position;}
            {_readOnly = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonBoolean>("readOnly"), out var __jsonReadOnly) ? (bool?)__jsonReadOnly : ReadOnly;}
            {_required = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonBoolean>("required"), out var __jsonRequired) ? (bool?)__jsonRequired : Required;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PolicyTemplateConfigField" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PolicyTemplateConfigField" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._tooltip ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) this._tooltip.ToJson(null,serializationMode) : null, "tooltip" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._defaultValue)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._defaultValue.ToString()) : null, "defaultValue" ,container.Add );
            AddIf( null != this._displayOptions ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) this._displayOptions.ToJson(null,serializationMode) : null, "displayOptions" ,container.Add );
            AddIf( null != (((object)this._displayType)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._displayType.ToString()) : null, "displayType" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != (((object)this._label)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._label.ToString()) : null, "label" ,container.Add );
            AddIf( null != this._position ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._position) : null, "position" ,container.Add );
            AddIf( null != this._readOnly ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonBoolean((bool)this._readOnly) : null, "readOnly" ,container.Add );
            AddIf( null != this._required ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonBoolean((bool)this._required) : null, "required" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}