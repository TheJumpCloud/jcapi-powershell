namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Workday Request</summary>
    public partial class WorkdayRequest :
        JumpCloudApiSdkV2.Models.IWorkdayRequest,
        JumpCloudApiSdkV2.Models.IWorkdayRequestInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ObjectId" /> property.</summary>
        private string _objectId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ObjectId { get => this._objectId; set => this._objectId = value; }

        /// <summary>Creates an new <see cref="WorkdayRequest" /> instance.</summary>
        public WorkdayRequest()
        {

        }
    }
    /// Workday Request
    public partial interface IWorkdayRequest :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectId { get; set; }

    }
    /// Workday Request
    internal partial interface IWorkdayRequestInternal

    {
        string Name { get; set; }

        string ObjectId { get; set; }

    }
}