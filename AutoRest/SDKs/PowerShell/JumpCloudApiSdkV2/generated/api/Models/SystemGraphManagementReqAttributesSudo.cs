namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class SystemGraphManagementReqAttributesSudo :
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudo,
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudoInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="WithoutPassword" /> property.</summary>
        private bool? _withoutPassword;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? WithoutPassword { get => this._withoutPassword; set => this._withoutPassword = value; }

        /// <summary>Creates an new <see cref="SystemGraphManagementReqAttributesSudo" /> instance.</summary>
        public SystemGraphManagementReqAttributesSudo()
        {

        }
    }
    public partial interface ISystemGraphManagementReqAttributesSudo :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"withoutPassword",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WithoutPassword { get; set; }

    }
    internal partial interface ISystemGraphManagementReqAttributesSudoInternal

    {
        bool? Enabled { get; set; }

        bool? WithoutPassword { get; set; }

    }
}