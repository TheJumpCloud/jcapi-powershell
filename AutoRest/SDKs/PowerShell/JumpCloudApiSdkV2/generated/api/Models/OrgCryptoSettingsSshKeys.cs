namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class OrgCryptoSettingsSshKeys :
        JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeys,
        JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeysInternal
    {

        /// <summary>Backing field for <see cref="KeySize" /> property.</summary>
        private int? _keySize;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? KeySize { get => this._keySize; set => this._keySize = value; }

        /// <summary>Backing field for <see cref="Validate" /> property.</summary>
        private bool? _validate;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? Validate { get => this._validate; set => this._validate = value; }

        /// <summary>Backing field for <see cref="ValidateKeySize" /> property.</summary>
        private bool? _validateKeySize;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? ValidateKeySize { get => this._validateKeySize; set => this._validateKeySize = value; }

        /// <summary>Creates an new <see cref="OrgCryptoSettingsSshKeys" /> instance.</summary>
        public OrgCryptoSettingsSshKeys()
        {

        }
    }
    public partial interface IOrgCryptoSettingsSshKeys :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"keySize",
        PossibleTypes = new [] { typeof(int) })]
        int? KeySize { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"validate",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Validate { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"validateKeySize",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ValidateKeySize { get; set; }

    }
    internal partial interface IOrgCryptoSettingsSshKeysInternal

    {
        int? KeySize { get; set; }

        bool? Validate { get; set; }

        bool? ValidateKeySize { get; set; }

    }
}