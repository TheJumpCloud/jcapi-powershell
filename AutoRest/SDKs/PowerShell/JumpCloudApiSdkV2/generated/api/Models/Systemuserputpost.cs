namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>SystemUserPost</summary>
    public partial class Systemuserputpost :
        JumpCloudApiSdkV2.Models.ISystemuserputpost,
        JumpCloudApiSdkV2.Models.ISystemuserputpostInternal
    {

        /// <summary>Backing field for <see cref="AccountLocked" /> property.</summary>
        private bool? _accountLocked;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? AccountLocked { get => this._accountLocked; set => this._accountLocked = value; }

        /// <summary>Backing field for <see cref="Activated" /> property.</summary>
        private bool? _activated;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? Activated { get => this._activated; set => this._activated = value; }

        /// <summary>Backing field for <see cref="Addresses" /> property.</summary>
        private JumpCloudApiSdkV2.Models.ISystemuserputpostAddressesItem[] _addresses;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.ISystemuserputpostAddressesItem[] Addresses { get => this._addresses; set => this._addresses = value; }

        /// <summary>Backing field for <see cref="AllowPublicKey" /> property.</summary>
        private bool? _allowPublicKey;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? AllowPublicKey { get => this._allowPublicKey; set => this._allowPublicKey = value; }

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV2.Models.ISystemuserputpostAttributesItem[] _attributes;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.ISystemuserputpostAttributesItem[] Attributes { get => this._attributes; set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private string _company;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Company { get => this._company; set => this._company = value; }

        /// <summary>Backing field for <see cref="CostCenter" /> property.</summary>
        private string _costCenter;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CostCenter { get => this._costCenter; set => this._costCenter = value; }

        /// <summary>Backing field for <see cref="Department" /> property.</summary>
        private string _department;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Department { get => this._department; set => this._department = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Displayname" /> property.</summary>
        private string _displayname;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Displayname { get => this._displayname; set => this._displayname = value; }

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Backing field for <see cref="EmployeeIdentifier" /> property.</summary>
        private string _employeeIdentifier;

        /// <summary>Must be unique per user.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string EmployeeIdentifier { get => this._employeeIdentifier; set => this._employeeIdentifier = value; }

        /// <summary>Backing field for <see cref="EmployeeType" /> property.</summary>
        private string _employeeType;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string EmployeeType { get => this._employeeType; set => this._employeeType = value; }

        /// <summary>Backing field for <see cref="EnableManagedUid" /> property.</summary>
        private bool? _enableManagedUid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? EnableManagedUid { get => this._enableManagedUid; set => this._enableManagedUid = value; }

        /// <summary>Backing field for <see cref="EnableUserPortalMultifactor" /> property.</summary>
        private bool? _enableUserPortalMultifactor;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? EnableUserPortalMultifactor { get => this._enableUserPortalMultifactor; set => this._enableUserPortalMultifactor = value; }

        /// <summary>Backing field for <see cref="ExternalDn" /> property.</summary>
        private string _externalDn;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ExternalDn { get => this._externalDn; set => this._externalDn = value; }

        /// <summary>Backing field for <see cref="ExternalPasswordExpirationDate" /> property.</summary>
        private global::System.DateTime? _externalPasswordExpirationDate;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public global::System.DateTime? ExternalPasswordExpirationDate { get => this._externalPasswordExpirationDate; set => this._externalPasswordExpirationDate = value; }

        /// <summary>Backing field for <see cref="ExternalSourceType" /> property.</summary>
        private string _externalSourceType;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ExternalSourceType { get => this._externalSourceType; set => this._externalSourceType = value; }

        /// <summary>Backing field for <see cref="ExternallyManaged" /> property.</summary>
        private bool? _externallyManaged;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? ExternallyManaged { get => this._externallyManaged; set => this._externallyManaged = value; }

        /// <summary>Backing field for <see cref="Firstname" /> property.</summary>
        private string _firstname;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Firstname { get => this._firstname; set => this._firstname = value; }

        /// <summary>Backing field for <see cref="JobTitle" /> property.</summary>
        private string _jobTitle;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string JobTitle { get => this._jobTitle; set => this._jobTitle = value; }

        /// <summary>Internal Acessors for Mfa</summary>
        JumpCloudApiSdkV2.Models.IMfa JumpCloudApiSdkV2.Models.ISystemuserputpostInternal.Mfa { get => (this._mfa = this._mfa ?? new JumpCloudApiSdkV2.Models.Mfa()); set { {_mfa = value;} } }

        /// <summary>Backing field for <see cref="Lastname" /> property.</summary>
        private string _lastname;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Lastname { get => this._lastname; set => this._lastname = value; }

        /// <summary>Backing field for <see cref="LdapBindingUser" /> property.</summary>
        private bool? _ldapBindingUser;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? LdapBindingUser { get => this._ldapBindingUser; set => this._ldapBindingUser = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="Mfa" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IMfa _mfa;

        /// <summary>mfa</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IMfa Mfa { get => (this._mfa = this._mfa ?? new JumpCloudApiSdkV2.Models.Mfa()); set => this._mfa = value; }

        /// <summary>FIXME: Property MfaConfigured is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? MfaConfigured { get => ((JumpCloudApiSdkV2.Models.IMfaInternal)Mfa).Configured; set => ((JumpCloudApiSdkV2.Models.IMfaInternal)Mfa).Configured = value; }

        /// <summary>FIXME: Property MfaExclusion is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? MfaExclusion { get => ((JumpCloudApiSdkV2.Models.IMfaInternal)Mfa).Exclusion; set => ((JumpCloudApiSdkV2.Models.IMfaInternal)Mfa).Exclusion = value; }

        /// <summary>FIXME: Property MfaExclusionUntil is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public global::System.DateTime? MfaExclusionUntil { get => ((JumpCloudApiSdkV2.Models.IMfaInternal)Mfa).ExclusionUntil; set => ((JumpCloudApiSdkV2.Models.IMfaInternal)Mfa).ExclusionUntil = value; }

        /// <summary>Backing field for <see cref="Middlename" /> property.</summary>
        private string _middlename;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Middlename { get => this._middlename; set => this._middlename = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="PasswordNeverExpires" /> property.</summary>
        private bool? _passwordNeverExpires;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? PasswordNeverExpires { get => this._passwordNeverExpires; set => this._passwordNeverExpires = value; }

        /// <summary>Backing field for <see cref="PasswordlessSudo" /> property.</summary>
        private bool? _passwordlessSudo;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? PasswordlessSudo { get => this._passwordlessSudo; set => this._passwordlessSudo = value; }

        /// <summary>Backing field for <see cref="PhoneNumbers" /> property.</summary>
        private JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem[] _phoneNumbers;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem[] PhoneNumbers { get => this._phoneNumbers; set => this._phoneNumbers = value; }

        /// <summary>Backing field for <see cref="PublicKey" /> property.</summary>
        private string _publicKey;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string PublicKey { get => this._publicKey; set => this._publicKey = value; }

        /// <summary>Backing field for <see cref="Relationships" /> property.</summary>
        private JumpCloudApiSdkV2.Models.ISystemuserputpostRelationshipsItem[] _relationships;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.ISystemuserputpostRelationshipsItem[] Relationships { get => this._relationships; set => this._relationships = value; }

        /// <summary>Backing field for <see cref="SambaServiceUser" /> property.</summary>
        private bool? _sambaServiceUser;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? SambaServiceUser { get => this._sambaServiceUser; set => this._sambaServiceUser = value; }

        /// <summary>Backing field for <see cref="Sudo" /> property.</summary>
        private bool? _sudo;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? Sudo { get => this._sudo; set => this._sudo = value; }

        /// <summary>Backing field for <see cref="Suspended" /> property.</summary>
        private bool? _suspended;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? Suspended { get => this._suspended; set => this._suspended = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private string[] _tags;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string[] Tags { get => this._tags; set => this._tags = value; }

        /// <summary>Backing field for <see cref="UnixGuid" /> property.</summary>
        private int? _unixGuid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? UnixGuid { get => this._unixGuid; set => this._unixGuid = value; }

        /// <summary>Backing field for <see cref="UnixUid" /> property.</summary>
        private int? _unixUid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? UnixUid { get => this._unixUid; set => this._unixUid = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="Systemuserputpost" /> instance.</summary>
        public Systemuserputpost()
        {

        }
    }
    /// SystemUserPost
    public partial interface ISystemuserputpost :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"account_locked",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AccountLocked { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"activated",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Activated { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"addresses",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.ISystemuserputpostAddressesItem) })]
        JumpCloudApiSdkV2.Models.ISystemuserputpostAddressesItem[] Addresses { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allow_public_key",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowPublicKey { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.ISystemuserputpostAttributesItem) })]
        JumpCloudApiSdkV2.Models.ISystemuserputpostAttributesItem[] Attributes { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"company",
        PossibleTypes = new [] { typeof(string) })]
        string Company { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"costCenter",
        PossibleTypes = new [] { typeof(string) })]
        string CostCenter { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"department",
        PossibleTypes = new [] { typeof(string) })]
        string Department { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayname",
        PossibleTypes = new [] { typeof(string) })]
        string Displayname { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string Email { get; set; }
        /// <summary>Must be unique per user.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Must be unique per user. ",
        SerializedName = @"employeeIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string EmployeeIdentifier { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"employeeType",
        PossibleTypes = new [] { typeof(string) })]
        string EmployeeType { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enable_managed_uid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableManagedUid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enable_user_portal_multifactor",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableUserPortalMultifactor { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"external_dn",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalDn { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"external_password_expiration_date",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExternalPasswordExpirationDate { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"external_source_type",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalSourceType { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"externally_managed",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ExternallyManaged { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"firstname",
        PossibleTypes = new [] { typeof(string) })]
        string Firstname { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"jobTitle",
        PossibleTypes = new [] { typeof(string) })]
        string JobTitle { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastname",
        PossibleTypes = new [] { typeof(string) })]
        string Lastname { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ldap_binding_user",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LdapBindingUser { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"configured",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MfaConfigured { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MfaExclusion { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"exclusionUntil",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MfaExclusionUntil { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"middlename",
        PossibleTypes = new [] { typeof(string) })]
        string Middlename { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password_never_expires",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordNeverExpires { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"passwordless_sudo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordlessSudo { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"phoneNumbers",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem) })]
        JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem[] PhoneNumbers { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"public_key",
        PossibleTypes = new [] { typeof(string) })]
        string PublicKey { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"relationships",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.ISystemuserputpostRelationshipsItem) })]
        JumpCloudApiSdkV2.Models.ISystemuserputpostRelationshipsItem[] Relationships { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"samba_service_user",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SambaServiceUser { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sudo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Sudo { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"suspended",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Suspended { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string[] Tags { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"unix_guid",
        PossibleTypes = new [] { typeof(int) })]
        int? UnixGuid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"unix_uid",
        PossibleTypes = new [] { typeof(int) })]
        int? UnixUid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
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

        JumpCloudApiSdkV2.Models.ISystemuserputpostAddressesItem[] Addresses { get; set; }

        bool? AllowPublicKey { get; set; }

        JumpCloudApiSdkV2.Models.ISystemuserputpostAttributesItem[] Attributes { get; set; }

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

        global::System.DateTime? ExternalPasswordExpirationDate { get; set; }

        string ExternalSourceType { get; set; }

        bool? ExternallyManaged { get; set; }

        string Firstname { get; set; }

        string JobTitle { get; set; }

        string Lastname { get; set; }

        bool? LdapBindingUser { get; set; }

        string Location { get; set; }
        /// <summary>mfa</summary>
        JumpCloudApiSdkV2.Models.IMfa Mfa { get; set; }

        bool? MfaConfigured { get; set; }

        bool? MfaExclusion { get; set; }

        global::System.DateTime? MfaExclusionUntil { get; set; }

        string Middlename { get; set; }

        string Password { get; set; }

        bool? PasswordNeverExpires { get; set; }

        bool? PasswordlessSudo { get; set; }

        JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem[] PhoneNumbers { get; set; }

        string PublicKey { get; set; }

        JumpCloudApiSdkV2.Models.ISystemuserputpostRelationshipsItem[] Relationships { get; set; }

        bool? SambaServiceUser { get; set; }

        bool? Sudo { get; set; }

        bool? Suspended { get; set; }

        string[] Tags { get; set; }

        int? UnixGuid { get; set; }

        int? UnixUid { get; set; }

        string Username { get; set; }

    }
}