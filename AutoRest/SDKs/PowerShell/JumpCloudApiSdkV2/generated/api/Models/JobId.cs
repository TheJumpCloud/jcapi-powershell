namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Job ID</summary>
    public partial class JobId :
        JumpCloudApiSdkV2.Models.IJobId,
        JumpCloudApiSdkV2.Models.IJobIdInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="JobId" /> instance.</summary>
        public JobId()
        {

        }
    }
    /// Job ID
    public partial interface IJobId :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Job ID
    internal partial interface IJobIdInternal

    {
        string Id { get; set; }

    }
}