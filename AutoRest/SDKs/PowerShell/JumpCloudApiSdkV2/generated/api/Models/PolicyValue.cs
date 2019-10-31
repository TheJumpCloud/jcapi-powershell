namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>PolicyValue</summary>
    public partial class PolicyValue :
        JumpCloudApiSdkV2.Models.IPolicyValue,
        JumpCloudApiSdkV2.Models.IPolicyValueInternal
    {

        /// <summary>Backing field for <see cref="ConfigFieldId" /> property.</summary>
        private string _configFieldId;

        /// <summary>The ObjectId of the corresponding Policy Template configuration field.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ConfigFieldId { get => this._configFieldId; set => this._configFieldId = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The value for the configuration field for this Policy instance.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PolicyValue" /> instance.</summary>
        public PolicyValue()
        {

        }
    }
    /// PolicyValue
    public partial interface IPolicyValue :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The ObjectId of the corresponding Policy Template configuration field.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ObjectId of the corresponding Policy Template configuration field.",
        SerializedName = @"configFieldID",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigFieldId { get; set; }
        /// <summary>The value for the configuration field for this Policy instance.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value for the configuration field for this Policy instance.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// PolicyValue
    internal partial interface IPolicyValueInternal

    {
        /// <summary>The ObjectId of the corresponding Policy Template configuration field.</summary>
        string ConfigFieldId { get; set; }
        /// <summary>The value for the configuration field for this Policy instance.</summary>
        string Value { get; set; }

    }
}