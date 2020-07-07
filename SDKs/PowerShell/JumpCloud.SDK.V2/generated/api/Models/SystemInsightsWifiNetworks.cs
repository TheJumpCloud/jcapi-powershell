// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights WiFi Networks</summary>
    public partial class SystemInsightsWifiNetworks :
        JumpCloud.SDK.V2.Models.ISystemInsightsWifiNetworks,
        JumpCloud.SDK.V2.Models.ISystemInsightsWifiNetworksInternal
    {

        /// <summary>Backing field for <see cref="AutoLogin" /> property.</summary>
        private float? _autoLogin;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? AutoLogin { get => this._autoLogin; set => this._autoLogin = value; }

        /// <summary>Backing field for <see cref="CaptivePortal" /> property.</summary>
        private float? _captivePortal;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? CaptivePortal { get => this._captivePortal; set => this._captivePortal = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Disabled" /> property.</summary>
        private float? _disabled;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? Disabled { get => this._disabled; set => this._disabled = value; }

        /// <summary>Backing field for <see cref="LastConnected" /> property.</summary>
        private float? _lastConnected;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? LastConnected { get => this._lastConnected; set => this._lastConnected = value; }

        /// <summary>Backing field for <see cref="NetworkName" /> property.</summary>
        private string _networkName;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string NetworkName { get => this._networkName; set => this._networkName = value; }

        /// <summary>Backing field for <see cref="Passpoint" /> property.</summary>
        private float? _passpoint;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? Passpoint { get => this._passpoint; set => this._passpoint = value; }

        /// <summary>Backing field for <see cref="PossiblyHidden" /> property.</summary>
        private float? _possiblyHidden;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? PossiblyHidden { get => this._possiblyHidden; set => this._possiblyHidden = value; }

        /// <summary>Backing field for <see cref="Roaming" /> property.</summary>
        private float? _roaming;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? Roaming { get => this._roaming; set => this._roaming = value; }

        /// <summary>Backing field for <see cref="RoamingProfile" /> property.</summary>
        private string _roamingProfile;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string RoamingProfile { get => this._roamingProfile; set => this._roamingProfile = value; }

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

        /// <summary>Backing field for <see cref="TemporarilyDisabled" /> property.</summary>
        private float? _temporarilyDisabled;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? TemporarilyDisabled { get => this._temporarilyDisabled; set => this._temporarilyDisabled = value; }

        /// <summary>Creates an new <see cref="SystemInsightsWifiNetworks" /> instance.</summary>
        public SystemInsightsWifiNetworks()
        {

        }
    }
    /// System Insights WiFi Networks
    public partial interface ISystemInsightsWifiNetworks :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"auto_login",
        PossibleTypes = new [] { typeof(float) })]
        float? AutoLogin { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"captive_portal",
        PossibleTypes = new [] { typeof(float) })]
        float? CaptivePortal { get; set; }

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
        SerializedName = @"disabled",
        PossibleTypes = new [] { typeof(float) })]
        float? Disabled { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"last_connected",
        PossibleTypes = new [] { typeof(float) })]
        float? LastConnected { get; set; }

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
        SerializedName = @"passpoint",
        PossibleTypes = new [] { typeof(float) })]
        float? Passpoint { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"possibly_hidden",
        PossibleTypes = new [] { typeof(float) })]
        float? PossiblyHidden { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"roaming",
        PossibleTypes = new [] { typeof(float) })]
        float? Roaming { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"roaming_profile",
        PossibleTypes = new [] { typeof(string) })]
        string RoamingProfile { get; set; }

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
        SerializedName = @"temporarily_disabled",
        PossibleTypes = new [] { typeof(float) })]
        float? TemporarilyDisabled { get; set; }

    }
    /// System Insights WiFi Networks
    internal partial interface ISystemInsightsWifiNetworksInternal

    {
        float? AutoLogin { get; set; }

        float? CaptivePortal { get; set; }

        string CollectionTime { get; set; }

        float? Disabled { get; set; }

        float? LastConnected { get; set; }

        string NetworkName { get; set; }

        float? Passpoint { get; set; }

        float? PossiblyHidden { get; set; }

        float? Roaming { get; set; }

        string RoamingProfile { get; set; }

        string SecurityType { get; set; }

        string Ssid { get; set; }

        string SystemId { get; set; }

        float? TemporarilyDisabled { get; set; }

    }
}