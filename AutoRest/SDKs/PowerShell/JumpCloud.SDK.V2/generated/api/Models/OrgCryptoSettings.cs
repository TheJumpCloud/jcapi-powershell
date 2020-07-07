// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Org Crypto Settings</summary>
    public partial class OrgCryptoSettings :
        JumpCloud.SDK.V2.Models.IOrgCryptoSettings,
        JumpCloud.SDK.V2.Models.IOrgCryptoSettingsInternal
    {

        /// <summary>Internal Acessors for SshKeys</summary>
        JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeys JumpCloud.SDK.V2.Models.IOrgCryptoSettingsInternal.SshKeys { get => (this._sshKeys = this._sshKeys ?? new JumpCloud.SDK.V2.Models.OrgCryptoSettingsSshKeys()); set { {_sshKeys = value;} } }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public int? SshKeySize { get => ((JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).KeySize; set => ((JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).KeySize = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? SshKeyValidate { get => ((JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).Validate; set => ((JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).Validate = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? SshKeyValidateKeySize { get => ((JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).ValidateKeySize; set => ((JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeysInternal)SshKeys).ValidateKeySize = value; }

        /// <summary>Backing field for <see cref="SshKeys" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeys _sshKeys;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeys SshKeys { get => (this._sshKeys = this._sshKeys ?? new JumpCloud.SDK.V2.Models.OrgCryptoSettingsSshKeys()); set => this._sshKeys = value; }

        /// <summary>Creates an new <see cref="OrgCryptoSettings" /> instance.</summary>
        public OrgCryptoSettings()
        {

        }
    }
    /// Org Crypto Settings
    public partial interface IOrgCryptoSettings :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"keySize",
        PossibleTypes = new [] { typeof(int) })]
        int? SshKeySize { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"validate",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SshKeyValidate { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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

        JumpCloud.SDK.V2.Models.IOrgCryptoSettingsSshKeys SshKeys { get; set; }

    }
}