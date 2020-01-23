namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Job ID</summary>
    public partial class JobId :
        JumpCloud.SDK.V2.Models.IJobId,
        JumpCloud.SDK.V2.Models.IJobIdInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="JobId" /> instance.</summary>
        public JobId()
        {

        }
    }
    /// Job ID
    public partial interface IJobId :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
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