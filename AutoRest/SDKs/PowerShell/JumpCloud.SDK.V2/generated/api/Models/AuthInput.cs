namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Auth Input</summary>
    public partial class AuthInput :
        JumpCloud.SDK.V2.Models.IAuthInput,
        JumpCloud.SDK.V2.Models.IAuthInputInternal
    {

        /// <summary>Backing field for <see cref="Basic" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IAuthInputBasic _basic;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IAuthInputBasic Basic { get => (this._basic = this._basic ?? new JumpCloud.SDK.V2.Models.AuthInputBasic()); set => this._basic = value; }

        /// <summary>FIXME: Property BasicPassword is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string BasicPassword { get => ((JumpCloud.SDK.V2.Models.IAuthInputBasicInternal)Basic).Password; set => ((JumpCloud.SDK.V2.Models.IAuthInputBasicInternal)Basic).Password = value; }

        /// <summary>FIXME: Property BasicUsername is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string BasicUsername { get => ((JumpCloud.SDK.V2.Models.IAuthInputBasicInternal)Basic).Username; set => ((JumpCloud.SDK.V2.Models.IAuthInputBasicInternal)Basic).Username = value; }

        /// <summary>Internal Acessors for Basic</summary>
        JumpCloud.SDK.V2.Models.IAuthInputBasic JumpCloud.SDK.V2.Models.IAuthInputInternal.Basic { get => (this._basic = this._basic ?? new JumpCloud.SDK.V2.Models.AuthInputBasic()); set { {_basic = value;} } }

        /// <summary>Internal Acessors for Oauth</summary>
        JumpCloud.SDK.V2.Models.IAuthInputOauth JumpCloud.SDK.V2.Models.IAuthInputInternal.Oauth { get => (this._oauth = this._oauth ?? new JumpCloud.SDK.V2.Models.AuthInputOauth()); set { {_oauth = value;} } }

        /// <summary>Backing field for <see cref="Oauth" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IAuthInputOauth _oauth;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IAuthInputOauth Oauth { get => (this._oauth = this._oauth ?? new JumpCloud.SDK.V2.Models.AuthInputOauth()); set => this._oauth = value; }

        /// <summary>FIXME: Property OauthCode is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string OauthCode { get => ((JumpCloud.SDK.V2.Models.IAuthInputOauthInternal)Oauth).Code; set => ((JumpCloud.SDK.V2.Models.IAuthInputOauthInternal)Oauth).Code = value; }

        /// <summary>Creates an new <see cref="AuthInput" /> instance.</summary>
        public AuthInput()
        {

        }
    }
    /// Auth Input
    public partial interface IAuthInput :
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
    /// Auth Input
    internal partial interface IAuthInputInternal

    {
        JumpCloud.SDK.V2.Models.IAuthInputBasic Basic { get; set; }

        string BasicPassword { get; set; }

        string BasicUsername { get; set; }

        JumpCloud.SDK.V2.Models.IAuthInputOauth Oauth { get; set; }

        string OauthCode { get; set; }

    }
}