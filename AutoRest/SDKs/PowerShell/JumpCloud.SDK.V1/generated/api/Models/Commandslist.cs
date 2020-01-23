namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>CommandsList</summary>
    public partial class Commandslist :
        JumpCloud.SDK.V1.Models.ICommandslist,
        JumpCloud.SDK.V1.Models.ICommandslistInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ICommandslistResultsItem[] _results;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.ICommandslistResultsItem[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        /// <summary>The total number of commands</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Commandslist" /> instance.</summary>
        public Commandslist()
        {

        }
    }
    /// CommandsList
    public partial interface ICommandslist :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ICommandslistResultsItem) })]
        JumpCloud.SDK.V1.Models.ICommandslistResultsItem[] Results { get; set; }
        /// <summary>The total number of commands</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of commands",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    /// CommandsList
    internal partial interface ICommandslistInternal

    {
        JumpCloud.SDK.V1.Models.ICommandslistResultsItem[] Results { get; set; }
        /// <summary>The total number of commands</summary>
        int? TotalCount { get; set; }

    }
}