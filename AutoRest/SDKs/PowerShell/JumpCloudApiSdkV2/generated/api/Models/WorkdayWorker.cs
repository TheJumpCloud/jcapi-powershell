namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Workday Worker</summary>
    public partial class WorkdayWorker :
        JumpCloudApiSdkV2.Models.IWorkdayWorker,
        JumpCloudApiSdkV2.Models.IWorkdayWorkerInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IWorkdayWorkerAttributes _attributes;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IWorkdayWorkerAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.WorkdayWorkerAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Backing field for <see cref="FirstName" /> property.</summary>
        private string _firstName;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string FirstName { get => this._firstName; set => this._firstName = value; }

        /// <summary>Backing field for <see cref="LastName" /> property.</summary>
        private string _lastName;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string LastName { get => this._lastName; set => this._lastName = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="WorkdayWorker" /> instance.</summary>
        public WorkdayWorker()
        {

        }
    }
    /// Workday Worker
    public partial interface IWorkdayWorker :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IWorkdayWorkerAttributes) })]
        JumpCloudApiSdkV2.Models.IWorkdayWorkerAttributes Attributes { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string Email { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        string FirstName { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        string LastName { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// Workday Worker
    internal partial interface IWorkdayWorkerInternal

    {
        JumpCloudApiSdkV2.Models.IWorkdayWorkerAttributes Attributes { get; set; }

        string Email { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Username { get; set; }

    }
}