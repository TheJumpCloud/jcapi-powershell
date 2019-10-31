namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>Tag</summary>
    public partial class Tag :
        JumpCloudApiSdkV1.Models.ITag,
        JumpCloudApiSdkV1.Models.ITagInternal
    {

        /// <summary>Backing field for <see cref="ExpirationTime" /> property.</summary>
        private int? _expirationTime;

        /// <summary>
        /// A date timestamp indicating when this Tag will expire itself. When a Tag expires it will revoke any system user to system
        /// associations.
        /// </summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? ExpirationTime { get => this._expirationTime; set => this._expirationTime = value; }

        /// <summary>Backing field for <see cref="Expired" /> property.</summary>
        private bool? _expired;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Expired { get => this._expired; set => this._expired = value; }

        /// <summary>Backing field for <see cref="ExternalDn" /> property.</summary>
        private string _externalDn;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string ExternalDn { get => this._externalDn; set => this._externalDn = value; }

        /// <summary>Backing field for <see cref="ExternalSourceType" /> property.</summary>
        private string _externalSourceType;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string ExternalSourceType { get => this._externalSourceType; set => this._externalSourceType = value; }

        /// <summary>Backing field for <see cref="ExternallyManaged" /> property.</summary>
        private bool? _externallyManaged;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? ExternallyManaged { get => this._externallyManaged; set => this._externallyManaged = value; }

        /// <summary>Backing field for <see cref="GroupGid" /> property.</summary>
        private string _groupGid;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string GroupGid { get => this._groupGid; set => this._groupGid = value; }

        /// <summary>Backing field for <see cref="GroupName" /> property.</summary>
        private string _groupName;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string GroupName { get => this._groupName; set => this._groupName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>A unique name for the Tag.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="RegularExpressions" /> property.</summary>
        private string[] _regularExpressions;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] RegularExpressions { get => this._regularExpressions; set => this._regularExpressions = value; }

        /// <summary>Backing field for <see cref="SendToLdap" /> property.</summary>
        private bool? _sendToLdap;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? SendToLdap { get => this._sendToLdap; set => this._sendToLdap = value; }

        /// <summary>Backing field for <see cref="Systems" /> property.</summary>
        private string[] _systems;

        /// <summary>An array of system ids that are associated to the Tag.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Systems { get => this._systems; set => this._systems = value; }

        /// <summary>Backing field for <see cref="Systemusers" /> property.</summary>
        private string[] _systemusers;

        /// <summary>An array of system user ids that are associated to the Tag.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Systemusers { get => this._systemusers; set => this._systemusers = value; }

        /// <summary>Creates an new <see cref="Tag" /> instance.</summary>
        public Tag()
        {

        }
    }
    /// Tag
    public partial interface ITag :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A date timestamp indicating when this Tag will expire itself. When a Tag expires it will revoke any system user to system
        /// associations.
        /// </summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A date timestamp indicating when this Tag will expire itself. When a Tag expires it will revoke any system user to system associations.",
        SerializedName = @"expirationTime",
        PossibleTypes = new [] { typeof(int) })]
        int? ExpirationTime { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Expired { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"externalDN",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalDn { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"externalSourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalSourceType { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"externallyManaged",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ExternallyManaged { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"groupGid",
        PossibleTypes = new [] { typeof(string) })]
        string GroupGid { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"groupName",
        PossibleTypes = new [] { typeof(string) })]
        string GroupName { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>A unique name for the Tag.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A unique name for the Tag.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"regularExpressions",
        PossibleTypes = new [] { typeof(string) })]
        string[] RegularExpressions { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sendToLDAP",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SendToLdap { get; set; }
        /// <summary>An array of system ids that are associated to the Tag.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of system ids that are associated to the Tag.",
        SerializedName = @"systems",
        PossibleTypes = new [] { typeof(string) })]
        string[] Systems { get; set; }
        /// <summary>An array of system user ids that are associated to the Tag.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of system user ids that are associated to the Tag.",
        SerializedName = @"systemusers",
        PossibleTypes = new [] { typeof(string) })]
        string[] Systemusers { get; set; }

    }
    /// Tag
    internal partial interface ITagInternal

    {
        /// <summary>
        /// A date timestamp indicating when this Tag will expire itself. When a Tag expires it will revoke any system user to system
        /// associations.
        /// </summary>
        int? ExpirationTime { get; set; }

        bool? Expired { get; set; }

        string ExternalDn { get; set; }

        string ExternalSourceType { get; set; }

        bool? ExternallyManaged { get; set; }

        string GroupGid { get; set; }

        string GroupName { get; set; }

        string Id { get; set; }
        /// <summary>A unique name for the Tag.</summary>
        string Name { get; set; }

        string[] RegularExpressions { get; set; }

        bool? SendToLdap { get; set; }
        /// <summary>An array of system ids that are associated to the Tag.</summary>
        string[] Systems { get; set; }
        /// <summary>An array of system user ids that are associated to the Tag.</summary>
        string[] Systemusers { get; set; }

    }
}