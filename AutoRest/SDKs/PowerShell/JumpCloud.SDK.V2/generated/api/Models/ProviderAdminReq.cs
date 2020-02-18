// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6219, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>ProviderAdminReq</summary>
    public partial class ProviderAdminReq :
        JumpCloud.SDK.V2.Models.IProviderAdminReq,
        JumpCloud.SDK.V2.Models.IProviderAdminReqInternal
    {

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Backing field for <see cref="EnableMultiFactor" /> property.</summary>
        private bool? _enableMultiFactor;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public bool? EnableMultiFactor { get => this._enableMultiFactor; set => this._enableMultiFactor = value; }

        /// <summary>Backing field for <see cref="Firstname" /> property.</summary>
        private string _firstname;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Firstname { get => this._firstname; set => this._firstname = value; }

        /// <summary>Backing field for <see cref="Lastname" /> property.</summary>
        private string _lastname;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Lastname { get => this._lastname; set => this._lastname = value; }

        /// <summary>Creates an new <see cref="ProviderAdminReq" /> instance.</summary>
        public ProviderAdminReq()
        {

        }
    }
    /// ProviderAdminReq
    public partial interface IProviderAdminReq :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string Email { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMultiFactor",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableMultiFactor { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"firstname",
        PossibleTypes = new [] { typeof(string) })]
        string Firstname { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastname",
        PossibleTypes = new [] { typeof(string) })]
        string Lastname { get; set; }

    }
    /// ProviderAdminReq
    internal partial interface IProviderAdminReqInternal

    {
        string Email { get; set; }

        bool? EnableMultiFactor { get; set; }

        string Firstname { get; set; }

        string Lastname { get; set; }

    }
}