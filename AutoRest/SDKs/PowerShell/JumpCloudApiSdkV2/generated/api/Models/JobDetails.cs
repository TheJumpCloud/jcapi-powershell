namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Job Details</summary>
    public partial class JobDetails :
        JumpCloudApiSdkV2.Models.IJobDetails,
        JumpCloudApiSdkV2.Models.IJobDetailsInternal
    {

        /// <summary>Backing field for <see cref="AdminId" /> property.</summary>
        private string _adminId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string AdminId { get => this._adminId; set => this._adminId = value; }

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private string _createdAt;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CreatedAt { get => this._createdAt; set => this._createdAt = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Meta" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IJobDetailsMeta _meta;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IJobDetailsMeta Meta { get => (this._meta = this._meta ?? new JumpCloudApiSdkV2.Models.JobDetailsMeta()); set => this._meta = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PersistedFields" /> property.</summary>
        private string[] _persistedFields;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string[] PersistedFields { get => this._persistedFields; set => this._persistedFields = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="UpdatedAt" /> property.</summary>
        private string _updatedAt;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UpdatedAt { get => this._updatedAt; set => this._updatedAt = value; }

        /// <summary>Backing field for <see cref="WorkUnitsCount" /> property.</summary>
        private int? _workUnitsCount;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? WorkUnitsCount { get => this._workUnitsCount; set => this._workUnitsCount = value; }

        /// <summary>Creates an new <see cref="JobDetails" /> instance.</summary>
        public JobDetails()
        {

        }
    }
    /// Job Details
    public partial interface IJobDetails :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"adminId",
        PossibleTypes = new [] { typeof(string) })]
        string AdminId { get; set; }

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
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IJobDetailsMeta) })]
        JumpCloudApiSdkV2.Models.IJobDetailsMeta Meta { get; set; }

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
        SerializedName = @"persistedFields",
        PossibleTypes = new [] { typeof(string) })]
        string[] PersistedFields { get; set; }

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
        SerializedName = @"updatedAt",
        PossibleTypes = new [] { typeof(string) })]
        string UpdatedAt { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"workUnitsCount",
        PossibleTypes = new [] { typeof(int) })]
        int? WorkUnitsCount { get; set; }

    }
    /// Job Details
    internal partial interface IJobDetailsInternal

    {
        string AdminId { get; set; }

        string CreatedAt { get; set; }

        string Id { get; set; }

        JumpCloudApiSdkV2.Models.IJobDetailsMeta Meta { get; set; }

        string Name { get; set; }

        string[] PersistedFields { get; set; }

        string Status { get; set; }

        string UpdatedAt { get; set; }

        int? WorkUnitsCount { get; set; }

    }
}