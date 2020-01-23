namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights System Info</summary>
    public partial class SystemInsightsSystemInfo :
        JumpCloud.SDK.V2.Models.ISystemInsightsSystemInfo,
        JumpCloud.SDK.V2.Models.ISystemInsightsSystemInfoInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="ComputerName" /> property.</summary>
        private string _computerName;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string ComputerName { get => this._computerName; set => this._computerName = value; }

        /// <summary>Backing field for <see cref="CpuBrand" /> property.</summary>
        private string _cpuBrand;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CpuBrand { get => this._cpuBrand; set => this._cpuBrand = value; }

        /// <summary>Backing field for <see cref="CpuLogicalCores" /> property.</summary>
        private int? _cpuLogicalCores;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? CpuLogicalCores { get => this._cpuLogicalCores; set => this._cpuLogicalCores = value; }

        /// <summary>Backing field for <see cref="CpuMicrocode" /> property.</summary>
        private string _cpuMicrocode;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CpuMicrocode { get => this._cpuMicrocode; set => this._cpuMicrocode = value; }

        /// <summary>Backing field for <see cref="CpuPhysicalCores" /> property.</summary>
        private int? _cpuPhysicalCores;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? CpuPhysicalCores { get => this._cpuPhysicalCores; set => this._cpuPhysicalCores = value; }

        /// <summary>Backing field for <see cref="CpuSubtype" /> property.</summary>
        private string _cpuSubtype;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CpuSubtype { get => this._cpuSubtype; set => this._cpuSubtype = value; }

        /// <summary>Backing field for <see cref="CpuType" /> property.</summary>
        private string _cpuType;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CpuType { get => this._cpuType; set => this._cpuType = value; }

        /// <summary>Backing field for <see cref="HardwareModel" /> property.</summary>
        private string _hardwareModel;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string HardwareModel { get => this._hardwareModel; set => this._hardwareModel = value; }

        /// <summary>Backing field for <see cref="HardwareSerial" /> property.</summary>
        private string _hardwareSerial;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string HardwareSerial { get => this._hardwareSerial; set => this._hardwareSerial = value; }

        /// <summary>Backing field for <see cref="HardwareVendor" /> property.</summary>
        private string _hardwareVendor;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string HardwareVendor { get => this._hardwareVendor; set => this._hardwareVendor = value; }

        /// <summary>Backing field for <see cref="HardwareVersion" /> property.</summary>
        private string _hardwareVersion;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string HardwareVersion { get => this._hardwareVersion; set => this._hardwareVersion = value; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; set => this._hostname = value; }

        /// <summary>Backing field for <see cref="LocalHostname" /> property.</summary>
        private string _localHostname;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string LocalHostname { get => this._localHostname; set => this._localHostname = value; }

        /// <summary>Backing field for <see cref="PhysicalMemory" /> property.</summary>
        private string _physicalMemory;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string PhysicalMemory { get => this._physicalMemory; set => this._physicalMemory = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Uuid { get => this._uuid; set => this._uuid = value; }

        /// <summary>Creates an new <see cref="SystemInsightsSystemInfo" /> instance.</summary>
        public SystemInsightsSystemInfo()
        {

        }
    }
    /// System Insights System Info
    public partial interface ISystemInsightsSystemInfo :
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
        SerializedName = @"computer_name",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cpu_brand",
        PossibleTypes = new [] { typeof(string) })]
        string CpuBrand { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cpu_logical_cores",
        PossibleTypes = new [] { typeof(int) })]
        int? CpuLogicalCores { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cpu_microcode",
        PossibleTypes = new [] { typeof(string) })]
        string CpuMicrocode { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cpu_physical_cores",
        PossibleTypes = new [] { typeof(int) })]
        int? CpuPhysicalCores { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cpu_subtype",
        PossibleTypes = new [] { typeof(string) })]
        string CpuSubtype { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cpu_type",
        PossibleTypes = new [] { typeof(string) })]
        string CpuType { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hardware_model",
        PossibleTypes = new [] { typeof(string) })]
        string HardwareModel { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hardware_serial",
        PossibleTypes = new [] { typeof(string) })]
        string HardwareSerial { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hardware_vendor",
        PossibleTypes = new [] { typeof(string) })]
        string HardwareVendor { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hardware_version",
        PossibleTypes = new [] { typeof(string) })]
        string HardwareVersion { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"local_hostname",
        PossibleTypes = new [] { typeof(string) })]
        string LocalHostname { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"physical_memory",
        PossibleTypes = new [] { typeof(string) })]
        string PhysicalMemory { get; set; }

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
        SerializedName = @"uuid",
        PossibleTypes = new [] { typeof(string) })]
        string Uuid { get; set; }

    }
    /// System Insights System Info
    internal partial interface ISystemInsightsSystemInfoInternal

    {
        string CollectionTime { get; set; }

        string ComputerName { get; set; }

        string CpuBrand { get; set; }

        int? CpuLogicalCores { get; set; }

        string CpuMicrocode { get; set; }

        int? CpuPhysicalCores { get; set; }

        string CpuSubtype { get; set; }

        string CpuType { get; set; }

        string HardwareModel { get; set; }

        string HardwareSerial { get; set; }

        string HardwareVendor { get; set; }

        string HardwareVersion { get; set; }

        string Hostname { get; set; }

        string LocalHostname { get; set; }

        string PhysicalMemory { get; set; }

        string SystemId { get; set; }

        string Uuid { get; set; }

    }
}