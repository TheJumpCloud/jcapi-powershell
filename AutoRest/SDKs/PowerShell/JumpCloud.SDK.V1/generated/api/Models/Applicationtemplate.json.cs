namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>ApplicationTemplate</summary>
    public partial class Applicationtemplate
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloud.SDK.V1.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloud.SDK.V1.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloud.SDK.V1.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloud.SDK.V1.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="Applicationtemplate" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Applicationtemplate(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_jit = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonObject>("jit"), out var __jsonJit) ? JumpCloud.SDK.V1.Models.ApplicationtemplateJit.FromJson(__jsonJit) : Jit;}
            {_name = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_id = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("_id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_beta = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("beta"), out var __jsonBeta) ? (bool?)__jsonBeta : Beta;}
            {_color = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("color"), out var __jsonColor) ? (string)__jsonColor : (string)Color;}
            {_displayLabel = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("displayLabel"), out var __jsonDisplayLabel) ? (string)__jsonDisplayLabel : (string)DisplayLabel;}
            {_displayName = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_isConfigured = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("isConfigured"), out var __jsonIsConfigured) ? (bool?)__jsonIsConfigured : IsConfigured;}
            {_learnMore = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("learnMore"), out var __jsonLearnMore) ? (string)__jsonLearnMore : (string)LearnMore;}
            {_ssoUrl = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("ssoUrl"), out var __jsonSsoUrl) ? (string)__jsonSsoUrl : (string)SsoUrl;}
            {_config = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonObject>("config"), out var __jsonConfig) ? JumpCloud.SDK.V1.Models.ApplicationtemplateConfig.FromJson(__jsonConfig) : Config;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.IApplicationtemplate.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.IApplicationtemplate.</returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplate FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new Applicationtemplate(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Applicationtemplate" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Applicationtemplate" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloud.SDK.V1.Runtime.Json.JsonNode ToJson(JumpCloud.SDK.V1.Runtime.Json.JsonObject container, JumpCloud.SDK.V1.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloud.SDK.V1.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._jit ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) this._jit.ToJson(null,serializationMode) : null, "jit" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._id.ToString()) : null, "_id" ,container.Add );
            AddIf( null != this._beta ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._beta) : null, "beta" ,container.Add );
            AddIf( null != (((object)this._color)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._color.ToString()) : null, "color" ,container.Add );
            AddIf( null != (((object)this._displayLabel)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._displayLabel.ToString()) : null, "displayLabel" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != this._isConfigured ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._isConfigured) : null, "isConfigured" ,container.Add );
            AddIf( null != (((object)this._learnMore)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._learnMore.ToString()) : null, "learnMore" ,container.Add );
            AddIf( null != (((object)this._ssoUrl)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._ssoUrl.ToString()) : null, "ssoUrl" ,container.Add );
            AddIf( null != this._config ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) this._config.ToJson(null,serializationMode) : null, "config" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}