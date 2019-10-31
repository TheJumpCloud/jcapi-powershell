namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class BodyParameterRadiusServerPutRequestBody :
        JumpCloudApiSdkV1.Models.IBodyParameterRadiusServerPutRequestBody,
        JumpCloudApiSdkV1.Models.IBodyParameterRadiusServerPutRequestBodyInternal
    {

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

        /// <summary>Creates an new <see cref="BodyParameterRadiusServerPutRequestBody" /> instance.</summary>
        public BodyParameterRadiusServerPutRequestBody()
        {

        }
    }
    public partial interface IBodyParameterRadiusServerPutRequestBody :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"mfa",
        PossibleTypes = new [] { typeof(string) })]
        string Mfa { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkSourceIp",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSourceIP { get; set; }

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
    internal partial interface IBodyParameterRadiusServerPutRequestBodyInternal

    {
        string Mfa { get; set; }

        string Name { get; set; }

        string NetworkSourceIP { get; set; }

        string[] Tags { get; set; }

        string UserLockoutAction { get; set; }

        string UserPasswordExpirationAction { get; set; }

    }
}