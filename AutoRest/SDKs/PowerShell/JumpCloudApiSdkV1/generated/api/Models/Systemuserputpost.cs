namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>SystemUserPost</summary>
    public partial class Systemuserputpost :
        JumpCloudApiSdkV1.Models.ISystemuserputpost,
        JumpCloudApiSdkV1.Models.ISystemuserputpostInternal
    {

        /// <summary>Backing field for <see cref="AccountLocked" /> property.</summary>
        private bool? _accountLocked;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? AccountLocked { get => this._accountLocked; set => this._accountLocked = value; }

        /// <summary>Backing field for <see cref="Activated" /> property.</summary>
        private bool? _activated;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Activated { get => this._activated; set => this._activated = value; }

        /// <summary>Backing field for <see cref="Addresses" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISystemuserputpostAddressesItem[] _addresses;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISystemuserputpostAddressesItem[] Addresses { get => this._addresses; set => this._addresses = value; }

        /// <summary>Backing field for <see cref="AllowPublicKey" /> property.</summary>
        private bool? _allowPublicKey;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? AllowPublicKey { get => this._allowPublicKey; set => this._allowPublicKey = value; }

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISystemuserputpostAttributesItem[] _attributes;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISystemuserputpostAttributesItem[] Attributes { get => this._attributes; set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private string _company;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Company { get => this._company; set => this._company = value; }

        /// <summary>Backing field for <see cref="CostCenter" /> property.</summary>
        private string _costCenter;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string CostCenter { get => this._costCenter; set => this._costCenter = value; }

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

        /// <summary>Backing field for <see cref="JobTitle" /> property.</summary>
        private string _jobTitle;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string JobTitle { get => this._jobTitle; set => this._jobTitle = value; }

        /// <summary>Internal Acessors for Mfa</summary>
        JumpCloudApiSdkV1.Models.IMfa JumpCloudApiSdkV1.Models.ISystemuserputpostInternal.Mfa { get => (this._mfa = this._mfa ?? new JumpCloudApiSdkV1.Models.Mfa()); set { {_mfa = value;} } }

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

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="PasswordNeverExpires" /> property.</summary>
        private bool? _passwordNeverExpires;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? PasswordNeverExpires { get => this._passwordNeverExpires; set => this._passwordNeverExpires = value; }

        /// <summary>Backing field for <see cref="PasswordlessSudo" /> property.</summary>
        private bool? _passwordlessSudo;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? PasswordlessSudo { get => this._passwordlessSudo; set => this._passwordlessSudo = value; }

        /// <summary>Backing field for <see cref="PhoneNumbers" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISystemuserputpostPhoneNumbersItem[] _phoneNumbers;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISystemuserputpostPhoneNumbersItem[] PhoneNumbers { get => this._phoneNumbers; set => this._phoneNumbers = value; }

        /// <summary>Backing field for <see cref="PublicKey" /> property.</summary>
        private string _publicKey;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string PublicKey { get => this._publicKey; set => this._publicKey = value; }

        /// <summary>Backing field for <see cref="Relationships" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISystemuserputpostRelationshipsItem[] _relationships;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISystemuserputpostRelationshipsItem[] Relationships { get => this._relationships; set => this._relationships = value; }

        /// <summary>Backing field for <see cref="SambaServiceUser" /> property.</summary>
        private bool? _sambaServiceUser;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? SambaServiceUser { get => this._sambaServiceUser; set => this._sambaServiceUser = value; }

        /// <summary>Backing field for <see cref="Sudo" /> property.</summary>
        private bool? _sudo;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Sudo { get => this._sudo; set => this._sudo = value; }

        /// <summary>Backing field for <see cref="Suspended" /> property.</summary>
        private bool? _suspended;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Suspended { get => this._suspended; set => this._suspended = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private string[] _tags;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Tags { get => this._tags; set => this._tags = value; }

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

        /// <summary>Creates an new <see cref="Systemuserputpost" /> instance.</summary>
        public Systemuserputpost()
        {

        }
    }
    /// SystemUserPost
    public partial interface ISystemuserputpost :
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
        SerializedName = @"addresses",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISystemuserputpostAddressesItem) })]
        JumpCloudApiSdkV1.Models.ISystemuserputpostAddressesItem[] Addresses { get; set; }

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
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISystemuserputpostAttributesItem) })]
        JumpCloudApiSdkV1.Models.ISystemuserputpostAttributesItem[] Attributes { get; set; }

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
        Required = true,
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
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }

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
        SerializedName = @"phoneNumbers",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISystemuserputpostPhoneNumbersItem) })]
        JumpCloudApiSdkV1.Models.ISystemuserputpostPhoneNumbersItem[] PhoneNumbers { get; set; }

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
        SerializedName = @"relationships",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISystemuserputpostRelationshipsItem) })]
        JumpCloudApiSdkV1.Models.ISystemuserputpostRelationshipsItem[] Relationships { get; set; }

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
        SerializedName = @"sudo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Sudo { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"suspended",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Suspended { get; set; }

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
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// SystemUserPost
    internal partial interface ISystemuserputpostInternal

    {
        bool? AccountLocked { get; set; }

        bool? Activated { get; set; }

        JumpCloudApiSdkV1.Models.ISystemuserputpostAddressesItem[] Addresses { get; set; }

        bool? AllowPublicKey { get; set; }

        JumpCloudApiSdkV1.Models.ISystemuserputpostAttributesItem[] Attributes { get; set; }

        string Company { get; set; }

        string CostCenter { get; set; }

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

        string Password { get; set; }

        bool? PasswordNeverExpires { get; set; }

        bool? PasswordlessSudo { get; set; }

        JumpCloudApiSdkV1.Models.ISystemuserputpostPhoneNumbersItem[] PhoneNumbers { get; set; }

        string PublicKey { get; set; }

        JumpCloudApiSdkV1.Models.ISystemuserputpostRelationshipsItem[] Relationships { get; set; }

        bool? SambaServiceUser { get; set; }

        bool? Sudo { get; set; }

        bool? Suspended { get; set; }

        string[] Tags { get; set; }

        int? UnixGuid { get; set; }

        int? UnixUid { get; set; }

        string Username { get; set; }

    }
}