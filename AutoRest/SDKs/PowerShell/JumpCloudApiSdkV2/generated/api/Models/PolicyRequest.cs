namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>An instance of a policy template.</summary>
    public partial class PolicyRequest :
        JumpCloudApiSdkV2.Models.IPolicyRequest,
        JumpCloudApiSdkV2.Models.IPolicyRequestInternal
    {

        /// <summary>Internal Acessors for Template</summary>
        JumpCloudApiSdkV2.Models.IPolicyRequestTemplate JumpCloudApiSdkV2.Models.IPolicyRequestInternal.Template { get => (this._template = this._template ?? new JumpCloudApiSdkV2.Models.PolicyRequestTemplate()); set { {_template = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The description for this specific Policy.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IPolicyRequestTemplate _template;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IPolicyRequestTemplate Template { get => (this._template = this._template ?? new JumpCloudApiSdkV2.Models.PolicyRequestTemplate()); set => this._template = value; }

        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string TemplateId { get => ((JumpCloudApiSdkV2.Models.IPolicyRequestTemplateInternal)Template).Id; set => ((JumpCloudApiSdkV2.Models.IPolicyRequestTemplateInternal)Template).Id = value; }

        /// <summary>Backing field for <see cref="Values" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IPolicyValue[] _values;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IPolicyValue[] Values { get => this._values; set => this._values = value; }

        /// <summary>Creates an new <see cref="PolicyRequest" /> instance.</summary>
        public PolicyRequest()
        {

        }
    }
    /// An instance of a policy template.
    public partial interface IPolicyRequest :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The description for this specific Policy.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The description for this specific Policy.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a Policy instance; only allowed on POST requests.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"values",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IPolicyValue) })]
        JumpCloudApiSdkV2.Models.IPolicyValue[] Values { get; set; }

    }
    /// An instance of a policy template.
    internal partial interface IPolicyRequestInternal

    {
        /// <summary>The description for this specific Policy.</summary>
        string Name { get; set; }

        JumpCloudApiSdkV2.Models.IPolicyRequestTemplate Template { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        string TemplateId { get; set; }

        JumpCloudApiSdkV2.Models.IPolicyValue[] Values { get; set; }

    }
}