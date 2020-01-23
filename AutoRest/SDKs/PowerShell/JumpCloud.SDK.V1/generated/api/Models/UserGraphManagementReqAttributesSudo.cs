namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class UserGraphManagementReqAttributesSudo :
        JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudo,
        JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudoInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="WithoutPassword" /> property.</summary>
        private bool? _withoutPassword;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? WithoutPassword { get => this._withoutPassword; set => this._withoutPassword = value; }

        /// <summary>Creates an new <see cref="UserGraphManagementReqAttributesSudo" /> instance.</summary>
        public UserGraphManagementReqAttributesSudo()
        {

        }
    }
    public partial interface IUserGraphManagementReqAttributesSudo :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"withoutPassword",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WithoutPassword { get; set; }

    }
    internal partial interface IUserGraphManagementReqAttributesSudoInternal

    {
        bool? Enabled { get; set; }

        bool? WithoutPassword { get; set; }

    }
}