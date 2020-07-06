// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class JcSystemInsights :
        JumpCloud.SDK.V1.Models.IJcSystemInsights,
        JumpCloud.SDK.V1.Models.IJcSystemInsightsInternal
    {

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="JcSystemInsights" /> instance.</summary>
        public JcSystemInsights()
        {

        }
    }
    public partial interface IJcSystemInsights :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
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