namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class AuthInputOauth :
        JumpCloudApiSdkV2.Models.IAuthInputOauth,
        JumpCloudApiSdkV2.Models.IAuthInputOauthInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Creates an new <see cref="AuthInputOauth" /> instance.</summary>
        public AuthInputOauth()
        {

        }
    }
    public partial interface IAuthInputOauth :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }

    }
    internal partial interface IAuthInputOauthInternal

    {
        string Code { get; set; }

    }
}