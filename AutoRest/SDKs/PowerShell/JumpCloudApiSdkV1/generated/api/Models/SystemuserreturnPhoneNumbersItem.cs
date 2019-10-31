namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class SystemuserreturnPhoneNumbersItem :
        JumpCloudApiSdkV1.Models.ISystemuserreturnPhoneNumbersItem,
        JumpCloudApiSdkV1.Models.ISystemuserreturnPhoneNumbersItemInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Number" /> property.</summary>
        private string _number;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Number { get => this._number; set => this._number = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemuserreturnPhoneNumbersItem" /> instance.</summary>
        public SystemuserreturnPhoneNumbersItem()
        {

        }
    }
    public partial interface ISystemuserreturnPhoneNumbersItem :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

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
    internal partial interface ISystemuserreturnPhoneNumbersItemInternal

    {
        string Id { get; set; }

        string Number { get; set; }

        string Type { get; set; }

    }
}