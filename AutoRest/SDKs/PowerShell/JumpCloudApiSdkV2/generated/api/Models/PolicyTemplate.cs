namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>The shallow information about a Policy Template.</summary>
    public partial class PolicyTemplate :
        JumpCloudApiSdkV2.Models.IPolicyTemplate,
        JumpCloudApiSdkV2.Models.IPolicyTemplateInternal
    {

        /// <summary>Backing field for <see cref="Activation" /> property.</summary>
        private string _activation;

        /// <summary>Requirements before the policy can be activated.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Activation { get => this._activation; set => this._activation = value; }

        /// <summary>Backing field for <see cref="Behavior" /> property.</summary>
        private string _behavior;

        /// <summary>Specifics about the behavior of the policy.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Behavior { get => this._behavior; set => this._behavior = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The default description for the Policy.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The default display name for the Policy.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectId uniquely identifying a Policy Template.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The unique name for the Policy Template.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="OSMetaFamily" /> property.</summary>
        private string _oSMetaFamily;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string OSMetaFamily { get => this._oSMetaFamily; set => this._oSMetaFamily = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>String describing the release status of the policy template.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="PolicyTemplate" /> instance.</summary>
        public PolicyTemplate()
        {

        }
    }
    /// The shallow information about a Policy Template.
    public partial interface IPolicyTemplate :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>Requirements before the policy can be activated.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Requirements before the policy can be activated.",
        SerializedName = @"activation",
        PossibleTypes = new [] { typeof(string) })]
        string Activation { get; set; }
        /// <summary>Specifics about the behavior of the policy.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifics about the behavior of the policy.",
        SerializedName = @"behavior",
        PossibleTypes = new [] { typeof(string) })]
        string Behavior { get; set; }
        /// <summary>The default description for the Policy.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default description for the Policy.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The default display name for the Policy.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default display name for the Policy.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy Template.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a Policy Template.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The unique name for the Policy Template.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique name for the Policy Template.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"osMetaFamily",
        PossibleTypes = new [] { typeof(string) })]
        string OSMetaFamily { get; set; }
        /// <summary>String describing the release status of the policy template.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"String describing the release status of the policy template.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }

    }
    /// The shallow information about a Policy Template.
    internal partial interface IPolicyTemplateInternal

    {
        /// <summary>Requirements before the policy can be activated.</summary>
        string Activation { get; set; }
        /// <summary>Specifics about the behavior of the policy.</summary>
        string Behavior { get; set; }
        /// <summary>The default description for the Policy.</summary>
        string Description { get; set; }
        /// <summary>The default display name for the Policy.</summary>
        string DisplayName { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy Template.</summary>
        string Id { get; set; }
        /// <summary>The unique name for the Policy Template.</summary>
        string Name { get; set; }

        string OSMetaFamily { get; set; }
        /// <summary>String describing the release status of the policy template.</summary>
        string State { get; set; }

    }
}