namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Auth Input</summary>
    public partial class AuthInput :
        JumpCloudApiSdkV2.Models.IAuthInput,
        JumpCloudApiSdkV2.Models.IAuthInputInternal
    {

        /// <summary>Backing field for <see cref="Basic" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IAuthInputBasic _basic;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IAuthInputBasic Basic { get => (this._basic = this._basic ?? new JumpCloudApiSdkV2.Models.AuthInputBasic()); set => this._basic = value; }

        /// <summary>FIXME: Property BasicPassword is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string BasicPassword { get => ((JumpCloudApiSdkV2.Models.IAuthInputBasicInternal)Basic).Password; set => ((JumpCloudApiSdkV2.Models.IAuthInputBasicInternal)Basic).Password = value; }

        /// <summary>FIXME: Property BasicUsername is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string BasicUsername { get => ((JumpCloudApiSdkV2.Models.IAuthInputBasicInternal)Basic).Username; set => ((JumpCloudApiSdkV2.Models.IAuthInputBasicInternal)Basic).Username = value; }

        /// <summary>Internal Acessors for Basic</summary>
        JumpCloudApiSdkV2.Models.IAuthInputBasic JumpCloudApiSdkV2.Models.IAuthInputInternal.Basic { get => (this._basic = this._basic ?? new JumpCloudApiSdkV2.Models.AuthInputBasic()); set { {_basic = value;} } }

        /// <summary>Internal Acessors for Oauth</summary>
        JumpCloudApiSdkV2.Models.IAuthInputOauth JumpCloudApiSdkV2.Models.IAuthInputInternal.Oauth { get => (this._oauth = this._oauth ?? new JumpCloudApiSdkV2.Models.AuthInputOauth()); set { {_oauth = value;} } }

        /// <summary>Backing field for <see cref="Oauth" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IAuthInputOauth _oauth;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IAuthInputOauth Oauth { get => (this._oauth = this._oauth ?? new JumpCloudApiSdkV2.Models.AuthInputOauth()); set => this._oauth = value; }

        /// <summary>FIXME: Property OauthCode is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string OauthCode { get => ((JumpCloudApiSdkV2.Models.IAuthInputOauthInternal)Oauth).Code; set => ((JumpCloudApiSdkV2.Models.IAuthInputOauthInternal)Oauth).Code = value; }

        /// <summary>Creates an new <see cref="AuthInput" /> instance.</summary>
        public AuthInput()
        {

        }
    }
    /// Auth Input
    public partial interface IAuthInput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string BasicPassword { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string BasicUsername { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
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
        JumpCloudApiSdkV2.Models.IAuthInputBasic Basic { get; set; }

        string BasicPassword { get; set; }

        string BasicUsername { get; set; }

        JumpCloudApiSdkV2.Models.IAuthInputOauth Oauth { get; set; }

        string OauthCode { get; set; }

    }
}