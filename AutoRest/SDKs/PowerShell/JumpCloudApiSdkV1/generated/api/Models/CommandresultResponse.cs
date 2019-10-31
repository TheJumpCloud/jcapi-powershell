namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class CommandresultResponse :
        JumpCloudApiSdkV1.Models.ICommandresultResponse,
        JumpCloudApiSdkV1.Models.ICommandresultResponseInternal
    {

        /// <summary>Backing field for <see cref="Data" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ICommandresultResponseData _data;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.ICommandresultResponseData Data { get => (this._data = this._data ?? new JumpCloudApiSdkV1.Models.CommandresultResponseData()); set => this._data = value; }

        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? DataExitCode { get => ((JumpCloudApiSdkV1.Models.ICommandresultResponseDataInternal)Data).ExitCode; set => ((JumpCloudApiSdkV1.Models.ICommandresultResponseDataInternal)Data).ExitCode = value; }

        /// <summary>The output of the command that was executed.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string DataOutput { get => ((JumpCloudApiSdkV1.Models.ICommandresultResponseDataInternal)Data).Output; set => ((JumpCloudApiSdkV1.Models.ICommandresultResponseDataInternal)Data).Output = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private string _error;

        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Error { get => this._error; set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ID of the response.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Data</summary>
        JumpCloudApiSdkV1.Models.ICommandresultResponseData JumpCloudApiSdkV1.Models.ICommandresultResponseInternal.Data { get => (this._data = this._data ?? new JumpCloudApiSdkV1.Models.CommandresultResponseData()); set { {_data = value;} } }

        /// <summary>Creates an new <see cref="CommandresultResponse" /> instance.</summary>
        public CommandresultResponse()
        {

        }
    }
    public partial interface ICommandresultResponse :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The stderr output from the command that ran.",
        SerializedName = @"exitCode",
        PossibleTypes = new [] { typeof(int) })]
        int? DataExitCode { get; set; }
        /// <summary>The output of the command that was executed.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The output of the command that was executed.",
        SerializedName = @"output",
        PossibleTypes = new [] { typeof(string) })]
        string DataOutput { get; set; }
        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The stderr output from the command that ran.",
        SerializedName = @"error",
        PossibleTypes = new [] { typeof(string) })]
        string Error { get; set; }
        /// <summary>ID of the response.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the response.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    internal partial interface ICommandresultResponseInternal

    {
        JumpCloudApiSdkV1.Models.ICommandresultResponseData Data { get; set; }
        /// <summary>The stderr output from the command that ran.</summary>
        int? DataExitCode { get; set; }
        /// <summary>The output of the command that was executed.</summary>
        string DataOutput { get; set; }
        /// <summary>The stderr output from the command that ran.</summary>
        string Error { get; set; }
        /// <summary>ID of the response.</summary>
        string Id { get; set; }

    }
}