namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Groups</summary>
    public partial class SystemInsightsGroups :
        JumpCloudApiSdkV2.Models.ISystemInsightsGroups,
        JumpCloudApiSdkV2.Models.ISystemInsightsGroupsInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Comment" /> property.</summary>
        private string _comment;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Comment { get => this._comment; set => this._comment = value; }

        /// <summary>Backing field for <see cref="Gid" /> property.</summary>
        private string _gid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Gid { get => this._gid; set => this._gid = value; }

        /// <summary>Backing field for <see cref="GidSigned" /> property.</summary>
        private string _gidSigned;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string GidSigned { get => this._gidSigned; set => this._gidSigned = value; }

        /// <summary>Backing field for <see cref="GroupSid" /> property.</summary>
        private string _groupSid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string GroupSid { get => this._groupSid; set => this._groupSid = value; }

        /// <summary>Backing field for <see cref="Groupname" /> property.</summary>
        private string _groupname;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Groupname { get => this._groupname; set => this._groupname = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Creates an new <see cref="SystemInsightsGroups" /> instance.</summary>
        public SystemInsightsGroups()
        {

        }
    }
    /// System Insights Groups
    public partial interface ISystemInsightsGroups :
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
        SerializedName = @"comment",
        PossibleTypes = new [] { typeof(string) })]
        string Comment { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"gid",
        PossibleTypes = new [] { typeof(string) })]
        string Gid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"gid_signed",
        PossibleTypes = new [] { typeof(string) })]
        string GidSigned { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"group_sid",
        PossibleTypes = new [] { typeof(string) })]
        string GroupSid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"groupname",
        PossibleTypes = new [] { typeof(string) })]
        string Groupname { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

    }
    /// System Insights Groups
    internal partial interface ISystemInsightsGroupsInternal

    {
        string CollectionTime { get; set; }

        string Comment { get; set; }

        string Gid { get; set; }

        string GidSigned { get; set; }

        string GroupSid { get; set; }

        string Groupname { get; set; }

        string SystemId { get; set; }

    }
}