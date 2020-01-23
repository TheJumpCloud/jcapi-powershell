namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>CommandResultsList</summary>
    public partial class Commandresultslist :
        JumpCloud.SDK.V1.Models.ICommandresultslist,
        JumpCloud.SDK.V1.Models.ICommandresultslistInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ICommandresult[] _results;

        /// <summary>The list of command results</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.ICommandresult[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        /// <summary>The total number of command results</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Commandresultslist" /> instance.</summary>
        public Commandresultslist()
        {

        }
    }
    /// CommandResultsList
    public partial interface ICommandresultslist :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        /// <summary>The list of command results</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of command results",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ICommandresult) })]
        JumpCloud.SDK.V1.Models.ICommandresult[] Results { get; set; }
        /// <summary>The total number of command results</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of command results",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    /// CommandResultsList
    internal partial interface ICommandresultslistInternal

    {
        /// <summary>The list of command results</summary>
        JumpCloud.SDK.V1.Models.ICommandresult[] Results { get; set; }
        /// <summary>The total number of command results</summary>
        int? TotalCount { get; set; }

    }
}