namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Org Crypto Settings</summary>
    public partial class OrgCryptoSettings :
        JumpCloudApiSdkV2.Models.IOrgCryptoSettings,
        JumpCloudApiSdkV2.Models.IOrgCryptoSettingsInternal
    {

        /// <summary>Internal Acessors for SshKeys</summary>
        JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeys JumpCloudApiSdkV2.Models.IOrgCryptoSettingsInternal.SshKeys { get => (this._sshKeys = this._sshKeys ?? new JumpCloudApiSdkV2.Models.OrgCryptoSettingsSshKeys()); set { {_sshKeys = value;} } }

        /// <summary>FIXME: Property SshKeySize is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public int? SshKeySize { get => ((JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).KeySize; set => ((JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).KeySize = value; }

        /// <summary>FIXME: Property SshKeyValidate is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? SshKeyValidate { get => ((JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).Validate; set => ((JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).Validate = value; }

        /// <summary>FIXME: Property SshKeyValidateKeySize is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? SshKeyValidateKeySize { get => ((JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).ValidateKeySize; set => ((JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).ValidateKeySize = value; }

        /// <summary>Backing field for <see cref="SshKeys" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeys _sshKeys;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeys SshKeys { get => (this._sshKeys = this._sshKeys ?? new JumpCloudApiSdkV2.Models.OrgCryptoSettingsSshKeys()); set => this._sshKeys = value; }

        /// <summary>Creates an new <see cref="OrgCryptoSettings" /> instance.</summary>
        public OrgCryptoSettings()
        {

        }
    }
    /// Org Crypto Settings
    public partial interface IOrgCryptoSettings :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"keySize",
        PossibleTypes = new [] { typeof(int) })]
        int? SshKeySize { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"validate",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SshKeyValidate { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"validateKeySize",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SshKeyValidateKeySize { get; set; }

    }
    /// Org Crypto Settings
    internal partial interface IOrgCryptoSettingsInternal

    {
        int? SshKeySize { get; set; }

        bool? SshKeyValidate { get; set; }

        bool? SshKeyValidateKeySize { get; set; }

        JumpCloudApiSdkV2.Models.IOrgCryptoSettingsSshKeys SshKeys { get; set; }

    }
}