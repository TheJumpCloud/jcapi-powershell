namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Active Directory Input</summary>
    public partial class ActiveDirectoryInput :
        JumpCloudApiSdkV2.Models.IActiveDirectoryInput,
        JumpCloudApiSdkV2.Models.IActiveDirectoryInputInternal
    {

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string _domain;

        /// <summary>Domain name for this Active Directory instance.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Creates an new <see cref="ActiveDirectoryInput" /> instance.</summary>
        public ActiveDirectoryInput()
        {

        }
    }
    /// Active Directory Input
    public partial interface IActiveDirectoryInput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>Domain name for this Active Directory instance.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
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