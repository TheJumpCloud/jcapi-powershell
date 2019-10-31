namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>RadiusServer</summary>
    public partial class Radiusserver :
        JumpCloudApiSdkV1.Models.IRadiusserver,
        JumpCloudApiSdkV1.Models.IRadiusserverInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Mfa" /> property.</summary>
        private string _mfa;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Mfa { get => this._mfa; set => this._mfa = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NetworkSourceIP" /> property.</summary>
        private string _networkSourceIP;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string NetworkSourceIP { get => this._networkSourceIP; set => this._networkSourceIP = value; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="SharedSecret" /> property.</summary>
        private string _sharedSecret;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string SharedSecret { get => this._sharedSecret; set => this._sharedSecret = value; }

        /// <summary>Backing field for <see cref="TagNames" /> property.</summary>
        private string[] _tagNames;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] TagNames { get => this._tagNames; set => this._tagNames = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private string[] _tags;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Tags { get => this._tags; set => this._tags = value; }

        /// <summary>Backing field for <see cref="UserLockoutAction" /> property.</summary>
        private string _userLockoutAction;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string UserLockoutAction { get => this._userLockoutAction; set => this._userLockoutAction = value; }

        /// <summary>Backing field for <see cref="UserPasswordExpirationAction" /> property.</summary>
        private string _userPasswordExpirationAction;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string UserPasswordExpirationAction { get => this._userPasswordExpirationAction; set => this._userPasswordExpirationAction = value; }

        /// <summary>Creates an new <see cref="Radiusserver" /> instance.</summary>
        public Radiusserver()
        {

        }
    }
    /// RadiusServer
    public partial interface IRadiusserver :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
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
        SerializedName = @"mfa",
        PossibleTypes = new [] { typeof(string) })]
        string Mfa { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkSourceIp",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSourceIP { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        string Organization { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sharedSecret",
        PossibleTypes = new [] { typeof(string) })]
        string SharedSecret { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tagNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] TagNames { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string[] Tags { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userLockoutAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserLockoutAction { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userPasswordExpirationAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserPasswordExpirationAction { get; set; }

    }
    /// RadiusServer
    internal partial interface IRadiusserverInternal

    {
        string Id { get; set; }

        string Mfa { get; set; }

        string Name { get; set; }

        string NetworkSourceIP { get; set; }

        string Organization { get; set; }

        string SharedSecret { get; set; }

        string[] TagNames { get; set; }

        string[] Tags { get; set; }

        string UserLockoutAction { get; set; }

        string UserPasswordExpirationAction { get; set; }

    }
}