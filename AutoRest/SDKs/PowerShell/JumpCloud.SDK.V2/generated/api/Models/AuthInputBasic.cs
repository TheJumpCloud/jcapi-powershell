namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class AuthInputBasic :
        JumpCloud.SDK.V2.Models.IAuthInputBasic,
        JumpCloud.SDK.V2.Models.IAuthInputBasicInternal
    {

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="AuthInputBasic" /> instance.</summary>
        public AuthInputBasic()
        {

        }
    }
    public partial interface IAuthInputBasic :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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