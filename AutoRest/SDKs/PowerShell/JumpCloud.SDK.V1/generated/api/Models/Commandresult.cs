namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>CommandResult</summary>
    public partial class Commandresult :
        JumpCloud.SDK.V1.Models.ICommandresult,
        JumpCloud.SDK.V1.Models.ICommandresultInternal
    {

        /// <summary>Backing field for <see cref="Command" /> property.</summary>
        private string _command;

        /// <summary>The command that was executed on the system.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Command { get => this._command; set => this._command = value; }

        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? DataExitCode { get => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).DataExitCode; set => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).DataExitCode = value; }

        /// <summary>The output of the command that was executed.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string DataOutput { get => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).DataOutput; set => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).DataOutput = value; }

        /// <summary>Backing field for <see cref="Files" /> property.</summary>
        private string[] _files;

        /// <summary>An array of file ids that were included in the command</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string[] Files { get => this._files; set => this._files = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ID of the command.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Response</summary>
        JumpCloud.SDK.V1.Models.ICommandresultResponse JumpCloud.SDK.V1.Models.ICommandresultInternal.Response { get => (this._response = this._response ?? new JumpCloud.SDK.V1.Models.CommandresultResponse()); set { {_response = value;} } }

        /// <summary>Internal Acessors for ResponseData</summary>
        JumpCloud.SDK.V1.Models.ICommandresultResponseData JumpCloud.SDK.V1.Models.ICommandresultInternal.ResponseData { get => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).Data; set => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).Data = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the command.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        /// <summary>The ID of the organization.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="RequestTime" /> property.</summary>
        private string _requestTime;

        /// <summary>The time that the command was sent.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string RequestTime { get => this._requestTime; set => this._requestTime = value; }

        /// <summary>Backing field for <see cref="Response" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ICommandresultResponse _response;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.ICommandresultResponse Response { get => (this._response = this._response ?? new JumpCloud.SDK.V1.Models.CommandresultResponse()); set => this._response = value; }

        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ResponseError { get => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).Error; set => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).Error = value; }

        /// <summary>ID of the response.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ResponseId { get => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).Id; set => ((JumpCloud.SDK.V1.Models.ICommandresultResponseInternal)Response).Id = value; }

        /// <summary>Backing field for <see cref="ResponseTime" /> property.</summary>
        private string _responseTime;

        /// <summary>The time that the command was completed.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string ResponseTime { get => this._responseTime; set => this._responseTime = value; }

        /// <summary>Backing field for <see cref="Sudo" /> property.</summary>
        private bool? _sudo;

        /// <summary>If the user had sudo rights</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Sudo { get => this._sudo; set => this._sudo = value; }

        /// <summary>Backing field for <see cref="System" /> property.</summary>
        private string _system;

        /// <summary>The name of the system the command was executed on.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string System { get => this._system; set => this._system = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        /// <summary>The id of the system the command was executed on.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private string _user;

        /// <summary>The user the command ran as.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string User { get => this._user; set => this._user = value; }

        /// <summary>Backing field for <see cref="WorkflowId" /> property.</summary>
        private string _workflowId;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string WorkflowId { get => this._workflowId; set => this._workflowId = value; }

        /// <summary>Backing field for <see cref="WorkflowInstanceId" /> property.</summary>
        private string _workflowInstanceId;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string WorkflowInstanceId { get => this._workflowInstanceId; set => this._workflowInstanceId = value; }

        /// <summary>Creates an new <see cref="Commandresult" /> instance.</summary>
        public Commandresult()
        {

        }
    }
    /// CommandResult
    public partial interface ICommandresult :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        /// <summary>The command that was executed on the system.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The command that was executed on the system.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        string Command { get; set; }
        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The stderr output from the command that ran.",
        SerializedName = @"exitCode",
        PossibleTypes = new [] { typeof(int) })]
        int? DataExitCode { get; set; }
        /// <summary>The output of the command that was executed.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The output of the command that was executed.",
        SerializedName = @"output",
        PossibleTypes = new [] { typeof(string) })]
        string DataOutput { get; set; }
        /// <summary>An array of file ids that were included in the command</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of file ids that were included in the command",
        SerializedName = @"files",
        PossibleTypes = new [] { typeof(string) })]
        string[] Files { get; set; }
        /// <summary>The ID of the command.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the command.",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the command.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the command.",
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
        /// <summary>The time that the command was sent.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time that the command was sent.",
        SerializedName = @"requestTime",
        PossibleTypes = new [] { typeof(string) })]
        string RequestTime { get; set; }
        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The stderr output from the command that ran.",
        SerializedName = @"error",
        PossibleTypes = new [] { typeof(string) })]
        string ResponseError { get; set; }
        /// <summary>ID of the response.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the response.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ResponseId { get; set; }
        /// <summary>The time that the command was completed.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time that the command was completed.",
        SerializedName = @"responseTime",
        PossibleTypes = new [] { typeof(string) })]
        string ResponseTime { get; set; }
        /// <summary>If the user had sudo rights</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If the user had sudo rights",
        SerializedName = @"sudo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Sudo { get; set; }
        /// <summary>The name of the system the command was executed on.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the system the command was executed on.",
        SerializedName = @"system",
        PossibleTypes = new [] { typeof(string) })]
        string System { get; set; }
        /// <summary>The id of the system the command was executed on.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the system the command was executed on.",
        SerializedName = @"systemId",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }
        /// <summary>The user the command ran as.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user the command ran as.",
        SerializedName = @"user",
        PossibleTypes = new [] { typeof(string) })]
        string User { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"workflowId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkflowId { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"workflowInstanceId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkflowInstanceId { get; set; }

    }
    /// CommandResult
    internal partial interface ICommandresultInternal

    {
        /// <summary>The command that was executed on the system.</summary>
        string Command { get; set; }
        /// <summary>The stderr output from the command that ran.</summary>
        int? DataExitCode { get; set; }
        /// <summary>The output of the command that was executed.</summary>
        string DataOutput { get; set; }
        /// <summary>An array of file ids that were included in the command</summary>
        string[] Files { get; set; }
        /// <summary>The ID of the command.</summary>
        string Id { get; set; }
        /// <summary>The name of the command.</summary>
        string Name { get; set; }
        /// <summary>The ID of the organization.</summary>
        string Organization { get; set; }
        /// <summary>The time that the command was sent.</summary>
        string RequestTime { get; set; }

        JumpCloud.SDK.V1.Models.ICommandresultResponse Response { get; set; }

        JumpCloud.SDK.V1.Models.ICommandresultResponseData ResponseData { get; set; }
        /// <summary>The stderr output from the command that ran.</summary>
        string ResponseError { get; set; }
        /// <summary>ID of the response.</summary>
        string ResponseId { get; set; }
        /// <summary>The time that the command was completed.</summary>
        string ResponseTime { get; set; }
        /// <summary>If the user had sudo rights</summary>
        bool? Sudo { get; set; }
        /// <summary>The name of the system the command was executed on.</summary>
        string System { get; set; }
        /// <summary>The id of the system the command was executed on.</summary>
        string SystemId { get; set; }
        /// <summary>The user the command ran as.</summary>
        string User { get; set; }

        string WorkflowId { get; set; }

        string WorkflowInstanceId { get; set; }

    }
}