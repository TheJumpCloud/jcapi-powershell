namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>EmailRequest</summary>
    public partial class Emailrequest :
        JumpCloudApiSdkV2.Models.IEmailrequest,
        JumpCloudApiSdkV2.Models.IEmailrequestInternal
    {

        /// <summary>Backing field for <see cref="EmailType" /> property.</summary>
        private string _emailType;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string EmailType { get => this._emailType; set => this._emailType = value; }

        /// <summary>Creates an new <see cref="Emailrequest" /> instance.</summary>
        public Emailrequest()
        {

        }
    }
    /// EmailRequest
    public partial interface IEmailrequest :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailType",
        PossibleTypes = new [] { typeof(string) })]
        string EmailType { get; set; }

    }
    /// EmailRequest
    internal partial interface IEmailrequestInternal

    {
        string EmailType { get; set; }

    }
}