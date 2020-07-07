// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationConfigDatabaseAttributes :
        JumpCloud.SDK.V1.Models.IApplicationConfigDatabaseAttributes,
        JumpCloud.SDK.V1.Models.IApplicationConfigDatabaseAttributesInternal
    {

        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private int? _position;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? Position { get => this._position; set => this._position = value; }

        /// <summary>Creates an new <see cref="ApplicationConfigDatabaseAttributes" /> instance.</summary>
        public ApplicationConfigDatabaseAttributes()
        {

        }
    }
    public partial interface IApplicationConfigDatabaseAttributes :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? Position { get; set; }

    }
    internal partial interface IApplicationConfigDatabaseAttributesInternal

    {
        int? Position { get; set; }

    }
}