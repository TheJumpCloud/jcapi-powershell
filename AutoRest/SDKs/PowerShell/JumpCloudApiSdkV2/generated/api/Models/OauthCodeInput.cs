namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>OAuth Code Input</summary>
    public partial class OauthCodeInput :
        JumpCloudApiSdkV2.Models.IOauthCodeInput,
        JumpCloudApiSdkV2.Models.IOauthCodeInputInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Creates an new <see cref="OauthCodeInput" /> instance.</summary>
        public OauthCodeInput()
        {

        }
    }
    /// OAuth Code Input
    public partial interface IOauthCodeInput :
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
    /// OAuth Code Input
    internal partial interface IOauthCodeInputInternal

    {
        string Code { get; set; }

    }
}