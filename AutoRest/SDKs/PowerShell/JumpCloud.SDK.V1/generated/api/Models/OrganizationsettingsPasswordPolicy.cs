namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class OrganizationsettingsPasswordPolicy :
        JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicy,
        JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicyInternal
    {

        /// <summary>Backing field for <see cref="AllowUsernameSubstring" /> property.</summary>
        private bool? _allowUsernameSubstring;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? AllowUsernameSubstring { get => this._allowUsernameSubstring; set => this._allowUsernameSubstring = value; }

        /// <summary>Backing field for <see cref="DaysAfterExpirationToSelfRecover" /> property.</summary>
        private int? _daysAfterExpirationToSelfRecover;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? DaysAfterExpirationToSelfRecover { get => this._daysAfterExpirationToSelfRecover; set => this._daysAfterExpirationToSelfRecover = value; }

        /// <summary>Backing field for <see cref="DaysBeforeExpirationToForceReset" /> property.</summary>
        private int? _daysBeforeExpirationToForceReset;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? DaysBeforeExpirationToForceReset { get => this._daysBeforeExpirationToForceReset; set => this._daysBeforeExpirationToForceReset = value; }

        /// <summary>Backing field for <see cref="EffectiveDate" /> property.</summary>
        private string _effectiveDate;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string EffectiveDate { get => this._effectiveDate; set => this._effectiveDate = value; }

        /// <summary>
        /// Backing field for <see cref="EnableDaysAfterExpirationToSelfRecover" /> property.
        /// </summary>
        private bool? _enableDaysAfterExpirationToSelfRecover;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableDaysAfterExpirationToSelfRecover { get => this._enableDaysAfterExpirationToSelfRecover; set => this._enableDaysAfterExpirationToSelfRecover = value; }

        /// <summary>
        /// Backing field for <see cref="EnableDaysBeforeExpirationToForceReset" /> property.
        /// </summary>
        private bool? _enableDaysBeforeExpirationToForceReset;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableDaysBeforeExpirationToForceReset { get => this._enableDaysBeforeExpirationToForceReset; set => this._enableDaysBeforeExpirationToForceReset = value; }

        /// <summary>Backing field for <see cref="EnableLockoutTimeInSeconds" /> property.</summary>
        private bool? _enableLockoutTimeInSeconds;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableLockoutTimeInSeconds { get => this._enableLockoutTimeInSeconds; set => this._enableLockoutTimeInSeconds = value; }

        /// <summary>Backing field for <see cref="EnableMaxHistory" /> property.</summary>
        private bool? _enableMaxHistory;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableMaxHistory { get => this._enableMaxHistory; set => this._enableMaxHistory = value; }

        /// <summary>Backing field for <see cref="EnableMaxLoginAttempts" /> property.</summary>
        private bool? _enableMaxLoginAttempts;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableMaxLoginAttempts { get => this._enableMaxLoginAttempts; set => this._enableMaxLoginAttempts = value; }

        /// <summary>Backing field for <see cref="EnableMinChangePeriodInDays" /> property.</summary>
        private bool? _enableMinChangePeriodInDays;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableMinChangePeriodInDays { get => this._enableMinChangePeriodInDays; set => this._enableMinChangePeriodInDays = value; }

        /// <summary>Backing field for <see cref="EnableMinLength" /> property.</summary>
        private bool? _enableMinLength;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnableMinLength { get => this._enableMinLength; set => this._enableMinLength = value; }

        /// <summary>Backing field for <see cref="EnablePasswordExpirationInDays" /> property.</summary>
        private bool? _enablePasswordExpirationInDays;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? EnablePasswordExpirationInDays { get => this._enablePasswordExpirationInDays; set => this._enablePasswordExpirationInDays = value; }

        /// <summary>Backing field for <see cref="LockoutTimeInSeconds" /> property.</summary>
        private int? _lockoutTimeInSeconds;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? LockoutTimeInSeconds { get => this._lockoutTimeInSeconds; set => this._lockoutTimeInSeconds = value; }

        /// <summary>Backing field for <see cref="MaxHistory" /> property.</summary>
        private int? _maxHistory;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? MaxHistory { get => this._maxHistory; set => this._maxHistory = value; }

        /// <summary>Backing field for <see cref="MaxLoginAttempts" /> property.</summary>
        private int? _maxLoginAttempts;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? MaxLoginAttempts { get => this._maxLoginAttempts; set => this._maxLoginAttempts = value; }

        /// <summary>Backing field for <see cref="MinChangePeriodInDays" /> property.</summary>
        private int? _minChangePeriodInDays;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? MinChangePeriodInDays { get => this._minChangePeriodInDays; set => this._minChangePeriodInDays = value; }

        /// <summary>Backing field for <see cref="MinLength" /> property.</summary>
        private int? _minLength;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? MinLength { get => this._minLength; set => this._minLength = value; }

        /// <summary>Backing field for <see cref="NeedsLowercase" /> property.</summary>
        private bool? _needsLowercase;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? NeedsLowercase { get => this._needsLowercase; set => this._needsLowercase = value; }

        /// <summary>Backing field for <see cref="NeedsNumeric" /> property.</summary>
        private bool? _needsNumeric;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? NeedsNumeric { get => this._needsNumeric; set => this._needsNumeric = value; }

        /// <summary>Backing field for <see cref="NeedsSymbolic" /> property.</summary>
        private bool? _needsSymbolic;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? NeedsSymbolic { get => this._needsSymbolic; set => this._needsSymbolic = value; }

        /// <summary>Backing field for <see cref="NeedsUppercase" /> property.</summary>
        private bool? _needsUppercase;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? NeedsUppercase { get => this._needsUppercase; set => this._needsUppercase = value; }

        /// <summary>Backing field for <see cref="PasswordExpirationInDays" /> property.</summary>
        private int? _passwordExpirationInDays;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? PasswordExpirationInDays { get => this._passwordExpirationInDays; set => this._passwordExpirationInDays = value; }

        /// <summary>Creates an new <see cref="OrganizationsettingsPasswordPolicy" /> instance.</summary>
        public OrganizationsettingsPasswordPolicy()
        {

        }
    }
    public partial interface IOrganizationsettingsPasswordPolicy :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowUsernameSubstring",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowUsernameSubstring { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"daysAfterExpirationToSelfRecover",
        PossibleTypes = new [] { typeof(int) })]
        int? DaysAfterExpirationToSelfRecover { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"daysBeforeExpirationToForceReset",
        PossibleTypes = new [] { typeof(int) })]
        int? DaysBeforeExpirationToForceReset { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"effectiveDate",
        PossibleTypes = new [] { typeof(string) })]
        string EffectiveDate { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableDaysAfterExpirationToSelfRecover",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableDaysAfterExpirationToSelfRecover { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableDaysBeforeExpirationToForceReset",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableDaysBeforeExpirationToForceReset { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableLockoutTimeInSeconds",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableLockoutTimeInSeconds { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMaxHistory",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableMaxHistory { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMaxLoginAttempts",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableMaxLoginAttempts { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMinChangePeriodInDays",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableMinChangePeriodInDays { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableMinLength",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableMinLength { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enablePasswordExpirationInDays",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnablePasswordExpirationInDays { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lockoutTimeInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? LockoutTimeInSeconds { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"maxHistory",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxHistory { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"maxLoginAttempts",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxLoginAttempts { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minChangePeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? MinChangePeriodInDays { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minLength",
        PossibleTypes = new [] { typeof(int) })]
        int? MinLength { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsLowercase",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NeedsLowercase { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsNumeric",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NeedsNumeric { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsSymbolic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NeedsSymbolic { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"needsUppercase",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NeedsUppercase { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"passwordExpirationInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? PasswordExpirationInDays { get; set; }

    }
    internal partial interface IOrganizationsettingsPasswordPolicyInternal

    {
        bool? AllowUsernameSubstring { get; set; }

        int? DaysAfterExpirationToSelfRecover { get; set; }

        int? DaysBeforeExpirationToForceReset { get; set; }

        string EffectiveDate { get; set; }

        bool? EnableDaysAfterExpirationToSelfRecover { get; set; }

        bool? EnableDaysBeforeExpirationToForceReset { get; set; }

        bool? EnableLockoutTimeInSeconds { get; set; }

        bool? EnableMaxHistory { get; set; }

        bool? EnableMaxLoginAttempts { get; set; }

        bool? EnableMinChangePeriodInDays { get; set; }

        bool? EnableMinLength { get; set; }

        bool? EnablePasswordExpirationInDays { get; set; }

        int? LockoutTimeInSeconds { get; set; }

        int? MaxHistory { get; set; }

        int? MaxLoginAttempts { get; set; }

        int? MinChangePeriodInDays { get; set; }

        int? MinLength { get; set; }

        bool? NeedsLowercase { get; set; }

        bool? NeedsNumeric { get; set; }

        bool? NeedsSymbolic { get; set; }

        bool? NeedsUppercase { get; set; }

        int? PasswordExpirationInDays { get; set; }

    }
}