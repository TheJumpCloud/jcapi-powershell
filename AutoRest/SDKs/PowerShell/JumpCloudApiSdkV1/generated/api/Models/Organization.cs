namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>Organization</summary>
    public partial class Organization :
        JumpCloudApiSdkV1.Models.IOrganization,
        JumpCloudApiSdkV1.Models.IOrganizationInternal
    {

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private string _created;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Created { get => this._created; set => this._created = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="HasStripeCustomerId" /> property.</summary>
        private bool? _hasStripeCustomerId;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? HasStripeCustomerId { get => this._hasStripeCustomerId; set => this._hasStripeCustomerId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LogoUrl" /> property.</summary>
        private string _logoUrl;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string LogoUrl { get => this._logoUrl; set => this._logoUrl = value; }

        /// <summary>Backing field for <see cref="Provider" /> property.</summary>
        private string _provider;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Provider { get => this._provider; set => this._provider = value; }

        /// <summary>Backing field for <see cref="Settings" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IOrganizationsettings _settings;

        /// <summary>OrganizationSettings</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IOrganizationsettings Settings { get => (this._settings = this._settings ?? new JumpCloudApiSdkV1.Models.Organizationsettings()); set => this._settings = value; }

        /// <summary>Creates an new <see cref="Organization" /> instance.</summary>
        public Organization()
        {

        }
    }
    /// Organization
    public partial interface IOrganization :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(string) })]
        string Created { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hasStripeCustomerId",
        PossibleTypes = new [] { typeof(bool) })]
        bool? HasStripeCustomerId { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"logoUrl",
        PossibleTypes = new [] { typeof(string) })]
        string LogoUrl { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string Provider { get; set; }
        /// <summary>OrganizationSettings</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"OrganizationSettings",
        SerializedName = @"settings",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IOrganizationsettings) })]
        JumpCloudApiSdkV1.Models.IOrganizationsettings Settings { get; set; }

    }
    /// Organization
    internal partial interface IOrganizationInternal

    {
        string Created { get; set; }

        string DisplayName { get; set; }

        bool? HasStripeCustomerId { get; set; }

        string Id { get; set; }

        string LogoUrl { get; set; }

        string Provider { get; set; }
        /// <summary>OrganizationSettings</summary>
        JumpCloudApiSdkV1.Models.IOrganizationsettings Settings { get; set; }

    }
}