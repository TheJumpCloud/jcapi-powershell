namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>ErrorResponse</summary>
    public partial class Errorresponse :
        JumpCloudApiSdkV1.Models.IErrorresponse,
        JumpCloudApiSdkV1.Models.IErrorresponseInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="Errorresponse" /> instance.</summary>
        public Errorresponse()
        {

        }
    }
    /// ErrorResponse
    public partial interface IErrorresponse :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
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