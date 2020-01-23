namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Auth Input Object</summary>
    public partial class AuthInputObject :
        JumpCloud.SDK.V2.Models.IAuthInputObject,
        JumpCloud.SDK.V2.Models.IAuthInputObjectInternal
    {

        /// <summary>Backing field for <see cref="Auth" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IAuthInput _auth;

        /// <summary>Auth Input</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IAuthInput Auth { get => (this._auth = this._auth ?? new JumpCloud.SDK.V2.Models.AuthInput()); set => this._auth = value; }

        /// <summary>FIXME: Property BasicPassword is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string BasicPassword { get => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).BasicPassword; set => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).BasicPassword = value; }

        /// <summary>FIXME: Property BasicUsername is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string BasicUsername { get => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).BasicUsername; set => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).BasicUsername = value; }

        /// <summary>Internal Acessors for Auth</summary>
        JumpCloud.SDK.V2.Models.IAuthInput JumpCloud.SDK.V2.Models.IAuthInputObjectInternal.Auth { get => (this._auth = this._auth ?? new JumpCloud.SDK.V2.Models.AuthInput()); set { {_auth = value;} } }

        /// <summary>Internal Acessors for AuthBasic</summary>
        JumpCloud.SDK.V2.Models.IAuthInputBasic JumpCloud.SDK.V2.Models.IAuthInputObjectInternal.AuthBasic { get => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).Basic; set => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).Basic = value; }

        /// <summary>Internal Acessors for AuthOauth</summary>
        JumpCloud.SDK.V2.Models.IAuthInputOauth JumpCloud.SDK.V2.Models.IAuthInputObjectInternal.AuthOauth { get => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).Oauth; set => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).Oauth = value; }

        /// <summary>FIXME: Property OauthCode is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string OauthCode { get => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).OauthCode; set => ((JumpCloud.SDK.V2.Models.IAuthInputInternal)Auth).OauthCode = value; }

        /// <summary>Creates an new <see cref="AuthInputObject" /> instance.</summary>
        public AuthInputObject()
        {

        }
    }
    /// Auth Input Object
    public partial interface IAuthInputObject :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string BasicPassword { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string BasicUsername { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string OauthCode { get; set; }

    }
    /// Auth Input Object
    internal partial interface IAuthInputObjectInternal

    {
        /// <summary>Auth Input</summary>
        JumpCloud.SDK.V2.Models.IAuthInput Auth { get; set; }

        JumpCloud.SDK.V2.Models.IAuthInputBasic AuthBasic { get; set; }

        JumpCloud.SDK.V2.Models.IAuthInputOauth AuthOauth { get; set; }

        string BasicPassword { get; set; }

        string BasicUsername { get; set; }

        string OauthCode { get; set; }

    }
}