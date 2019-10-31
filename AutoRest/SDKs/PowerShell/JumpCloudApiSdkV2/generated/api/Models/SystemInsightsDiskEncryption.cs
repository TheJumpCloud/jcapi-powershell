namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Disk Encryption</summary>
    public partial class SystemInsightsDiskEncryption :
        JumpCloudApiSdkV2.Models.ISystemInsightsDiskEncryption,
        JumpCloudApiSdkV2.Models.ISystemInsightsDiskEncryptionInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Encrypted" /> property.</summary>
        private int? _encrypted;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Encrypted { get => this._encrypted; set => this._encrypted = value; }

        /// <summary>Backing field for <see cref="EncryptionStatus" /> property.</summary>
        private string _encryptionStatus;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string EncryptionStatus { get => this._encryptionStatus; set => this._encryptionStatus = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Uid" /> property.</summary>
        private string _uid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Uid { get => this._uid; set => this._uid = value; }

        /// <summary>Backing field for <see cref="UserUuid" /> property.</summary>
        private string _userUuid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UserUuid { get => this._userUuid; set => this._userUuid = value; }

        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Uuid { get => this._uuid; set => this._uuid = value; }

        /// <summary>Creates an new <see cref="SystemInsightsDiskEncryption" /> instance.</summary>
        public SystemInsightsDiskEncryption()
        {

        }
    }
    /// System Insights Disk Encryption
    public partial interface ISystemInsightsDiskEncryption :
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
        SerializedName = @"encrypted",
        PossibleTypes = new [] { typeof(int) })]
        int? Encrypted { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"encryption_status",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionStatus { get; set; }

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

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"uid",
        PossibleTypes = new [] { typeof(string) })]
        string Uid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"user_uuid",
        PossibleTypes = new [] { typeof(string) })]
        string UserUuid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"uuid",
        PossibleTypes = new [] { typeof(string) })]
        string Uuid { get; set; }

    }
    /// System Insights Disk Encryption
    internal partial interface ISystemInsightsDiskEncryptionInternal

    {
        string CollectionTime { get; set; }

        int? Encrypted { get; set; }

        string EncryptionStatus { get; set; }

        string Name { get; set; }

        string SystemId { get; set; }

        string Type { get; set; }

        string Uid { get; set; }

        string UserUuid { get; set; }

        string Uuid { get; set; }

    }
}