namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>
    /// See [V1 system user creation](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.
    /// </summary>
    public partial class BulkUserCreate
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
        /// Deserializes a JumpCloudApiSdkV1.Runtime.Json.JsonObject into a new instance of <see cref="BulkUserCreate" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal BulkUserCreate(JumpCloudApiSdkV1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_attributes = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonArray>("attributes"), out var __jsonAttributes) ? If( __jsonAttributes as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<JumpCloudApiSdkV1.Models.IBulkUserCreateAttributesItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(JumpCloudApiSdkV1.Models.IBulkUserCreateAttributesItem) (JumpCloudApiSdkV1.Models.BulkUserCreateAttributesItem.FromJson(__u) )) ))() : null : Attributes;}
            {_email = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("email"), out var __jsonEmail) ? (string)__jsonEmail : (string)Email;}
            {_firstname = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("firstname"), out var __jsonFirstname) ? (string)__jsonFirstname : (string)Firstname;}
            {_lastname = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("lastname"), out var __jsonLastname) ? (string)__jsonLastname : (string)Lastname;}
            {_username = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("username"), out var __jsonUsername) ? (string)__jsonUsername : (string)Username;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV1.Models.IBulkUserCreate.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV1.Models.IBulkUserCreate.</returns>
        public static JumpCloudApiSdkV1.Models.IBulkUserCreate FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV1.Runtime.Json.JsonObject json ? new BulkUserCreate(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="BulkUserCreate" /> into a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="BulkUserCreate" /> as a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
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
            if (null != this._attributes)
            {
                var __w = new JumpCloudApiSdkV1.Runtime.Json.XNodeArray();
                foreach( var __x in this._attributes )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("attributes",__w);
            }
            AddIf( null != (((object)this._email)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._email.ToString()) : null, "email" ,container.Add );
            AddIf( null != (((object)this._firstname)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._firstname.ToString()) : null, "firstname" ,container.Add );
            AddIf( null != (((object)this._lastname)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._lastname.ToString()) : null, "lastname" ,container.Add );
            AddIf( null != (((object)this._username)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._username.ToString()) : null, "username" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}