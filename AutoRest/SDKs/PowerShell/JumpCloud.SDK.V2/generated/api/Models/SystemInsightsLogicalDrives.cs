// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Logical Drives</summary>
    public partial class SystemInsightsLogicalDrives :
        JumpCloud.SDK.V2.Models.ISystemInsightsLogicalDrives,
        JumpCloud.SDK.V2.Models.ISystemInsightsLogicalDrivesInternal
    {

        /// <summary>Backing field for <see cref="BootPartition" /> property.</summary>
        private int? _bootPartition;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? BootPartition { get => this._bootPartition; set => this._bootPartition = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="DeviceId" /> property.</summary>
        private string _deviceId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string DeviceId { get => this._deviceId; set => this._deviceId = value; }

        /// <summary>Backing field for <see cref="FileSystem" /> property.</summary>
        private string _fileSystem;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string FileSystem { get => this._fileSystem; set => this._fileSystem = value; }

        /// <summary>Backing field for <see cref="FreeSpace" /> property.</summary>
        private string _freeSpace;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string FreeSpace { get => this._freeSpace; set => this._freeSpace = value; }

        /// <summary>Backing field for <see cref="Size" /> property.</summary>
        private string _size;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Size { get => this._size; set => this._size = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemInsightsLogicalDrives" /> instance.</summary>
        public SystemInsightsLogicalDrives()
        {

        }
    }
    /// System Insights Logical Drives
    public partial interface ISystemInsightsLogicalDrives :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"boot_partition",
        PossibleTypes = new [] { typeof(int) })]
        int? BootPartition { get; set; }

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
        SerializedName = @"device_id",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"file_system",
        PossibleTypes = new [] { typeof(string) })]
        string FileSystem { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"free_space",
        PossibleTypes = new [] { typeof(string) })]
        string FreeSpace { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(string) })]
        string Size { get; set; }

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
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// System Insights Logical Drives
    internal partial interface ISystemInsightsLogicalDrivesInternal

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