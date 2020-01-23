namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>RadiusServer</summary>
    public partial class Radiusserver
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
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.IRadiusserver.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.IRadiusserver.</returns>
        public static JumpCloud.SDK.V1.Models.IRadiusserver FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new Radiusserver(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="Radiusserver" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Radiusserver(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_id = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("_id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_mfa = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("mfa"), out var __jsonMfa) ? (string)__jsonMfa : (string)Mfa;}
            {_networkSourceIP = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("networkSourceIp"), out var __jsonNetworkSourceIP) ? (string)__jsonNetworkSourceIP : (string)NetworkSourceIP;}
            {_organization = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("organization"), out var __jsonOrganization) ? (string)__jsonOrganization : (string)Organization;}
            {_sharedSecret = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("sharedSecret"), out var __jsonSharedSecret) ? (string)__jsonSharedSecret : (string)SharedSecret;}
            {_tagNames = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("tagNames"), out var __jsonTagNames) ? If( __jsonTagNames as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is JumpCloud.SDK.V1.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : TagNames;}
            {_tags = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("tags"), out var __jsonTags) ? If( __jsonTags as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is JumpCloud.SDK.V1.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : Tags;}
            {_userLockoutAction = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("userLockoutAction"), out var __jsonUserLockoutAction) ? (string)__jsonUserLockoutAction : (string)UserLockoutAction;}
            {_userPasswordExpirationAction = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("userPasswordExpirationAction"), out var __jsonUserPasswordExpirationAction) ? (string)__jsonUserPasswordExpirationAction : (string)UserPasswordExpirationAction;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Radiusserver" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Radiusserver" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._id.ToString()) : null, "_id" ,container.Add );
            AddIf( null != (((object)this._mfa)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._mfa.ToString()) : null, "mfa" ,container.Add );
            AddIf( null != (((object)this._networkSourceIP)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._networkSourceIP.ToString()) : null, "networkSourceIp" ,container.Add );
            AddIf( null != (((object)this._organization)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._organization.ToString()) : null, "organization" ,container.Add );
            AddIf( null != (((object)this._sharedSecret)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._sharedSecret.ToString()) : null, "sharedSecret" ,container.Add );
            if (null != this._tagNames)
            {
                var __w = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __x in this._tagNames )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("tagNames",__w);
            }
            if (null != this._tags)
            {
                var __r = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __s in this._tags )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("tags",__r);
            }
            AddIf( null != (((object)this._userLockoutAction)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._userLockoutAction.ToString()) : null, "userLockoutAction" ,container.Add );
            AddIf( null != (((object)this._userPasswordExpirationAction)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._userPasswordExpirationAction.ToString()) : null, "userPasswordExpirationAction" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}