namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>SystemGroupData</summary>
    public partial class SystemGroupData :
        JumpCloud.SDK.V2.Models.ISystemGroupData,
        JumpCloud.SDK.V2.Models.ISystemGroupDataInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Display name of a System Group.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="SystemGroupData" /> instance.</summary>
        public SystemGroupData()
        {

        }
    }
    /// SystemGroupData
    public partial interface ISystemGroupData :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>Display name of a System Group.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
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