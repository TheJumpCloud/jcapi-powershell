namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Bitlocker Info</summary>
    public partial class SystemInsightsBitlockerInfo :
        JumpCloud.SDK.V2.Models.ISystemInsightsBitlockerInfo,
        JumpCloud.SDK.V2.Models.ISystemInsightsBitlockerInfoInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="ConversionStatus" /> property.</summary>
        private int? _conversionStatus;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? ConversionStatus { get => this._conversionStatus; set => this._conversionStatus = value; }

        /// <summary>Backing field for <see cref="DeviceId" /> property.</summary>
        private string _deviceId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string DeviceId { get => this._deviceId; set => this._deviceId = value; }

        /// <summary>Backing field for <see cref="DriveLetter" /> property.</summary>
        private string _driveLetter;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string DriveLetter { get => this._driveLetter; set => this._driveLetter = value; }

        /// <summary>Backing field for <see cref="EncryptionMethod" /> property.</summary>
        private string _encryptionMethod;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string EncryptionMethod { get => this._encryptionMethod; set => this._encryptionMethod = value; }

        /// <summary>Backing field for <see cref="PersistentVolumeId" /> property.</summary>
        private string _persistentVolumeId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string PersistentVolumeId { get => this._persistentVolumeId; set => this._persistentVolumeId = value; }

        /// <summary>Backing field for <see cref="ProtectionStatus" /> property.</summary>
        private int? _protectionStatus;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? ProtectionStatus { get => this._protectionStatus; set => this._protectionStatus = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Creates an new <see cref="SystemInsightsBitlockerInfo" /> instance.</summary>
        public SystemInsightsBitlockerInfo()
        {

        }
    }
    /// System Insights Bitlocker Info
    public partial interface ISystemInsightsBitlockerInfo :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
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
        SerializedName = @"conversion_status",
        PossibleTypes = new [] { typeof(int) })]
        int? ConversionStatus { get; set; }

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
        SerializedName = @"drive_letter",
        PossibleTypes = new [] { typeof(string) })]
        string DriveLetter { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"encryption_method",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionMethod { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"persistent_volume_id",
        PossibleTypes = new [] { typeof(string) })]
        string PersistentVolumeId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"protection_status",
        PossibleTypes = new [] { typeof(int) })]
        int? ProtectionStatus { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

    }
    /// System Insights Bitlocker Info
    internal partial interface ISystemInsightsBitlockerInfoInternal

    {
        string CollectionTime { get; set; }

        int? ConversionStatus { get; set; }

        string DeviceId { get; set; }

        string DriveLetter { get; set; }

        string EncryptionMethod { get; set; }

        string PersistentVolumeId { get; set; }

        int? ProtectionStatus { get; set; }

        string SystemId { get; set; }

    }
}