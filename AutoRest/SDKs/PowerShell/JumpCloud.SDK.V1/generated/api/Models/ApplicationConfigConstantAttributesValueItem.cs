namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationConfigConstantAttributesValueItem :
        JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesValueItem,
        JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesValueItemInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ReadOnly" /> property.</summary>
        private bool? _readOnly;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? ReadOnly { get => this._readOnly; set => this._readOnly = value; }

        /// <summary>Backing field for <see cref="Required" /> property.</summary>
        private bool? _required;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Required { get => this._required; set => this._required = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Backing field for <see cref="Visible" /> property.</summary>
        private bool? _visible;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Visible { get => this._visible; set => this._visible = value; }

        /// <summary>
        /// Creates an new <see cref="ApplicationConfigConstantAttributesValueItem" /> instance.
        /// </summary>
        public ApplicationConfigConstantAttributesValueItem()
        {

        }
    }
    public partial interface IApplicationConfigConstantAttributesValueItem :
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
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReadOnly { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Required { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Visible { get; set; }

    }
    internal partial interface IApplicationConfigConstantAttributesValueItemInternal

    {
        string Name { get; set; }

        bool? ReadOnly { get; set; }

        bool? Required { get; set; }

        string Value { get; set; }

        bool? Visible { get; set; }

    }
}