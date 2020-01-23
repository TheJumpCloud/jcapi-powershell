namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Job Details</summary>
    public partial class JobDetails :
        JumpCloud.SDK.V2.Models.IJobDetails,
        JumpCloud.SDK.V2.Models.IJobDetailsInternal
    {

        /// <summary>Backing field for <see cref="AdminId" /> property.</summary>
        private string _adminId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string AdminId { get => this._adminId; set => this._adminId = value; }

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private string _createdAt;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CreatedAt { get => this._createdAt; set => this._createdAt = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Meta" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IJobDetailsMeta _meta;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V2.Models.IJobDetailsMeta Meta { get => (this._meta = this._meta ?? new JumpCloud.SDK.V2.Models.JobDetailsMeta()); set => this._meta = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PersistedFields" /> property.</summary>
        private string[] _persistedFields;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string[] PersistedFields { get => this._persistedFields; set => this._persistedFields = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="UpdatedAt" /> property.</summary>
        private string _updatedAt;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string UpdatedAt { get => this._updatedAt; set => this._updatedAt = value; }

        /// <summary>Backing field for <see cref="WorkUnitsCount" /> property.</summary>
        private int? _workUnitsCount;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? WorkUnitsCount { get => this._workUnitsCount; set => this._workUnitsCount = value; }

        /// <summary>Creates an new <see cref="JobDetails" /> instance.</summary>
        public JobDetails()
        {

        }
    }
    /// Job Details
    public partial interface IJobDetails :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"adminId",
        PossibleTypes = new [] { typeof(string) })]
        string AdminId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedAt { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"meta",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IJobDetailsMeta) })]
        JumpCloud.SDK.V2.Models.IJobDetailsMeta Meta { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"persistedFields",
        PossibleTypes = new [] { typeof(string) })]
        string[] PersistedFields { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"updatedAt",
        PossibleTypes = new [] { typeof(string) })]
        string UpdatedAt { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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

        JumpCloud.SDK.V2.Models.IJobDetailsMeta Meta { get; set; }

        string Name { get; set; }

        string[] PersistedFields { get; set; }

        string Status { get; set; }

        string UpdatedAt { get; set; }

        int? WorkUnitsCount { get; set; }

    }
}