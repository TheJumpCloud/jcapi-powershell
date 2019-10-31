namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>TagsList</summary>
    public partial class Tagslist :
        JumpCloudApiSdkV1.Models.ITagslist,
        JumpCloudApiSdkV1.Models.ITagslistInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ITag[] _results;

        /// <summary>The list of tags.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ITag[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        /// <summary>The total number of tags.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Tagslist" /> instance.</summary>
        public Tagslist()
        {

        }
    }
    /// TagsList
    public partial interface ITagslist :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>The list of tags.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of tags.",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ITag) })]
        JumpCloudApiSdkV1.Models.ITag[] Results { get; set; }
        /// <summary>The total number of tags.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of tags.",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    /// TagsList
    internal partial interface ITagslistInternal

    {
        /// <summary>The list of tags.</summary>
        JumpCloudApiSdkV1.Models.ITag[] Results { get; set; }
        /// <summary>The total number of tags.</summary>
        int? TotalCount { get; set; }

    }
}