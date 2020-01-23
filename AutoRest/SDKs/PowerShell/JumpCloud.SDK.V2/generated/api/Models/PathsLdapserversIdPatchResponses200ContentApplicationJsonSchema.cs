namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PathsLdapserversIdPatchResponses200ContentApplicationJsonSchema :
        JumpCloud.SDK.V2.Models.IPathsLdapserversIdPatchResponses200ContentApplicationJsonSchema,
        JumpCloud.SDK.V2.Models.IPathsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="UserLockoutAction" /> property.</summary>
        private string _userLockoutAction;

        /// <summary>LDAP Server Action</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string UserLockoutAction { get => this._userLockoutAction; set => this._userLockoutAction = value; }

        /// <summary>Backing field for <see cref="UserPasswordExpirationAction" /> property.</summary>
        private string _userPasswordExpirationAction;

        /// <summary>LDAP Server Action</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string UserPasswordExpirationAction { get => this._userPasswordExpirationAction; set => this._userPasswordExpirationAction = value; }

        /// <summary>
        /// Creates an new <see cref="PathsLdapserversIdPatchResponses200ContentApplicationJsonSchema" /> instance.
        /// </summary>
        public PathsLdapserversIdPatchResponses200ContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsLdapserversIdPatchResponses200ContentApplicationJsonSchema :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>LDAP Server Action</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"LDAP Server Action",
        SerializedName = @"userLockoutAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserLockoutAction { get; set; }
        /// <summary>LDAP Server Action</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"LDAP Server Action",
        SerializedName = @"userPasswordExpirationAction",
        PossibleTypes = new [] { typeof(string) })]
        string UserPasswordExpirationAction { get; set; }

    }
    internal partial interface IPathsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal

    {
        string Id { get; set; }

        string Name { get; set; }
        /// <summary>LDAP Server Action</summary>
        string UserLockoutAction { get; set; }
        /// <summary>LDAP Server Action</summary>
        string UserPasswordExpirationAction { get; set; }

    }
}