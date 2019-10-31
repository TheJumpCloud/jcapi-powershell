namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Kernel Info</summary>
    public partial class SystemInsightsKernelInfo :
        JumpCloudApiSdkV2.Models.ISystemInsightsKernelInfo,
        JumpCloudApiSdkV2.Models.ISystemInsightsKernelInfoInternal
    {

        /// <summary>Backing field for <see cref="Arguments" /> property.</summary>
        private string _arguments;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Arguments { get => this._arguments; set => this._arguments = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Device" /> property.</summary>
        private string _device;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Device { get => this._device; set => this._device = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SystemInsightsKernelInfo" /> instance.</summary>
        public SystemInsightsKernelInfo()
        {

        }
    }
    /// System Insights Kernel Info
    public partial interface ISystemInsightsKernelInfo :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"arguments",
        PossibleTypes = new [] { typeof(string) })]
        string Arguments { get; set; }

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
        SerializedName = @"device",
        PossibleTypes = new [] { typeof(string) })]
        string Device { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

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
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// System Insights Kernel Info
    internal partial interface ISystemInsightsKernelInfoInternal

    {
        string Arguments { get; set; }

        string CollectionTime { get; set; }

        string Device { get; set; }

        string Path { get; set; }

        string SystemId { get; set; }

        string Version { get; set; }

    }
}