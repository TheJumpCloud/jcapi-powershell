namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class JcSystemInsights :
        JumpCloudApiSdkV1.Models.IJcSystemInsights,
        JumpCloudApiSdkV1.Models.IJcSystemInsightsInternal
    {

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="JcSystemInsights" /> instance.</summary>
        public JcSystemInsights()
        {

        }
    }
    public partial interface IJcSystemInsights :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }

    }
    internal partial interface IJcSystemInsightsInternal

    {
        string State { get; set; }

    }
}