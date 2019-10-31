namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>SystemFDEKey</summary>
    public partial class Systemfdekey :
        JumpCloudApiSdkV2.Models.ISystemfdekey,
        JumpCloudApiSdkV2.Models.ISystemfdekeyInternal
    {

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private string _key;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Key { get => this._key; set => this._key = value; }

        /// <summary>Creates an new <see cref="Systemfdekey" /> instance.</summary>
        public Systemfdekey()
        {

        }
    }
    /// SystemFDEKey
    public partial interface ISystemfdekey :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string Key { get; set; }

    }
    /// SystemFDEKey
    internal partial interface ISystemfdekeyInternal

    {
        string Key { get; set; }

    }
}