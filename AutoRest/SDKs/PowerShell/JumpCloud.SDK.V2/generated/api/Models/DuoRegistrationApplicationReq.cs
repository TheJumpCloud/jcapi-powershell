namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>DuoRegistrationApplicationReq</summary>
    public partial class DuoRegistrationApplicationReq :
        JumpCloud.SDK.V2.Models.IDuoRegistrationApplicationReq,
        JumpCloud.SDK.V2.Models.IDuoRegistrationApplicationReqInternal
    {

        /// <summary>Internal Acessors for RegistrationApplication</summary>
        JumpCloud.SDK.V2.Models.IDuoRegistrationApplication JumpCloud.SDK.V2.Models.IDuoRegistrationApplicationReqInternal.RegistrationApplication { get => (this._registrationApplication = this._registrationApplication ?? new JumpCloud.SDK.V2.Models.DuoRegistrationApplication()); set { {_registrationApplication = value;} } }

        /// <summary>Backing field for <see cref="RegistrationApplication" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IDuoRegistrationApplication _registrationApplication;

        /// <summary>DuoRegistrationApplication</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IDuoRegistrationApplication RegistrationApplication { get => (this._registrationApplication = this._registrationApplication ?? new JumpCloud.SDK.V2.Models.DuoRegistrationApplication()); set => this._registrationApplication = value; }

        /// <summary>Duo Application host name.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string RegistrationApplicationApiHost { get => ((JumpCloud.SDK.V2.Models.IDuoRegistrationApplicationInternal)RegistrationApplication).ApiHost; set => ((JumpCloud.SDK.V2.Models.IDuoRegistrationApplicationInternal)RegistrationApplication).ApiHost = value; }

        /// <summary>Duo Application integration key.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string RegistrationApplicationIntegrationKey { get => ((JumpCloud.SDK.V2.Models.IDuoRegistrationApplicationInternal)RegistrationApplication).IntegrationKey; set => ((JumpCloud.SDK.V2.Models.IDuoRegistrationApplicationInternal)RegistrationApplication).IntegrationKey = value; }

        /// <summary>Duo Application secret key.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string RegistrationApplicationSecretKey { get => ((JumpCloud.SDK.V2.Models.IDuoRegistrationApplicationInternal)RegistrationApplication).SecretKey; set => ((JumpCloud.SDK.V2.Models.IDuoRegistrationApplicationInternal)RegistrationApplication).SecretKey = value; }

        /// <summary>Creates an new <see cref="DuoRegistrationApplicationReq" /> instance.</summary>
        public DuoRegistrationApplicationReq()
        {

        }
    }
    /// DuoRegistrationApplicationReq
    public partial interface IDuoRegistrationApplicationReq :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>Duo Application host name.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Duo Application host name.",
        SerializedName = @"apiHost",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationApplicationApiHost { get; set; }
        /// <summary>Duo Application integration key.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Duo Application integration key.",
        SerializedName = @"integrationKey",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationApplicationIntegrationKey { get; set; }
        /// <summary>Duo Application secret key.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Duo Application secret key.",
        SerializedName = @"secretKey",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationApplicationSecretKey { get; set; }

    }
    /// DuoRegistrationApplicationReq
    internal partial interface IDuoRegistrationApplicationReqInternal

    {
        /// <summary>DuoRegistrationApplication</summary>
        JumpCloud.SDK.V2.Models.IDuoRegistrationApplication RegistrationApplication { get; set; }
        /// <summary>Duo Application host name.</summary>
        string RegistrationApplicationApiHost { get; set; }
        /// <summary>Duo Application integration key.</summary>
        string RegistrationApplicationIntegrationKey { get; set; }
        /// <summary>Duo Application secret key.</summary>
        string RegistrationApplicationSecretKey { get; set; }

    }
}