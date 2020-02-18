// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6219, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class AuthInputOauth :
        JumpCloud.SDK.V2.Models.IAuthInputOauth,
        JumpCloud.SDK.V2.Models.IAuthInputOauthInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Creates an new <see cref="AuthInputOauth" /> instance.</summary>
        public AuthInputOauth()
        {

        }
    }
    public partial interface IAuthInputOauth :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }

    }
    internal partial interface IAuthInputOauthInternal

    {
        string Code { get; set; }

    }
}