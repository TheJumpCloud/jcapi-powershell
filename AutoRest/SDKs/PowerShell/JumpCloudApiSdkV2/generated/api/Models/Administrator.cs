namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Administrator</summary>
    public partial class Administrator :
        JumpCloudApiSdkV2.Models.IAdministrator,
        JumpCloudApiSdkV2.Models.IAdministratorInternal
    {

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Backing field for <see cref="EnableMultiFactor" /> property.</summary>
        private bool? _enableMultiFactor;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? EnableMultiFactor { get => this._enableMultiFactor; set => this._enableMultiFactor = value; }

        /// <summary>Backing field for <see cref="Firstname" /> property.</summary>
        private string _firstname;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Firstname { get => this._firstname; set => this._firstname = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Lastname" /> property.</summary>
        private string _lastname;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Lastname { get => this._lastname; set => this._lastname = value; }

        /// <summary>Backing field for <see cref="Registered" /> property.</summary>
        private bool? _registered;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? Registered { get => this._registered; set => this._registered = value; }

        /// <summary>Creates an new <see cref="Administrator" /> instance.</summary>
        public Administrator()
        {

        }
    }
    /// Administrator
    public partial interface IAdministrator :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
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
        SerializedName = @"enableMultiFactor",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableMultiFactor { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"firstname",
        PossibleTypes = new [] { typeof(string) })]
        string Firstname { get; set; }

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
        SerializedName = @"lastname",
        PossibleTypes = new [] { typeof(string) })]
        string Lastname { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"registered",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Registered { get; set; }

    }
    /// Administrator
    internal partial interface IAdministratorInternal

    {
        string Email { get; set; }

        bool? EnableMultiFactor { get; set; }

        string Firstname { get; set; }

        string Id { get; set; }

        string Lastname { get; set; }

        bool? Registered { get; set; }

    }
}