namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>System</summary>
    public partial class JcSystem
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
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.IJcSystem.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.IJcSystem.</returns>
        public static JumpCloud.SDK.V1.Models.IJcSystem FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new JcSystem(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="JcSystem" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal JcSystem(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_fde = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonObject>("fde"), out var __jsonFde) ? JumpCloud.SDK.V1.Models.Fde.FromJson(__jsonFde) : Fde;}
            {_systemInsights = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonObject>("systemInsights"), out var __jsonSystemInsights) ? JumpCloud.SDK.V1.Models.JcSystemInsights.FromJson(__jsonSystemInsights) : SystemInsights;}
            {_id = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("_id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_active = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("active"), out var __jsonActive) ? (bool?)__jsonActive : Active;}
            {_agentVersion = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("agentVersion"), out var __jsonAgentVersion) ? (string)__jsonAgentVersion : (string)AgentVersion;}
            {_allowMultiFactorAuthentication = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allowMultiFactorAuthentication"), out var __jsonAllowMultiFactorAuthentication) ? (bool?)__jsonAllowMultiFactorAuthentication : AllowMultiFactorAuthentication;}
            {_allowPublicKeyAuthentication = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allowPublicKeyAuthentication"), out var __jsonAllowPublicKeyAuthentication) ? (bool?)__jsonAllowPublicKeyAuthentication : AllowPublicKeyAuthentication;}
            {_allowSshPasswordAuthentication = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allowSshPasswordAuthentication"), out var __jsonAllowSshPasswordAuthentication) ? (bool?)__jsonAllowSshPasswordAuthentication : AllowSshPasswordAuthentication;}
            {_allowSshRootLogin = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allowSshRootLogin"), out var __jsonAllowSshRootLogin) ? (bool?)__jsonAllowSshRootLogin : AllowSshRootLogin;}
            {_amazonInstanceId = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("amazonInstanceID"), out var __jsonAmazonInstanceId) ? (string)__jsonAmazonInstanceId : (string)AmazonInstanceId;}
            {_arch = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("arch"), out var __jsonArch) ? (string)__jsonArch : (string)Arch;}
            {_connectionHistory = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("connectionHistory"), out var __jsonConnectionHistory) ? If( __jsonConnectionHistory as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem) (JumpCloud.SDK.V1.Models.JcSystemConnectionHistoryItem.FromJson(__u) )) ))() : null : ConnectionHistory;}
            {_created = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("created"), out var __jsonCreated) ? (string)__jsonCreated : (string)Created;}
            {_displayName = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_fileSystem = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("fileSystem"), out var __jsonFileSystem) ? (string)__jsonFileSystem : (string)FileSystem;}
            {_hasServiceAccount = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("hasServiceAccount"), out var __jsonHasServiceAccount) ? (bool?)__jsonHasServiceAccount : HasServiceAccount;}
            {_hostname = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("hostname"), out var __jsonHostname) ? (string)__jsonHostname : (string)Hostname;}
            {_lastContact = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("lastContact"), out var __jsonLastContact) ? (string)__jsonLastContact : (string)LastContact;}
            {_modifySshdConfig = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("modifySSHDConfig"), out var __jsonModifySshdConfig) ? (bool?)__jsonModifySshdConfig : ModifySshdConfig;}
            {_networkInterfaces = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("networkInterfaces"), out var __jsonNetworkInterfaces) ? If( __jsonNetworkInterfaces as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem) (JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItem.FromJson(__p) )) ))() : null : NetworkInterfaces;}
            {_organization = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("organization"), out var __jsonOrganization) ? (string)__jsonOrganization : (string)Organization;}
            {_oS = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("os"), out var __jsonOS) ? (string)__jsonOS : (string)OS;}
            {_remoteIP = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("remoteIP"), out var __jsonRemoteIP) ? (string)__jsonRemoteIP : (string)RemoteIP;}
            {_sshRootEnabled = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("sshRootEnabled"), out var __jsonSshRootEnabled) ? (bool?)__jsonSshRootEnabled : SshRootEnabled;}
            {_sshdParams = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("sshdParams"), out var __jsonSshdParams) ? If( __jsonSshdParams as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem) (JumpCloud.SDK.V1.Models.JcSystemSshdParamsItem.FromJson(__k) )) ))() : null : SshdParams;}
            {_systemTimezone = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("systemTimezone"), out var __jsonSystemTimezone) ? (int?)__jsonSystemTimezone : SystemTimezone;}
            {_tags = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("tags"), out var __jsonTags) ? If( __jsonTags as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(string) (__f is JumpCloud.SDK.V1.Runtime.Json.JsonString __e ? (string)(__e.ToString()) : null)) ))() : null : Tags;}
            {_templateName = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("templateName"), out var __jsonTemplateName) ? (string)__jsonTemplateName : (string)TemplateName;}
            {_version = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="JcSystem" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="JcSystem" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._fde ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) this._fde.ToJson(null,serializationMode) : null, "fde" ,container.Add );
            AddIf( null != this._systemInsights ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) this._systemInsights.ToJson(null,serializationMode) : null, "systemInsights" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._id.ToString()) : null, "_id" ,container.Add );
            AddIf( null != this._active ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._active) : null, "active" ,container.Add );
            AddIf( null != (((object)this._agentVersion)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._agentVersion.ToString()) : null, "agentVersion" ,container.Add );
            AddIf( null != this._allowMultiFactorAuthentication ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowMultiFactorAuthentication) : null, "allowMultiFactorAuthentication" ,container.Add );
            AddIf( null != this._allowPublicKeyAuthentication ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowPublicKeyAuthentication) : null, "allowPublicKeyAuthentication" ,container.Add );
            AddIf( null != this._allowSshPasswordAuthentication ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowSshPasswordAuthentication) : null, "allowSshPasswordAuthentication" ,container.Add );
            AddIf( null != this._allowSshRootLogin ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowSshRootLogin) : null, "allowSshRootLogin" ,container.Add );
            AddIf( null != (((object)this._amazonInstanceId)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._amazonInstanceId.ToString()) : null, "amazonInstanceID" ,container.Add );
            AddIf( null != (((object)this._arch)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._arch.ToString()) : null, "arch" ,container.Add );
            if (null != this._connectionHistory)
            {
                var __w = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __x in this._connectionHistory )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("connectionHistory",__w);
            }
            AddIf( null != (((object)this._created)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._created.ToString()) : null, "created" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._fileSystem)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._fileSystem.ToString()) : null, "fileSystem" ,container.Add );
            AddIf( null != this._hasServiceAccount ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._hasServiceAccount) : null, "hasServiceAccount" ,container.Add );
            AddIf( null != (((object)this._hostname)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._hostname.ToString()) : null, "hostname" ,container.Add );
            AddIf( null != (((object)this._lastContact)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._lastContact.ToString()) : null, "lastContact" ,container.Add );
            AddIf( null != this._modifySshdConfig ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._modifySshdConfig) : null, "modifySSHDConfig" ,container.Add );
            if (null != this._networkInterfaces)
            {
                var __r = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __s in this._networkInterfaces )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("networkInterfaces",__r);
            }
            AddIf( null != (((object)this._organization)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._organization.ToString()) : null, "organization" ,container.Add );
            AddIf( null != (((object)this._oS)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._oS.ToString()) : null, "os" ,container.Add );
            AddIf( null != (((object)this._remoteIP)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._remoteIP.ToString()) : null, "remoteIP" ,container.Add );
            AddIf( null != this._sshRootEnabled ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._sshRootEnabled) : null, "sshRootEnabled" ,container.Add );
            if (null != this._sshdParams)
            {
                var __m = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __n in this._sshdParams )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("sshdParams",__m);
            }
            AddIf( null != this._systemTimezone ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._systemTimezone) : null, "systemTimezone" ,container.Add );
            if (null != this._tags)
            {
                var __h = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __i in this._tags )
                {
                    AddIf(null != (((object)__i)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(__i.ToString()) : null ,__h.Add);
                }
                container.Add("tags",__h);
            }
            AddIf( null != (((object)this._templateName)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._templateName.ToString()) : null, "templateName" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}