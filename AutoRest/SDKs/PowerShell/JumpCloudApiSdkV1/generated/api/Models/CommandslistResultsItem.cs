namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class CommandslistResultsItem :
        JumpCloudApiSdkV1.Models.ICommandslistResultsItem,
        JumpCloudApiSdkV1.Models.ICommandslistResultsItemInternal
    {

        /// <summary>Backing field for <see cref="Command" /> property.</summary>
        private string _command;

        /// <summary>The Command to execute.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Command { get => this._command; set => this._command = value; }

        /// <summary>Backing field for <see cref="CommandType" /> property.</summary>
        private string _commandType;

        /// <summary>The Command OS.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string CommandType { get => this._commandType; set => this._commandType = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ID of the command.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LaunchType" /> property.</summary>
        private string _launchType;

        /// <summary>How the Command is executed.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string LaunchType { get => this._launchType; set => this._launchType = value; }

        /// <summary>Backing field for <see cref="ListensTo" /> property.</summary>
        private string _listensTo;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string ListensTo { get => this._listensTo; set => this._listensTo = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the Command.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        /// <summary>The ID of the Organization.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="Schedule" /> property.</summary>
        private string _schedule;

        /// <summary>
        /// A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you
        /// send this as an empty string, it will run immediately.
        /// </summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Schedule { get => this._schedule; set => this._schedule = value; }

        /// <summary>Backing field for <see cref="ScheduleRepeatType" /> property.</summary>
        private string _scheduleRepeatType;

        /// <summary>When the command will repeat.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string ScheduleRepeatType { get => this._scheduleRepeatType; set => this._scheduleRepeatType = value; }

        /// <summary>Backing field for <see cref="Trigger" /> property.</summary>
        private string _trigger;

        /// <summary>Trigger to execute command.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Trigger { get => this._trigger; set => this._trigger = value; }

        /// <summary>Creates an new <see cref="CommandslistResultsItem" /> instance.</summary>
        public CommandslistResultsItem()
        {

        }
    }
    public partial interface ICommandslistResultsItem :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>The Command to execute.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Command to execute.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        string Command { get; set; }
        /// <summary>The Command OS.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Command OS.",
        SerializedName = @"commandType",
        PossibleTypes = new [] { typeof(string) })]
        string CommandType { get; set; }
        /// <summary>The ID of the command.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the command.",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>How the Command is executed.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"How the Command is executed.",
        SerializedName = @"launchType",
        PossibleTypes = new [] { typeof(string) })]
        string LaunchType { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"listensTo",
        PossibleTypes = new [] { typeof(string) })]
        string ListensTo { get; set; }
        /// <summary>The name of the Command.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Command.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The ID of the Organization.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the Organization.",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        string Organization { get; set; }
        /// <summary>
        /// A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you
        /// send this as an empty string, it will run immediately.
        /// </summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you send this as an empty string, it will run immediately.",
        SerializedName = @"schedule",
        PossibleTypes = new [] { typeof(string) })]
        string Schedule { get; set; }
        /// <summary>When the command will repeat.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When the command will repeat.",
        SerializedName = @"scheduleRepeatType",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleRepeatType { get; set; }
        /// <summary>Trigger to execute command.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Trigger to execute command.",
        SerializedName = @"trigger",
        PossibleTypes = new [] { typeof(string) })]
        string Trigger { get; set; }

    }
    internal partial interface ICommandslistResultsItemInternal

    {
        /// <summary>The Command to execute.</summary>
        string Command { get; set; }
        /// <summary>The Command OS.</summary>
        string CommandType { get; set; }
        /// <summary>The ID of the command.</summary>
        string Id { get; set; }
        /// <summary>How the Command is executed.</summary>
        string LaunchType { get; set; }

        string ListensTo { get; set; }
        /// <summary>The name of the Command.</summary>
        string Name { get; set; }
        /// <summary>The ID of the Organization.</summary>
        string Organization { get; set; }
        /// <summary>
        /// A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you
        /// send this as an empty string, it will run immediately.
        /// </summary>
        string Schedule { get; set; }
        /// <summary>When the command will repeat.</summary>
        string ScheduleRepeatType { get; set; }
        /// <summary>Trigger to execute command.</summary>
        string Trigger { get; set; }

    }
}