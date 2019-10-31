namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>UserGroupAttributes</summary>
    public partial class UserGroupAttributes :
        JumpCloudApiSdkV2.Models.IUserGroupAttributes,
        JumpCloudApiSdkV2.Models.IUserGroupAttributesInternal
    {

        /// <summary>Backing field for <see cref="PosixGroups" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem[] _posixGroups;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem[] PosixGroups { get => this._posixGroups; set => this._posixGroups = value; }

        /// <summary>Backing field for <see cref="SambaEnabled" /> property.</summary>
        private bool? _sambaEnabled;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? SambaEnabled { get => this._sambaEnabled; set => this._sambaEnabled = value; }

        /// <summary>Creates an new <see cref="UserGroupAttributes" /> instance.</summary>
        public UserGroupAttributes()
        {

        }
    }
    /// UserGroupAttributes
    public partial interface IUserGroupAttributes :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"posixGroups",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem) })]
        JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem[] PosixGroups { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
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
        JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem[] PosixGroups { get; set; }

        bool? SambaEnabled { get; set; }

    }
}