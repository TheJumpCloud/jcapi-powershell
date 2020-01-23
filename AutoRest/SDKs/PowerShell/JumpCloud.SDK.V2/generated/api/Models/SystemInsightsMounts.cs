namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Mounts</summary>
    public partial class SystemInsightsMounts :
        JumpCloud.SDK.V2.Models.ISystemInsightsMounts,
        JumpCloud.SDK.V2.Models.ISystemInsightsMountsInternal
    {

        /// <summary>Backing field for <see cref="Blocks" /> property.</summary>
        private string _blocks;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Blocks { get => this._blocks; set => this._blocks = value; }

        /// <summary>Backing field for <see cref="BlocksAvailable" /> property.</summary>
        private string _blocksAvailable;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string BlocksAvailable { get => this._blocksAvailable; set => this._blocksAvailable = value; }

        /// <summary>Backing field for <see cref="BlocksFree" /> property.</summary>
        private string _blocksFree;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string BlocksFree { get => this._blocksFree; set => this._blocksFree = value; }

        /// <summary>Backing field for <see cref="BlocksSize" /> property.</summary>
        private string _blocksSize;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string BlocksSize { get => this._blocksSize; set => this._blocksSize = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Device" /> property.</summary>
        private string _device;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Device { get => this._device; set => this._device = value; }

        /// <summary>Backing field for <see cref="DeviceAlias" /> property.</summary>
        private string _deviceAlias;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string DeviceAlias { get => this._deviceAlias; set => this._deviceAlias = value; }

        /// <summary>Backing field for <see cref="Flags" /> property.</summary>
        private string _flags;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Flags { get => this._flags; set => this._flags = value; }

        /// <summary>Backing field for <see cref="Inodes" /> property.</summary>
        private string _inodes;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Inodes { get => this._inodes; set => this._inodes = value; }

        /// <summary>Backing field for <see cref="InodesFree" /> property.</summary>
        private string _inodesFree;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string InodesFree { get => this._inodesFree; set => this._inodesFree = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemInsightsMounts" /> instance.</summary>
        public SystemInsightsMounts()
        {

        }
    }
    /// System Insights Mounts
    public partial interface ISystemInsightsMounts :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"blocks",
        PossibleTypes = new [] { typeof(string) })]
        string Blocks { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"blocks_available",
        PossibleTypes = new [] { typeof(string) })]
        string BlocksAvailable { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"blocks_free",
        PossibleTypes = new [] { typeof(string) })]
        string BlocksFree { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"blocks_size",
        PossibleTypes = new [] { typeof(string) })]
        string BlocksSize { get; set; }

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
        SerializedName = @"device",
        PossibleTypes = new [] { typeof(string) })]
        string Device { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"device_alias",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceAlias { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"flags",
        PossibleTypes = new [] { typeof(string) })]
        string Flags { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"inodes",
        PossibleTypes = new [] { typeof(string) })]
        string Inodes { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"inodes_free",
        PossibleTypes = new [] { typeof(string) })]
        string InodesFree { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

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
    /// System Insights Mounts
    internal partial interface ISystemInsightsMountsInternal

    {
        string Blocks { get; set; }

        string BlocksAvailable { get; set; }

        string BlocksFree { get; set; }

        string BlocksSize { get; set; }

        string CollectionTime { get; set; }

        string Device { get; set; }

        string DeviceAlias { get; set; }

        string Flags { get; set; }

        string Inodes { get; set; }

        string InodesFree { get; set; }

        string Path { get; set; }

        string SystemId { get; set; }

        string Type { get; set; }

    }
}