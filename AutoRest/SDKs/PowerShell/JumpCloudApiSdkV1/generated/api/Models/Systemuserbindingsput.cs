namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>SystemUserBindingsPut</summary>
    public partial class Systemuserbindingsput :
        JumpCloudApiSdkV1.Models.ISystemuserbindingsput,
        JumpCloudApiSdkV1.Models.ISystemuserbindingsputInternal
    {

        /// <summary>Backing field for <see cref="Add" /> property.</summary>
        private string[] _add;

        /// <summary>The list of systemuser ids to be added to this system.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Add { get => this._add; set => this._add = value; }

        /// <summary>Backing field for <see cref="Remove" /> property.</summary>
        private string[] _remove;

        /// <summary>The list of systemuser ids to be removed from this system.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Remove { get => this._remove; set => this._remove = value; }

        /// <summary>Creates an new <see cref="Systemuserbindingsput" /> instance.</summary>
        public Systemuserbindingsput()
        {

        }
    }
    /// SystemUserBindingsPut
    public partial interface ISystemuserbindingsput :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>The list of systemuser ids to be added to this system.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The list of systemuser ids to be added to this system.",
        SerializedName = @"add",
        PossibleTypes = new [] { typeof(string) })]
        string[] Add { get; set; }
        /// <summary>The list of systemuser ids to be removed from this system.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The list of systemuser ids to be removed from this system.",
        SerializedName = @"remove",
        PossibleTypes = new [] { typeof(string) })]
        string[] Remove { get; set; }

    }
    /// SystemUserBindingsPut
    internal partial interface ISystemuserbindingsputInternal

    {
        /// <summary>The list of systemuser ids to be added to this system.</summary>
        string[] Add { get; set; }
        /// <summary>The list of systemuser ids to be removed from this system.</summary>
        string[] Remove { get; set; }

    }
}