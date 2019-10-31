namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class SystemuserputPhoneNumbersItem :
        JumpCloudApiSdkV1.Models.ISystemuserputPhoneNumbersItem,
        JumpCloudApiSdkV1.Models.ISystemuserputPhoneNumbersItemInternal
    {

        /// <summary>Backing field for <see cref="Number" /> property.</summary>
        private string _number;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Number { get => this._number; set => this._number = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemuserputPhoneNumbersItem" /> instance.</summary>
        public SystemuserputPhoneNumbersItem()
        {

        }
    }
    public partial interface ISystemuserputPhoneNumbersItem :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"number",
        PossibleTypes = new [] { typeof(string) })]
        string Number { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    internal partial interface ISystemuserputPhoneNumbersItemInternal

    {
        string Number { get; set; }

        string Type { get; set; }

    }
}