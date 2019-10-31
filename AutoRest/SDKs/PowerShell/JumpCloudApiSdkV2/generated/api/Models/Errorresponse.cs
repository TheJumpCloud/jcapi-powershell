namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>ErrorResponse</summary>
    public partial class Errorresponse :
        JumpCloudApiSdkV2.Models.IErrorresponse,
        JumpCloudApiSdkV2.Models.IErrorresponseInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="Errorresponse" /> instance.</summary>
        public Errorresponse()
        {

        }
    }
    /// ErrorResponse
    public partial interface IErrorresponse :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
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