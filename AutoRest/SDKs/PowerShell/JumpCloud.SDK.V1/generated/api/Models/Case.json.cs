// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>Case</summary>
    public partial class Case
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
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="Case" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Case(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_description = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_firstname = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("firstname"), out var __jsonFirstname) ? (string)__jsonFirstname : (string)Firstname;}
            {_lastname = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("lastname"), out var __jsonLastname) ? (string)__jsonLastname : (string)Lastname;}
            {_subject = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("subject"), out var __jsonSubject) ? (string)__jsonSubject : (string)Subject;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.ICase.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.ICase.</returns>
        public static JumpCloud.SDK.V1.Models.ICase FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new Case(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Case" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Case" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._description)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._firstname)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._firstname.ToString()) : null, "firstname" ,container.Add );
            AddIf( null != (((object)this._lastname)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._lastname.ToString()) : null, "lastname" ,container.Add );
            AddIf( null != (((object)this._subject)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._subject.ToString()) : null, "subject" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}