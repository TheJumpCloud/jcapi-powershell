namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>OrganizationSettings</summary>
    public partial class Organizationsettings :
        JumpCloud.SDK.V1.Models.IOrganizationsettings,
        JumpCloud.SDK.V1.Models.IOrganizationsettingsInternal
    {

        /// <summary>Backing field for <see cref="BetaFeatures" /> property.</summary>
        private bool[] _betaFeatures;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool[] BetaFeatures { get => this._betaFeatures; set => this._betaFeatures = value; }

        /// <summary>Backing field for <see cref="ContactEmail" /> property.</summary>
        private string _contactEmail;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string ContactEmail { get => this._contactEmail; set => this._contactEmail = value; }

        /// <summary>Backing field for <see cref="ContactName" /> property.</summary>
        private string _contactName;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string ContactName { get => this._contactName; set => this._contactName = value; }

        /// <summary>Backing field for <see cref="DisableLdap" /> property.</summary>
        private bool? _disableLdap;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? DisableLdap { get => this._disableLdap; set => this._disableLdap = value; }

        /// <summary>Backing field for <see cref="DisableUm" /> property.</summary>
        private bool? _disableUm;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? DisableUm { get => this._disableUm; set => this._disableUm = value; }

        /// <summary>Backing field for <see cref="DuplicateLdapGroups" /> property.</summary>
        private bool? _duplicateLdapGroups;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? DuplicateLdapGroups { get => this._duplicateLdapGroups; set => this._duplicateLdapGroups = value; }

        /// <summary>Backing field for <see cref="EmailDisclaimer" /> property.</summary>
        private string _emailDisclaimer;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string EmailDisclaimer { get => this._emailDisclaimer; set => this._emailDisclaimer = value; }

        /// <summary>Backing field for <see cref="EnableGoogleApps" /> property.</summary>
        private bool? _enableGoogleApps;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableGoogleApps { get => this._enableGoogleApps; set => this._enableGoogleApps = value; }

        /// <summary>Backing field for <see cref="EnableManagedUid" /> property.</summary>
        private bool? _enableManagedUid;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableManagedUid { get => this._enableManagedUid; set => this._enableManagedUid = value; }

        /// <summary>Backing field for <see cref="EnableO365" /> property.</summary>
        private bool? _enableO365;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableO365 { get => this._enableO365; set => this._enableO365 = value; }

        /// <summary>Backing field for <see cref="Features" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IOrganizationsettingsFeatures _features;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IOrganizationsettingsFeatures Features { get => (this._features = this._features ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsFeatures()); set => this._features = value; }

        /// <summary>Internal Acessors for FeatureSystemInsights</summary>
        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsights JumpCloud.SDK.V1.Models.IOrganizationsettingsInternal.FeatureSystemInsights { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesInternal)Features).SystemInsights; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesInternal)Features).SystemInsights = value; }

        /// <summary>Internal Acessors for Features</summary>
        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeatures JumpCloud.SDK.V1.Models.IOrganizationsettingsInternal.Features { get => (this._features = this._features ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsFeatures()); set { {_features = value;} } }

        /// <summary>Internal Acessors for PasswordPolicy</summary>
        JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicy JumpCloud.SDK.V1.Models.IOrganizationsettingsInternal.PasswordPolicy { get => (this._passwordPolicy = this._passwordPolicy ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsPasswordPolicy()); set { {_passwordPolicy = value;} } }

        /// <summary>Internal Acessors for UserPortal</summary>
        JumpCloud.SDK.V1.Models.IOrganizationsettingsUserPortal JumpCloud.SDK.V1.Models.IOrganizationsettingsInternal.UserPortal { get => (this._userPortal = this._userPortal ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsUserPortal()); set { {_userPortal = value;} } }

        /// <summary>Backing field for <see cref="Logo" /> property.</summary>
        private string _logo;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Logo { get => this._logo; set => this._logo = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PasswordCompliance" /> property.</summary>
        private string _passwordCompliance;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string PasswordCompliance { get => this._passwordCompliance; set => this._passwordCompliance = value; }

        /// <summary>Backing field for <see cref="PasswordPolicy" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicy _passwordPolicy;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicy PasswordPolicy { get => (this._passwordPolicy = this._passwordPolicy ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsPasswordPolicy()); set => this._passwordPolicy = value; }

        /// <summary>FIXME: Property PasswordPolicyAllowUsernameSubstring is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyAllowUsernameSubstring { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).AllowUsernameSubstring; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).AllowUsernameSubstring = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyDaysAfterExpirationToSelfRecover is MISSING DESCRIPTION
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyDaysAfterExpirationToSelfRecover { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).DaysAfterExpirationToSelfRecover; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).DaysAfterExpirationToSelfRecover = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyDaysBeforeExpirationToForceReset is MISSING DESCRIPTION
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyDaysBeforeExpirationToForceReset { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).DaysBeforeExpirationToForceReset; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).DaysBeforeExpirationToForceReset = value; }

        /// <summary>FIXME: Property PasswordPolicyEffectiveDate is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string PasswordPolicyEffectiveDate { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EffectiveDate; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EffectiveDate = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyEnableDaysAfterExpirationToSelfRecover is MISSING DESCRIPTION
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableDaysAfterExpirationToSelfRecover { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableDaysAfterExpirationToSelfRecover; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableDaysAfterExpirationToSelfRecover = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyEnableDaysBeforeExpirationToForceReset is MISSING DESCRIPTION
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableDaysBeforeExpirationToForceReset { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableDaysBeforeExpirationToForceReset; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableDaysBeforeExpirationToForceReset = value; }

        /// <summary>FIXME: Property PasswordPolicyEnableLockoutTimeInSeconds is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableLockoutTimeInSeconds { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableLockoutTimeInSeconds; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableLockoutTimeInSeconds = value; }

        /// <summary>FIXME: Property PasswordPolicyEnableMaxHistory is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableMaxHistory { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableMaxHistory; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableMaxHistory = value; }

        /// <summary>FIXME: Property PasswordPolicyEnableMaxLoginAttempts is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableMaxLoginAttempts { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableMaxLoginAttempts; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableMaxLoginAttempts = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyEnableMinChangePeriodInDays is MISSING DESCRIPTION
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableMinChangePeriodInDays { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableMinChangePeriodInDays; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableMinChangePeriodInDays = value; }

        /// <summary>FIXME: Property PasswordPolicyEnableMinLength is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnableMinLength { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableMinLength; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnableMinLength = value; }

        /// <summary>
        /// FIXME: Property PasswordPolicyEnablePasswordExpirationInDays is MISSING DESCRIPTION
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyEnablePasswordExpirationInDays { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnablePasswordExpirationInDays; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).EnablePasswordExpirationInDays = value; }

        /// <summary>FIXME: Property PasswordPolicyLockoutTimeInSeconds is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyLockoutTimeInSeconds { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).LockoutTimeInSeconds; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).LockoutTimeInSeconds = value; }

        /// <summary>FIXME: Property PasswordPolicyMaxHistory is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyMaxHistory { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).MaxHistory; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).MaxHistory = value; }

        /// <summary>FIXME: Property PasswordPolicyMaxLoginAttempts is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyMaxLoginAttempts { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).MaxLoginAttempts; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).MaxLoginAttempts = value; }

        /// <summary>FIXME: Property PasswordPolicyMinChangePeriodInDays is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyMinChangePeriodInDays { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).MinChangePeriodInDays; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).MinChangePeriodInDays = value; }

        /// <summary>FIXME: Property PasswordPolicyMinLength is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyMinLength { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).MinLength; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).MinLength = value; }

        /// <summary>FIXME: Property PasswordPolicyNeedsLowercase is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyNeedsLowercase { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).NeedsLowercase; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).NeedsLowercase = value; }

        /// <summary>FIXME: Property PasswordPolicyNeedsNumeric is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyNeedsNumeric { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).NeedsNumeric; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).NeedsNumeric = value; }

        /// <summary>FIXME: Property PasswordPolicyNeedsSymbolic is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyNeedsSymbolic { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).NeedsSymbolic; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).NeedsSymbolic = value; }

        /// <summary>FIXME: Property PasswordPolicyNeedsUppercase is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? PasswordPolicyNeedsUppercase { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).NeedsUppercase; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).NeedsUppercase = value; }

        /// <summary>FIXME: Property PasswordPolicyPasswordExpirationInDays is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? PasswordPolicyPasswordExpirationInDays { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).PasswordExpirationInDays; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal)PasswordPolicy).PasswordExpirationInDays = value; }

        /// <summary>Backing field for <see cref="ShowIntro" /> property.</summary>
        private bool? _showIntro;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? ShowIntro { get => this._showIntro; set => this._showIntro = value; }

        /// <summary>FIXME: Property SystemInsightEnabled is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? SystemInsightEnabled { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesInternal)Features).SystemInsightEnabled; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesInternal)Features).SystemInsightEnabled = value; }

        /// <summary>Backing field for <see cref="SystemUserPasswordExpirationInDays" /> property.</summary>
        private int? _systemUserPasswordExpirationInDays;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? SystemUserPasswordExpirationInDays { get => this._systemUserPasswordExpirationInDays; set => this._systemUserPasswordExpirationInDays = value; }

        /// <summary>Backing field for <see cref="SystemUsersCanEdit" /> property.</summary>
        private bool? _systemUsersCanEdit;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? SystemUsersCanEdit { get => this._systemUsersCanEdit; set => this._systemUsersCanEdit = value; }

        /// <summary>Backing field for <see cref="UserPortal" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IOrganizationsettingsUserPortal _userPortal;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IOrganizationsettingsUserPortal UserPortal { get => (this._userPortal = this._userPortal ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsUserPortal()); set => this._userPortal = value; }

        /// <summary>FIXME: Property UserPortalIdleSessionDurationMinutes is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? UserPortalIdleSessionDurationMinutes { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsUserPortalInternal)UserPortal).IdleSessionDurationMinutes; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsUserPortalInternal)UserPortal).IdleSessionDurationMinutes = value; }

        /// <summary>Creates an new <see cref="Organizationsettings" /> instance.</summary>
        public Organizationsettings()
        {

        }
    }
    /// OrganizationSettings
    public partial interface IOrganizationsettings :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"betaFeatures",
        PossibleTypes = new [] { typeof(bool) })]
        bool[] BetaFeatures { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"contactEmail",
        PossibleTypes = new [] { typeof(string) })]
        string ContactEmail { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"contactName",
        PossibleTypes = new [] { typeof(string) })]
        string ContactName { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"disableLdap",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisableLdap { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"disableUM",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisableUm { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"duplicateLDAPGroups",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DuplicateLdapGroups { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailDisclaimer",
        PossibleTypes = new [] { typeof(string) })]
        string EmailDisclaimer { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableGoogleApps",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableGoogleApps { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableManagedUID",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableManagedUid { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableO365",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableO365 { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"logo",
        PossibleTypes = new [] { typeof(string) })]
        string Logo { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"passwordCompliance",
        PossibleTypes = new [] { typeof(string) })]
        string PasswordCompliance { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowUsernameSubstring",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyAllowUsernameSubstring { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"daysAfterExpirationToSelfRecover",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyDaysAfterExpirationToSelfRecover { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"daysBeforeExpirationToForceReset",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyDaysBeforeExpirationToForceReset { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"effectiveDate",
        PossibleTypes = new [] { typeof(string) })]
        string PasswordPolicyEffectiveDate { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableDaysAfterExpirationToSelfRecover",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableDaysAfterExpirationToSelfRecover { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableDaysBeforeExpirationToForceReset",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableDaysBeforeExpirationToForceReset { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableLockoutTimeInSeconds",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableLockoutTimeInSeconds { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMaxHistory",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableMaxHistory { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMaxLoginAttempts",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableMaxLoginAttempts { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMinChangePeriodInDays",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableMinChangePeriodInDays { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMinLength",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnableMinLength { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enablePasswordExpirationInDays",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyEnablePasswordExpirationInDays { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lockoutTimeInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyLockoutTimeInSeconds { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"maxHistory",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyMaxHistory { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"maxLoginAttempts",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyMaxLoginAttempts { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minChangePeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyMinChangePeriodInDays { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minLength",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyMinLength { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsLowercase",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyNeedsLowercase { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsNumeric",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyNeedsNumeric { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsSymbolic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyNeedsSymbolic { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsUppercase",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PasswordPolicyNeedsUppercase { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"passwordExpirationInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordPolicyPasswordExpirationInDays { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"showIntro",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ShowIntro { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemInsightEnabled { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"systemUserPasswordExpirationInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SystemUserPasswordExpirationInDays { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"systemUsersCanEdit",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemUsersCanEdit { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"idleSessionDurationMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? UserPortalIdleSessionDurationMinutes { get; set; }

    }
    /// OrganizationSettings
    internal partial interface IOrganizationsettingsInternal

    {
        bool[] BetaFeatures { get; set; }

        string ContactEmail { get; set; }

        string ContactName { get; set; }

        bool? DisableLdap { get; set; }

        bool? DisableUm { get; set; }

        bool? DuplicateLdapGroups { get; set; }

        string EmailDisclaimer { get; set; }

        bool? EnableGoogleApps { get; set; }

        bool? EnableManagedUid { get; set; }

        bool? EnableO365 { get; set; }

        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsights FeatureSystemInsights { get; set; }

        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeatures Features { get; set; }

        string Logo { get; set; }

        string Name { get; set; }

        string PasswordCompliance { get; set; }

        JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicy PasswordPolicy { get; set; }

        bool? PasswordPolicyAllowUsernameSubstring { get; set; }

        int? PasswordPolicyDaysAfterExpirationToSelfRecover { get; set; }

        int? PasswordPolicyDaysBeforeExpirationToForceReset { get; set; }

        string PasswordPolicyEffectiveDate { get; set; }

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

        JumpCloud.SDK.V1.Models.IOrganizationsettingsUserPortal UserPortal { get; set; }

        int? UserPortalIdleSessionDurationMinutes { get; set; }

    }
}