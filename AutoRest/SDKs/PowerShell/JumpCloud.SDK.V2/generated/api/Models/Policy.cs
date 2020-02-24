// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>An instance of a policy template.</summary>
    public partial class Policy :
        JumpCloud.SDK.V2.Models.IPolicy,
        JumpCloud.SDK.V2.Models.IPolicyInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectId uniquely identifying a Policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Template</summary>
        JumpCloud.SDK.V2.Models.IPolicyTemplate JumpCloud.SDK.V2.Models.IPolicyInternal.Template { get => (this._template = this._template ?? new JumpCloud.SDK.V2.Models.PolicyTemplate()); set { {_template = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The description for this specific Policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IPolicyTemplate _template;

        /// <summary>The shallow information about a Policy Template.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IPolicyTemplate Template { get => (this._template = this._template ?? new JumpCloud.SDK.V2.Models.PolicyTemplate()); set => this._template = value; }

        /// <summary>Requirements before the policy can be activated.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string TemplateActivation { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Activation; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Activation = value; }

        /// <summary>Specifics about the behavior of the policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string TemplateBehavior { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Behavior; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Behavior = value; }

        /// <summary>The default description for the Policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string TemplateDescription { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Description; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Description = value; }

        /// <summary>The default display name for the Policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string TemplateDisplayName { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).DisplayName; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).DisplayName = value; }

        /// <summary>ObjectId uniquely identifying a Policy Template.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string TemplateId { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Id; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Id = value; }

        /// <summary>The unique name for the Policy Template.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string TemplateName { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Name; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).Name = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string TemplateOSMetaFamily { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).OSMetaFamily; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).OSMetaFamily = value; }

        /// <summary>String describing the release status of the policy template.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string TemplateState { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).State; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateInternal)Template).State = value; }

        /// <summary>Creates an new <see cref="Policy" /> instance.</summary>
        public Policy()
        {

        }
    }
    /// An instance of a policy template.
    public partial interface IPolicy :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>ObjectId uniquely identifying a Policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a Policy.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The description for this specific Policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description for this specific Policy.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Requirements before the policy can be activated.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Requirements before the policy can be activated.",
        SerializedName = @"activation",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateActivation { get; set; }
        /// <summary>Specifics about the behavior of the policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifics about the behavior of the policy.",
        SerializedName = @"behavior",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateBehavior { get; set; }
        /// <summary>The default description for the Policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default description for the Policy.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateDescription { get; set; }
        /// <summary>The default display name for the Policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default display name for the Policy.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateDisplayName { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy Template.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a Policy Template.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateId { get; set; }
        /// <summary>The unique name for the Policy Template.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique name for the Policy Template.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"osMetaFamily",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateOSMetaFamily { get; set; }
        /// <summary>String describing the release status of the policy template.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"String describing the release status of the policy template.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateState { get; set; }

    }
    /// An instance of a policy template.
    internal partial interface IPolicyInternal

    {
        /// <summary>ObjectId uniquely identifying a Policy.</summary>
        string Id { get; set; }
        /// <summary>The description for this specific Policy.</summary>
        string Name { get; set; }
        /// <summary>The shallow information about a Policy Template.</summary>
        JumpCloud.SDK.V2.Models.IPolicyTemplate Template { get; set; }
        /// <summary>Requirements before the policy can be activated.</summary>
        string TemplateActivation { get; set; }
        /// <summary>Specifics about the behavior of the policy.</summary>
        string TemplateBehavior { get; set; }
        /// <summary>The default description for the Policy.</summary>
        string TemplateDescription { get; set; }
        /// <summary>The default display name for the Policy.</summary>
        string TemplateDisplayName { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy Template.</summary>
        string TemplateId { get; set; }
        /// <summary>The unique name for the Policy Template.</summary>
        string TemplateName { get; set; }

        string TemplateOSMetaFamily { get; set; }
        /// <summary>String describing the release status of the policy template.</summary>
        string TemplateState { get; set; }

    }
}