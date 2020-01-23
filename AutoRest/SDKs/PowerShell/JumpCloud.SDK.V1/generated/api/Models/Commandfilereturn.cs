namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>CommandFileReturn</summary>
    public partial class Commandfilereturn :
        JumpCloud.SDK.V1.Models.ICommandfilereturn,
        JumpCloud.SDK.V1.Models.ICommandfilereturnInternal
    {

        /// <summary>Internal Acessors for Results</summary>
        JumpCloud.SDK.V1.Models.ICommandfilereturnResults JumpCloud.SDK.V1.Models.ICommandfilereturnInternal.Results { get => (this._results = this._results ?? new JumpCloud.SDK.V1.Models.CommandfilereturnResults()); set { {_results = value;} } }

        /// <summary>The location where the file will be stored.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ResultDestination { get => ((JumpCloud.SDK.V1.Models.ICommandfilereturnResultsInternal)Results).Destination; set => ((JumpCloud.SDK.V1.Models.ICommandfilereturnResultsInternal)Results).Destination = value; }

        /// <summary>The ID of the file.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ResultId { get => ((JumpCloud.SDK.V1.Models.ICommandfilereturnResultsInternal)Results).Id; set => ((JumpCloud.SDK.V1.Models.ICommandfilereturnResultsInternal)Results).Id = value; }

        /// <summary>The file name.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ResultName { get => ((JumpCloud.SDK.V1.Models.ICommandfilereturnResultsInternal)Results).Name; set => ((JumpCloud.SDK.V1.Models.ICommandfilereturnResultsInternal)Results).Name = value; }

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ICommandfilereturnResults _results;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.ICommandfilereturnResults Results { get => (this._results = this._results ?? new JumpCloud.SDK.V1.Models.CommandfilereturnResults()); set => this._results = value; }

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
        /// <summary>The location where the file will be stored.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location where the file will be stored.",
        SerializedName = @"destination",
        PossibleTypes = new [] { typeof(string) })]
        string ResultDestination { get; set; }
        /// <summary>The ID of the file.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the file.",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string ResultId { get; set; }
        /// <summary>The file name.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The file name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ResultName { get; set; }
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
        /// <summary>The location where the file will be stored.</summary>
        string ResultDestination { get; set; }
        /// <summary>The ID of the file.</summary>
        string ResultId { get; set; }
        /// <summary>The file name.</summary>
        string ResultName { get; set; }

        JumpCloud.SDK.V1.Models.ICommandfilereturnResults Results { get; set; }
        /// <summary>The total number of commands files</summary>
        int? TotalCount { get; set; }

    }
}