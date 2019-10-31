namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class CommandresultResponseData :
        JumpCloudApiSdkV1.Models.ICommandresultResponseData,
        JumpCloudApiSdkV1.Models.ICommandresultResponseDataInternal
    {

        /// <summary>Backing field for <see cref="ExitCode" /> property.</summary>
        private int? _exitCode;

        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? ExitCode { get => this._exitCode; set => this._exitCode = value; }

        /// <summary>Backing field for <see cref="Output" /> property.</summary>
        private string _output;

        /// <summary>The output of the command that was executed.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Output { get => this._output; set => this._output = value; }

        /// <summary>Creates an new <see cref="CommandresultResponseData" /> instance.</summary>
        public CommandresultResponseData()
        {

        }
    }
    public partial interface ICommandresultResponseData :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>The stderr output from the command that ran.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The stderr output from the command that ran.",
        SerializedName = @"exitCode",
        PossibleTypes = new [] { typeof(int) })]
        int? ExitCode { get; set; }
        /// <summary>The output of the command that was executed.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The output of the command that was executed.",
        SerializedName = @"output",
        PossibleTypes = new [] { typeof(string) })]
        string Output { get; set; }

    }
    internal partial interface ICommandresultResponseDataInternal

    {
        /// <summary>The stderr output from the command that ran.</summary>
        int? ExitCode { get; set; }
        /// <summary>The output of the command that was executed.</summary>
        string Output { get; set; }

    }
}