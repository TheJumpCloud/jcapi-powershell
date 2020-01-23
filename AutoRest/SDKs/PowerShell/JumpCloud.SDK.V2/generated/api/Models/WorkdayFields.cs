namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Workday Fields</summary>
    public partial class WorkdayFields :
        JumpCloud.SDK.V2.Models.IWorkdayFields,
        JumpCloud.SDK.V2.Models.IWorkdayFieldsInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ReportUrl" /> property.</summary>
        private string _reportUrl;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string ReportUrl { get => this._reportUrl; set => this._reportUrl = value; }

        /// <summary>Creates an new <see cref="WorkdayFields" /> instance.</summary>
        public WorkdayFields()
        {

        }
    }
    /// Workday Fields
    public partial interface IWorkdayFields :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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