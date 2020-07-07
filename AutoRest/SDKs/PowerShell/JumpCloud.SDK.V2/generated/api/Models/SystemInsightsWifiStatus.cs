// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights WiFi Status</summary>
    public partial class SystemInsightsWifiStatus :
        JumpCloud.SDK.V2.Models.ISystemInsightsWifiStatus,
        JumpCloud.SDK.V2.Models.ISystemInsightsWifiStatusInternal
    {

        /// <summary>Backing field for <see cref="Bssid" /> property.</summary>
        private string _bssid;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Bssid { get => this._bssid; set => this._bssid = value; }

        /// <summary>Backing field for <see cref="Channel" /> property.</summary>
        private float? _channel;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? Channel { get => this._channel; set => this._channel = value; }

        /// <summary>Backing field for <see cref="ChannelBand" /> property.</summary>
        private float? _channelBand;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? ChannelBand { get => this._channelBand; set => this._channelBand = value; }

        /// <summary>Backing field for <see cref="ChannelWidth" /> property.</summary>
        private float? _channelWidth;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? ChannelWidth { get => this._channelWidth; set => this._channelWidth = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="CountryCode" /> property.</summary>
        private string _countryCode;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CountryCode { get => this._countryCode; set => this._countryCode = value; }

        /// <summary>Backing field for <see cref="Interface" /> property.</summary>
        private string _interface;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Interface { get => this._interface; set => this._interface = value; }

        /// <summary>Backing field for <see cref="Mode" /> property.</summary>
        private string _mode;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Mode { get => this._mode; set => this._mode = value; }

        /// <summary>Backing field for <see cref="NetworkName" /> property.</summary>
        private string _networkName;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string NetworkName { get => this._networkName; set => this._networkName = value; }

        /// <summary>Backing field for <see cref="Noise" /> property.</summary>
        private float? _noise;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? Noise { get => this._noise; set => this._noise = value; }

        /// <summary>Backing field for <see cref="Rssi" /> property.</summary>
        private float? _rssi;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? Rssi { get => this._rssi; set => this._rssi = value; }

        /// <summary>Backing field for <see cref="SecurityType" /> property.</summary>
        private string _securityType;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SecurityType { get => this._securityType; set => this._securityType = value; }

        /// <summary>Backing field for <see cref="Ssid" /> property.</summary>
        private string _ssid;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Ssid { get => this._ssid; set => this._ssid = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="TransmitRate" /> property.</summary>
        private string _transmitRate;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string TransmitRate { get => this._transmitRate; set => this._transmitRate = value; }

        /// <summary>Creates an new <see cref="SystemInsightsWifiStatus" /> instance.</summary>
        public SystemInsightsWifiStatus()
        {

        }
    }
    /// System Insights WiFi Status
    public partial interface ISystemInsightsWifiStatus :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bssid",
        PossibleTypes = new [] { typeof(string) })]
        string Bssid { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"channel",
        PossibleTypes = new [] { typeof(float) })]
        float? Channel { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"channel_band",
        PossibleTypes = new [] { typeof(float) })]
        float? ChannelBand { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"channel_width",
        PossibleTypes = new [] { typeof(float) })]
        float? ChannelWidth { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"collection_time",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionTime { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"country_code",
        PossibleTypes = new [] { typeof(string) })]
        string CountryCode { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"interface",
        PossibleTypes = new [] { typeof(string) })]
        string Interface { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(string) })]
        string Mode { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"network_name",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"noise",
        PossibleTypes = new [] { typeof(float) })]
        float? Noise { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"rssi",
        PossibleTypes = new [] { typeof(float) })]
        float? Rssi { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"security_type",
        PossibleTypes = new [] { typeof(string) })]
        string SecurityType { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ssid",
        PossibleTypes = new [] { typeof(string) })]
        string Ssid { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"transmit_rate",
        PossibleTypes = new [] { typeof(string) })]
        string TransmitRate { get; set; }

    }
    /// System Insights WiFi Status
    internal partial interface ISystemInsightsWifiStatusInternal

    {
        string Bssid { get; set; }

        float? Channel { get; set; }

        float? ChannelBand { get; set; }

        float? ChannelWidth { get; set; }

        string CollectionTime { get; set; }

        string CountryCode { get; set; }

        string Interface { get; set; }

        string Mode { get; set; }

        string NetworkName { get; set; }

        float? Noise { get; set; }

        float? Rssi { get; set; }

        string SecurityType { get; set; }

        string Ssid { get; set; }

        string SystemId { get; set; }

        string TransmitRate { get; set; }

    }
}