namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema :
        JumpCloud.SDK.V2.Models.IPathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema,
        JumpCloud.SDK.V2.Models.IPathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IAdministrator[] _results;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V2.Models.IAdministrator[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>
        /// Creates an new <see cref="PathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema" /> instance.
        /// </summary>
        public PathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IAdministrator) })]
        JumpCloud.SDK.V2.Models.IAdministrator[] Results { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    internal partial interface IPathsProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchemaInternal

    {
        JumpCloud.SDK.V2.Models.IAdministrator[] Results { get; set; }

        int? TotalCount { get; set; }

    }
}