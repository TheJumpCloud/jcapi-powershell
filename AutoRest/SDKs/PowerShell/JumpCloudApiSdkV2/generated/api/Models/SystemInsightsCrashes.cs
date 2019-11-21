namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Crashes</summary>
    public partial class SystemInsightsCrashes :
        JumpCloudApiSdkV2.Models.ISystemInsightsCrashes,
        JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal
    {

        /// <summary>Backing field for <see cref="CrashPath" /> property.</summary>
        private string _crashPath;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CrashPath { get => this._crashPath; set => this._crashPath = value; }

        /// <summary>Backing field for <see cref="CrashedThread" /> property.</summary>
        private string _crashedThread;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CrashedThread { get => this._crashedThread; set => this._crashedThread = value; }

        /// <summary>Backing field for <see cref="Datetime" /> property.</summary>
        private string _datetime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Datetime { get => this._datetime; set => this._datetime = value; }

        /// <summary>Backing field for <see cref="ExceptionCodes" /> property.</summary>
        private string _exceptionCodes;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ExceptionCodes { get => this._exceptionCodes; set => this._exceptionCodes = value; }

        /// <summary>Backing field for <see cref="ExceptionNotes" /> property.</summary>
        private string _exceptionNotes;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ExceptionNotes { get => this._exceptionNotes; set => this._exceptionNotes = value; }

        /// <summary>Backing field for <see cref="ExceptionType" /> property.</summary>
        private string _exceptionType;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ExceptionType { get => this._exceptionType; set => this._exceptionType = value; }

        /// <summary>Backing field for <see cref="Identifier" /> property.</summary>
        private string _identifier;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Identifier { get => this._identifier; set => this._identifier = value; }

        /// <summary>Backing field for <see cref="Parent" /> property.</summary>
        private string _parent;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Parent { get => this._parent; set => this._parent = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="Pid" /> property.</summary>
        private string _pid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Pid { get => this._pid; set => this._pid = value; }

        /// <summary>Backing field for <see cref="Registers" /> property.</summary>
        private string _registers;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Registers { get => this._registers; set => this._registers = value; }

        /// <summary>Backing field for <see cref="Responsible" /> property.</summary>
        private string _responsible;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Responsible { get => this._responsible; set => this._responsible = value; }

        /// <summary>Backing field for <see cref="StackTrace" /> property.</summary>
        private string _stackTrace;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string StackTrace { get => this._stackTrace; set => this._stackTrace = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Uid" /> property.</summary>
        private int? _uid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Uid { get => this._uid; set => this._uid = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SystemInsightsCrashes" /> instance.</summary>
        public SystemInsightsCrashes()
        {

        }
    }
    /// System Insights Crashes
    public partial interface ISystemInsightsCrashes :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
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
        SerializedName = @"crashed_thread",
        PossibleTypes = new [] { typeof(string) })]
        string CrashedThread { get; set; }

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
        SerializedName = @"exception_codes",
        PossibleTypes = new [] { typeof(string) })]
        string ExceptionCodes { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exception_notes",
        PossibleTypes = new [] { typeof(string) })]
        string ExceptionNotes { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exception_type",
        PossibleTypes = new [] { typeof(string) })]
        string ExceptionType { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"identifier",
        PossibleTypes = new [] { typeof(string) })]
        string Identifier { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"parent",
        PossibleTypes = new [] { typeof(string) })]
        string Parent { get; set; }

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
        SerializedName = @"registers",
        PossibleTypes = new [] { typeof(string) })]
        string Registers { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"responsible",
        PossibleTypes = new [] { typeof(string) })]
        string Responsible { get; set; }

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
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"uid",
        PossibleTypes = new [] { typeof(int) })]
        int? Uid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// System Insights Crashes
    internal partial interface ISystemInsightsCrashesInternal

    {
        string CrashPath { get; set; }

        string CrashedThread { get; set; }

        string Datetime { get; set; }

        string ExceptionCodes { get; set; }

        string ExceptionNotes { get; set; }

        string ExceptionType { get; set; }

        string Identifier { get; set; }

        string Parent { get; set; }

        string Path { get; set; }

        string Pid { get; set; }

        string Registers { get; set; }

        string Responsible { get; set; }

        string StackTrace { get; set; }

        string Type { get; set; }

        int? Uid { get; set; }

        string Version { get; set; }

    }
}