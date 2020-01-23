namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Patches</summary>
    public partial class SystemInsightsPatches :
        JumpCloud.SDK.V2.Models.ISystemInsightsPatches,
        JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal
    {

        /// <summary>Backing field for <see cref="Caption" /> property.</summary>
        private string _caption;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Caption { get => this._caption; set => this._caption = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Csname" /> property.</summary>
        private string _csname;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Csname { get => this._csname; set => this._csname = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="FixComments" /> property.</summary>
        private string _fixComments;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string FixComments { get => this._fixComments; set => this._fixComments = value; }

        /// <summary>Backing field for <see cref="HotfixId" /> property.</summary>
        private string _hotfixId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string HotfixId { get => this._hotfixId; set => this._hotfixId = value; }

        /// <summary>Backing field for <see cref="InstallDate" /> property.</summary>
        private string _installDate;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string InstallDate { get => this._installDate; set => this._installDate = value; }

        /// <summary>Backing field for <see cref="InstalledBy" /> property.</summary>
        private string _installedBy;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string InstalledBy { get => this._installedBy; set => this._installedBy = value; }

        /// <summary>Backing field for <see cref="InstalledOn" /> property.</summary>
        private string _installedOn;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string InstalledOn { get => this._installedOn; set => this._installedOn = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Creates an new <see cref="SystemInsightsPatches" /> instance.</summary>
        public SystemInsightsPatches()
        {

        }
    }
    /// System Insights Patches
    public partial interface ISystemInsightsPatches :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"caption",
        PossibleTypes = new [] { typeof(string) })]
        string Caption { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"collection_time",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionTime { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"csname",
        PossibleTypes = new [] { typeof(string) })]
        string Csname { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fix_comments",
        PossibleTypes = new [] { typeof(string) })]
        string FixComments { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hotfix_id",
        PossibleTypes = new [] { typeof(string) })]
        string HotfixId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"install_date",
        PossibleTypes = new [] { typeof(string) })]
        string InstallDate { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"installed_by",
        PossibleTypes = new [] { typeof(string) })]
        string InstalledBy { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"installed_on",
        PossibleTypes = new [] { typeof(string) })]
        string InstalledOn { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

    }
    /// System Insights Patches
    internal partial interface ISystemInsightsPatchesInternal

    {
        string Caption { get; set; }

        string CollectionTime { get; set; }

        string Csname { get; set; }

        string Description { get; set; }

        string FixComments { get; set; }

        string HotfixId { get; set; }

        string InstallDate { get; set; }

        string InstalledBy { get; set; }

        string InstalledOn { get; set; }

        string SystemId { get; set; }

    }
}