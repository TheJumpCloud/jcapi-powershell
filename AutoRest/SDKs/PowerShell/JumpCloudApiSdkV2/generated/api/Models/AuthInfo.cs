namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Auth Info</summary>
    public partial class AuthInfo :
        JumpCloudApiSdkV2.Models.IAuthInfo,
        JumpCloudApiSdkV2.Models.IAuthInfoInternal
    {

        /// <summary>Backing field for <see cref="Expiry" /> property.</summary>
        private string _expiry;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Expiry { get => this._expiry; set => this._expiry = value; }

        /// <summary>Backing field for <see cref="IsValid" /> property.</summary>
        private bool? _isValid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? IsValid { get => this._isValid; set => this._isValid = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="AuthInfo" /> instance.</summary>
        public AuthInfo()
        {

        }
    }
    /// Auth Info
    public partial interface IAuthInfo :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string Expiry { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsValid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// Auth Info
    internal partial interface IAuthInfoInternal

    {
        string Expiry { get; set; }

        bool? IsValid { get; set; }

        string Message { get; set; }

    }
}