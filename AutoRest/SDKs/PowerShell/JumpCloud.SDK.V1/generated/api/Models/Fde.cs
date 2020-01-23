namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>FDE</summary>
    public partial class Fde :
        JumpCloud.SDK.V1.Models.IFde,
        JumpCloud.SDK.V1.Models.IFdeInternal
    {

        /// <summary>Backing field for <see cref="Active" /> property.</summary>
        private bool? _active;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Active { get => this._active; set => this._active = value; }

        /// <summary>Backing field for <see cref="KeyPresent" /> property.</summary>
        private bool? _keyPresent;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? KeyPresent { get => this._keyPresent; set => this._keyPresent = value; }

        /// <summary>Creates an new <see cref="Fde" /> instance.</summary>
        public Fde()
        {

        }
    }
    /// FDE
    public partial interface IFde :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"active",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Active { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
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