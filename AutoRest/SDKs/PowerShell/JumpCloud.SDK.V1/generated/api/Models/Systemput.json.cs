namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>SystemPut</summary>
    public partial class Systemput
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
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.ISystemput.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.ISystemput.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemput FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new Systemput(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="Systemput" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Systemput(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_agentBoundMessages = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("agentBoundMessages"), out var __jsonAgentBoundMessages) ? If( __jsonAgentBoundMessages as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItem) (JumpCloud.SDK.V1.Models.SystemputAgentBoundMessagesItem.FromJson(__u) )) ))() : null : AgentBoundMessages;}
            {_allowMultiFactorAuthentication = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allowMultiFactorAuthentication"), out var __jsonAllowMultiFactorAuthentication) ? (bool?)__jsonAllowMultiFactorAuthentication : AllowMultiFactorAuthentication;}
            {_allowPublicKeyAuthentication = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allowPublicKeyAuthentication"), out var __jsonAllowPublicKeyAuthentication) ? (bool?)__jsonAllowPublicKeyAuthentication : AllowPublicKeyAuthentication;}
            {_allowSshPasswordAuthentication = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allowSshPasswordAuthentication"), out var __jsonAllowSshPasswordAuthentication) ? (bool?)__jsonAllowSshPasswordAuthentication : AllowSshPasswordAuthentication;}
            {_allowSshRootLogin = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allowSshRootLogin"), out var __jsonAllowSshRootLogin) ? (bool?)__jsonAllowSshRootLogin : AllowSshRootLogin;}
            {_displayName = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_tags = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("tags"), out var __jsonTags) ? If( __jsonTags as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is JumpCloud.SDK.V1.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : Tags;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Systemput" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Systemput" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
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
            if (null != this._agentBoundMessages)
            {
                var __w = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __x in this._agentBoundMessages )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("agentBoundMessages",__w);
            }
            AddIf( null != this._allowMultiFactorAuthentication ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowMultiFactorAuthentication) : null, "allowMultiFactorAuthentication" ,container.Add );
            AddIf( null != this._allowPublicKeyAuthentication ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowPublicKeyAuthentication) : null, "allowPublicKeyAuthentication" ,container.Add );
            AddIf( null != this._allowSshPasswordAuthentication ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowSshPasswordAuthentication) : null, "allowSshPasswordAuthentication" ,container.Add );
            AddIf( null != this._allowSshRootLogin ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowSshRootLogin) : null, "allowSshRootLogin" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            if (null != this._tags)
            {
                var __r = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __s in this._tags )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("tags",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}