namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>UserGroupPut</summary>
    public partial class UserGroupPut :
        JumpCloud.SDK.V2.Models.IUserGroupPut,
        JumpCloud.SDK.V2.Models.IUserGroupPutInternal
    {

        /// <summary>FIXME: Property AttributePosixGroups is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[] AttributePosixGroups { get => ((JumpCloud.SDK.V2.Models.IUserGroupAttributesInternal)Attributes).PosixGroups; set => ((JumpCloud.SDK.V2.Models.IUserGroupAttributesInternal)Attributes).PosixGroups = value; }

        /// <summary>FIXME: Property AttributeSambaEnabled is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? AttributeSambaEnabled { get => ((JumpCloud.SDK.V2.Models.IUserGroupAttributesInternal)Attributes).SambaEnabled; set => ((JumpCloud.SDK.V2.Models.IUserGroupAttributesInternal)Attributes).SambaEnabled = value; }

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IUserGroupAttributes _attributes;

        /// <summary>UserGroupAttributes</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IUserGroupAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloud.SDK.V2.Models.UserGroupAttributes()); set => this._attributes = value; }

        /// <summary>Internal Acessors for Attributes</summary>
        JumpCloud.SDK.V2.Models.IUserGroupAttributes JumpCloud.SDK.V2.Models.IUserGroupPutInternal.Attributes { get => (this._attributes = this._attributes ?? new JumpCloud.SDK.V2.Models.UserGroupAttributes()); set { {_attributes = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Display name of a User Group.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="UserGroupPut" /> instance.</summary>
        public UserGroupPut()
        {

        }
    }
    /// UserGroupPut
    public partial interface IUserGroupPut :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"posixGroups",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem) })]
        JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[] AttributePosixGroups { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sambaEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AttributeSambaEnabled { get; set; }
        /// <summary>Display name of a User Group.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Display name of a User Group.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// UserGroupPut
    internal partial interface IUserGroupPutInternal

    {
        JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[] AttributePosixGroups { get; set; }

        bool? AttributeSambaEnabled { get; set; }
        /// <summary>UserGroupAttributes</summary>
        JumpCloud.SDK.V2.Models.IUserGroupAttributes Attributes { get; set; }
        /// <summary>Display name of a User Group.</summary>
        string Name { get; set; }

    }
}