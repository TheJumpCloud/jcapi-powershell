namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>ApplicationsList</summary>
    public partial class Applicationslist :
        JumpCloudApiSdkV1.Models.IApplicationslist,
        JumpCloudApiSdkV1.Models.IApplicationslistInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplication[] _results;

        /// <summary>The list of applications.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IApplication[] Results { get => this._results; set => this._results = value; }

        /// <summary>Backing field for <see cref="TotalCount" /> property.</summary>
        private int? _totalCount;

        /// <summary>The total number of applications.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? TotalCount { get => this._totalCount; set => this._totalCount = value; }

        /// <summary>Creates an new <see cref="Applicationslist" /> instance.</summary>
        public Applicationslist()
        {

        }
    }
    /// ApplicationsList
    public partial interface IApplicationslist :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The list of applications.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of applications.",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IApplication) })]
        JumpCloudApiSdkV1.Models.IApplication[] Results { get; set; }
        /// <summary>The total number of applications.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of applications.",
        SerializedName = @"totalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCount { get; set; }

    }
    /// ApplicationsList
    internal partial interface IApplicationslistInternal

    {
        string Name { get; set; }
        /// <summary>The list of applications.</summary>
        JumpCloudApiSdkV1.Models.IApplication[] Results { get; set; }
        /// <summary>The total number of applications.</summary>
        int? TotalCount { get; set; }

    }
}