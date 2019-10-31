namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Workday Fields</summary>
    public partial class WorkdayFields :
        JumpCloudApiSdkV2.Models.IWorkdayFields,
        JumpCloudApiSdkV2.Models.IWorkdayFieldsInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ReportUrl" /> property.</summary>
        private string _reportUrl;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ReportUrl { get => this._reportUrl; set => this._reportUrl = value; }

        /// <summary>Creates an new <see cref="WorkdayFields" /> instance.</summary>
        public WorkdayFields()
        {

        }
    }
    /// Workday Fields
    public partial interface IWorkdayFields :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"reportUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ReportUrl { get; set; }

    }
    /// Workday Fields
    internal partial interface IWorkdayFieldsInternal

    {
        string Name { get; set; }

        string ReportUrl { get; set; }

    }
}