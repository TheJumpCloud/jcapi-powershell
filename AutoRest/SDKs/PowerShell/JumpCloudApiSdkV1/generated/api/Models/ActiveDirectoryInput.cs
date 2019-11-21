namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>Active Directory Input</summary>
    public partial class ActiveDirectoryInput :
        JumpCloudApiSdkV1.Models.IActiveDirectoryInput,
        JumpCloudApiSdkV1.Models.IActiveDirectoryInputInternal
    {

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string _domain;

        /// <summary>Domain name for this Active Directory instance.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Creates an new <see cref="ActiveDirectoryInput" /> instance.</summary>
        public ActiveDirectoryInput()
        {

        }
    }
    /// Active Directory Input
    public partial interface IActiveDirectoryInput :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>Domain name for this Active Directory instance.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
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