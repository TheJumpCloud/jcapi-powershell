namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>ErrorResponse</summary>
    public partial class Errorresponse :
        JumpCloud.SDK.V1.Models.IErrorresponse,
        JumpCloud.SDK.V1.Models.IErrorresponseInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="Errorresponse" /> instance.</summary>
        public Errorresponse()
        {

        }
    }
    /// ErrorResponse
    public partial interface IErrorresponse :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// ErrorResponse
    internal partial interface IErrorresponseInternal

    {
        string Message { get; set; }

    }
}