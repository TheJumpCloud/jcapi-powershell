namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>Command</summary>
    public partial class Command :
        JumpCloud.SDK.V1.Models.ICommand,
        JumpCloud.SDK.V1.Models.ICommandInternal
    {

        /// <summary>Backing field for <see cref="Command1" /> property.</summary>
        private string _command1;

        /// <summary>The command to execute on the server.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Command1 { get => this._command1; set => this._command1 = value; }

        /// <summary>Backing field for <see cref="CommandRunners" /> property.</summary>
        private string[] _commandRunners;

        /// <summary>An array of IDs of the Command Runner Users that can execute this command.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string[] CommandRunners { get => this._commandRunners; set => this._commandRunners = value; }

        /// <summary>Backing field for <see cref="CommandType" /> property.</summary>
        private string _commandType;

        /// <summary>The Command OS</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string CommandType { get => this._commandType; set => this._commandType = value; }

        /// <summary>Backing field for <see cref="Files" /> property.</summary>
        private string[] _files;

        /// <summary>An array of file IDs to include with the command.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string[] Files { get => this._files; set => this._files = value; }

        /// <summary>Backing field for <see cref="LaunchType" /> property.</summary>
        private string _launchType;

        /// <summary>How the command will execute.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string LaunchType { get => this._launchType; set => this._launchType = value; }

        /// <summary>Backing field for <see cref="ListensTo" /> property.</summary>
        private string _listensTo;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string ListensTo { get => this._listensTo; set => this._listensTo = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        /// <summary>The ID of the organization.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="Schedule" /> property.</summary>
        private string _schedule;

        /// <summary>
        /// A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you
        /// send this as an empty string, it will run immediately.
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Schedule { get => this._schedule; set => this._schedule = value; }

        /// <summary>Backing field for <see cref="ScheduleRepeatType" /> property.</summary>
        private string _scheduleRepeatType;

        /// <summary>When the command will repeat.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string ScheduleRepeatType { get => this._scheduleRepeatType; set => this._scheduleRepeatType = value; }

        /// <summary>Backing field for <see cref="Sudo" /> property.</summary>
        private bool? _sudo;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Sudo { get => this._sudo; set => this._sudo = value; }

        /// <summary>Backing field for <see cref="Systems" /> property.</summary>
        private string[] _systems;

        /// <summary>
        /// An array of system IDs to run the command on. Not available if you are using Groups.
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string[] Systems { get => this._systems; set => this._systems = value; }

        /// <summary>Backing field for <see cref="Timeout" /> property.</summary>
        private string _timeout;

        /// <summary>The time in seconds to allow the command to run for.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Timeout { get => this._timeout; set => this._timeout = value; }

        /// <summary>Backing field for <see cref="Trigger" /> property.</summary>
        private string _trigger;

        /// <summary>The name of the command trigger.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Trigger { get => this._trigger; set => this._trigger = value; }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private string _user;

        /// <summary>
        /// The ID of the system user to run the command as. This field is required when creating a command with a commandType of
        /// "mac" or "linux".
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string User { get => this._user; set => this._user = value; }

        /// <summary>Creates an new <see cref="Command" /> instance.</summary>
        public Command()
        {

        }
    }
    /// Command
    public partial interface ICommand :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        /// <summary>The command to execute on the server.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The command to execute on the server.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        string Command1 { get; set; }
        /// <summary>An array of IDs of the Command Runner Users that can execute this command.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of IDs of the Command Runner Users that can execute this command.",
        SerializedName = @"commandRunners",
        PossibleTypes = new [] { typeof(string) })]
        string[] CommandRunners { get; set; }
        /// <summary>The Command OS</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Command OS",
        SerializedName = @"commandType",
        PossibleTypes = new [] { typeof(string) })]
        string CommandType { get; set; }
        /// <summary>An array of file IDs to include with the command.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of file IDs to include with the command.",
        SerializedName = @"files",
        PossibleTypes = new [] { typeof(string) })]
        string[] Files { get; set; }
        /// <summary>How the command will execute.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"How the command will execute.",
        SerializedName = @"launchType",
        PossibleTypes = new [] { typeof(string) })]
        string LaunchType { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"listensTo",
        PossibleTypes = new [] { typeof(string) })]
        string ListensTo { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The ID of the organization.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the organization.",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        string Organization { get; set; }
        /// <summary>
        /// A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you
        /// send this as an empty string, it will run immediately.
        /// </summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you send this as an empty string, it will run immediately.
        ",
        SerializedName = @"schedule",
        PossibleTypes = new [] { typeof(string) })]
        string Schedule { get; set; }
        /// <summary>When the command will repeat.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When the command will repeat.",
        SerializedName = @"scheduleRepeatType",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleRepeatType { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sudo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Sudo { get; set; }
        /// <summary>
        /// An array of system IDs to run the command on. Not available if you are using Groups.
        /// </summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of system IDs to run the command on. Not available if you are using Groups.",
        SerializedName = @"systems",
        PossibleTypes = new [] { typeof(string) })]
        string[] Systems { get; set; }
        /// <summary>The time in seconds to allow the command to run for.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time in seconds to allow the command to run for.",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(string) })]
        string Timeout { get; set; }
        /// <summary>The name of the command trigger.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the command trigger.",
        SerializedName = @"trigger",
        PossibleTypes = new [] { typeof(string) })]
        string Trigger { get; set; }
        /// <summary>
        /// The ID of the system user to run the command as. This field is required when creating a command with a commandType of
        /// "mac" or "linux".
        /// </summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the system user to run the command as. This field is required when creating a command with a commandType of ""mac"" or ""linux"".",
        SerializedName = @"user",
        PossibleTypes = new [] { typeof(string) })]
        string User { get; set; }

    }
    /// Command
    internal partial interface ICommandInternal

    {
        /// <summary>The command to execute on the server.</summary>
        string Command1 { get; set; }
        /// <summary>An array of IDs of the Command Runner Users that can execute this command.</summary>
        string[] CommandRunners { get; set; }
        /// <summary>The Command OS</summary>
        string CommandType { get; set; }
        /// <summary>An array of file IDs to include with the command.</summary>
        string[] Files { get; set; }
        /// <summary>How the command will execute.</summary>
        string LaunchType { get; set; }

        string ListensTo { get; set; }

        string Name { get; set; }
        /// <summary>The ID of the organization.</summary>
        string Organization { get; set; }
        /// <summary>
        /// A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you
        /// send this as an empty string, it will run immediately.
        /// </summary>
        string Schedule { get; set; }
        /// <summary>When the command will repeat.</summary>
        string ScheduleRepeatType { get; set; }

        bool? Sudo { get; set; }
        /// <summary>
        /// An array of system IDs to run the command on. Not available if you are using Groups.
        /// </summary>
        string[] Systems { get; set; }
        /// <summary>The time in seconds to allow the command to run for.</summary>
        string Timeout { get; set; }
        /// <summary>The name of the command trigger.</summary>
        string Trigger { get; set; }
        /// <summary>
        /// The ID of the system user to run the command as. This field is required when creating a command with a commandType of
        /// "mac" or "linux".
        /// </summary>
        string User { get; set; }

    }
}