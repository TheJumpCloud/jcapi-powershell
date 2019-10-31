namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class SystemuserputpostPhoneNumbersItem :
        JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem,
        JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItemInternal
    {

        /// <summary>Backing field for <see cref="Number" /> property.</summary>
        private string _number;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Number { get => this._number; set => this._number = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemuserputpostPhoneNumbersItem" /> instance.</summary>
        public SystemuserputpostPhoneNumbersItem()
        {

        }
    }
    public partial interface ISystemuserputpostPhoneNumbersItem :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"number",
        PossibleTypes = new [] { typeof(string) })]
        string Number { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
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