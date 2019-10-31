namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class BodyParameterResetSystemUserMfaRequestBody :
        JumpCloudApiSdkV1.Models.IBodyParameterResetSystemUserMfaRequestBody,
        JumpCloudApiSdkV1.Models.IBodyParameterResetSystemUserMfaRequestBodyInternal
    {

        /// <summary>Backing field for <see cref="Exclusion" /> property.</summary>
        private bool? _exclusion;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Exclusion { get => this._exclusion; set => this._exclusion = value; }

        /// <summary>Backing field for <see cref="ExclusionUntil" /> property.</summary>
        private global::System.DateTime? _exclusionUntil;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public global::System.DateTime? ExclusionUntil { get => this._exclusionUntil; set => this._exclusionUntil = value; }

        /// <summary>
        /// Creates an new <see cref="BodyParameterResetSystemUserMfaRequestBody" /> instance.
        /// </summary>
        public BodyParameterResetSystemUserMfaRequestBody()
        {

        }
    }
    public partial interface IBodyParameterResetSystemUserMfaRequestBody :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Exclusion { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusionUntil",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExclusionUntil { get; set; }

    }
    internal partial interface IBodyParameterResetSystemUserMfaRequestBodyInternal

    {
        bool? Exclusion { get; set; }

        global::System.DateTime? ExclusionUntil { get; set; }

    }
}