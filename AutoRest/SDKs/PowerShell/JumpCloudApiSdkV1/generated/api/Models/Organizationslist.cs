namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>OrganizationList</summary>
    public partial class Organizationslist :
        JumpCloudApiSdkV1.Models.IOrganizationslist,
        JumpCloudApiSdkV1.Models.IOrganizationslistInternal
    {

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IOrganizationslistResultsItem[] _results;

        /// <summary>The list of organizations.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IOrganizationslistResultsItem[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        /// <summary>The total number of organizations.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Organizationslist" /> instance.</summary>
        public Organizationslist()
        {

        }
    }
    /// OrganizationList
    public partial interface IOrganizationslist :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>The list of organizations.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of organizations.",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IOrganizationslistResultsItem) })]
        JumpCloudApiSdkV1.Models.IOrganizationslistResultsItem[] Results { get; set; }
        /// <summary>The total number of organizations.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of organizations. ",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    /// OrganizationList
    internal partial interface IOrganizationslistInternal

    {
        /// <summary>The list of organizations.</summary>
        JumpCloudApiSdkV1.Models.IOrganizationslistResultsItem[] Results { get; set; }
        /// <summary>The total number of organizations.</summary>
        int? TotalCount { get; set; }

    }
}