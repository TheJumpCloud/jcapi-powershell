// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6219, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>RadiusServersList</summary>
    public partial class Radiusserverslist :
        JumpCloud.SDK.V1.Models.IRadiusserverslist,
        JumpCloud.SDK.V1.Models.IRadiusserverslistInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IRadiusserver[] _results;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IRadiusserver[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Radiusserverslist" /> instance.</summary>
        public Radiusserverslist()
        {

        }
    }
    /// RadiusServersList
    public partial interface IRadiusserverslist :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IRadiusserver) })]
        JumpCloud.SDK.V1.Models.IRadiusserver[] Results { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
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
        JumpCloud.SDK.V1.Models.IRadiusserver[] Results { get; set; }

        int? TotalCount { get; set; }

    }
}