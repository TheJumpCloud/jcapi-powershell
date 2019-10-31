namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>FDE</summary>
    public partial class Fde :
        JumpCloudApiSdkV1.Models.IFde,
        JumpCloudApiSdkV1.Models.IFdeInternal
    {

        /// <summary>Backing field for <see cref="Active" /> property.</summary>
        private bool? _active;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Active { get => this._active; set => this._active = value; }

        /// <summary>Backing field for <see cref="KeyPresent" /> property.</summary>
        private bool? _keyPresent;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? KeyPresent { get => this._keyPresent; set => this._keyPresent = value; }

        /// <summary>Creates an new <see cref="Fde" /> instance.</summary>
        public Fde()
        {

        }
    }
    /// FDE
    public partial interface IFde :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"active",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Active { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"keyPresent",
        PossibleTypes = new [] { typeof(bool) })]
        bool? KeyPresent { get; set; }

    }
    /// FDE
    internal partial interface IFdeInternal

    {
        bool? Active { get; set; }

        bool? KeyPresent { get; set; }

    }
}