namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>Search</summary>
    public partial class Search :
        JumpCloudApiSdkV1.Models.ISearch,
        JumpCloudApiSdkV1.Models.ISearchInternal
    {

        /// <summary>Backing field for <see cref="Fields" /> property.</summary>
        private string _fields;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Fields { get => this._fields; set => this._fields = value; }

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISearchFilter _filter;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISearchFilter Filter { get => (this._filter = this._filter ?? new JumpCloudApiSdkV1.Models.SearchFilter()); set => this._filter = value; }

        /// <summary>Backing field for <see cref="SearchFilter" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISearchFilter1 _searchFilter;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISearchFilter1 SearchFilter { get => (this._searchFilter = this._searchFilter ?? new JumpCloudApiSdkV1.Models.SearchFilter1()); set => this._searchFilter = value; }

        /// <summary>Creates an new <see cref="Search" /> instance.</summary>
        public Search()
        {

        }
    }
    /// Search
    public partial interface ISearch :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fields",
        PossibleTypes = new [] { typeof(string) })]
        string Fields { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"filter",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISearchFilter) })]
        JumpCloudApiSdkV1.Models.ISearchFilter Filter { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"searchFilter",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISearchFilter1) })]
        JumpCloudApiSdkV1.Models.ISearchFilter1 SearchFilter { get; set; }

    }
    /// Search
    internal partial interface ISearchInternal

    {
        string Fields { get; set; }

        JumpCloudApiSdkV1.Models.ISearchFilter Filter { get; set; }

        JumpCloudApiSdkV1.Models.ISearchFilter1 SearchFilter { get; set; }

    }
}