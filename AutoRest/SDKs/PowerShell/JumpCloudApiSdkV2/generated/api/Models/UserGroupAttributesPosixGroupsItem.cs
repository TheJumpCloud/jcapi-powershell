namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class UserGroupAttributesPosixGroupsItem :
        JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem,
        JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItemInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="UserGroupAttributesPosixGroupsItem" /> instance.</summary>
        public UserGroupAttributesPosixGroupsItem()
        {

        }
    }
    public partial interface IUserGroupAttributesPosixGroupsItem :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    internal partial interface IUserGroupAttributesPosixGroupsItemInternal

    {
        int? Id { get; set; }

        string Name { get; set; }

    }
}