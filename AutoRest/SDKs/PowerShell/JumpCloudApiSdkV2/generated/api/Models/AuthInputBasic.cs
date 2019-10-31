namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class AuthInputBasic :
        JumpCloudApiSdkV2.Models.IAuthInputBasic,
        JumpCloudApiSdkV2.Models.IAuthInputBasicInternal
    {

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="AuthInputBasic" /> instance.</summary>
        public AuthInputBasic()
        {

        }
    }
    public partial interface IAuthInputBasic :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    internal partial interface IAuthInputBasicInternal

    {
        string Password { get; set; }

        string Username { get; set; }

    }
}