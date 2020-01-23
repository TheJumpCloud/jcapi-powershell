namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>GraphObjectWithPaths</summary>
    public partial class GraphObjectWithPaths :
        JumpCloud.SDK.V2.Models.IGraphObjectWithPaths,
        JumpCloud.SDK.V2.Models.IGraphObjectWithPathsInternal
    {

        /// <summary>Backing field for <see cref="CompiledAttributes" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IGraphObjectWithPathsCompiledAttributes _compiledAttributes;

        /// <summary>The compiled graph attributes of the target object.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V2.Models.IGraphObjectWithPathsCompiledAttributes CompiledAttributes { get => (this._compiledAttributes = this._compiledAttributes ?? new JumpCloud.SDK.V2.Models.GraphObjectWithPathsCompiledAttributes()); set => this._compiledAttributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Object ID of this graph object.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Paths" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IGraphConnection[][] _paths;

        /// <summary>A path through the graph between two graph objects.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V2.Models.IGraphConnection[][] Paths { get => this._paths; set => this._paths = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The graph type.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="GraphObjectWithPaths" /> instance.</summary>
        public GraphObjectWithPaths()
        {

        }
    }
    /// GraphObjectWithPaths
    public partial interface IGraphObjectWithPaths :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>The compiled graph attributes of the target object.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The compiled graph attributes of the target object.",
        SerializedName = @"compiledAttributes",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IGraphObjectWithPathsCompiledAttributes) })]
        JumpCloud.SDK.V2.Models.IGraphObjectWithPathsCompiledAttributes CompiledAttributes { get; set; }
        /// <summary>Object ID of this graph object.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Object ID of this graph object.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>A path through the graph between two graph objects.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A path through the graph between two graph objects.",
        SerializedName = @"paths",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IGraphConnection) })]
        JumpCloud.SDK.V2.Models.IGraphConnection[][] Paths { get; set; }
        /// <summary>The graph type.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The graph type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// GraphObjectWithPaths
    internal partial interface IGraphObjectWithPathsInternal

    {
        /// <summary>The compiled graph attributes of the target object.</summary>
        JumpCloud.SDK.V2.Models.IGraphObjectWithPathsCompiledAttributes CompiledAttributes { get; set; }
        /// <summary>Object ID of this graph object.</summary>
        string Id { get; set; }
        /// <summary>A path through the graph between two graph objects.</summary>
        JumpCloud.SDK.V2.Models.IGraphConnection[][] Paths { get; set; }
        /// <summary>The graph type.</summary>
        string Type { get; set; }

    }
}