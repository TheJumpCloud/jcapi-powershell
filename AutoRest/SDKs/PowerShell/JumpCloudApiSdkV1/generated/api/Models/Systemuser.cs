namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>SystemUser</summary>
    public partial class Systemuser :
        JumpCloudApiSdkV1.Models.ISystemuser,
        JumpCloudApiSdkV1.Models.ISystemuserInternal
    {

        /// <summary>Backing field for <see cref="AccountLocked" /> property.</summary>
        private bool? _accountLocked;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? AccountLocked { get => this._accountLocked; set => this._accountLocked = value; }

        /// <summary>Backing field for <see cref="Activated" /> property.</summary>
        private bool? _activated;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Activated { get => this._activated; set => this._activated = value; }

        /// <summary>Backing field for <see cref="AllowPublicKey" /> property.</summary>
        private bool? _allowPublicKey;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? AllowPublicKey { get => this._allowPublicKey; set => this._allowPublicKey = value; }

        /// <summary>Backing field for <see cref="AssociatedTagCount" /> property.</summary>
        private int? _associatedTagCount;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? AssociatedTagCount { get => this._associatedTagCount; set => this._associatedTagCount = value; }

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISystemuserAttributesItem[] _attributes;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISystemuserAttributesItem[] Attributes { get => this._attributes; set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private string _company;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Company { get => this._company; set => this._company = value; }

        /// <summary>Backing field for <see cref="CostCenter" /> property.</summary>
        private string _costCenter;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string CostCenter { get => this._costCenter; set => this._costCenter = value; }

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private string _created;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Created { get => this._created; set => this._created = value; }

        /// <summary>Backing field for <see cref="Department" /> property.</summary>
        private string _department;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Department { get => this._department; set => this._department = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Displayname" /> property.</summary>
        private string _displayname;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Displayname { get => this._displayname; set => this._displayname = value; }

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Backing field for <see cref="EmployeeIdentifier" /> property.</summary>
        private string _employeeIdentifier;

        /// <summary>Must be unique per user.</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string EmployeeIdentifier { get => this._employeeIdentifier; set => this._employeeIdentifier = value; }

        /// <summary>Backing field for <see cref="EmployeeType" /> property.</summary>
        private string _employeeType;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string EmployeeType { get => this._employeeType; set => this._employeeType = value; }

        /// <summary>Backing field for <see cref="EnableManagedUid" /> property.</summary>
        private bool? _enableManagedUid;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? EnableManagedUid { get => this._enableManagedUid; set => this._enableManagedUid = value; }

        /// <summary>Backing field for <see cref="EnableUserPortalMultifactor" /> property.</summary>
        private bool? _enableUserPortalMultifactor;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? EnableUserPortalMultifactor { get => this._enableUserPortalMultifactor; set => this._enableUserPortalMultifactor = value; }

        /// <summary>Backing field for <see cref="ExternalDn" /> property.</summary>
        private string _externalDn;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string ExternalDn { get => this._externalDn; set => this._externalDn = value; }

        /// <summary>Backing field for <see cref="ExternalSourceType" /> property.</summary>
        private string _externalSourceType;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string ExternalSourceType { get => this._externalSourceType; set => this._externalSourceType = value; }

        /// <summary>Backing field for <see cref="ExternallyManaged" /> property.</summary>
        private bool? _externallyManaged;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? ExternallyManaged { get => this._externallyManaged; set => this._externallyManaged = value; }

        /// <summary>Backing field for <see cref="Firstname" /> property.</summary>
        private string _firstname;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Firstname { get => this._firstname; set => this._firstname = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="JobTitle" /> property.</summary>
        private string _jobTitle;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string JobTitle { get => this._jobTitle; set => this._jobTitle = value; }

        /// <summary>Internal Acessors for Mfa</summary>
        JumpCloudApiSdkV1.Models.IMfa JumpCloudApiSdkV1.Models.ISystemuserInternal.Mfa { get => (this._mfa = this._mfa ?? new JumpCloudApiSdkV1.Models.Mfa()); set { {_mfa = value;} } }

        /// <summary>Backing field for <see cref="Lastname" /> property.</summary>
        private string _lastname;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Lastname { get => this._lastname; set => this._lastname = value; }

        /// <summary>Backing field for <see cref="LdapBindingUser" /> property.</summary>
        private bool? _ldapBindingUser;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? LdapBindingUser { get => this._ldapBindingUser; set => this._ldapBindingUser = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="Mfa" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IMfa _mfa;

        /// <summary>mfa</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IMfa Mfa { get => (this._mfa = this._mfa ?? new JumpCloudApiSdkV1.Models.Mfa()); set => this._mfa = value; }

        /// <summary>FIXME: Property MfaConfigured is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? MfaConfigured { get => ((JumpCloudApiSdkV1.Models.IMfaInternal)Mfa).Configured; set => ((JumpCloudApiSdkV1.Models.IMfaInternal)Mfa).Configured = value; }

        /// <summary>FIXME: Property MfaExclusion is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? MfaExclusion { get => ((JumpCloudApiSdkV1.Models.IMfaInternal)Mfa).Exclusion; set => ((JumpCloudApiSdkV1.Models.IMfaInternal)Mfa).Exclusion = value; }

        /// <summary>FIXME: Property MfaExclusionUntil is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public global::System.DateTime? MfaExclusionUntil { get => ((JumpCloudApiSdkV1.Models.IMfaInternal)Mfa).ExclusionUntil; set => ((JumpCloudApiSdkV1.Models.IMfaInternal)Mfa).ExclusionUntil = value; }

        /// <summary>Backing field for <see cref="Middlename" /> property.</summary>
        private string _middlename;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Middlename { get => this._middlename; set => this._middlename = value; }

        /// <summary>Backing field for <see cref="PasswordExpirationDate" /> property.</summary>
        private string _passwordExpirationDate;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string PasswordExpirationDate { get => this._passwordExpirationDate; set => this._passwordExpirationDate = value; }

        /// <summary>Backing field for <see cref="PasswordExpired" /> property.</summary>
        private bool? _passwordExpired;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? PasswordExpired { get => this._passwordExpired; set => this._passwordExpired = value; }

        /// <summary>Backing field for <see cref="PasswordNeverExpires" /> property.</summary>
        private bool? _passwordNeverExpires;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? PasswordNeverExpires { get => this._passwordNeverExpires; set => this._passwordNeverExpires = value; }

        /// <summary>Backing field for <see cref="PasswordlessSudo" /> property.</summary>
        private bool? _passwordlessSudo;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? PasswordlessSudo { get => this._passwordlessSudo; set => this._passwordlessSudo = value; }

        /// <summary>Backing field for <see cref="PublicKey" /> property.</summary>
        private string _publicKey;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string PublicKey { get => this._publicKey; set => this._publicKey = value; }

        /// <summary>Backing field for <see cref="SambaServiceUser" /> property.</summary>
        private bool? _sambaServiceUser;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? SambaServiceUser { get => this._sambaServiceUser; set => this._sambaServiceUser = value; }

        /// <summary>Backing field for <see cref="SshKeys" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISshkeylist[] _sshKeys;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISshkeylist[] SshKeys { get => this._sshKeys; set => this._sshKeys = value; }

        /// <summary>Backing field for <see cref="Sudo" /> property.</summary>
        private bool? _sudo;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Sudo { get => this._sudo; set => this._sudo = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private string[] _tags;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Tags { get => this._tags; set => this._tags = value; }

        /// <summary>Backing field for <see cref="TotpEnabled" /> property.</summary>
        private bool? _totpEnabled;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? TotpEnabled { get => this._totpEnabled; set => this._totpEnabled = value; }

        /// <summary>Backing field for <see cref="UnixGuid" /> property.</summary>
        private int? _unixGuid;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? UnixGuid { get => this._unixGuid; set => this._unixGuid = value; }

        /// <summary>Backing field for <see cref="UnixUid" /> property.</summary>
        private int? _unixUid;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? UnixUid { get => this._unixUid; set => this._unixUid = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="Systemuser" /> instance.</summary>
        public Systemuser()
        {

        }
    }
    /// SystemUser
    public partial interface ISystemuser :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"account_locked",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AccountLocked { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"activated",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Activated { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allow_public_key",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowPublicKey { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"associatedTagCount",
        PossibleTypes = new [] { typeof(int) })]
        int? AssociatedTagCount { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISystemuserAttributesItem) })]
        JumpCloudApiSdkV1.Models.ISystemuserAttributesItem[] Attributes { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"company",
        PossibleTypes = new [] { typeof(string) })]
        string Company { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"costCenter",
        PossibleTypes = new [] { typeof(string) })]
        string CostCenter { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(string) })]
        string Created { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"department",
        PossibleTypes = new [] { typeof(string) })]
        string Department { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayname",
        PossibleTypes = new [] { typeof(string) })]
        string Displayname { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string Email { get; set; }
        /// <summary>Must be unique per user.</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Must be unique per user. ",
        SerializedName = @"employeeIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string EmployeeIdentifier { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"employeeType",
        PossibleTypes = new [] { typeof(string) })]
        string EmployeeType { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enable_managed_uid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableManagedUid { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enable_user_portal_multifactor",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableUserPortalMultifactor { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"external_dn",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalDn { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"external_source_type",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalSourceType { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"externally_managed",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ExternallyManaged { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"firstname",
        PossibleTypes = new [] { typeof(string) })]
        string Firstname { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"jobTitle",
        PossibleTypes = new [] { typeof(string) })]
        string JobTitle { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastname",
        PossibleTypes = new [] { typeof(string) })]
        string Lastname { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ldap_binding_user",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LdapBindingUser { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"configured",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MfaConfigured { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MfaExclusion { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusionUntil",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MfaExclusionUntil { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"middlename",
        PossibleTypes = new [] { typeof(string) })]
        string Middlename { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password_expiration_date",
        PossibleTypes = new [] { typeof(string) })]
        string PasswordExpirationDate { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password_expired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordExpired { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password_never_expires",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordNeverExpires { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"passwordless_sudo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordlessSudo { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"public_key",
        PossibleTypes = new [] { typeof(string) })]
        string PublicKey { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"samba_service_user",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SambaServiceUser { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ssh_keys",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISshkeylist) })]
        JumpCloudApiSdkV1.Models.ISshkeylist[] SshKeys { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sudo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Sudo { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string[] Tags { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"totp_enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TotpEnabled { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"unix_guid",
        PossibleTypes = new [] { typeof(int) })]
        int? UnixGuid { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"unix_uid",
        PossibleTypes = new [] { typeof(int) })]
        int? UnixUid { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// SystemUser
    internal partial interface ISystemuserInternal

    {
        bool? AccountLocked { get; set; }

        bool? Activated { get; set; }

        bool? AllowPublicKey { get; set; }

        int? AssociatedTagCount { get; set; }

        JumpCloudApiSdkV1.Models.ISystemuserAttributesItem[] Attributes { get; set; }

        string Company { get; set; }

        string CostCenter { get; set; }

        string Created { get; set; }

        string Department { get; set; }

        string Description { get; set; }

        string Displayname { get; set; }

        string Email { get; set; }
        /// <summary>Must be unique per user.</summary>
        string EmployeeIdentifier { get; set; }

        string EmployeeType { get; set; }

        bool? EnableManagedUid { get; set; }

        bool? EnableUserPortalMultifactor { get; set; }

        string ExternalDn { get; set; }

        string ExternalSourceType { get; set; }

        bool? ExternallyManaged { get; set; }

        string Firstname { get; set; }

        string Id { get; set; }

        string JobTitle { get; set; }

        string Lastname { get; set; }

        bool? LdapBindingUser { get; set; }

        string Location { get; set; }
        /// <summary>mfa</summary>
        JumpCloudApiSdkV1.Models.IMfa Mfa { get; set; }

        bool? MfaConfigured { get; set; }

        bool? MfaExclusion { get; set; }

        global::System.DateTime? MfaExclusionUntil { get; set; }

        string Middlename { get; set; }

        string PasswordExpirationDate { get; set; }

        bool? PasswordExpired { get; set; }

        bool? PasswordNeverExpires { get; set; }

        bool? PasswordlessSudo { get; set; }

        string PublicKey { get; set; }

        bool? SambaServiceUser { get; set; }

        JumpCloudApiSdkV1.Models.ISshkeylist[] SshKeys { get; set; }

        bool? Sudo { get; set; }

        string[] Tags { get; set; }

        bool? TotpEnabled { get; set; }

        int? UnixGuid { get; set; }

        int? UnixUid { get; set; }

        string Username { get; set; }

    }
}