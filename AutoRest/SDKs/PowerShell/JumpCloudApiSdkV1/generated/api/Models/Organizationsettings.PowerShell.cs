namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>OrganizationSettings</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationsettingsTypeConverter))]
    public partial class Organizationsettings
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Organizationsettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IOrganizationsettings" />.</returns>
        public static JumpCloudApiSdkV1.Models.IOrganizationsettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Organizationsettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Organizationsettings"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IOrganizationsettings" />.</returns>
        public static JumpCloudApiSdkV1.Models.IOrganizationsettings DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Organizationsettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Organizationsettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.IOrganizationsettings FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Organizationsettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Organizationsettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Features = (JumpCloudApiSdkV1.Models.IOrganizationsettingsFeatures) content.GetValueForProperty("Features",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Features, JumpCloudApiSdkV1.Models.OrganizationsettingsFeaturesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicy = (JumpCloudApiSdkV1.Models.IOrganizationsettingsPasswordPolicy) content.GetValueForProperty("PasswordPolicy",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicy, JumpCloudApiSdkV1.Models.OrganizationsettingsPasswordPolicyTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).UserPortal = (JumpCloudApiSdkV1.Models.IOrganizationsettingsUserPortal) content.GetValueForProperty("UserPortal",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).UserPortal, JumpCloudApiSdkV1.Models.OrganizationsettingsUserPortalTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).BetaFeatures = (bool[]) content.GetValueForProperty("BetaFeatures",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).BetaFeatures, __y => TypeConverterExtensions.SelectToArray<bool>(__y, (__w)=> (bool) global::System.Convert.ChangeType(__w, typeof(bool))));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ContactEmail = (string) content.GetValueForProperty("ContactEmail",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ContactEmail, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ContactName = (string) content.GetValueForProperty("ContactName",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ContactName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DisableLdap = (bool?) content.GetValueForProperty("DisableLdap",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DisableLdap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DisableUm = (bool?) content.GetValueForProperty("DisableUm",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DisableUm, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DuplicateLdapGroups = (bool?) content.GetValueForProperty("DuplicateLdapGroups",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DuplicateLdapGroups, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EmailDisclaimer = (string) content.GetValueForProperty("EmailDisclaimer",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EmailDisclaimer, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableGoogleApps = (bool?) content.GetValueForProperty("EnableGoogleApps",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableGoogleApps, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableO365 = (bool?) content.GetValueForProperty("EnableO365",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableO365, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Logo = (string) content.GetValueForProperty("Logo",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Logo, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordCompliance = (string) content.GetValueForProperty("PasswordCompliance",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordCompliance, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ShowIntro = (bool?) content.GetValueForProperty("ShowIntro",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ShowIntro, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemUserPasswordExpirationInDays = (int?) content.GetValueForProperty("SystemUserPasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemUserPasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemUsersCanEdit = (bool?) content.GetValueForProperty("SystemUsersCanEdit",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemUsersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).FeatureSystemInsights = (JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesSystemInsights) content.GetValueForProperty("FeatureSystemInsights",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).FeatureSystemInsights, JumpCloudApiSdkV1.Models.OrganizationsettingsFeaturesSystemInsightsTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyAllowUsernameSubstring = (bool?) content.GetValueForProperty("PasswordPolicyAllowUsernameSubstring",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyAllowUsernameSubstring, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyDaysAfterExpirationToSelfRecover = (int?) content.GetValueForProperty("PasswordPolicyDaysAfterExpirationToSelfRecover",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyDaysAfterExpirationToSelfRecover, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyDaysBeforeExpirationToForceReset = (int?) content.GetValueForProperty("PasswordPolicyDaysBeforeExpirationToForceReset",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyDaysBeforeExpirationToForceReset, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEffectiveDate = (string) content.GetValueForProperty("PasswordPolicyEffectiveDate",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEffectiveDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableDaysAfterExpirationToSelfRecover = (bool?) content.GetValueForProperty("PasswordPolicyEnableDaysAfterExpirationToSelfRecover",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableDaysAfterExpirationToSelfRecover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableDaysBeforeExpirationToForceReset = (bool?) content.GetValueForProperty("PasswordPolicyEnableDaysBeforeExpirationToForceReset",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableDaysBeforeExpirationToForceReset, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableLockoutTimeInSeconds = (bool?) content.GetValueForProperty("PasswordPolicyEnableLockoutTimeInSeconds",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableLockoutTimeInSeconds, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMaxHistory = (bool?) content.GetValueForProperty("PasswordPolicyEnableMaxHistory",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMaxHistory, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMaxLoginAttempts = (bool?) content.GetValueForProperty("PasswordPolicyEnableMaxLoginAttempts",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMaxLoginAttempts, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMinChangePeriodInDays = (bool?) content.GetValueForProperty("PasswordPolicyEnableMinChangePeriodInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMinChangePeriodInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMinLength = (bool?) content.GetValueForProperty("PasswordPolicyEnableMinLength",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMinLength, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnablePasswordExpirationInDays = (bool?) content.GetValueForProperty("PasswordPolicyEnablePasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnablePasswordExpirationInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyLockoutTimeInSeconds = (int?) content.GetValueForProperty("PasswordPolicyLockoutTimeInSeconds",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyLockoutTimeInSeconds, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMaxHistory = (int?) content.GetValueForProperty("PasswordPolicyMaxHistory",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMaxHistory, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMaxLoginAttempts = (int?) content.GetValueForProperty("PasswordPolicyMaxLoginAttempts",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMaxLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMinChangePeriodInDays = (int?) content.GetValueForProperty("PasswordPolicyMinChangePeriodInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMinChangePeriodInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMinLength = (int?) content.GetValueForProperty("PasswordPolicyMinLength",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMinLength, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsLowercase = (bool?) content.GetValueForProperty("PasswordPolicyNeedsLowercase",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsLowercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsNumeric = (bool?) content.GetValueForProperty("PasswordPolicyNeedsNumeric",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsNumeric, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsSymbolic = (bool?) content.GetValueForProperty("PasswordPolicyNeedsSymbolic",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsSymbolic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsUppercase = (bool?) content.GetValueForProperty("PasswordPolicyNeedsUppercase",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsUppercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyPasswordExpirationInDays = (int?) content.GetValueForProperty("PasswordPolicyPasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyPasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).UserPortalIdleSessionDurationMinutes = (int?) content.GetValueForProperty("UserPortalIdleSessionDurationMinutes",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).UserPortalIdleSessionDurationMinutes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemInsightEnabled = (bool?) content.GetValueForProperty("SystemInsightEnabled",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemInsightEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Organizationsettings"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Organizationsettings(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Features = (JumpCloudApiSdkV1.Models.IOrganizationsettingsFeatures) content.GetValueForProperty("Features",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Features, JumpCloudApiSdkV1.Models.OrganizationsettingsFeaturesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicy = (JumpCloudApiSdkV1.Models.IOrganizationsettingsPasswordPolicy) content.GetValueForProperty("PasswordPolicy",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicy, JumpCloudApiSdkV1.Models.OrganizationsettingsPasswordPolicyTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).UserPortal = (JumpCloudApiSdkV1.Models.IOrganizationsettingsUserPortal) content.GetValueForProperty("UserPortal",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).UserPortal, JumpCloudApiSdkV1.Models.OrganizationsettingsUserPortalTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).BetaFeatures = (bool[]) content.GetValueForProperty("BetaFeatures",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).BetaFeatures, __y => TypeConverterExtensions.SelectToArray<bool>(__y, (__w)=> (bool) global::System.Convert.ChangeType(__w, typeof(bool))));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ContactEmail = (string) content.GetValueForProperty("ContactEmail",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ContactEmail, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ContactName = (string) content.GetValueForProperty("ContactName",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ContactName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DisableLdap = (bool?) content.GetValueForProperty("DisableLdap",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DisableLdap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DisableUm = (bool?) content.GetValueForProperty("DisableUm",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DisableUm, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DuplicateLdapGroups = (bool?) content.GetValueForProperty("DuplicateLdapGroups",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).DuplicateLdapGroups, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EmailDisclaimer = (string) content.GetValueForProperty("EmailDisclaimer",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EmailDisclaimer, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableGoogleApps = (bool?) content.GetValueForProperty("EnableGoogleApps",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableGoogleApps, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableO365 = (bool?) content.GetValueForProperty("EnableO365",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).EnableO365, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Logo = (string) content.GetValueForProperty("Logo",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).Logo, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordCompliance = (string) content.GetValueForProperty("PasswordCompliance",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordCompliance, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ShowIntro = (bool?) content.GetValueForProperty("ShowIntro",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).ShowIntro, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemUserPasswordExpirationInDays = (int?) content.GetValueForProperty("SystemUserPasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemUserPasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemUsersCanEdit = (bool?) content.GetValueForProperty("SystemUsersCanEdit",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemUsersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).FeatureSystemInsights = (JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesSystemInsights) content.GetValueForProperty("FeatureSystemInsights",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).FeatureSystemInsights, JumpCloudApiSdkV1.Models.OrganizationsettingsFeaturesSystemInsightsTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyAllowUsernameSubstring = (bool?) content.GetValueForProperty("PasswordPolicyAllowUsernameSubstring",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyAllowUsernameSubstring, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyDaysAfterExpirationToSelfRecover = (int?) content.GetValueForProperty("PasswordPolicyDaysAfterExpirationToSelfRecover",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyDaysAfterExpirationToSelfRecover, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyDaysBeforeExpirationToForceReset = (int?) content.GetValueForProperty("PasswordPolicyDaysBeforeExpirationToForceReset",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyDaysBeforeExpirationToForceReset, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEffectiveDate = (string) content.GetValueForProperty("PasswordPolicyEffectiveDate",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEffectiveDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableDaysAfterExpirationToSelfRecover = (bool?) content.GetValueForProperty("PasswordPolicyEnableDaysAfterExpirationToSelfRecover",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableDaysAfterExpirationToSelfRecover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableDaysBeforeExpirationToForceReset = (bool?) content.GetValueForProperty("PasswordPolicyEnableDaysBeforeExpirationToForceReset",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableDaysBeforeExpirationToForceReset, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableLockoutTimeInSeconds = (bool?) content.GetValueForProperty("PasswordPolicyEnableLockoutTimeInSeconds",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableLockoutTimeInSeconds, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMaxHistory = (bool?) content.GetValueForProperty("PasswordPolicyEnableMaxHistory",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMaxHistory, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMaxLoginAttempts = (bool?) content.GetValueForProperty("PasswordPolicyEnableMaxLoginAttempts",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMaxLoginAttempts, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMinChangePeriodInDays = (bool?) content.GetValueForProperty("PasswordPolicyEnableMinChangePeriodInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMinChangePeriodInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMinLength = (bool?) content.GetValueForProperty("PasswordPolicyEnableMinLength",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnableMinLength, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnablePasswordExpirationInDays = (bool?) content.GetValueForProperty("PasswordPolicyEnablePasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyEnablePasswordExpirationInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyLockoutTimeInSeconds = (int?) content.GetValueForProperty("PasswordPolicyLockoutTimeInSeconds",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyLockoutTimeInSeconds, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMaxHistory = (int?) content.GetValueForProperty("PasswordPolicyMaxHistory",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMaxHistory, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMaxLoginAttempts = (int?) content.GetValueForProperty("PasswordPolicyMaxLoginAttempts",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMaxLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMinChangePeriodInDays = (int?) content.GetValueForProperty("PasswordPolicyMinChangePeriodInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMinChangePeriodInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMinLength = (int?) content.GetValueForProperty("PasswordPolicyMinLength",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyMinLength, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsLowercase = (bool?) content.GetValueForProperty("PasswordPolicyNeedsLowercase",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsLowercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsNumeric = (bool?) content.GetValueForProperty("PasswordPolicyNeedsNumeric",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsNumeric, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsSymbolic = (bool?) content.GetValueForProperty("PasswordPolicyNeedsSymbolic",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsSymbolic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsUppercase = (bool?) content.GetValueForProperty("PasswordPolicyNeedsUppercase",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyNeedsUppercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyPasswordExpirationInDays = (int?) content.GetValueForProperty("PasswordPolicyPasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).PasswordPolicyPasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).UserPortalIdleSessionDurationMinutes = (int?) content.GetValueForProperty("UserPortalIdleSessionDurationMinutes",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).UserPortalIdleSessionDurationMinutes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemInsightEnabled = (bool?) content.GetValueForProperty("SystemInsightEnabled",((JumpCloudApiSdkV1.Models.IOrganizationsettingsInternal)this).SystemInsightEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// OrganizationSettings
    [System.ComponentModel.TypeConverter(typeof(OrganizationsettingsTypeConverter))]
    public partial interface IOrganizationsettings

    {

    }
}