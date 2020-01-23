namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>Search</summary>
    public partial class Search :
        JumpCloud.SDK.V1.Models.ISearch,
        JumpCloud.SDK.V1.Models.ISearchInternal
    {

        /// <summary>Backing field for <see cref="Fields" /> property.</summary>
        private string _fields;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Fields { get => this._fields; set => this._fields = value; }

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ISearchFilter _filter;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.ISearchFilter Filter { get => (this._filter = this._filter ?? new JumpCloud.SDK.V1.Models.SearchFilter()); set => this._filter = value; }

        /// <summary>Backing field for <see cref="SearchFilter" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ISearchFilter1 _searchFilter;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.ISearchFilter1 SearchFilter { get => (this._searchFilter = this._searchFilter ?? new JumpCloud.SDK.V1.Models.SearchFilter1()); set => this._searchFilter = value; }

        /// <summary>Creates an new <see cref="Search" /> instance.</summary>
        public Search()
        {

        }
    }
    /// Search
    public partial interface ISearch :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fields",
        PossibleTypes = new [] { typeof(string) })]
        string Fields { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"filter",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ISearchFilter) })]
        JumpCloud.SDK.V1.Models.ISearchFilter Filter { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"searchFilter",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ISearchFilter1) })]
        JumpCloud.SDK.V1.Models.ISearchFilter1 SearchFilter { get; set; }

    }
    /// Search
    internal partial interface ISearchInternal

    {
        string Fields { get; set; }

        JumpCloud.SDK.V1.Models.ISearchFilter Filter { get; set; }

        JumpCloud.SDK.V1.Models.ISearchFilter1 SearchFilter { get; set; }

    }
}