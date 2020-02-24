// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationtemplateJit :
        JumpCloud.SDK.V1.Models.IApplicationtemplateJit,
        JumpCloud.SDK.V1.Models.IApplicationtemplateJitInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes _attributes;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateJitAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="CreateOnly" /> property.</summary>
        private bool? _createOnly;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? CreateOnly { get => this._createOnly; set => this._createOnly = value; }

        /// <summary>Creates an new <see cref="ApplicationtemplateJit" /> instance.</summary>
        public ApplicationtemplateJit()
        {

        }
    }
    public partial interface IApplicationtemplateJit :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes) })]
        JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes Attributes { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"createOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CreateOnly { get; set; }

    }
    internal partial interface IApplicationtemplateJitInternal

    {
        JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes Attributes { get; set; }

        bool? CreateOnly { get; set; }

    }
}