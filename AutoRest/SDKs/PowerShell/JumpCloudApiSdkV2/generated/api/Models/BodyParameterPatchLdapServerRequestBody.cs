namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class BodyParameterPatchLdapServerRequestBody :
        JumpCloudApiSdkV2.Models.IBodyParameterPatchLdapServerRequestBody,
        JumpCloudApiSdkV2.Models.IBodyParameterPatchLdapServerRequestBodyInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="UserLockoutAction" /> property.</summary>
        private string _userLockoutAction;

        /// <summary>LDAP Server Action</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UserLockoutAction { get => this._userLockoutAction; set => this._userLockoutAction = value; }

        /// <summary>Backing field for <see cref="UserPasswordExpirationAction" /> property.</summary>
        private string _userPasswordExpirationAction;

        /// <summary>LDAP Server Action</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UserPasswordExpirationAction { get => this._userPasswordExpirationAction; set => this._userPasswordExpirationAction = value; }

        /// <summary>Creates an new <see cref="BodyParameterPatchLdapServerRequestBody" /> instance.</summary>
        public BodyParameterPatchLdapServerRequestBody()
        {

        }
    }
    public partial interface IBodyParameterPatchLdapServerRequestBody :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>LDAP Server Action</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"LDAP Server Action",
        SerializedName = @"userLockoutAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserLockoutAction { get; set; }
        /// <summary>LDAP Server Action</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"LDAP Server Action",
        SerializedName = @"userPasswordExpirationAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserPasswordExpirationAction { get; set; }

    }
    internal partial interface IBodyParameterPatchLdapServerRequestBodyInternal

    {
        string Id { get; set; }
        /// <summary>LDAP Server Action</summary>
        string UserLockoutAction { get; set; }
        /// <summary>LDAP Server Action</summary>
        string UserPasswordExpirationAction { get; set; }

    }
}