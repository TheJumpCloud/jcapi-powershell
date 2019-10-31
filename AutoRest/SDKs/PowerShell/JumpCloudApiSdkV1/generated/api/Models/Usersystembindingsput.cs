namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>UserSystemBindingsPut</summary>
    public partial class Usersystembindingsput :
        JumpCloudApiSdkV1.Models.IUsersystembindingsput,
        JumpCloudApiSdkV1.Models.IUsersystembindingsputInternal
    {

        /// <summary>Backing field for <see cref="Add" /> property.</summary>
        private string[] _add;

        /// <summary>The list of system ids to be added to this user.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Add { get => this._add; set => this._add = value; }

        /// <summary>Backing field for <see cref="Remove" /> property.</summary>
        private string[] _remove;

        /// <summary>The list of system ids to be removed from this user.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Remove { get => this._remove; set => this._remove = value; }

        /// <summary>Creates an new <see cref="Usersystembindingsput" /> instance.</summary>
        public Usersystembindingsput()
        {

        }
    }
    /// UserSystemBindingsPut
    public partial interface IUsersystembindingsput :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>The list of system ids to be added to this user.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The list of system ids to be added to this user.",
        SerializedName = @"add",
        PossibleTypes = new [] { typeof(string) })]
        string[] Add { get; set; }
        /// <summary>The list of system ids to be removed from this user.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The list of system ids to be removed from this user.",
        SerializedName = @"remove",
        PossibleTypes = new [] { typeof(string) })]
        string[] Remove { get; set; }

    }
    /// UserSystemBindingsPut
    internal partial interface IUsersystembindingsputInternal

    {
        /// <summary>The list of system ids to be added to this user.</summary>
        string[] Add { get; set; }
        /// <summary>The list of system ids to be removed from this user.</summary>
        string[] Remove { get; set; }

    }
}