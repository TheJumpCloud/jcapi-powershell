// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class SystemuserputpostPhoneNumbersItem :
        JumpCloud.SDK.V1.Models.ISystemuserputpostPhoneNumbersItem,
        JumpCloud.SDK.V1.Models.ISystemuserputpostPhoneNumbersItemInternal
    {

        /// <summary>Backing field for <see cref="Number" /> property.</summary>
        private string _number;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Number { get => this._number; set => this._number = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemuserputpostPhoneNumbersItem" /> instance.</summary>
        public SystemuserputpostPhoneNumbersItem()
        {

        }
    }
    public partial interface ISystemuserputpostPhoneNumbersItem :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"number",
        PossibleTypes = new [] { typeof(string) })]
        string Number { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    internal partial interface ISystemuserputpostPhoneNumbersItemInternal

    {
        string Number { get; set; }

        string Type { get; set; }

    }
}