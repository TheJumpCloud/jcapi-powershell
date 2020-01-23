namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class UserGroupAttributesPosixGroupsItem :
        JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem,
        JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItemInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="UserGroupAttributesPosixGroupsItem" /> instance.</summary>
        public UserGroupAttributesPosixGroupsItem()
        {

        }
    }
    public partial interface IUserGroupAttributesPosixGroupsItem :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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