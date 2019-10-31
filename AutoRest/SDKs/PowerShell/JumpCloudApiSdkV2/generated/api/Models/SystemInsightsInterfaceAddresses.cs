namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Interface Addresses</summary>
    public partial class SystemInsightsInterfaceAddresses :
        JumpCloudApiSdkV2.Models.ISystemInsightsInterfaceAddresses,
        JumpCloudApiSdkV2.Models.ISystemInsightsInterfaceAddressesInternal
    {

        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private string _address;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Address { get => this._address; set => this._address = value; }

        /// <summary>Backing field for <see cref="Broadcast" /> property.</summary>
        private string _broadcast;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Broadcast { get => this._broadcast; set => this._broadcast = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>Backing field for <see cref="Interface" /> property.</summary>
        private string _interface;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Interface { get => this._interface; set => this._interface = value; }

        /// <summary>Backing field for <see cref="Mask" /> property.</summary>
        private string _mask;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Mask { get => this._mask; set => this._mask = value; }

        /// <summary>Backing field for <see cref="PointToPoint" /> property.</summary>
        private string _pointToPoint;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string PointToPoint { get => this._pointToPoint; set => this._pointToPoint = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemInsightsInterfaceAddresses" /> instance.</summary>
        public SystemInsightsInterfaceAddresses()
        {

        }
    }
    /// System Insights Interface Addresses
    public partial interface ISystemInsightsInterfaceAddresses :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"address",
        PossibleTypes = new [] { typeof(string) })]
        string Address { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"broadcast",
        PossibleTypes = new [] { typeof(string) })]
        string Broadcast { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"collection_time",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionTime { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"friendly_name",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"interface",
        PossibleTypes = new [] { typeof(string) })]
        string Interface { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"mask",
        PossibleTypes = new [] { typeof(string) })]
        string Mask { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"point_to_point",
        PossibleTypes = new [] { typeof(string) })]
        string PointToPoint { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// System Insights Interface Addresses
    internal partial interface ISystemInsightsInterfaceAddressesInternal

    {
        string Address { get; set; }

        string Broadcast { get; set; }

        string CollectionTime { get; set; }

        string FriendlyName { get; set; }

        string Interface { get; set; }

        string Mask { get; set; }

        string PointToPoint { get; set; }

        string SystemId { get; set; }

        string Type { get; set; }

    }
}