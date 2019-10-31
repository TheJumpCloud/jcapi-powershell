namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>RadiusServersList</summary>
    public partial class Radiusserverslist :
        JumpCloudApiSdkV1.Models.IRadiusserverslist,
        JumpCloudApiSdkV1.Models.IRadiusserverslistInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IRadiusserver[] _results;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IRadiusserver[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Radiusserverslist" /> instance.</summary>
        public Radiusserverslist()
        {

        }
    }
    /// RadiusServersList
    public partial interface IRadiusserverslist :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IRadiusserver) })]
        JumpCloudApiSdkV1.Models.IRadiusserver[] Results { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    /// RadiusServersList
    internal partial interface IRadiusserverslistInternal

    {
        JumpCloudApiSdkV1.Models.IRadiusserver[] Results { get; set; }

        int? TotalCount { get; set; }

    }
}