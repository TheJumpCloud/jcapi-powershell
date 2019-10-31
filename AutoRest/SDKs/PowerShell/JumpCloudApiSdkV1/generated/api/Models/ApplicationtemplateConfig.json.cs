namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class ApplicationtemplateConfig
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
        /// Deserializes a JumpCloudApiSdkV1.Runtime.Json.JsonObject into a new instance of <see cref="ApplicationtemplateConfig" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ApplicationtemplateConfig(JumpCloudApiSdkV1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_acsUrl = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("acsUrl"), out var __jsonAcsUrl) ? JumpCloudApiSdkV1.Models.ApplicationtemplateConfigAcsUrl.FromJson(__jsonAcsUrl) : AcsUrl;}
            {_constantAttributes = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("constantAttributes"), out var __jsonConstantAttributes) ? JumpCloudApiSdkV1.Models.ApplicationtemplateConfigConstantAttributes.FromJson(__jsonConstantAttributes) : ConstantAttributes;}
            {_databaseAttributes = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("databaseAttributes"), out var __jsonDatabaseAttributes) ? JumpCloudApiSdkV1.Models.ApplicationtemplateConfigDatabaseAttributes.FromJson(__jsonDatabaseAttributes) : DatabaseAttributes;}
            {_idpCertificate = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("idpCertificate"), out var __jsonIdpCertificate) ? JumpCloudApiSdkV1.Models.ApplicationtemplateConfigIdpCertificate.FromJson(__jsonIdpCertificate) : IdpCertificate;}
            {_idpEntityId = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("idpEntityId"), out var __jsonIdpEntityId) ? JumpCloudApiSdkV1.Models.ApplicationtemplateConfigIdpEntityId.FromJson(__jsonIdpEntityId) : IdpEntityId;}
            {_idpPrivateKey = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("idpPrivateKey"), out var __jsonIdpPrivateKey) ? JumpCloudApiSdkV1.Models.ApplicationtemplateConfigIdpPrivateKey.FromJson(__jsonIdpPrivateKey) : IdpPrivateKey;}
            {_spEntityId = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonObject>("spEntityId"), out var __jsonSpEntityId) ? JumpCloudApiSdkV1.Models.ApplicationtemplateConfigSpEntityId.FromJson(__jsonSpEntityId) : SpEntityId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV1.Models.IApplicationtemplateConfig.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV1.Models.IApplicationtemplateConfig.</returns>
        public static JumpCloudApiSdkV1.Models.IApplicationtemplateConfig FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV1.Runtime.Json.JsonObject json ? new ApplicationtemplateConfig(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ApplicationtemplateConfig" /> into a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ApplicationtemplateConfig" /> as a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._acsUrl ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._acsUrl.ToJson(null,serializationMode) : null, "acsUrl" ,container.Add );
            AddIf( null != this._constantAttributes ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._constantAttributes.ToJson(null,serializationMode) : null, "constantAttributes" ,container.Add );
            AddIf( null != this._databaseAttributes ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._databaseAttributes.ToJson(null,serializationMode) : null, "databaseAttributes" ,container.Add );
            AddIf( null != this._idpCertificate ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._idpCertificate.ToJson(null,serializationMode) : null, "idpCertificate" ,container.Add );
            AddIf( null != this._idpEntityId ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._idpEntityId.ToJson(null,serializationMode) : null, "idpEntityId" ,container.Add );
            AddIf( null != this._idpPrivateKey ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._idpPrivateKey.ToJson(null,serializationMode) : null, "idpPrivateKey" ,container.Add );
            AddIf( null != this._spEntityId ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) this._spEntityId.ToJson(null,serializationMode) : null, "spEntityId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}