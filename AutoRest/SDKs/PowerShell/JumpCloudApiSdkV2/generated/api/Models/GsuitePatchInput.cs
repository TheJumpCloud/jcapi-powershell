namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>GSuite Patch Input</summary>
    public partial class GsuitePatchInput :
        JumpCloudApiSdkV2.Models.IGsuitePatchInput,
        JumpCloudApiSdkV2.Models.IGsuitePatchInputInternal
    {

        /// <summary>Backing field for <see cref="UserLockoutAction" /> property.</summary>
        private string _userLockoutAction;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UserLockoutAction { get => this._userLockoutAction; set => this._userLockoutAction = value; }

        /// <summary>Backing field for <see cref="UserPasswordExpirationAction" /> property.</summary>
        private string _userPasswordExpirationAction;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UserPasswordExpirationAction { get => this._userPasswordExpirationAction; set => this._userPasswordExpirationAction = value; }

        /// <summary>Creates an new <see cref="GsuitePatchInput" /> instance.</summary>
        public GsuitePatchInput()
        {

        }
    }
    /// GSuite Patch Input
    public partial interface IGsuitePatchInput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userLockoutAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserLockoutAction { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userPasswordExpirationAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserPasswordExpirationAction { get; set; }

    }
    /// GSuite Patch Input
    internal partial interface IGsuitePatchInputInternal

    {
        string UserLockoutAction { get; set; }

        string UserPasswordExpirationAction { get; set; }

    }
}