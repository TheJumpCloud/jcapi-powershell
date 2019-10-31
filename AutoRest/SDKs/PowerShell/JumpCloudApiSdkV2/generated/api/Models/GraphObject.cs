namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>GraphObject</summary>
    public partial class GraphObject :
        JumpCloudApiSdkV2.Models.IGraphObject,
        JumpCloudApiSdkV2.Models.IGraphObjectInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IGraphObjectAttributes _attributes;

        /// <summary>The graph object's attributes.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IGraphObjectAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.GraphObjectAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ObjectID of the graph object.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of graph object.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="GraphObject" /> instance.</summary>
        public GraphObject()
        {

        }
    }
    /// GraphObject
    public partial interface IGraphObject :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The graph object's attributes.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The graph object's attributes.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IGraphObjectAttributes) })]
        JumpCloudApiSdkV2.Models.IGraphObjectAttributes Attributes { get; set; }
        /// <summary>The ObjectID of the graph object.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ObjectID of the graph object.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The type of graph object.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of graph object.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// GraphObject
    internal partial interface IGraphObjectInternal

    {
        /// <summary>The graph object's attributes.</summary>
        JumpCloudApiSdkV2.Models.IGraphObjectAttributes Attributes { get; set; }
        /// <summary>The ObjectID of the graph object.</summary>
        string Id { get; set; }
        /// <summary>The type of graph object.</summary>
        string Type { get; set; }

    }
}