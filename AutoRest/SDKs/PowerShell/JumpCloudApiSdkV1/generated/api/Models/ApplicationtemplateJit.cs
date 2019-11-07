namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class ApplicationtemplateJit :
        JumpCloudApiSdkV1.Models.IApplicationtemplateJit,
        JumpCloudApiSdkV1.Models.IApplicationtemplateJitInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplicationtemplateJitAttributes _attributes;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IApplicationtemplateJitAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateJitAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="CreateOnly" /> property.</summary>
        private bool? _createOnly;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? CreateOnly { get => this._createOnly; set => this._createOnly = value; }

        /// <summary>Creates an new <see cref="ApplicationtemplateJit" /> instance.</summary>
        public ApplicationtemplateJit()
        {

        }
    }
    public partial interface IApplicationtemplateJit :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IApplicationtemplateJitAttributes) })]
        JumpCloudApiSdkV1.Models.IApplicationtemplateJitAttributes Attributes { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"createOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CreateOnly { get; set; }

    }
    internal partial interface IApplicationtemplateJitInternal

    {
        JumpCloudApiSdkV1.Models.IApplicationtemplateJitAttributes Attributes { get; set; }

        bool? CreateOnly { get; set; }

    }
}