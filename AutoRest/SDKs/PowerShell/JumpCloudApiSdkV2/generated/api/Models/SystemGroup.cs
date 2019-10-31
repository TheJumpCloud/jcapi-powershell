namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>SystemGroup</summary>
    public partial class SystemGroup :
        JumpCloudApiSdkV2.Models.ISystemGroup,
        JumpCloudApiSdkV2.Models.ISystemGroupInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV2.Models.ISystemGroupAttributes _attributes;

        /// <summary>The group object's attributes.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.ISystemGroupAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.SystemGroupAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectId uniquely identifying a System Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Display name of a System Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the group; always 'system' for a System Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemGroup" /> instance.</summary>
        public SystemGroup()
        {

        }
    }
    /// SystemGroup
    public partial interface ISystemGroup :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The group object's attributes.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group object's attributes.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.ISystemGroupAttributes) })]
        JumpCloudApiSdkV2.Models.ISystemGroupAttributes Attributes { get; set; }
        /// <summary>ObjectId uniquely identifying a System Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a System Group.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Display name of a System Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of a System Group.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The type of the group; always 'system' for a System Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the group; always 'system' for a System Group.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// SystemGroup
    internal partial interface ISystemGroupInternal

    {
        /// <summary>The group object's attributes.</summary>
        JumpCloudApiSdkV2.Models.ISystemGroupAttributes Attributes { get; set; }
        /// <summary>ObjectId uniquely identifying a System Group.</summary>
        string Id { get; set; }
        /// <summary>Display name of a System Group.</summary>
        string Name { get; set; }
        /// <summary>The type of the group; always 'system' for a System Group.</summary>
        string Type { get; set; }

    }
}