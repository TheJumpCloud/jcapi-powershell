namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Battery</summary>
    public partial class SystemInsightsBattery :
        JumpCloudApiSdkV2.Models.ISystemInsightsBattery,
        JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal
    {

        /// <summary>Backing field for <see cref="Amgerage" /> property.</summary>
        private int? _amgerage;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Amgerage { get => this._amgerage; set => this._amgerage = value; }

        /// <summary>Backing field for <see cref="Charged" /> property.</summary>
        private int? _charged;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Charged { get => this._charged; set => this._charged = value; }

        /// <summary>Backing field for <see cref="Charging" /> property.</summary>
        private int? _charging;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Charging { get => this._charging; set => this._charging = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Condition" /> property.</summary>
        private string _condition;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Condition { get => this._condition; set => this._condition = value; }

        /// <summary>Backing field for <see cref="CurrentCapacity" /> property.</summary>
        private int? _currentCapacity;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? CurrentCapacity { get => this._currentCapacity; set => this._currentCapacity = value; }

        /// <summary>Backing field for <see cref="CycleCount" /> property.</summary>
        private int? _cycleCount;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? CycleCount { get => this._cycleCount; set => this._cycleCount = value; }

        /// <summary>Backing field for <see cref="DesignedCapacity" /> property.</summary>
        private int? _designedCapacity;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? DesignedCapacity { get => this._designedCapacity; set => this._designedCapacity = value; }

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private string _health;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Health { get => this._health; set => this._health = value; }

        /// <summary>Backing field for <see cref="ManufactureDate" /> property.</summary>
        private int? _manufactureDate;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? ManufactureDate { get => this._manufactureDate; set => this._manufactureDate = value; }

        /// <summary>Backing field for <see cref="Manufacturer" /> property.</summary>
        private string _manufacturer;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Manufacturer { get => this._manufacturer; set => this._manufacturer = value; }

        /// <summary>Backing field for <see cref="MaxCapacity" /> property.</summary>
        private int? _maxCapacity;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? MaxCapacity { get => this._maxCapacity; set => this._maxCapacity = value; }

        /// <summary>Backing field for <see cref="MinutesToFullCharge" /> property.</summary>
        private int? _minutesToFullCharge;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? MinutesToFullCharge { get => this._minutesToFullCharge; set => this._minutesToFullCharge = value; }

        /// <summary>Backing field for <see cref="MinutesUntilEmpty" /> property.</summary>
        private int? _minutesUntilEmpty;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? MinutesUntilEmpty { get => this._minutesUntilEmpty; set => this._minutesUntilEmpty = value; }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="PercentRemaining" /> property.</summary>
        private int? _percentRemaining;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? PercentRemaining { get => this._percentRemaining; set => this._percentRemaining = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Voltage" /> property.</summary>
        private int? _voltage;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Voltage { get => this._voltage; set => this._voltage = value; }

        /// <summary>Creates an new <see cref="SystemInsightsBattery" /> instance.</summary>
        public SystemInsightsBattery()
        {

        }
    }
    /// System Insights Battery
    public partial interface ISystemInsightsBattery :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"amgerage",
        PossibleTypes = new [] { typeof(int) })]
        int? Amgerage { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"charged",
        PossibleTypes = new [] { typeof(int) })]
        int? Charged { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"charging",
        PossibleTypes = new [] { typeof(int) })]
        int? Charging { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"collection_time",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionTime { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"condition",
        PossibleTypes = new [] { typeof(string) })]
        string Condition { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"current_capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? CurrentCapacity { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cycle_count",
        PossibleTypes = new [] { typeof(int) })]
        int? CycleCount { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"designed_capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? DesignedCapacity { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(string) })]
        string Health { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"manufacture_date",
        PossibleTypes = new [] { typeof(int) })]
        int? ManufactureDate { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"manufacturer",
        PossibleTypes = new [] { typeof(string) })]
        string Manufacturer { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"max_capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxCapacity { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minutes_to_full_charge",
        PossibleTypes = new [] { typeof(int) })]
        int? MinutesToFullCharge { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minutes_until_empty",
        PossibleTypes = new [] { typeof(int) })]
        int? MinutesUntilEmpty { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        string Model { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"percent_remaining",
        PossibleTypes = new [] { typeof(int) })]
        int? PercentRemaining { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"serial_number",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"voltage",
        PossibleTypes = new [] { typeof(int) })]
        int? Voltage { get; set; }

    }
    /// System Insights Battery
    internal partial interface ISystemInsightsBatteryInternal

    {
        int? Amgerage { get; set; }

        int? Charged { get; set; }

        int? Charging { get; set; }

        string CollectionTime { get; set; }

        string Condition { get; set; }

        int? CurrentCapacity { get; set; }

        int? CycleCount { get; set; }

        int? DesignedCapacity { get; set; }

        string Health { get; set; }

        int? ManufactureDate { get; set; }

        string Manufacturer { get; set; }

        int? MaxCapacity { get; set; }

        int? MinutesToFullCharge { get; set; }

        int? MinutesUntilEmpty { get; set; }

        string Model { get; set; }

        int? PercentRemaining { get; set; }

        string SerialNumber { get; set; }

        string State { get; set; }

        string SystemId { get; set; }

        int? Voltage { get; set; }

    }
}