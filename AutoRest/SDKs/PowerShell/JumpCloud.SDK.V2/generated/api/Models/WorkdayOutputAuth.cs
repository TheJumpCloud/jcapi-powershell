namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class WorkdayOutputAuth :
        JumpCloud.SDK.V2.Models.IWorkdayOutputAuth,
        JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal
    {

        /// <summary>Backing field for <see cref="Basic" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IAuthInfo _basic;

        /// <summary>Auth Info</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IAuthInfo Basic { get => (this._basic = this._basic ?? new JumpCloud.SDK.V2.Models.AuthInfo()); set => this._basic = value; }

        /// <summary>FIXME: Property BasicExpiry is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string BasicExpiry { get => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Basic).Expiry; set => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Basic).Expiry = value; }

        /// <summary>FIXME: Property BasicIsValid is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? BasicIsValid { get => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Basic).IsValid; set => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Basic).IsValid = value; }

        /// <summary>FIXME: Property BasicMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string BasicMessage { get => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Basic).Message; set => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Basic).Message = value; }

        /// <summary>Internal Acessors for Basic</summary>
        JumpCloud.SDK.V2.Models.IAuthInfo JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal.Basic { get => (this._basic = this._basic ?? new JumpCloud.SDK.V2.Models.AuthInfo()); set { {_basic = value;} } }

        /// <summary>Internal Acessors for Oauth</summary>
        JumpCloud.SDK.V2.Models.IAuthInfo JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal.Oauth { get => (this._oauth = this._oauth ?? new JumpCloud.SDK.V2.Models.AuthInfo()); set { {_oauth = value;} } }

        /// <summary>Backing field for <see cref="Oauth" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IAuthInfo _oauth;

        /// <summary>Auth Info</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IAuthInfo Oauth { get => (this._oauth = this._oauth ?? new JumpCloud.SDK.V2.Models.AuthInfo()); set => this._oauth = value; }

        /// <summary>FIXME: Property OauthExpiry is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string OauthExpiry { get => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Oauth).Expiry; set => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Oauth).Expiry = value; }

        /// <summary>FIXME: Property OauthIsValid is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? OauthIsValid { get => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Oauth).IsValid; set => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Oauth).IsValid = value; }

        /// <summary>FIXME: Property OauthMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string OauthMessage { get => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Oauth).Message; set => ((JumpCloud.SDK.V2.Models.IAuthInfoInternal)Oauth).Message = value; }

        /// <summary>Creates an new <see cref="WorkdayOutputAuth" /> instance.</summary>
        public WorkdayOutputAuth()
        {

        }
    }
    public partial interface IWorkdayOutputAuth :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string BasicExpiry { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BasicIsValid { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string BasicMessage { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string OauthExpiry { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OauthIsValid { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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
        JumpCloud.SDK.V2.Models.IAuthInfo Basic { get; set; }

        string BasicExpiry { get; set; }

        bool? BasicIsValid { get; set; }

        string BasicMessage { get; set; }
        /// <summary>Auth Info</summary>
        JumpCloud.SDK.V2.Models.IAuthInfo Oauth { get; set; }

        string OauthExpiry { get; set; }

        bool? OauthIsValid { get; set; }

        string OauthMessage { get; set; }

    }
}