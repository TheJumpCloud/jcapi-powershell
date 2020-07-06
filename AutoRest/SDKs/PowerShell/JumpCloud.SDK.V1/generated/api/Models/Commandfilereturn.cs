// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>CommandFileReturn</summary>
    public partial class Commandfilereturn :
        JumpCloud.SDK.V1.Models.ICommandfilereturn,
        JumpCloud.SDK.V1.Models.ICommandfilereturnInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ICommandfilereturnResultsItem[] _results;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.ICommandfilereturnResultsItem[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        /// <summary>The total number of commands files</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Commandfilereturn" /> instance.</summary>
        public Commandfilereturn()
        {

        }
    }
    /// CommandFileReturn
    public partial interface ICommandfilereturn :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ICommandfilereturnResultsItem) })]
        JumpCloud.SDK.V1.Models.ICommandfilereturnResultsItem[] Results { get; set; }
        /// <summary>The total number of commands files</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of commands files",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    /// CommandFileReturn
    internal partial interface ICommandfilereturnInternal

    {
        JumpCloud.SDK.V1.Models.ICommandfilereturnResultsItem[] Results { get; set; }
        /// <summary>The total number of commands files</summary>
        int? TotalCount { get; set; }

    }
}