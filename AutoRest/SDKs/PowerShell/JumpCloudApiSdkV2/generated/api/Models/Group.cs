namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Group</summary>
    public partial class Group :
        JumpCloudApiSdkV2.Models.IGroup,
        JumpCloudApiSdkV2.Models.IGroupInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IGroupAttributes _attributes;

        /// <summary>The group object's attributes.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IGroupAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.GroupAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectId uniquely identifying a Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Display name of a Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The group type.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="Group" /> instance.</summary>
        public Group()
        {

        }
    }
    /// Group
    public partial interface IGroup :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The group object's attributes.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group object's attributes.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IGroupAttributes) })]
        JumpCloudApiSdkV2.Models.IGroupAttributes Attributes { get; set; }
        /// <summary>ObjectId uniquely identifying a Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a Group.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Display name of a Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of a Group.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The group type.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Group
    internal partial interface IGroupInternal

    {
        /// <summary>The group object's attributes.</summary>
        JumpCloudApiSdkV2.Models.IGroupAttributes Attributes { get; set; }
        /// <summary>ObjectId uniquely identifying a Group.</summary>
        string Id { get; set; }
        /// <summary>Display name of a Group.</summary>
        string Name { get; set; }
        /// <summary>The group type.</summary>
        string Type { get; set; }

    }
}