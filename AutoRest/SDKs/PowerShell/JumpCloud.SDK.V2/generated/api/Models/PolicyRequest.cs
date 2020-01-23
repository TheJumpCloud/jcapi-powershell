namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>An instance of a policy template.</summary>
    public partial class PolicyRequest :
        JumpCloud.SDK.V2.Models.IPolicyRequest,
        JumpCloud.SDK.V2.Models.IPolicyRequestInternal
    {

        /// <summary>Internal Acessors for Template</summary>
        JumpCloud.SDK.V2.Models.IPolicyRequestTemplate JumpCloud.SDK.V2.Models.IPolicyRequestInternal.Template { get => (this._template = this._template ?? new JumpCloud.SDK.V2.Models.PolicyRequestTemplate()); set { {_template = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The description for this specific Policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IPolicyRequestTemplate _template;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IPolicyRequestTemplate Template { get => (this._template = this._template ?? new JumpCloud.SDK.V2.Models.PolicyRequestTemplate()); set => this._template = value; }

        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string TemplateId { get => ((JumpCloud.SDK.V2.Models.IPolicyRequestTemplateInternal)Template).Id; set => ((JumpCloud.SDK.V2.Models.IPolicyRequestTemplateInternal)Template).Id = value; }

        /// <summary>Backing field for <see cref="Values" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IPolicyValue[] _values;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V2.Models.IPolicyValue[] Values { get => this._values; set => this._values = value; }

        /// <summary>Creates an new <see cref="PolicyRequest" /> instance.</summary>
        public PolicyRequest()
        {

        }
    }
    /// An instance of a policy template.
    public partial interface IPolicyRequest :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>The description for this specific Policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The description for this specific Policy.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a Policy instance; only allowed on POST requests.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"values",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IPolicyValue) })]
        JumpCloud.SDK.V2.Models.IPolicyValue[] Values { get; set; }

    }
    /// An instance of a policy template.
    internal partial interface IPolicyRequestInternal

    {
        /// <summary>The description for this specific Policy.</summary>
        string Name { get; set; }

        JumpCloud.SDK.V2.Models.IPolicyRequestTemplate Template { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        string TemplateId { get; set; }

        JumpCloud.SDK.V2.Models.IPolicyValue[] Values { get; set; }

    }
}