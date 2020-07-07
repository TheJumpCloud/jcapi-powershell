// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Active Directory Input</summary>
    public partial class ActiveDirectoryInput :
        JumpCloud.SDK.V2.Models.IActiveDirectoryInput,
        JumpCloud.SDK.V2.Models.IActiveDirectoryInputInternal
    {

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string _domain;

        /// <summary>Domain name for this Active Directory instance.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Creates an new <see cref="ActiveDirectoryInput" /> instance.</summary>
        public ActiveDirectoryInput()
        {

        }
    }
    /// Active Directory Input
    public partial interface IActiveDirectoryInput :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>Domain name for this Active Directory instance.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Domain name for this Active Directory instance.",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string Domain { get; set; }

    }
    /// Active Directory Input
    internal partial interface IActiveDirectoryInputInternal

    {
        /// <summary>Domain name for this Active Directory instance.</summary>
        string Domain { get; set; }

    }
}