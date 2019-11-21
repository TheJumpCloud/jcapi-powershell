namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>SystemGroupGraphManagementReq</summary>
    public partial class SystemGroupGraphManagementReq :
        JumpCloudApiSdkV1.Models.ISystemGroupGraphManagementReq,
        JumpCloudApiSdkV1.Models.ISystemGroupGraphManagementReqInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISystemGroupGraphManagementReqAttributes _attributes;

        /// <summary>The graph connection's attributes.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISystemGroupGraphManagementReqAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV1.Models.SystemGroupGraphManagementReqAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Op" /> property.</summary>
        private string _op;

        /// <summary>How to modify the graph connection.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Op { get => this._op; set => this._op = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemGroupGraphManagementReq" /> instance.</summary>
        public SystemGroupGraphManagementReq()
        {

        }
    }
    /// SystemGroupGraphManagementReq
    public partial interface ISystemGroupGraphManagementReq :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>The graph connection's attributes.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The graph connection's attributes.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISystemGroupGraphManagementReqAttributes) })]
        JumpCloudApiSdkV1.Models.ISystemGroupGraphManagementReqAttributes Attributes { get; set; }
        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ObjectID of graph object being added or removed as an association.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>How to modify the graph connection.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"How to modify the graph connection.",
        SerializedName = @"op",
        PossibleTypes = new [] { typeof(string) })]
        string Op { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// SystemGroupGraphManagementReq
    internal partial interface ISystemGroupGraphManagementReqInternal

    {
        /// <summary>The graph connection's attributes.</summary>
        JumpCloudApiSdkV1.Models.ISystemGroupGraphManagementReqAttributes Attributes { get; set; }
        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        string Id { get; set; }
        /// <summary>How to modify the graph connection.</summary>
        string Op { get; set; }

        string Type { get; set; }

    }
}