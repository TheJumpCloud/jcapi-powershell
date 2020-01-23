namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class SystemuserreturnPhoneNumbersItem :
        JumpCloud.SDK.V1.Models.ISystemuserreturnPhoneNumbersItem,
        JumpCloud.SDK.V1.Models.ISystemuserreturnPhoneNumbersItemInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Number" /> property.</summary>
        private string _number;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Number { get => this._number; set => this._number = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemuserreturnPhoneNumbersItem" /> instance.</summary>
        public SystemuserreturnPhoneNumbersItem()
        {

        }
    }
    public partial interface ISystemuserreturnPhoneNumbersItem :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

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
    internal partial interface ISystemuserreturnPhoneNumbersItemInternal

    {
        string Id { get; set; }

        string Number { get; set; }

        string Type { get; set; }

    }
}