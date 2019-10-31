namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Disk Info</summary>
    public partial class SystemInsightsDiskInfo :
        JumpCloudApiSdkV2.Models.ISystemInsightsDiskInfo,
        JumpCloudApiSdkV2.Models.ISystemInsightsDiskInfoInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DiskIndex" /> property.</summary>
        private int? _diskIndex;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? DiskIndex { get => this._diskIndex; set => this._diskIndex = value; }

        /// <summary>Backing field for <see cref="DiskSize" /> property.</summary>
        private string _diskSize;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string DiskSize { get => this._diskSize; set => this._diskSize = value; }

        /// <summary>Backing field for <see cref="HardwareModel" /> property.</summary>
        private string _hardwareModel;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string HardwareModel { get => this._hardwareModel; set => this._hardwareModel = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Manufacturer" /> property.</summary>
        private string _manufacturer;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Manufacturer { get => this._manufacturer; set => this._manufacturer = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Partitions" /> property.</summary>
        private int? _partitions;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Partitions { get => this._partitions; set => this._partitions = value; }

        /// <summary>Backing field for <see cref="PnpDeviceId" /> property.</summary>
        private string _pnpDeviceId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string PnpDeviceId { get => this._pnpDeviceId; set => this._pnpDeviceId = value; }

        /// <summary>Backing field for <see cref="Serial" /> property.</summary>
        private string _serial;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Serial { get => this._serial; set => this._serial = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemInsightsDiskInfo" /> instance.</summary>
        public SystemInsightsDiskInfo()
        {

        }
    }
    /// System Insights Disk Info
    public partial interface ISystemInsightsDiskInfo :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
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
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"disk_index",
        PossibleTypes = new [] { typeof(int) })]
        int? DiskIndex { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"disk_size",
        PossibleTypes = new [] { typeof(string) })]
        string DiskSize { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hardware_model",
        PossibleTypes = new [] { typeof(string) })]
        string HardwareModel { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"manufacturer",
        PossibleTypes = new [] { typeof(string) })]
        string Manufacturer { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"partitions",
        PossibleTypes = new [] { typeof(int) })]
        int? Partitions { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"pnp_device_id",
        PossibleTypes = new [] { typeof(string) })]
        string PnpDeviceId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"serial",
        PossibleTypes = new [] { typeof(string) })]
        string Serial { get; set; }

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
    /// System Insights Disk Info
    internal partial interface ISystemInsightsDiskInfoInternal

    {
        string CollectionTime { get; set; }

        string Description { get; set; }

        int? DiskIndex { get; set; }

        string DiskSize { get; set; }

        string HardwareModel { get; set; }

        string Id { get; set; }

        string Manufacturer { get; set; }

        string Name { get; set; }

        int? Partitions { get; set; }

        string PnpDeviceId { get; set; }

        string Serial { get; set; }

        string SystemId { get; set; }

        string Type { get; set; }

    }
}