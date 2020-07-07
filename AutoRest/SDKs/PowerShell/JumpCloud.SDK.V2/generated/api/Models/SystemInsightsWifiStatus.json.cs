// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights WiFi Status</summary>
    public partial class SystemInsightsWifiStatus
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
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.ISystemInsightsWifiStatus.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.ISystemInsightsWifiStatus.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsWifiStatus FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new SystemInsightsWifiStatus(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsWifiStatus" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsWifiStatus(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_bssid = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("bssid"), out var __jsonBssid) ? (string)__jsonBssid : (string)Bssid;}
            {_channel = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("channel"), out var __jsonChannel) ? (float?)__jsonChannel : Channel;}
            {_channelBand = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("channel_band"), out var __jsonChannelBand) ? (float?)__jsonChannelBand : ChannelBand;}
            {_channelWidth = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("channel_width"), out var __jsonChannelWidth) ? (float?)__jsonChannelWidth : ChannelWidth;}
            {_collectionTime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_countryCode = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("country_code"), out var __jsonCountryCode) ? (string)__jsonCountryCode : (string)CountryCode;}
            {_interface = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("interface"), out var __jsonInterface) ? (string)__jsonInterface : (string)Interface;}
            {_mode = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("mode"), out var __jsonMode) ? (string)__jsonMode : (string)Mode;}
            {_networkName = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("network_name"), out var __jsonNetworkName) ? (string)__jsonNetworkName : (string)NetworkName;}
            {_noise = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("noise"), out var __jsonNoise) ? (float?)__jsonNoise : Noise;}
            {_rssi = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("rssi"), out var __jsonRssi) ? (float?)__jsonRssi : Rssi;}
            {_securityType = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("security_type"), out var __jsonSecurityType) ? (string)__jsonSecurityType : (string)SecurityType;}
            {_ssid = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("ssid"), out var __jsonSsid) ? (string)__jsonSsid : (string)Ssid;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_transmitRate = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("transmit_rate"), out var __jsonTransmitRate) ? (string)__jsonTransmitRate : (string)TransmitRate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsWifiStatus" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsWifiStatus" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._bssid)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._bssid.ToString()) : null, "bssid" ,container.Add );
            AddIf( null != this._channel ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._channel) : null, "channel" ,container.Add );
            AddIf( null != this._channelBand ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._channelBand) : null, "channel_band" ,container.Add );
            AddIf( null != this._channelWidth ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._channelWidth) : null, "channel_width" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._countryCode)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._countryCode.ToString()) : null, "country_code" ,container.Add );
            AddIf( null != (((object)this._interface)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._interface.ToString()) : null, "interface" ,container.Add );
            AddIf( null != (((object)this._mode)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._mode.ToString()) : null, "mode" ,container.Add );
            AddIf( null != (((object)this._networkName)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._networkName.ToString()) : null, "network_name" ,container.Add );
            AddIf( null != this._noise ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._noise) : null, "noise" ,container.Add );
            AddIf( null != this._rssi ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._rssi) : null, "rssi" ,container.Add );
            AddIf( null != (((object)this._securityType)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._securityType.ToString()) : null, "security_type" ,container.Add );
            AddIf( null != (((object)this._ssid)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._ssid.ToString()) : null, "ssid" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != (((object)this._transmitRate)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._transmitRate.ToString()) : null, "transmit_rate" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}