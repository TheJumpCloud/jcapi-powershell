namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Windows Crashes</summary>
    public partial class SystemInsightsWindowsCrashes :
        JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashes,
        JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal
    {

        /// <summary>Backing field for <see cref="BuildNumber" /> property.</summary>
        private int? _buildNumber;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? BuildNumber { get => this._buildNumber; set => this._buildNumber = value; }

        /// <summary>Backing field for <see cref="CommandLine" /> property.</summary>
        private string _commandLine;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CommandLine { get => this._commandLine; set => this._commandLine = value; }

        /// <summary>Backing field for <see cref="CrashPath" /> property.</summary>
        private string _crashPath;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CrashPath { get => this._crashPath; set => this._crashPath = value; }

        /// <summary>Backing field for <see cref="CurrentDirectory" /> property.</summary>
        private string _currentDirectory;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CurrentDirectory { get => this._currentDirectory; set => this._currentDirectory = value; }

        /// <summary>Backing field for <see cref="Datetime" /> property.</summary>
        private string _datetime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Datetime { get => this._datetime; set => this._datetime = value; }

        /// <summary>Backing field for <see cref="ExceptionAddress" /> property.</summary>
        private string _exceptionAddress;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ExceptionAddress { get => this._exceptionAddress; set => this._exceptionAddress = value; }

        /// <summary>Backing field for <see cref="ExceptionCode" /> property.</summary>
        private string _exceptionCode;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ExceptionCode { get => this._exceptionCode; set => this._exceptionCode = value; }

        /// <summary>Backing field for <see cref="ExceptionMessage" /> property.</summary>
        private string _exceptionMessage;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ExceptionMessage { get => this._exceptionMessage; set => this._exceptionMessage = value; }

        /// <summary>Backing field for <see cref="MachineName" /> property.</summary>
        private string _machineName;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string MachineName { get => this._machineName; set => this._machineName = value; }

        /// <summary>Backing field for <see cref="MajorVersion" /> property.</summary>
        private int? _majorVersion;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? MajorVersion { get => this._majorVersion; set => this._majorVersion = value; }

        /// <summary>Backing field for <see cref="MinorVersion" /> property.</summary>
        private int? _minorVersion;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? MinorVersion { get => this._minorVersion; set => this._minorVersion = value; }

        /// <summary>Backing field for <see cref="Module" /> property.</summary>
        private string _module;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Module { get => this._module; set => this._module = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="Pid" /> property.</summary>
        private string _pid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Pid { get => this._pid; set => this._pid = value; }

        /// <summary>Backing field for <see cref="ProcessUptime" /> property.</summary>
        private string _processUptime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ProcessUptime { get => this._processUptime; set => this._processUptime = value; }

        /// <summary>Backing field for <see cref="Registers" /> property.</summary>
        private string _registers;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Registers { get => this._registers; set => this._registers = value; }

        /// <summary>Backing field for <see cref="StackTrace" /> property.</summary>
        private string _stackTrace;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string StackTrace { get => this._stackTrace; set => this._stackTrace = value; }

        /// <summary>Backing field for <see cref="Tid" /> property.</summary>
        private string _tid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Tid { get => this._tid; set => this._tid = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SystemInsightsWindowsCrashes" /> instance.</summary>
        public SystemInsightsWindowsCrashes()
        {

        }
    }
    /// System Insights Windows Crashes
    public partial interface ISystemInsightsWindowsCrashes :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"build_number",
        PossibleTypes = new [] { typeof(int) })]
        int? BuildNumber { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"command_line",
        PossibleTypes = new [] { typeof(string) })]
        string CommandLine { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"crash_path",
        PossibleTypes = new [] { typeof(string) })]
        string CrashPath { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"current_directory",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentDirectory { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"datetime",
        PossibleTypes = new [] { typeof(string) })]
        string Datetime { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exception_address",
        PossibleTypes = new [] { typeof(string) })]
        string ExceptionAddress { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exception_code",
        PossibleTypes = new [] { typeof(string) })]
        string ExceptionCode { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exception_message",
        PossibleTypes = new [] { typeof(string) })]
        string ExceptionMessage { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"machine_name",
        PossibleTypes = new [] { typeof(string) })]
        string MachineName { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"major_version",
        PossibleTypes = new [] { typeof(int) })]
        int? MajorVersion { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minor_version",
        PossibleTypes = new [] { typeof(int) })]
        int? MinorVersion { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"module",
        PossibleTypes = new [] { typeof(string) })]
        string Module { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"pid",
        PossibleTypes = new [] { typeof(string) })]
        string Pid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"process_uptime",
        PossibleTypes = new [] { typeof(string) })]
        string ProcessUptime { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"registers",
        PossibleTypes = new [] { typeof(string) })]
        string Registers { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"stack_trace",
        PossibleTypes = new [] { typeof(string) })]
        string StackTrace { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tid",
        PossibleTypes = new [] { typeof(string) })]
        string Tid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// System Insights Windows Crashes
    internal partial interface ISystemInsightsWindowsCrashesInternal

    {
        int? BuildNumber { get; set; }

        string CommandLine { get; set; }

        string CrashPath { get; set; }

        string CurrentDirectory { get; set; }

        string Datetime { get; set; }

        string ExceptionAddress { get; set; }

        string ExceptionCode { get; set; }

        string ExceptionMessage { get; set; }

        string MachineName { get; set; }

        int? MajorVersion { get; set; }

        int? MinorVersion { get; set; }

        string Module { get; set; }

        string Path { get; set; }

        string Pid { get; set; }

        string ProcessUptime { get; set; }

        string Registers { get; set; }

        string StackTrace { get; set; }

        string Tid { get; set; }

        string Type { get; set; }

        string Username { get; set; }

        string Version { get; set; }

    }
}