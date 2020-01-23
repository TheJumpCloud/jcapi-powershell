namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class JcSystemSshdParamsItem :
        JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem,
        JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItemInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="JcSystemSshdParamsItem" /> instance.</summary>
        public JcSystemSshdParamsItem()
        {

        }
    }
    public partial interface IJcSystemSshdParamsItem :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    internal partial interface IJcSystemSshdParamsItemInternal

    {
        string Name { get; set; }

        string Value { get; set; }

    }
}