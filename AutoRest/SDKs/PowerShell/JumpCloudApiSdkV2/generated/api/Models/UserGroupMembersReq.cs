namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>UserGroupMembersReq</summary>
    public partial class UserGroupMembersReq :
        JumpCloudApiSdkV2.Models.IUserGroupMembersReq,
        JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ObjectID of member being added or removed.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Type</summary>
        string JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Op" /> property.</summary>
        private string _op;

        /// <summary>How to modify the membership connection.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Op { get => this._op; set => this._op = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"user";

        /// <summary>The member type.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="UserGroupMembersReq" /> instance.</summary>
        public UserGroupMembersReq()
        {

        }
    }
    /// UserGroupMembersReq
    public partial interface IUserGroupMembersReq :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The ObjectID of member being added or removed.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ObjectID of member being added or removed.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>How to modify the membership connection.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"How to modify the membership connection.",
        SerializedName = @"op",
        PossibleTypes = new [] { typeof(string) })]
        string Op { get; set; }
        /// <summary>The member type.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"The member type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// UserGroupMembersReq
    internal partial interface IUserGroupMembersReqInternal

    {
        /// <summary>The ObjectID of member being added or removed.</summary>
        string Id { get; set; }
        /// <summary>How to modify the membership connection.</summary>
        string Op { get; set; }
        /// <summary>The member type.</summary>
        string Type { get; set; }

    }
}