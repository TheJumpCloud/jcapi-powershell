// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PathsYwlyndProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema :
        JumpCloud.SDK.V2.Models.IPathsYwlyndProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema,
        JumpCloud.SDK.V2.Models.IPathsYwlyndProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchemaInternal
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
        /// Creates an new <see cref="PathsYwlyndProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema" />
        /// instance.
        /// </summary>
        public PathsYwlyndProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsYwlyndProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema :
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
    internal partial interface IPathsYwlyndProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchemaInternal

    {
        JumpCloud.SDK.V2.Models.IAdministrator[] Results { get; set; }

        int? TotalCount { get; set; }

    }
}