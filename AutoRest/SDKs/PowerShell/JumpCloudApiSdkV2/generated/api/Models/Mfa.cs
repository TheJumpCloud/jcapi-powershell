namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>mfa</summary>
    public partial class Mfa :
        JumpCloudApiSdkV2.Models.IMfa,
        JumpCloudApiSdkV2.Models.IMfaInternal
    {

        /// <summary>Backing field for <see cref="Configured" /> property.</summary>
        private bool? _configured;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? Configured { get => this._configured; set => this._configured = value; }

        /// <summary>Backing field for <see cref="Exclusion" /> property.</summary>
        private bool? _exclusion;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? Exclusion { get => this._exclusion; set => this._exclusion = value; }

        /// <summary>Backing field for <see cref="ExclusionUntil" /> property.</summary>
        private global::System.DateTime? _exclusionUntil;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public global::System.DateTime? ExclusionUntil { get => this._exclusionUntil; set => this._exclusionUntil = value; }

        /// <summary>Creates an new <see cref="Mfa" /> instance.</summary>
        public Mfa()
        {

        }
    }
    /// mfa
    public partial interface IMfa :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"configured",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Configured { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Exclusion { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusionUntil",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExclusionUntil { get; set; }

    }
    /// mfa
    internal partial interface IMfaInternal

    {
        bool? Configured { get; set; }

        bool? Exclusion { get; set; }

        global::System.DateTime? ExclusionUntil { get; set; }

    }
}