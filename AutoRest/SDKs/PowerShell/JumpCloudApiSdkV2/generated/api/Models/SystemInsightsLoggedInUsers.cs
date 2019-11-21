namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Logged-In Users</summary>
    public partial class SystemInsightsLoggedInUsers :
        JumpCloudApiSdkV2.Models.ISystemInsightsLoggedInUsers,
        JumpCloudApiSdkV2.Models.ISystemInsightsLoggedInUsersInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Host" /> property.</summary>
        private string _host;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Host { get => this._host; set => this._host = value; }

        /// <summary>Backing field for <see cref="Pid" /> property.</summary>
        private int? _pid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Pid { get => this._pid; set => this._pid = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Time" /> property.</summary>
        private int? _time;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Time { get => this._time; set => this._time = value; }

        /// <summary>Backing field for <see cref="Tty" /> property.</summary>
        private string _tty;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Tty { get => this._tty; set => this._tty = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private string _user;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string User { get => this._user; set => this._user = value; }

        /// <summary>Creates an new <see cref="SystemInsightsLoggedInUsers" /> instance.</summary>
        public SystemInsightsLoggedInUsers()
        {

        }
    }
    /// System Insights Logged-In Users
    public partial interface ISystemInsightsLoggedInUsers :
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
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string Host { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"pid",
        PossibleTypes = new [] { typeof(int) })]
        int? Pid { get; set; }

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
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(int) })]
        int? Time { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tty",
        PossibleTypes = new [] { typeof(string) })]
        string Tty { get; set; }

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
        SerializedName = @"user",
        PossibleTypes = new [] { typeof(string) })]
        string User { get; set; }

    }
    /// System Insights Logged-In Users
    internal partial interface ISystemInsightsLoggedInUsersInternal

    {
        string CollectionTime { get; set; }

        string Host { get; set; }

        int? Pid { get; set; }

        string SystemId { get; set; }

        int? Time { get; set; }

        string Tty { get; set; }

        string Type { get; set; }

        string User { get; set; }

    }
}