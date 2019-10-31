namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>ApplicationTemplatesList</summary>
    public partial class Applicationtemplateslist :
        JumpCloudApiSdkV1.Models.IApplicationtemplateslist,
        JumpCloudApiSdkV1.Models.IApplicationtemplateslistInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplicationtemplate[] _results;

        /// <summary>The list of applications.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IApplicationtemplate[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        /// <summary>The total number of applications.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Applicationtemplateslist" /> instance.</summary>
        public Applicationtemplateslist()
        {

        }
    }
    /// ApplicationTemplatesList
    public partial interface IApplicationtemplateslist :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>The list of applications.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of applications.",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IApplicationtemplate) })]
        JumpCloudApiSdkV1.Models.IApplicationtemplate[] Results { get; set; }
        /// <summary>The total number of applications.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of applications.",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    /// ApplicationTemplatesList
    internal partial interface IApplicationtemplateslistInternal

    {
        /// <summary>The list of applications.</summary>
        JumpCloudApiSdkV1.Models.IApplicationtemplate[] Results { get; set; }
        /// <summary>The total number of applications.</summary>
        int? TotalCount { get; set; }

    }
}