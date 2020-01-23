namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class SystemputAgentBoundMessagesItem :
        JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItem,
        JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItemInternal
    {

        /// <summary>Backing field for <see cref="Cmd" /> property.</summary>
        private string _cmd;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Cmd { get => this._cmd; set => this._cmd = value; }

        /// <summary>Creates an new <see cref="SystemputAgentBoundMessagesItem" /> instance.</summary>
        public SystemputAgentBoundMessagesItem()
        {

        }
    }
    public partial interface ISystemputAgentBoundMessagesItem :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
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