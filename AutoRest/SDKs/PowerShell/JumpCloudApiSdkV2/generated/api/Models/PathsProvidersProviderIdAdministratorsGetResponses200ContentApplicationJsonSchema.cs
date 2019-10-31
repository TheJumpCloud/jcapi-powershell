namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class PathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema :
        JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema,
        JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IAdministrator[] _results;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IAdministrator[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>
        /// Creates an new <see cref="PathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema" /> instance.
        /// </summary>
        public PathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IAdministrator) })]
        JumpCloudApiSdkV2.Models.IAdministrator[] Results { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    internal partial interface IPathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchemaInternal

    {
        JumpCloudApiSdkV2.Models.IAdministrator[] Results { get; set; }

        int? TotalCount { get; set; }

    }
}