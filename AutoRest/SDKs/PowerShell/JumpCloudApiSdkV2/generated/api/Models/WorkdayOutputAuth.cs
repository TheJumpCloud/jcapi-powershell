namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class WorkdayOutputAuth :
        JumpCloudApiSdkV2.Models.IWorkdayOutputAuth,
        JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal
    {

        /// <summary>Backing field for <see cref="Basic" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IAuthInfo _basic;

        /// <summary>Auth Info</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IAuthInfo Basic { get => (this._basic = this._basic ?? new JumpCloudApiSdkV2.Models.AuthInfo()); set => this._basic = value; }

        /// <summary>FIXME: Property BasicExpiry is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string BasicExpiry { get => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Basic).Expiry; set => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Basic).Expiry = value; }

        /// <summary>FIXME: Property BasicIsValid is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? BasicIsValid { get => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Basic).IsValid; set => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Basic).IsValid = value; }

        /// <summary>FIXME: Property BasicMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string BasicMessage { get => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Basic).Message; set => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Basic).Message = value; }

        /// <summary>Internal Acessors for Basic</summary>
        JumpCloudApiSdkV2.Models.IAuthInfo JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal.Basic { get => (this._basic = this._basic ?? new JumpCloudApiSdkV2.Models.AuthInfo()); set { {_basic = value;} } }

        /// <summary>Internal Acessors for Oauth</summary>
        JumpCloudApiSdkV2.Models.IAuthInfo JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal.Oauth { get => (this._oauth = this._oauth ?? new JumpCloudApiSdkV2.Models.AuthInfo()); set { {_oauth = value;} } }

        /// <summary>Backing field for <see cref="Oauth" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IAuthInfo _oauth;

        /// <summary>Auth Info</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IAuthInfo Oauth { get => (this._oauth = this._oauth ?? new JumpCloudApiSdkV2.Models.AuthInfo()); set => this._oauth = value; }

        /// <summary>FIXME: Property OauthExpiry is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string OauthExpiry { get => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Oauth).Expiry; set => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Oauth).Expiry = value; }

        /// <summary>FIXME: Property OauthIsValid is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? OauthIsValid { get => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Oauth).IsValid; set => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Oauth).IsValid = value; }

        /// <summary>FIXME: Property OauthMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string OauthMessage { get => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Oauth).Message; set => ((JumpCloudApiSdkV2.Models.IAuthInfoInternal)Oauth).Message = value; }

        /// <summary>Creates an new <see cref="WorkdayOutputAuth" /> instance.</summary>
        public WorkdayOutputAuth()
        {

        }
    }
    public partial interface IWorkdayOutputAuth :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string BasicExpiry { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BasicIsValid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string BasicMessage { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string OauthExpiry { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OauthIsValid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string OauthMessage { get; set; }

    }
    internal partial interface IWorkdayOutputAuthInternal

    {
        /// <summary>Auth Info</summary>
        JumpCloudApiSdkV2.Models.IAuthInfo Basic { get; set; }

        string BasicExpiry { get; set; }

        bool? BasicIsValid { get; set; }

        string BasicMessage { get; set; }
        /// <summary>Auth Info</summary>
        JumpCloudApiSdkV2.Models.IAuthInfo Oauth { get; set; }

        string OauthExpiry { get; set; }

        bool? OauthIsValid { get; set; }

        string OauthMessage { get; set; }

    }
}