namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Job WorkResult</summary>
    public partial class JobWorkresult :
        JumpCloudApiSdkV2.Models.IJobWorkresult,
        JumpCloudApiSdkV2.Models.IJobWorkresultInternal
    {

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private string _createdAt;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CreatedAt { get => this._createdAt; set => this._createdAt = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Meta" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IJobWorkresultMeta _meta;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IJobWorkresultMeta Meta { get => (this._meta = this._meta ?? new JumpCloudApiSdkV2.Models.JobWorkresultMeta()); set => this._meta = value; }

        /// <summary>Backing field for <see cref="PersistedFields" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IJobWorkresultPersistedFields _persistedFields;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IJobWorkresultPersistedFields PersistedFields { get => (this._persistedFields = this._persistedFields ?? new JumpCloudApiSdkV2.Models.JobWorkresultPersistedFields()); set => this._persistedFields = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="StatusMsg" /> property.</summary>
        private string _statusMsg;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string StatusMsg { get => this._statusMsg; set => this._statusMsg = value; }

        /// <summary>Backing field for <see cref="UpdatedAt" /> property.</summary>
        private string _updatedAt;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UpdatedAt { get => this._updatedAt; set => this._updatedAt = value; }

        /// <summary>Creates an new <see cref="JobWorkresult" /> instance.</summary>
        public JobWorkresult()
        {

        }
    }
    /// Job WorkResult
    public partial interface IJobWorkresult :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedAt { get; set; }

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
        SerializedName = @"meta",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IJobWorkresultMeta) })]
        JumpCloudApiSdkV2.Models.IJobWorkresultMeta Meta { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"persistedFields",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IJobWorkresultPersistedFields) })]
        JumpCloudApiSdkV2.Models.IJobWorkresultPersistedFields PersistedFields { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"statusMsg",
        PossibleTypes = new [] { typeof(string) })]
        string StatusMsg { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"updatedAt",
        PossibleTypes = new [] { typeof(string) })]
        string UpdatedAt { get; set; }

    }
    /// Job WorkResult
    internal partial interface IJobWorkresultInternal

    {
        string CreatedAt { get; set; }

        string Id { get; set; }

        JumpCloudApiSdkV2.Models.IJobWorkresultMeta Meta { get; set; }

        JumpCloudApiSdkV2.Models.IJobWorkresultPersistedFields PersistedFields { get; set; }

        string Status { get; set; }

        string StatusMsg { get; set; }

        string UpdatedAt { get; set; }

    }
}