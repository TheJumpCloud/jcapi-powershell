namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Uptime</summary>
    public partial class SystemInsightsUptime :
        JumpCloud.SDK.V2.Models.ISystemInsightsUptime,
        JumpCloud.SDK.V2.Models.ISystemInsightsUptimeInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Days" /> property.</summary>
        private int? _days;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? Days { get => this._days; set => this._days = value; }

        /// <summary>Backing field for <see cref="Hours" /> property.</summary>
        private int? _hours;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? Hours { get => this._hours; set => this._hours = value; }

        /// <summary>Backing field for <see cref="Minutes" /> property.</summary>
        private int? _minutes;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? Minutes { get => this._minutes; set => this._minutes = value; }

        /// <summary>Backing field for <see cref="Seconds" /> property.</summary>
        private int? _seconds;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? Seconds { get => this._seconds; set => this._seconds = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="TotalSeconds" /> property.</summary>
        private string _totalSeconds;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string TotalSeconds { get => this._totalSeconds; set => this._totalSeconds = value; }

        /// <summary>Creates an new <see cref="SystemInsightsUptime" /> instance.</summary>
        public SystemInsightsUptime()
        {

        }
    }
    /// System Insights Uptime
    public partial interface ISystemInsightsUptime :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
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
        SerializedName = @"days",
        PossibleTypes = new [] { typeof(int) })]
        int? Days { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hours",
        PossibleTypes = new [] { typeof(int) })]
        int? Hours { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minutes",
        PossibleTypes = new [] { typeof(int) })]
        int? Minutes { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"seconds",
        PossibleTypes = new [] { typeof(int) })]
        int? Seconds { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"total_seconds",
        PossibleTypes = new [] { typeof(string) })]
        string TotalSeconds { get; set; }

    }
    /// System Insights Uptime
    internal partial interface ISystemInsightsUptimeInternal

    {
        string CollectionTime { get; set; }

        int? Days { get; set; }

        int? Hours { get; set; }

        int? Minutes { get; set; }

        int? Seconds { get; set; }

        string SystemId { get; set; }

        string TotalSeconds { get; set; }

    }
}