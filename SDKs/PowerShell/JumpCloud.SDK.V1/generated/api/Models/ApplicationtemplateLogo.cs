// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationtemplateLogo :
        JumpCloud.SDK.V1.Models.IApplicationtemplateLogo,
        JumpCloud.SDK.V1.Models.IApplicationtemplateLogoInternal
    {

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Url { get => this._url; set => this._url = value; }

        /// <summary>Creates an new <see cref="ApplicationtemplateLogo" /> instance.</summary>
        public ApplicationtemplateLogo()
        {

        }
    }
    public partial interface IApplicationtemplateLogo :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }

    }
    internal partial interface IApplicationtemplateLogoInternal

    {
        string Url { get; set; }

    }
}