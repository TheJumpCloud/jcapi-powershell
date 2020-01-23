namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class BodyParameterSystemUserMfaResetRequestBody :
        JumpCloud.SDK.V1.Models.IBodyParameterSystemUserMfaResetRequestBody,
        JumpCloud.SDK.V1.Models.IBodyParameterSystemUserMfaResetRequestBodyInternal
    {

        /// <summary>Backing field for <see cref="Exclusion" /> property.</summary>
        private bool? _exclusion;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Exclusion { get => this._exclusion; set => this._exclusion = value; }

        /// <summary>Backing field for <see cref="ExclusionUntil" /> property.</summary>
        private global::System.DateTime? _exclusionUntil;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public global::System.DateTime? ExclusionUntil { get => this._exclusionUntil; set => this._exclusionUntil = value; }

        /// <summary>
        /// Creates an new <see cref="BodyParameterSystemUserMfaResetRequestBody" /> instance.
        /// </summary>
        public BodyParameterSystemUserMfaResetRequestBody()
        {

        }
    }
    public partial interface IBodyParameterSystemUserMfaResetRequestBody :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Exclusion { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusionUntil",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExclusionUntil { get; set; }

    }
    internal partial interface IBodyParameterSystemUserMfaResetRequestBodyInternal

    {
        bool? Exclusion { get; set; }

        global::System.DateTime? ExclusionUntil { get; set; }

    }
}