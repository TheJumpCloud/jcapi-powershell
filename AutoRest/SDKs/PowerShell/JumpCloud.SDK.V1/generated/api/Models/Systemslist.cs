namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>SystemsList</summary>
    public partial class Systemslist :
        JumpCloud.SDK.V1.Models.ISystemslist,
        JumpCloud.SDK.V1.Models.ISystemslistInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IJcSystem[] _results;

        /// <summary>The list of systems.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IJcSystem[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        /// <summary>The total number of systems.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Systemslist" /> instance.</summary>
        public Systemslist()
        {

        }
    }
    /// SystemsList
    public partial interface ISystemslist :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        /// <summary>The list of systems.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of systems.",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IJcSystem) })]
        JumpCloud.SDK.V1.Models.IJcSystem[] Results { get; set; }
        /// <summary>The total number of systems.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of systems.",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    /// SystemsList
    internal partial interface ISystemslistInternal

    {
        /// <summary>The list of systems.</summary>
        JumpCloud.SDK.V1.Models.IJcSystem[] Results { get; set; }
        /// <summary>The total number of systems.</summary>
        int? TotalCount { get; set; }

    }
}