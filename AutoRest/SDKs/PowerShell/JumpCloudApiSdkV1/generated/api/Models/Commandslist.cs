namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>CommandsList</summary>
    public partial class Commandslist :
        JumpCloudApiSdkV1.Models.ICommandslist,
        JumpCloudApiSdkV1.Models.ICommandslistInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ICommandslistResultsItem[] _results;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ICommandslistResultsItem[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        /// <summary>The total number of commands</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Commandslist" /> instance.</summary>
        public Commandslist()
        {

        }
    }
    /// CommandsList
    public partial interface ICommandslist :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ICommandslistResultsItem) })]
        JumpCloudApiSdkV1.Models.ICommandslistResultsItem[] Results { get; set; }
        /// <summary>The total number of commands</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
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
        JumpCloudApiSdkV1.Models.ICommandslistResultsItem[] Results { get; set; }
        /// <summary>The total number of commands</summary>
        int? TotalCount { get; set; }

    }
}