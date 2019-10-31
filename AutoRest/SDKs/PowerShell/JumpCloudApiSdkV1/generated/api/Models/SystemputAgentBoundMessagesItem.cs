namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class SystemputAgentBoundMessagesItem :
        JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem,
        JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItemInternal
    {

        /// <summary>Backing field for <see cref="Cmd" /> property.</summary>
        private string _cmd;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Cmd { get => this._cmd; set => this._cmd = value; }

        /// <summary>Creates an new <see cref="SystemputAgentBoundMessagesItem" /> instance.</summary>
        public SystemputAgentBoundMessagesItem()
        {

        }
    }
    public partial interface ISystemputAgentBoundMessagesItem :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cmd",
        PossibleTypes = new [] { typeof(string) })]
        string Cmd { get; set; }

    }
    internal partial interface ISystemputAgentBoundMessagesItemInternal

    {
        string Cmd { get; set; }

    }
}