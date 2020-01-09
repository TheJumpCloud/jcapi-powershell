namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>OrganizationSettingsPut</summary>
    public partial class Organizationsettingsput :
        JumpCloudApiSdkV1.Models.IOrganizationsettingsput,
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal
    {

        /// <summary>Backing field for <see cref="ContactEmail" /> property.</summary>
        private string _contactEmail;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string ContactEmail { get => this._contactEmail; set => this._contactEmail = value; }

        /// <summary>Backing field for <see cref="ContactName" /> property.</summary>
        private string _contactName;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string ContactName { get => this._contactName; set => this._contactName = value; }

        /// <summary>Backing field for <see cref="DisableLdap" /> property.</summary>
        private bool? _disableLdap;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? DisableLdap { get => this._disableLdap; set => this._disableLdap = value; }

        /// <summary>Backing field for <see cref="DisableUm" /> property.</summary>
        private bool? _disableUm;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? DisableUm { get => this._disableUm; set => this._disableUm = value; }

        /// <summary>Backing field for <see cref="DuplicateLdapGroups" /> property.</summary>
        private bool? _duplicateLdapGroups;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? DuplicateLdapGroups { get => this._duplicateLdapGroups; set => this._duplicateLdapGroups = value; }

        /// <summary>Backing field for <see cref="EmailDisclaimer" /> property.</summary>
        private string _emailDisclaimer;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string EmailDisclaimer { get => this._emailDisclaimer; set => this._emailDisclaimer = value; }

        /// <summary>Backing field for <see cref="EnableManagedUid" /> property.</summary>
        private bool? _enableManagedUid;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? EnableManagedUid { get => this._enableManagedUid; set => this._enableManagedUid = value; }

        /// <summary>Backing field for <see cref="Features" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeatures _features;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeatures Features { get => (this._features = this._features ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsputFeatures()); set => this._features = value; }

        /// <summary>Internal Acessors for FeatureSystemInsights</summary>
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsights JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal.FeatureSystemInsights { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesInternal)Features).SystemInsights; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesInternal)Features).SystemInsights = value; }

        /// <summary>Internal Acessors for Features</summary>
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeatures JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal.Features { get => (this._features = this._features ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsputFeatures()); set { {_features = value;} } }

        /// <summary>Internal Acessors for PasswordPolicy</summary>
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicy JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal.PasswordPolicy { get => (this._passwordPolicy = this._passwordPolicy ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsputPasswordPolicy()); set { {_passwordPolicy = value;} } }

        /// <summary>Internal Acessors for UserPortal</summary>
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortal JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal.UserPortal { get => (this._userPortal = this._userPortal ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsputUserPortal()); set { {_userPortal = value;} } }

        /// <summary>Backing field for <see cref="Logo" /> property.</summary>
        private string _logo;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Logo { get => this._logo; set => this._logo = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PasswordCompliance" /> property.</summary>
        private string _passwordCompliance;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string PasswordCompliance { get => this._passwordCompliance; set => this._passwordCompliance = value; }

        /// <summary>Backing field for <see cref="PasswordPolicy" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicy _passwordPolicy;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicy PasswordPolicy { get => (this._passwordPolicy = this._passwordPolicy ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsputPasswordPolicy()); set => this._passwordPolicy = value; }

        /// <summary>FIXME: Property PasswordPolicyAllowUsernameSubstring is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyAllowUsernameSubstring { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).AllowUsernameSubstring; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).AllowUsernameSubstring = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyDaysAfterExpirationToSelfRecover is MISSING DESCRIPTION
        /// </summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyDaysAfterExpirationToSelfRecover { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).DaysAfterExpirationToSelfRecover; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).DaysAfterExpirationToSelfRecover = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyDaysBeforeExpirationToForceReset is MISSING DESCRIPTION
        /// </summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyDaysBeforeExpirationToForceReset { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).DaysBeforeExpirationToForceReset; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).DaysBeforeExpirationToForceReset = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyEnableDaysAfterExpirationToSelfRecover is MISSING DESCRIPTION
        /// </summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableDaysAfterExpirationToSelfRecover { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableDaysAfterExpirationToSelfRecover; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableDaysAfterExpirationToSelfRecover = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyEnableDaysBeforeExpirationToForceReset is MISSING DESCRIPTION
        /// </summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableDaysBeforeExpirationToForceReset { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableDaysBeforeExpirationToForceReset; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableDaysBeforeExpirationToForceReset = value; }

        /// <summary>FIXME: Property PasswordPolicyEnableLockoutTimeInSeconds is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableLockoutTimeInSeconds { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableLockoutTimeInSeconds; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableLockoutTimeInSeconds = value; }

        /// <summary>FIXME: Property PasswordPolicyEnableMaxHistory is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableMaxHistory { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableMaxHistory; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableMaxHistory = value; }

        /// <summary>FIXME: Property PasswordPolicyEnableMaxLoginAttempts is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableMaxLoginAttempts { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableMaxLoginAttempts; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableMaxLoginAttempts = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyEnableMinChangePeriodInDays is MISSING DESCRIPTION
        /// </summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableMinChangePeriodInDays { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableMinChangePeriodInDays; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableMinChangePeriodInDays = value; }

        /// <summary>FIXME: Property PasswordPolicyEnableMinLength is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableMinLength { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableMinLength; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnableMinLength = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyEnablePasswordExpirationInDays is MISSING DESCRIPTION
        /// </summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnablePasswordExpirationInDays { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnablePasswordExpirationInDays; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).EnablePasswordExpirationInDays = value; }

        /// <summary>FIXME: Property PasswordPolicyLockoutTimeInSeconds is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyLockoutTimeInSeconds { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).LockoutTimeInSeconds; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).LockoutTimeInSeconds = value; }

        /// <summary>FIXME: Property PasswordPolicyMaxHistory is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyMaxHistory { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).MaxHistory; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).MaxHistory = value; }

        /// <summary>FIXME: Property PasswordPolicyMaxLoginAttempts is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyMaxLoginAttempts { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).MaxLoginAttempts; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).MaxLoginAttempts = value; }

        /// <summary>FIXME: Property PasswordPolicyMinChangePeriodInDays is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyMinChangePeriodInDays { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).MinChangePeriodInDays; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).MinChangePeriodInDays = value; }

        /// <summary>FIXME: Property PasswordPolicyMinLength is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyMinLength { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).MinLength; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).MinLength = value; }

        /// <summary>FIXME: Property PasswordPolicyNeedsLowercase is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyNeedsLowercase { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).NeedsLowercase; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).NeedsLowercase = value; }

        /// <summary>FIXME: Property PasswordPolicyNeedsNumeric is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyNeedsNumeric { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).NeedsNumeric; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).NeedsNumeric = value; }

        /// <summary>FIXME: Property PasswordPolicyNeedsSymbolic is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyNeedsSymbolic { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).NeedsSymbolic; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).NeedsSymbolic = value; }

        /// <summary>FIXME: Property PasswordPolicyNeedsUppercase is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyNeedsUppercase { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).NeedsUppercase; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).NeedsUppercase = value; }

        /// <summary>FIXME: Property PasswordPolicyPasswordExpirationInDays is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyPasswordExpirationInDays { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).PasswordExpirationInDays; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicyInternal)PasswordPolicy).PasswordExpirationInDays = value; }

        /// <summary>Backing field for <see cref="ShowIntro" /> property.</summary>
        private bool? _showIntro;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? ShowIntro { get => this._showIntro; set => this._showIntro = value; }

        /// <summary>FIXME: Property SystemInsightEnabled is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? SystemInsightEnabled { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesInternal)Features).SystemInsightEnabled; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesInternal)Features).SystemInsightEnabled = value; }

        /// <summary>Backing field for <see cref="SystemUserPasswordExpirationInDays" /> property.</summary>
        private int? _systemUserPasswordExpirationInDays;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? SystemUserPasswordExpirationInDays { get => this._systemUserPasswordExpirationInDays; set => this._systemUserPasswordExpirationInDays = value; }

        /// <summary>Backing field for <see cref="SystemUsersCanEdit" /> property.</summary>
        private bool? _systemUsersCanEdit;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? SystemUsersCanEdit { get => this._systemUsersCanEdit; set => this._systemUsersCanEdit = value; }

        /// <summary>Backing field for <see cref="UserPortal" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortal _userPortal;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortal UserPortal { get => (this._userPortal = this._userPortal ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsputUserPortal()); set => this._userPortal = value; }

        /// <summary>FIXME: Property UserPortalIdleSessionDurationMinutes is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public int? UserPortalIdleSessionDurationMinutes { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortalInternal)UserPortal).IdleSessionDurationMinutes; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortalInternal)UserPortal).IdleSessionDurationMinutes = value; }

        /// <summary>Creates an new <see cref="Organizationsettingsput" /> instance.</summary>
        public Organizationsettingsput()
        {

        }
    }
    /// OrganizationSettingsPut
    public partial interface IOrganizationsettingsput :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"contactEmail",
        PossibleTypes = new [] { typeof(string) })]
        string ContactEmail { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"contactName",
        PossibleTypes = new [] { typeof(string) })]
        string ContactName { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"disableLdap",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisableLdap { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"disableUM",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisableUm { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"duplicateLDAPGroups",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DuplicateLdapGroups { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailDisclaimer",
        PossibleTypes = new [] { typeof(string) })]
        string EmailDisclaimer { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableManagedUID",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableManagedUid { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"logo",
        PossibleTypes = new [] { typeof(string) })]
        string Logo { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"passwordCompliance",
        PossibleTypes = new [] { typeof(string) })]
        string PasswordCompliance { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowUsernameSubstring",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyAllowUsernameSubstring { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"daysAfterExpirationToSelfRecover",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyDaysAfterExpirationToSelfRecover { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"daysBeforeExpirationToForceReset",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyDaysBeforeExpirationToForceReset { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableDaysAfterExpirationToSelfRecover",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableDaysAfterExpirationToSelfRecover { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableDaysBeforeExpirationToForceReset",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableDaysBeforeExpirationToForceReset { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableLockoutTimeInSeconds",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableLockoutTimeInSeconds { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMaxHistory",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableMaxHistory { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMaxLoginAttempts",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableMaxLoginAttempts { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMinChangePeriodInDays",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableMinChangePeriodInDays { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMinLength",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableMinLength { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enablePasswordExpirationInDays",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnablePasswordExpirationInDays { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lockoutTimeInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyLockoutTimeInSeconds { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"maxHistory",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyMaxHistory { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"maxLoginAttempts",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyMaxLoginAttempts { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minChangePeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyMinChangePeriodInDays { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minLength",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyMinLength { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsLowercase",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyNeedsLowercase { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsNumeric",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyNeedsNumeric { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsSymbolic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyNeedsSymbolic { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsUppercase",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyNeedsUppercase { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"passwordExpirationInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyPasswordExpirationInDays { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"showIntro",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ShowIntro { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemInsightEnabled { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"systemUserPasswordExpirationInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SystemUserPasswordExpirationInDays { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"systemUsersCanEdit",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemUsersCanEdit { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"idleSessionDurationMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? UserPortalIdleSessionDurationMinutes { get; set; }

    }
    /// OrganizationSettingsPut
    internal partial interface IOrganizationsettingsputInternal

    {
        string ContactEmail { get; set; }

        string ContactName { get; set; }

        bool? DisableLdap { get; set; }

        bool? DisableUm { get; set; }

        bool? DuplicateLdapGroups { get; set; }

        string EmailDisclaimer { get; set; }

        bool? EnableManagedUid { get; set; }

        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsights FeatureSystemInsights { get; set; }

        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeatures Features { get; set; }

        string Logo { get; set; }

        string Name { get; set; }

        string PasswordCompliance { get; set; }

        JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicy PasswordPolicy { get; set; }

        bool? PasswordPolicyAllowUsernameSubstring { get; set; }

        int? PasswordPolicyDaysAfterExpirationToSelfRecover { get; set; }

        int? PasswordPolicyDaysBeforeExpirationToForceReset { get; set; }

        bool? PasswordPolicyEnableDaysAfterExpirationToSelfRecover { get; set; }

        bool? PasswordPolicyEnableDaysBeforeExpirationToForceReset { get; set; }

        bool? PasswordPolicyEnableLockoutTimeInSeconds { get; set; }

        bool? PasswordPolicyEnableMaxHistory { get; set; }

        bool? PasswordPolicyEnableMaxLoginAttempts { get; set; }

        bool? PasswordPolicyEnableMinChangePeriodInDays { get; set; }

        bool? PasswordPolicyEnableMinLength { get; set; }

        bool? PasswordPolicyEnablePasswordExpirationInDays { get; set; }

        int? PasswordPolicyLockoutTimeInSeconds { get; set; }

        int? PasswordPolicyMaxHistory { get; set; }

        int? PasswordPolicyMaxLoginAttempts { get; set; }

        int? PasswordPolicyMinChangePeriodInDays { get; set; }

        int? PasswordPolicyMinLength { get; set; }

        bool? PasswordPolicyNeedsLowercase { get; set; }

        bool? PasswordPolicyNeedsNumeric { get; set; }

        bool? PasswordPolicyNeedsSymbolic { get; set; }

        bool? PasswordPolicyNeedsUppercase { get; set; }

        int? PasswordPolicyPasswordExpirationInDays { get; set; }

        bool? ShowIntro { get; set; }

        bool? SystemInsightEnabled { get; set; }

        int? SystemUserPasswordExpirationInDays { get; set; }

        bool? SystemUsersCanEdit { get; set; }

        JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortal UserPortal { get; set; }

        int? UserPortalIdleSessionDurationMinutes { get; set; }

    }
}