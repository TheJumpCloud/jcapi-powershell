namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Office 365 Output</summary>
    public partial class Office365Output :
        JumpCloud.SDK.V2.Models.IOffice365Output,
        JumpCloud.SDK.V2.Models.IOffice365OutputInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="UserLockoutAction" /> property.</summary>
        private string _userLockoutAction;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string UserLockoutAction { get => this._userLockoutAction; set => this._userLockoutAction = value; }

        /// <summary>Backing field for <see cref="UserPasswordExpirationAction" /> property.</summary>
        private string _userPasswordExpirationAction;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string UserPasswordExpirationAction { get => this._userPasswordExpirationAction; set => this._userPasswordExpirationAction = value; }

        /// <summary>Creates an new <see cref="Office365Output" /> instance.</summary>
        public Office365Output()
        {

        }
    }
    /// Office 365 Output
    public partial interface IOffice365Output :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userLockoutAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserLockoutAction { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userPasswordExpirationAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserPasswordExpirationAction { get; set; }

    }
    /// Office 365 Output
    internal partial interface IOffice365OutputInternal

    {
        string Id { get; set; }

        string UserLockoutAction { get; set; }

        string UserPasswordExpirationAction { get; set; }

    }
}