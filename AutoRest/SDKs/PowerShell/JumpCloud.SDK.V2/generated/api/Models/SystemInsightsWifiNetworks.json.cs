// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights WiFi Networks</summary>
    public partial class SystemInsightsWifiNetworks
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
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.ISystemInsightsWifiNetworks.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.ISystemInsightsWifiNetworks.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsWifiNetworks FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new SystemInsightsWifiNetworks(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsWifiNetworks" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsWifiNetworks(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_autoLogin = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("auto_login"), out var __jsonAutoLogin) ? (float?)__jsonAutoLogin : AutoLogin;}
            {_captivePortal = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("captive_portal"), out var __jsonCaptivePortal) ? (float?)__jsonCaptivePortal : CaptivePortal;}
            {_collectionTime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_disabled = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("disabled"), out var __jsonDisabled) ? (float?)__jsonDisabled : Disabled;}
            {_lastConnected = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("last_connected"), out var __jsonLastConnected) ? (float?)__jsonLastConnected : LastConnected;}
            {_networkName = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("network_name"), out var __jsonNetworkName) ? (string)__jsonNetworkName : (string)NetworkName;}
            {_passpoint = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("passpoint"), out var __jsonPasspoint) ? (float?)__jsonPasspoint : Passpoint;}
            {_possiblyHidden = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("possibly_hidden"), out var __jsonPossiblyHidden) ? (float?)__jsonPossiblyHidden : PossiblyHidden;}
            {_roaming = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("roaming"), out var __jsonRoaming) ? (float?)__jsonRoaming : Roaming;}
            {_roamingProfile = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("roaming_profile"), out var __jsonRoamingProfile) ? (string)__jsonRoamingProfile : (string)RoamingProfile;}
            {_securityType = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("security_type"), out var __jsonSecurityType) ? (string)__jsonSecurityType : (string)SecurityType;}
            {_ssid = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("ssid"), out var __jsonSsid) ? (string)__jsonSsid : (string)Ssid;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_temporarilyDisabled = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("temporarily_disabled"), out var __jsonTemporarilyDisabled) ? (float?)__jsonTemporarilyDisabled : TemporarilyDisabled;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsWifiNetworks" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsWifiNetworks" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._autoLogin ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._autoLogin) : null, "auto_login" ,container.Add );
            AddIf( null != this._captivePortal ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._captivePortal) : null, "captive_portal" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != this._disabled ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._disabled) : null, "disabled" ,container.Add );
            AddIf( null != this._lastConnected ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._lastConnected) : null, "last_connected" ,container.Add );
            AddIf( null != (((object)this._networkName)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._networkName.ToString()) : null, "network_name" ,container.Add );
            AddIf( null != this._passpoint ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._passpoint) : null, "passpoint" ,container.Add );
            AddIf( null != this._possiblyHidden ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._possiblyHidden) : null, "possibly_hidden" ,container.Add );
            AddIf( null != this._roaming ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._roaming) : null, "roaming" ,container.Add );
            AddIf( null != (((object)this._roamingProfile)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._roamingProfile.ToString()) : null, "roaming_profile" ,container.Add );
            AddIf( null != (((object)this._securityType)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._securityType.ToString()) : null, "security_type" ,container.Add );
            AddIf( null != (((object)this._ssid)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._ssid.ToString()) : null, "ssid" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != this._temporarilyDisabled ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._temporarilyDisabled) : null, "temporarily_disabled" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}