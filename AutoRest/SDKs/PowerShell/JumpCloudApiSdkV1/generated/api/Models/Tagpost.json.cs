namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>TagPost</summary>
    public partial class Tagpost
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
        /// Deserializes a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV1.Models.ITagpost.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV1.Models.ITagpost.</returns>
        public static JumpCloudApiSdkV1.Models.ITagpost FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV1.Runtime.Json.JsonObject json ? new Tagpost(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV1.Runtime.Json.JsonObject into a new instance of <see cref="Tagpost" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Tagpost(JumpCloudApiSdkV1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_expirationTime = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonNumber>("expirationTime"), out var __jsonExpirationTime) ? (int?)__jsonExpirationTime : ExpirationTime;}
            {_externalDn = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("externalDN"), out var __jsonExternalDn) ? (string)__jsonExternalDn : (string)ExternalDn;}
            {_externalSourceType = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("externalSourceType"), out var __jsonExternalSourceType) ? (string)__jsonExternalSourceType : (string)ExternalSourceType;}
            {_externallyManaged = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("externallyManaged"), out var __jsonExternallyManaged) ? (bool?)__jsonExternallyManaged : ExternallyManaged;}
            {_groupGid = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("groupGid"), out var __jsonGroupGid) ? (string)__jsonGroupGid : (string)GroupGid;}
            {_groupName = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("groupName"), out var __jsonGroupName) ? (string)__jsonGroupName : (string)GroupName;}
            {_regularExpressions = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonArray>("regularExpressions"), out var __jsonRegularExpressions) ? If( __jsonRegularExpressions as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is JumpCloudApiSdkV1.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : RegularExpressions;}
            {_sendToLdap = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("sendToLDAP"), out var __jsonSendToLdap) ? (bool?)__jsonSendToLdap : SendToLdap;}
            {_systems = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonArray>("systems"), out var __jsonSystems) ? If( __jsonSystems as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is JumpCloudApiSdkV1.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : Systems;}
            {_systemusers = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonArray>("systemusers"), out var __jsonSystemusers) ? If( __jsonSystemusers as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is JumpCloudApiSdkV1.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : Systemusers;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Tagpost" /> into a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Tagpost" /> as a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != this._expirationTime ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonNumber((int)this._expirationTime) : null, "expirationTime" ,container.Add );
            AddIf( null != (((object)this._externalDn)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._externalDn.ToString()) : null, "externalDN" ,container.Add );
            AddIf( null != (((object)this._externalSourceType)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._externalSourceType.ToString()) : null, "externalSourceType" ,container.Add );
            AddIf( null != this._externallyManaged ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._externallyManaged) : null, "externallyManaged" ,container.Add );
            AddIf( null != (((object)this._groupGid)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._groupGid.ToString()) : null, "groupGid" ,container.Add );
            AddIf( null != (((object)this._groupName)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._groupName.ToString()) : null, "groupName" ,container.Add );
            if (null != this._regularExpressions)
            {
                var __w = new JumpCloudApiSdkV1.Runtime.Json.XNodeArray();
                foreach( var __x in this._regularExpressions )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("regularExpressions",__w);
            }
            AddIf( null != this._sendToLdap ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._sendToLdap) : null, "sendToLDAP" ,container.Add );
            if (null != this._systems)
            {
                var __r = new JumpCloudApiSdkV1.Runtime.Json.XNodeArray();
                foreach( var __s in this._systems )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("systems",__r);
            }
            if (null != this._systemusers)
            {
                var __m = new JumpCloudApiSdkV1.Runtime.Json.XNodeArray();
                foreach( var __n in this._systemusers )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("systemusers",__m);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}