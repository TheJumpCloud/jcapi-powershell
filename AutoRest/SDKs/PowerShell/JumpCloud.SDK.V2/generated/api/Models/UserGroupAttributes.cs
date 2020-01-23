namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>UserGroupAttributes</summary>
    public partial class UserGroupAttributes :
        JumpCloud.SDK.V2.Models.IUserGroupAttributes,
        JumpCloud.SDK.V2.Models.IUserGroupAttributesInternal
    {

        /// <summary>Backing field for <see cref="PosixGroups" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[] _posixGroups;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[] PosixGroups { get => this._posixGroups; set => this._posixGroups = value; }

        /// <summary>Backing field for <see cref="SambaEnabled" /> property.</summary>
        private bool? _sambaEnabled;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public bool? SambaEnabled { get => this._sambaEnabled; set => this._sambaEnabled = value; }

        /// <summary>Creates an new <see cref="UserGroupAttributes" /> instance.</summary>
        public UserGroupAttributes()
        {

        }
    }
    /// UserGroupAttributes
    public partial interface IUserGroupAttributes :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"posixGroups",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem) })]
        JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[] PosixGroups { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sambaEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SambaEnabled { get; set; }

    }
    /// UserGroupAttributes
    internal partial interface IUserGroupAttributesInternal

    {
        JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[] PosixGroups { get; set; }

        bool? SambaEnabled { get; set; }

    }
}