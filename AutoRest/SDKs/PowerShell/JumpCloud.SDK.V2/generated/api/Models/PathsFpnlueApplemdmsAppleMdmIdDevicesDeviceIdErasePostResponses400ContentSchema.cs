// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PathsFpnlueApplemdmsAppleMdmIdDevicesDeviceIdErasePostResponses400ContentSchema :
        JumpCloud.SDK.V2.Models.IPathsFpnlueApplemdmsAppleMdmIdDevicesDeviceIdErasePostResponses400ContentSchema,
        JumpCloud.SDK.V2.Models.IPathsFpnlueApplemdmsAppleMdmIdDevicesDeviceIdErasePostResponses400ContentSchemaInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>
        /// Creates an new <see cref="PathsFpnlueApplemdmsAppleMdmIdDevicesDeviceIdErasePostResponses400ContentSchema" /> instance.
        /// </summary>
        public PathsFpnlueApplemdmsAppleMdmIdDevicesDeviceIdErasePostResponses400ContentSchema()
        {

        }
    }
    public partial interface IPathsFpnlueApplemdmsAppleMdmIdDevicesDeviceIdErasePostResponses400ContentSchema :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    internal partial interface IPathsFpnlueApplemdmsAppleMdmIdDevicesDeviceIdErasePostResponses400ContentSchemaInternal

    {
        string Message { get; set; }

    }
}