namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Logical Drvies</summary>
    public partial class SystemInsightsLogicalDrvies :
        JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrvies,
        JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal
    {

        /// <summary>Backing field for <see cref="BootPartition" /> property.</summary>
        private int? _bootPartition;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? BootPartition { get => this._bootPartition; set => this._bootPartition = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="DeviceId" /> property.</summary>
        private string _deviceId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string DeviceId { get => this._deviceId; set => this._deviceId = value; }

        /// <summary>Backing field for <see cref="FileSystem" /> property.</summary>
        private string _fileSystem;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string FileSystem { get => this._fileSystem; set => this._fileSystem = value; }

        /// <summary>Backing field for <see cref="FreeSpace" /> property.</summary>
        private string _freeSpace;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string FreeSpace { get => this._freeSpace; set => this._freeSpace = value; }

        /// <summary>Backing field for <see cref="Size" /> property.</summary>
        private string _size;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Size { get => this._size; set => this._size = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemInsightsLogicalDrvies" /> instance.</summary>
        public SystemInsightsLogicalDrvies()
        {

        }
    }
    /// System Insights Logical Drvies
    public partial interface ISystemInsightsLogicalDrvies :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"boot_partition",
        PossibleTypes = new [] { typeof(int) })]
        int? BootPartition { get; set; }

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
        SerializedName = @"device_id",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"file_system",
        PossibleTypes = new [] { typeof(string) })]
        string FileSystem { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"free_space",
        PossibleTypes = new [] { typeof(string) })]
        string FreeSpace { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(string) })]
        string Size { get; set; }

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
    /// System Insights Logical Drvies
    internal partial interface ISystemInsightsLogicalDrviesInternal

    {
        int? BootPartition { get; set; }

        string CollectionTime { get; set; }

        string DeviceId { get; set; }

        string FileSystem { get; set; }

        string FreeSpace { get; set; }

        string Size { get; set; }

        string SystemId { get; set; }

        string Type { get; set; }

    }
}