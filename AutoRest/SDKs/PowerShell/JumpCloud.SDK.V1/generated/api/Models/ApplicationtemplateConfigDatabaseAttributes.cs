namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationtemplateConfigDatabaseAttributes :
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigDatabaseAttributes,
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigDatabaseAttributesInternal
    {

        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private int? _position;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? Position { get => this._position; set => this._position = value; }

        /// <summary>
        /// Creates an new <see cref="ApplicationtemplateConfigDatabaseAttributes" /> instance.
        /// </summary>
        public ApplicationtemplateConfigDatabaseAttributes()
        {

        }
    }
    public partial interface IApplicationtemplateConfigDatabaseAttributes :
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
    internal partial interface IApplicationtemplateConfigDatabaseAttributesInternal

    {
        int? Position { get; set; }

    }
}