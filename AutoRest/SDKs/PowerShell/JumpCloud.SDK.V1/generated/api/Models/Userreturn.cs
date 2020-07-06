// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>UserReturn</summary>
    public partial class Userreturn :
        JumpCloud.SDK.V1.Models.IUserreturn,
        JumpCloud.SDK.V1.Models.IUserreturnInternal
    {

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private string _created;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Created { get => this._created; set => this._created = value; }

        /// <summary>Backing field for <see cref="DisableIntroduction" /> property.</summary>
        private bool? _disableIntroduction;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? DisableIntroduction { get => this._disableIntroduction; set => this._disableIntroduction = value; }

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Backing field for <see cref="EnableMultiFactor" /> property.</summary>
        private bool? _enableMultiFactor;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableMultiFactor { get => this._enableMultiFactor; set => this._enableMultiFactor = value; }

        /// <summary>Backing field for <see cref="EnableWhatsNew" /> property.</summary>
        private bool? _enableWhatsNew;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableWhatsNew { get => this._enableWhatsNew; set => this._enableWhatsNew = value; }

        /// <summary>Backing field for <see cref="Firstname" /> property.</summary>
        private string _firstname;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Firstname { get => this._firstname; set => this._firstname = value; }

        /// <summary>Backing field for <see cref="GrowthData" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IUserreturnGrowthData _growthData;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IUserreturnGrowthData GrowthData { get => (this._growthData = this._growthData ?? new JumpCloud.SDK.V1.Models.UserreturnGrowthData()); set => this._growthData = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LastWhatsNewChecked" /> property.</summary>
        private string _lastWhatsNewChecked;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string LastWhatsNewChecked { get => this._lastWhatsNewChecked; set => this._lastWhatsNewChecked = value; }

        /// <summary>Backing field for <see cref="Lastname" /> property.</summary>
        private string _lastname;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Lastname { get => this._lastname; set => this._lastname = value; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="Provider" /> property.</summary>
        private string _provider;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Provider { get => this._provider; set => this._provider = value; }

        /// <summary>Backing field for <see cref="Role" /> property.</summary>
        private string _role;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Role { get => this._role; set => this._role = value; }

        /// <summary>Backing field for <see cref="RoleName" /> property.</summary>
        private string _roleName;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string RoleName { get => this._roleName; set => this._roleName = value; }

        /// <summary>Backing field for <see cref="UsersTimeZone" /> property.</summary>
        private string _usersTimeZone;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string UsersTimeZone { get => this._usersTimeZone; set => this._usersTimeZone = value; }

        /// <summary>Creates an new <see cref="Userreturn" /> instance.</summary>
        public Userreturn()
        {

        }
    }
    /// UserReturn
    public partial interface IUserreturn :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(string) })]
        string Created { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"disableIntroduction",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisableIntroduction { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string Email { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMultiFactor",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableMultiFactor { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableWhatsNew",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableWhatsNew { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"firstname",
        PossibleTypes = new [] { typeof(string) })]
        string Firstname { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"growthData",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IUserreturnGrowthData) })]
        JumpCloud.SDK.V1.Models.IUserreturnGrowthData GrowthData { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastWhatsNewChecked",
        PossibleTypes = new [] { typeof(string) })]
        string LastWhatsNewChecked { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastname",
        PossibleTypes = new [] { typeof(string) })]
        string Lastname { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        string Organization { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string Provider { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"role",
        PossibleTypes = new [] { typeof(string) })]
        string Role { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"roleName",
        PossibleTypes = new [] { typeof(string) })]
        string RoleName { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"usersTimeZone",
        PossibleTypes = new [] { typeof(string) })]
        string UsersTimeZone { get; set; }

    }
    /// UserReturn
    internal partial interface IUserreturnInternal

    {
        string Created { get; set; }

        bool? DisableIntroduction { get; set; }

        string Email { get; set; }

        bool? EnableMultiFactor { get; set; }

        bool? EnableWhatsNew { get; set; }

        string Firstname { get; set; }

        JumpCloud.SDK.V1.Models.IUserreturnGrowthData GrowthData { get; set; }

        string Id { get; set; }

        string LastWhatsNewChecked { get; set; }

        string Lastname { get; set; }

        string Organization { get; set; }

        string Provider { get; set; }

        string Role { get; set; }

        string RoleName { get; set; }

        string UsersTimeZone { get; set; }

    }
}