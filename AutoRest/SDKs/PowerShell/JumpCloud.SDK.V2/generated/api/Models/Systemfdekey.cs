namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>SystemFDEKey</summary>
    public partial class Systemfdekey :
        JumpCloud.SDK.V2.Models.ISystemfdekey,
        JumpCloud.SDK.V2.Models.ISystemfdekeyInternal
    {

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private string _key;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Key { get => this._key; set => this._key = value; }

        /// <summary>Creates an new <see cref="Systemfdekey" /> instance.</summary>
        public Systemfdekey()
        {

        }
    }
    /// SystemFDEKey
    public partial interface ISystemfdekey :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
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