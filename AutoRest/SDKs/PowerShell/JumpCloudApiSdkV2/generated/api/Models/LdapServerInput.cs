namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>LDAP Server Input</summary>
    public partial class LdapServerInput :
        JumpCloudApiSdkV2.Models.ILdapServerInput,
        JumpCloudApiSdkV2.Models.ILdapServerInputInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of this LDAP server</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="UserLockoutAction" /> property.</summary>
        private string _userLockoutAction;

        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UserLockoutAction { get => this._userLockoutAction; set => this._userLockoutAction = value; }

        /// <summary>Backing field for <see cref="UserPasswordExpirationAction" /> property.</summary>
        private string _userPasswordExpirationAction;

        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UserPasswordExpirationAction { get => this._userPasswordExpirationAction; set => this._userPasswordExpirationAction = value; }

        /// <summary>Creates an new <see cref="LdapServerInput" /> instance.</summary>
        public LdapServerInput()
        {

        }
    }
    /// LDAP Server Input
    public partial interface ILdapServerInput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The name of this LDAP server</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of this LDAP server",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"action to take; one of 'remove' or 'disable'",
        SerializedName = @"userLockoutAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserLockoutAction { get; set; }
        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"action to take; one of 'remove' or 'disable'",
        SerializedName = @"userPasswordExpirationAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserPasswordExpirationAction { get; set; }

    }
    /// LDAP Server Input
    internal partial interface ILdapServerInputInternal

    {
        /// <summary>The name of this LDAP server</summary>
        string Name { get; set; }
        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        string UserLockoutAction { get; set; }
        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        string UserPasswordExpirationAction { get; set; }

    }
}