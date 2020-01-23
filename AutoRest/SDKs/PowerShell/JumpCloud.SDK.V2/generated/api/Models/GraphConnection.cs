namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>
    /// Represents an edge between two graph objects. From can be omitted if it is clear from context.
    /// </summary>
    public partial class GraphConnection :
        JumpCloud.SDK.V2.Models.IGraphConnection,
        JumpCloud.SDK.V2.Models.IGraphConnectionInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IGraphConnectionAttributes _attributes;

        /// <summary>The graph connection's attributes.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V2.Models.IGraphConnectionAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloud.SDK.V2.Models.GraphConnectionAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="From" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IGraphObject _from;

        /// <summary>GraphObject</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IGraphObject From { get => (this._from = this._from ?? new JumpCloud.SDK.V2.Models.GraphObject()); set => this._from = value; }

        /// <summary>The graph object's attributes.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public JumpCloud.SDK.V2.Models.IGraphObjectAttributes FromAttributes { get => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)From).Attributes; set => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)From).Attributes = value; }

        /// <summary>The ObjectID of the graph object.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string FromId { get => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)From).Id; set => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)From).Id = value; }

        /// <summary>The type of graph object.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string FromType { get => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)From).Type; set => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)From).Type = value; }

        /// <summary>Internal Acessors for From</summary>
        JumpCloud.SDK.V2.Models.IGraphObject JumpCloud.SDK.V2.Models.IGraphConnectionInternal.From { get => (this._from = this._from ?? new JumpCloud.SDK.V2.Models.GraphObject()); set { {_from = value;} } }

        /// <summary>Internal Acessors for To</summary>
        JumpCloud.SDK.V2.Models.IGraphObject JumpCloud.SDK.V2.Models.IGraphConnectionInternal.To { get => (this._to = this._to ?? new JumpCloud.SDK.V2.Models.GraphObject()); set { {_to = value;} } }

        /// <summary>Backing field for <see cref="To" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IGraphObject _to;

        /// <summary>GraphObject</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IGraphObject To { get => (this._to = this._to ?? new JumpCloud.SDK.V2.Models.GraphObject()); set => this._to = value; }

        /// <summary>The graph object's attributes.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public JumpCloud.SDK.V2.Models.IGraphObjectAttributes ToAttributes { get => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)To).Attributes; set => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)To).Attributes = value; }

        /// <summary>The ObjectID of the graph object.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string ToId { get => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)To).Id; set => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)To).Id = value; }

        /// <summary>The type of graph object.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string ToType { get => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)To).Type; set => ((JumpCloud.SDK.V2.Models.IGraphObjectInternal)To).Type = value; }

        /// <summary>Creates an new <see cref="GraphConnection" /> instance.</summary>
        public GraphConnection()
        {

        }
    }
    /// Represents an edge between two graph objects. From can be omitted if it is clear from context.
    public partial interface IGraphConnection :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>The graph connection's attributes.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The graph connection's attributes.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IGraphConnectionAttributes) })]
        JumpCloud.SDK.V2.Models.IGraphConnectionAttributes Attributes { get; set; }
        /// <summary>The graph object's attributes.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The graph object's attributes.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IGraphObjectAttributes) })]
        JumpCloud.SDK.V2.Models.IGraphObjectAttributes FromAttributes { get; set; }
        /// <summary>The ObjectID of the graph object.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ObjectID of the graph object.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string FromId { get; set; }
        /// <summary>The type of graph object.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of graph object.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string FromType { get; set; }
        /// <summary>The graph object's attributes.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The graph object's attributes.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IGraphObjectAttributes) })]
        JumpCloud.SDK.V2.Models.IGraphObjectAttributes ToAttributes { get; set; }
        /// <summary>The ObjectID of the graph object.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ObjectID of the graph object.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ToId { get; set; }
        /// <summary>The type of graph object.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of graph object.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ToType { get; set; }

    }
    /// Represents an edge between two graph objects. From can be omitted if it is clear from context.
    internal partial interface IGraphConnectionInternal

    {
        /// <summary>The graph connection's attributes.</summary>
        JumpCloud.SDK.V2.Models.IGraphConnectionAttributes Attributes { get; set; }
        /// <summary>GraphObject</summary>
        JumpCloud.SDK.V2.Models.IGraphObject From { get; set; }
        /// <summary>The graph object's attributes.</summary>
        JumpCloud.SDK.V2.Models.IGraphObjectAttributes FromAttributes { get; set; }
        /// <summary>The ObjectID of the graph object.</summary>
        string FromId { get; set; }
        /// <summary>The type of graph object.</summary>
        string FromType { get; set; }
        /// <summary>GraphObject</summary>
        JumpCloud.SDK.V2.Models.IGraphObject To { get; set; }
        /// <summary>The graph object's attributes.</summary>
        JumpCloud.SDK.V2.Models.IGraphObjectAttributes ToAttributes { get; set; }
        /// <summary>The ObjectID of the graph object.</summary>
        string ToId { get; set; }
        /// <summary>The type of graph object.</summary>
        string ToType { get; set; }

    }
}