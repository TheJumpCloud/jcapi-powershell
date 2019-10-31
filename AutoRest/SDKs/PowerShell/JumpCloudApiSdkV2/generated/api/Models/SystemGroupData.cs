namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>SystemGroupData</summary>
    public partial class SystemGroupData :
        JumpCloudApiSdkV2.Models.ISystemGroupData,
        JumpCloudApiSdkV2.Models.ISystemGroupDataInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Display name of a System Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="SystemGroupData" /> instance.</summary>
        public SystemGroupData()
        {

        }
    }
    /// SystemGroupData
    public partial interface ISystemGroupData :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>Display name of a System Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Display name of a System Group.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// SystemGroupData
    internal partial interface ISystemGroupDataInternal

    {
        /// <summary>Display name of a System Group.</summary>
        string Name { get; set; }

    }
}