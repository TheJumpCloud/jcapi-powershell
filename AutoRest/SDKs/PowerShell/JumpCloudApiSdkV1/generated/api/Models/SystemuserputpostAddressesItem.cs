namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class SystemuserputpostAddressesItem :
        JumpCloudApiSdkV1.Models.ISystemuserputpostAddressesItem,
        JumpCloudApiSdkV1.Models.ISystemuserputpostAddressesItemInternal
    {

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Country { get => this._country; set => this._country = value; }

        /// <summary>Backing field for <see cref="ExtendedAddress" /> property.</summary>
        private string _extendedAddress;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string ExtendedAddress { get => this._extendedAddress; set => this._extendedAddress = value; }

        /// <summary>Backing field for <see cref="Locality" /> property.</summary>
        private string _locality;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Locality { get => this._locality; set => this._locality = value; }

        /// <summary>Backing field for <see cref="PoBox" /> property.</summary>
        private string _poBox;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string PoBox { get => this._poBox; set => this._poBox = value; }

        /// <summary>Backing field for <see cref="PostalCode" /> property.</summary>
        private string _postalCode;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string PostalCode { get => this._postalCode; set => this._postalCode = value; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private string _region;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Region { get => this._region; set => this._region = value; }

        /// <summary>Backing field for <see cref="StreetAddress" /> property.</summary>
        private string _streetAddress;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string StreetAddress { get => this._streetAddress; set => this._streetAddress = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemuserputpostAddressesItem" /> instance.</summary>
        public SystemuserputpostAddressesItem()
        {

        }
    }
    public partial interface ISystemuserputpostAddressesItem :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string Country { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"extendedAddress",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedAddress { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"locality",
        PossibleTypes = new [] { typeof(string) })]
        string Locality { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"poBox",
        PossibleTypes = new [] { typeof(string) })]
        string PoBox { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"postalCode",
        PossibleTypes = new [] { typeof(string) })]
        string PostalCode { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string Region { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"streetAddress",
        PossibleTypes = new [] { typeof(string) })]
        string StreetAddress { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    internal partial interface ISystemuserputpostAddressesItemInternal

    {
        string Country { get; set; }

        string ExtendedAddress { get; set; }

        string Locality { get; set; }

        string PoBox { get; set; }

        string PostalCode { get; set; }

        string Region { get; set; }

        string StreetAddress { get; set; }

        string Type { get; set; }

    }
}