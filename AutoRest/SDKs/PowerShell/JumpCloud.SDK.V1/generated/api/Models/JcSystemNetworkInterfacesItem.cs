namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class JcSystemNetworkInterfacesItem :
        JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem,
        JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal
    {

        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private string _address;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Address { get => this._address; set => this._address = value; }

        /// <summary>Backing field for <see cref="Family" /> property.</summary>
        private string _family;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Family { get => this._family; set => this._family = value; }

        /// <summary>Backing field for <see cref="Internal" /> property.</summary>
        private bool? _internal;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Internal { get => this._internal; set => this._internal = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="JcSystemNetworkInterfacesItem" /> instance.</summary>
        public JcSystemNetworkInterfacesItem()
        {

        }
    }
    public partial interface IJcSystemNetworkInterfacesItem :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"address",
        PossibleTypes = new [] { typeof(string) })]
        string Address { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        string Family { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"internal",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Internal { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    internal partial interface IJcSystemNetworkInterfacesItemInternal

    {
        string Address { get; set; }

        string Family { get; set; }

        bool? Internal { get; set; }

        string Name { get; set; }

    }
}