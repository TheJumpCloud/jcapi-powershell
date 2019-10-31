namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>UserGroupGraphManagementReq</summary>
    public partial class UserGroupGraphManagementReq :
        JumpCloudApiSdkV2.Models.IUserGroupGraphManagementReq,
        JumpCloudApiSdkV2.Models.IUserGroupGraphManagementReqInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IUserGroupGraphManagementReqAttributes _attributes;

        /// <summary>The graph connection's attributes.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IUserGroupGraphManagementReqAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.UserGroupGraphManagementReqAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Op" /> property.</summary>
        private string _op;

        /// <summary>How to modify the graph connection.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Op { get => this._op; set => this._op = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The graph type</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="UserGroupGraphManagementReq" /> instance.</summary>
        public UserGroupGraphManagementReq()
        {

        }
    }
    /// UserGroupGraphManagementReq
    public partial interface IUserGroupGraphManagementReq :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The graph connection's attributes.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The graph connection's attributes.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IUserGroupGraphManagementReqAttributes) })]
        JumpCloudApiSdkV2.Models.IUserGroupGraphManagementReqAttributes Attributes { get; set; }
        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ObjectID of graph object being added or removed as an association.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>How to modify the graph connection.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"How to modify the graph connection.",
        SerializedName = @"op",
        PossibleTypes = new [] { typeof(string) })]
        string Op { get; set; }
        /// <summary>The graph type</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The graph type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// UserGroupGraphManagementReq
    internal partial interface IUserGroupGraphManagementReqInternal

    {
        /// <summary>The graph connection's attributes.</summary>
        JumpCloudApiSdkV2.Models.IUserGroupGraphManagementReqAttributes Attributes { get; set; }
        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        string Id { get; set; }
        /// <summary>How to modify the graph connection.</summary>
        string Op { get; set; }
        /// <summary>The graph type</summary>
        string Type { get; set; }

    }
}