namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>DuoRegistrationApplication</summary>
    public partial class DuoRegistrationApplication :
        JumpCloudApiSdkV2.Models.IDuoRegistrationApplication,
        JumpCloudApiSdkV2.Models.IDuoRegistrationApplicationInternal
    {

        /// <summary>Backing field for <see cref="ApiHost" /> property.</summary>
        private string _apiHost;

        /// <summary>Duo Application host name.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ApiHost { get => this._apiHost; set => this._apiHost = value; }

        /// <summary>Backing field for <see cref="IntegrationKey" /> property.</summary>
        private string _integrationKey;

        /// <summary>Duo Application integration key.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string IntegrationKey { get => this._integrationKey; set => this._integrationKey = value; }

        /// <summary>Backing field for <see cref="SecretKey" /> property.</summary>
        private string _secretKey;

        /// <summary>Duo Application secret key.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SecretKey { get => this._secretKey; set => this._secretKey = value; }

        /// <summary>Creates an new <see cref="DuoRegistrationApplication" /> instance.</summary>
        public DuoRegistrationApplication()
        {

        }
    }
    /// DuoRegistrationApplication
    public partial interface IDuoRegistrationApplication :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>Duo Application host name.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Duo Application host name.",
        SerializedName = @"apiHost",
        PossibleTypes = new [] { typeof(string) })]
        string ApiHost { get; set; }
        /// <summary>Duo Application integration key.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Duo Application integration key.",
        SerializedName = @"integrationKey",
        PossibleTypes = new [] { typeof(string) })]
        string IntegrationKey { get; set; }
        /// <summary>Duo Application secret key.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Duo Application secret key.",
        SerializedName = @"secretKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecretKey { get; set; }

    }
    /// DuoRegistrationApplication
    internal partial interface IDuoRegistrationApplicationInternal

    {
        /// <summary>Duo Application host name.</summary>
        string ApiHost { get; set; }
        /// <summary>Duo Application integration key.</summary>
        string IntegrationKey { get; set; }
        /// <summary>Duo Application secret key.</summary>
        string SecretKey { get; set; }

    }
}