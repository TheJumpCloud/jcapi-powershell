// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.DirectoryInsights.Models
{
    using static JumpCloud.SDK.DirectoryInsights.Runtime.Extensions;

    /// <summary>
    /// list of event terms. If any term matches, the event will be returned by the service.
    /// </summary>
    public partial class SearchTermOr :
        JumpCloud.SDK.DirectoryInsights.Models.ISearchTermOr,
        JumpCloud.SDK.DirectoryInsights.Models.ISearchTermOrInternal
    {

        /// <summary>Creates an new <see cref="SearchTermOr" /> instance.</summary>
        public SearchTermOr()
        {

        }
    }
    /// list of event terms. If any term matches, the event will be returned by the service.
    public partial interface ISearchTermOr :
        JumpCloud.SDK.DirectoryInsights.Runtime.IJsonSerializable,
        JumpCloud.SDK.DirectoryInsights.Runtime.IAssociativeArray<global::System.Object>
    {

    }
    /// list of event terms. If any term matches, the event will be returned by the service.
    internal partial interface ISearchTermOrInternal

    {

    }
}