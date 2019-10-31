namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class ApplicationConfigDatabaseAttributes :
        JumpCloudApiSdkV1.Models.IApplicationConfigDatabaseAttributes,
        JumpCloudApiSdkV1.Models.IApplicationConfigDatabaseAttributesInternal
    {

        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private int? _position;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? Position { get => this._position; set => this._position = value; }

        /// <summary>Creates an new <see cref="ApplicationConfigDatabaseAttributes" /> instance.</summary>
        public ApplicationConfigDatabaseAttributes()
        {

        }
    }
    public partial interface IApplicationConfigDatabaseAttributes :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
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