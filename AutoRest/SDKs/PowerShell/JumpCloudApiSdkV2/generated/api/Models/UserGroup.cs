namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>UserGroup</summary>
    public partial class UserGroup :
        JumpCloudApiSdkV2.Models.IUserGroup,
        JumpCloudApiSdkV2.Models.IUserGroupInternal
    {

        /// <summary>FIXME: Property AttributePosixGroups is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem[] AttributePosixGroups { get => ((JumpCloudApiSdkV2.Models.IUserGroupAttributesInternal)Attributes).PosixGroups; set => ((JumpCloudApiSdkV2.Models.IUserGroupAttributesInternal)Attributes).PosixGroups = value; }

        /// <summary>FIXME: Property AttributeSambaEnabled is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? AttributeSambaEnabled { get => ((JumpCloudApiSdkV2.Models.IUserGroupAttributesInternal)Attributes).SambaEnabled; set => ((JumpCloudApiSdkV2.Models.IUserGroupAttributesInternal)Attributes).SambaEnabled = value; }

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IUserGroupAttributes _attributes;

        /// <summary>UserGroupAttributes</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IUserGroupAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.UserGroupAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectId uniquely identifying a User Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Attributes</summary>
        JumpCloudApiSdkV2.Models.IUserGroupAttributes JumpCloudApiSdkV2.Models.IUserGroupInternal.Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.UserGroupAttributes()); set { {_attributes = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Display name of a User Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="UserGroup" /> instance.</summary>
        public UserGroup()
        {

        }
    }
    /// UserGroup
    public partial interface IUserGroup :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"posixGroups",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem) })]
        JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem[] AttributePosixGroups { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sambaEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AttributeSambaEnabled { get; set; }
        /// <summary>ObjectId uniquely identifying a User Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a User Group.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Display name of a User Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of a User Group.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The type of the group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the group.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// UserGroup
    internal partial interface IUserGroupInternal

    {
        JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem[] AttributePosixGroups { get; set; }

        bool? AttributeSambaEnabled { get; set; }
        /// <summary>UserGroupAttributes</summary>
        JumpCloudApiSdkV2.Models.IUserGroupAttributes Attributes { get; set; }
        /// <summary>ObjectId uniquely identifying a User Group.</summary>
        string Id { get; set; }
        /// <summary>Display name of a User Group.</summary>
        string Name { get; set; }
        /// <summary>The type of the group.</summary>
        string Type { get; set; }

    }
}