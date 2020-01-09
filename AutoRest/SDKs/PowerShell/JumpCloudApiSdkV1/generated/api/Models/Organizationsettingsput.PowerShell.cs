namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>OrganizationSettingsPut</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationsettingsputTypeConverter))]
    public partial class Organizationsettingsput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Organizationsettingsput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.IOrganizationsettingsput" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.IOrganizationsettingsput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Organizationsettingsput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Organizationsettingsput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.IOrganizationsettingsput" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.IOrganizationsettingsput DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Organizationsettingsput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Organizationsettingsput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.IOrganizationsettingsput FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Organizationsettingsput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Organizationsettingsput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Features = (JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeatures) content.GetValueForProperty("Features",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Features, JumpCloudApiSdkV1.Models.OrganizationsettingsputFeaturesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicy = (JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicy) content.GetValueForProperty("PasswordPolicy",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicy, JumpCloudApiSdkV1.Models.OrganizationsettingsputPasswordPolicyTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).UserPortal = (JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortal) content.GetValueForProperty("UserPortal",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).UserPortal, JumpCloudApiSdkV1.Models.OrganizationsettingsputUserPortalTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ContactEmail = (string) content.GetValueForProperty("ContactEmail",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ContactEmail, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ContactName = (string) content.GetValueForProperty("ContactName",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ContactName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DisableLdap = (bool?) content.GetValueForProperty("DisableLdap",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DisableLdap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DisableUm = (bool?) content.GetValueForProperty("DisableUm",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DisableUm, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DuplicateLdapGroups = (bool?) content.GetValueForProperty("DuplicateLdapGroups",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DuplicateLdapGroups, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).EmailDisclaimer = (string) content.GetValueForProperty("EmailDisclaimer",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).EmailDisclaimer, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Logo = (string) content.GetValueForProperty("Logo",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Logo, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordCompliance = (string) content.GetValueForProperty("PasswordCompliance",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordCompliance, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ShowIntro = (bool?) content.GetValueForProperty("ShowIntro",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ShowIntro, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemUserPasswordExpirationInDays = (int?) content.GetValueForProperty("SystemUserPasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemUserPasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemUsersCanEdit = (bool?) content.GetValueForProperty("SystemUsersCanEdit",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemUsersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).FeatureSystemInsights = (JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsights) content.GetValueForProperty("FeatureSystemInsights",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).FeatureSystemInsights, JumpCloudApiSdkV1.Models.OrganizationsettingsputFeaturesSystemInsightsTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyAllowUsernameSubstring = (bool?) content.GetValueForProperty("PasswordPolicyAllowUsernameSubstring",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyAllowUsernameSubstring, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyDaysAfterExpirationToSelfRecover = (int?) content.GetValueForProperty("PasswordPolicyDaysAfterExpirationToSelfRecover",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyDaysAfterExpirationToSelfRecover, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyDaysBeforeExpirationToForceReset = (int?) content.GetValueForProperty("PasswordPolicyDaysBeforeExpirationToForceReset",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyDaysBeforeExpirationToForceReset, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableDaysAfterExpirationToSelfRecover = (bool?) content.GetValueForProperty("PasswordPolicyEnableDaysAfterExpirationToSelfRecover",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableDaysAfterExpirationToSelfRecover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableDaysBeforeExpirationToForceReset = (bool?) content.GetValueForProperty("PasswordPolicyEnableDaysBeforeExpirationToForceReset",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableDaysBeforeExpirationToForceReset, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableLockoutTimeInSeconds = (bool?) content.GetValueForProperty("PasswordPolicyEnableLockoutTimeInSeconds",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableLockoutTimeInSeconds, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMaxHistory = (bool?) content.GetValueForProperty("PasswordPolicyEnableMaxHistory",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMaxHistory, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMaxLoginAttempts = (bool?) content.GetValueForProperty("PasswordPolicyEnableMaxLoginAttempts",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMaxLoginAttempts, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMinChangePeriodInDays = (bool?) content.GetValueForProperty("PasswordPolicyEnableMinChangePeriodInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMinChangePeriodInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMinLength = (bool?) content.GetValueForProperty("PasswordPolicyEnableMinLength",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMinLength, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnablePasswordExpirationInDays = (bool?) content.GetValueForProperty("PasswordPolicyEnablePasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnablePasswordExpirationInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyLockoutTimeInSeconds = (int?) content.GetValueForProperty("PasswordPolicyLockoutTimeInSeconds",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyLockoutTimeInSeconds, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMaxHistory = (int?) content.GetValueForProperty("PasswordPolicyMaxHistory",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMaxHistory, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMaxLoginAttempts = (int?) content.GetValueForProperty("PasswordPolicyMaxLoginAttempts",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMaxLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMinChangePeriodInDays = (int?) content.GetValueForProperty("PasswordPolicyMinChangePeriodInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMinChangePeriodInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMinLength = (int?) content.GetValueForProperty("PasswordPolicyMinLength",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMinLength, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsLowercase = (bool?) content.GetValueForProperty("PasswordPolicyNeedsLowercase",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsLowercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsNumeric = (bool?) content.GetValueForProperty("PasswordPolicyNeedsNumeric",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsNumeric, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsSymbolic = (bool?) content.GetValueForProperty("PasswordPolicyNeedsSymbolic",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsSymbolic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsUppercase = (bool?) content.GetValueForProperty("PasswordPolicyNeedsUppercase",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsUppercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyPasswordExpirationInDays = (int?) content.GetValueForProperty("PasswordPolicyPasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyPasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).UserPortalIdleSessionDurationMinutes = (int?) content.GetValueForProperty("UserPortalIdleSessionDurationMinutes",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).UserPortalIdleSessionDurationMinutes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemInsightEnabled = (bool?) content.GetValueForProperty("SystemInsightEnabled",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemInsightEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Organizationsettingsput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Organizationsettingsput(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Features = (JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeatures) content.GetValueForProperty("Features",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Features, JumpCloudApiSdkV1.Models.OrganizationsettingsputFeaturesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicy = (JumpCloudApiSdkV1.Models.IOrganizationsettingsputPasswordPolicy) content.GetValueForProperty("PasswordPolicy",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicy, JumpCloudApiSdkV1.Models.OrganizationsettingsputPasswordPolicyTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).UserPortal = (JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortal) content.GetValueForProperty("UserPortal",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).UserPortal, JumpCloudApiSdkV1.Models.OrganizationsettingsputUserPortalTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ContactEmail = (string) content.GetValueForProperty("ContactEmail",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ContactEmail, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ContactName = (string) content.GetValueForProperty("ContactName",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ContactName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DisableLdap = (bool?) content.GetValueForProperty("DisableLdap",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DisableLdap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DisableUm = (bool?) content.GetValueForProperty("DisableUm",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DisableUm, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DuplicateLdapGroups = (bool?) content.GetValueForProperty("DuplicateLdapGroups",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).DuplicateLdapGroups, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).EmailDisclaimer = (string) content.GetValueForProperty("EmailDisclaimer",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).EmailDisclaimer, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Logo = (string) content.GetValueForProperty("Logo",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).Logo, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordCompliance = (string) content.GetValueForProperty("PasswordCompliance",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordCompliance, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ShowIntro = (bool?) content.GetValueForProperty("ShowIntro",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).ShowIntro, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemUserPasswordExpirationInDays = (int?) content.GetValueForProperty("SystemUserPasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemUserPasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemUsersCanEdit = (bool?) content.GetValueForProperty("SystemUsersCanEdit",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemUsersCanEdit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).FeatureSystemInsights = (JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsights) content.GetValueForProperty("FeatureSystemInsights",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).FeatureSystemInsights, JumpCloudApiSdkV1.Models.OrganizationsettingsputFeaturesSystemInsightsTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyAllowUsernameSubstring = (bool?) content.GetValueForProperty("PasswordPolicyAllowUsernameSubstring",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyAllowUsernameSubstring, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyDaysAfterExpirationToSelfRecover = (int?) content.GetValueForProperty("PasswordPolicyDaysAfterExpirationToSelfRecover",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyDaysAfterExpirationToSelfRecover, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyDaysBeforeExpirationToForceReset = (int?) content.GetValueForProperty("PasswordPolicyDaysBeforeExpirationToForceReset",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyDaysBeforeExpirationToForceReset, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableDaysAfterExpirationToSelfRecover = (bool?) content.GetValueForProperty("PasswordPolicyEnableDaysAfterExpirationToSelfRecover",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableDaysAfterExpirationToSelfRecover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableDaysBeforeExpirationToForceReset = (bool?) content.GetValueForProperty("PasswordPolicyEnableDaysBeforeExpirationToForceReset",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableDaysBeforeExpirationToForceReset, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableLockoutTimeInSeconds = (bool?) content.GetValueForProperty("PasswordPolicyEnableLockoutTimeInSeconds",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableLockoutTimeInSeconds, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMaxHistory = (bool?) content.GetValueForProperty("PasswordPolicyEnableMaxHistory",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMaxHistory, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMaxLoginAttempts = (bool?) content.GetValueForProperty("PasswordPolicyEnableMaxLoginAttempts",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMaxLoginAttempts, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMinChangePeriodInDays = (bool?) content.GetValueForProperty("PasswordPolicyEnableMinChangePeriodInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMinChangePeriodInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMinLength = (bool?) content.GetValueForProperty("PasswordPolicyEnableMinLength",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnableMinLength, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnablePasswordExpirationInDays = (bool?) content.GetValueForProperty("PasswordPolicyEnablePasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyEnablePasswordExpirationInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyLockoutTimeInSeconds = (int?) content.GetValueForProperty("PasswordPolicyLockoutTimeInSeconds",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyLockoutTimeInSeconds, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMaxHistory = (int?) content.GetValueForProperty("PasswordPolicyMaxHistory",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMaxHistory, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMaxLoginAttempts = (int?) content.GetValueForProperty("PasswordPolicyMaxLoginAttempts",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMaxLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMinChangePeriodInDays = (int?) content.GetValueForProperty("PasswordPolicyMinChangePeriodInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMinChangePeriodInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMinLength = (int?) content.GetValueForProperty("PasswordPolicyMinLength",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyMinLength, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsLowercase = (bool?) content.GetValueForProperty("PasswordPolicyNeedsLowercase",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsLowercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsNumeric = (bool?) content.GetValueForProperty("PasswordPolicyNeedsNumeric",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsNumeric, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsSymbolic = (bool?) content.GetValueForProperty("PasswordPolicyNeedsSymbolic",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsSymbolic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsUppercase = (bool?) content.GetValueForProperty("PasswordPolicyNeedsUppercase",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyNeedsUppercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyPasswordExpirationInDays = (int?) content.GetValueForProperty("PasswordPolicyPasswordExpirationInDays",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).PasswordPolicyPasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).UserPortalIdleSessionDurationMinutes = (int?) content.GetValueForProperty("UserPortalIdleSessionDurationMinutes",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).UserPortalIdleSessionDurationMinutes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemInsightEnabled = (bool?) content.GetValueForProperty("SystemInsightEnabled",((JumpCloudApiSdkV1.Models.IOrganizationsettingsputInternal)this).SystemInsightEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// OrganizationSettingsPut
    [System.ComponentModel.TypeConverter(typeof(OrganizationsettingsputTypeConverter))]
    public partial interface IOrganizationsettingsput

    {

    }
}