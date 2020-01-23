namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>FIXME: Class OrganizationsettingsputPasswordPolicy is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationsettingsputPasswordPolicyTypeConverter))]
    public partial class OrganizationsettingsputPasswordPolicy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.OrganizationsettingsputPasswordPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicy" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrganizationsettingsputPasswordPolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.OrganizationsettingsputPasswordPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicy" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicy DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new OrganizationsettingsputPasswordPolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrganizationsettingsputPasswordPolicy" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicy FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.OrganizationsettingsputPasswordPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OrganizationsettingsputPasswordPolicy(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).AllowUsernameSubstring = (bool?) content.GetValueForProperty("AllowUsernameSubstring",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).AllowUsernameSubstring, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).DaysAfterExpirationToSelfRecover = (int?) content.GetValueForProperty("DaysAfterExpirationToSelfRecover",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).DaysAfterExpirationToSelfRecover, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).DaysBeforeExpirationToForceReset = (int?) content.GetValueForProperty("DaysBeforeExpirationToForceReset",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).DaysBeforeExpirationToForceReset, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableDaysAfterExpirationToSelfRecover = (bool?) content.GetValueForProperty("EnableDaysAfterExpirationToSelfRecover",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableDaysAfterExpirationToSelfRecover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableDaysBeforeExpirationToForceReset = (bool?) content.GetValueForProperty("EnableDaysBeforeExpirationToForceReset",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableDaysBeforeExpirationToForceReset, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableLockoutTimeInSeconds = (bool?) content.GetValueForProperty("EnableLockoutTimeInSeconds",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableLockoutTimeInSeconds, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMaxHistory = (bool?) content.GetValueForProperty("EnableMaxHistory",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMaxHistory, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMaxLoginAttempts = (bool?) content.GetValueForProperty("EnableMaxLoginAttempts",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMaxLoginAttempts, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMinChangePeriodInDays = (bool?) content.GetValueForProperty("EnableMinChangePeriodInDays",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMinChangePeriodInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMinLength = (bool?) content.GetValueForProperty("EnableMinLength",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMinLength, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnablePasswordExpirationInDays = (bool?) content.GetValueForProperty("EnablePasswordExpirationInDays",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnablePasswordExpirationInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).LockoutTimeInSeconds = (int?) content.GetValueForProperty("LockoutTimeInSeconds",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).LockoutTimeInSeconds, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MaxHistory = (int?) content.GetValueForProperty("MaxHistory",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MaxHistory, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MaxLoginAttempts = (int?) content.GetValueForProperty("MaxLoginAttempts",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MaxLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MinChangePeriodInDays = (int?) content.GetValueForProperty("MinChangePeriodInDays",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MinChangePeriodInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MinLength = (int?) content.GetValueForProperty("MinLength",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MinLength, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsLowercase = (bool?) content.GetValueForProperty("NeedsLowercase",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsLowercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsNumeric = (bool?) content.GetValueForProperty("NeedsNumeric",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsNumeric, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsSymbolic = (bool?) content.GetValueForProperty("NeedsSymbolic",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsSymbolic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsUppercase = (bool?) content.GetValueForProperty("NeedsUppercase",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsUppercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).PasswordExpirationInDays = (int?) content.GetValueForProperty("PasswordExpirationInDays",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).PasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.OrganizationsettingsputPasswordPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal OrganizationsettingsputPasswordPolicy(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).AllowUsernameSubstring = (bool?) content.GetValueForProperty("AllowUsernameSubstring",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).AllowUsernameSubstring, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).DaysAfterExpirationToSelfRecover = (int?) content.GetValueForProperty("DaysAfterExpirationToSelfRecover",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).DaysAfterExpirationToSelfRecover, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).DaysBeforeExpirationToForceReset = (int?) content.GetValueForProperty("DaysBeforeExpirationToForceReset",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).DaysBeforeExpirationToForceReset, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableDaysAfterExpirationToSelfRecover = (bool?) content.GetValueForProperty("EnableDaysAfterExpirationToSelfRecover",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableDaysAfterExpirationToSelfRecover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableDaysBeforeExpirationToForceReset = (bool?) content.GetValueForProperty("EnableDaysBeforeExpirationToForceReset",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableDaysBeforeExpirationToForceReset, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableLockoutTimeInSeconds = (bool?) content.GetValueForProperty("EnableLockoutTimeInSeconds",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableLockoutTimeInSeconds, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMaxHistory = (bool?) content.GetValueForProperty("EnableMaxHistory",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMaxHistory, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMaxLoginAttempts = (bool?) content.GetValueForProperty("EnableMaxLoginAttempts",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMaxLoginAttempts, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMinChangePeriodInDays = (bool?) content.GetValueForProperty("EnableMinChangePeriodInDays",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMinChangePeriodInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMinLength = (bool?) content.GetValueForProperty("EnableMinLength",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnableMinLength, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnablePasswordExpirationInDays = (bool?) content.GetValueForProperty("EnablePasswordExpirationInDays",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).EnablePasswordExpirationInDays, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).LockoutTimeInSeconds = (int?) content.GetValueForProperty("LockoutTimeInSeconds",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).LockoutTimeInSeconds, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MaxHistory = (int?) content.GetValueForProperty("MaxHistory",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MaxHistory, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MaxLoginAttempts = (int?) content.GetValueForProperty("MaxLoginAttempts",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MaxLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MinChangePeriodInDays = (int?) content.GetValueForProperty("MinChangePeriodInDays",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MinChangePeriodInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MinLength = (int?) content.GetValueForProperty("MinLength",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).MinLength, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsLowercase = (bool?) content.GetValueForProperty("NeedsLowercase",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsLowercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsNumeric = (bool?) content.GetValueForProperty("NeedsNumeric",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsNumeric, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsSymbolic = (bool?) content.GetValueForProperty("NeedsSymbolic",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsSymbolic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsUppercase = (bool?) content.GetValueForProperty("NeedsUppercase",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).NeedsUppercase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).PasswordExpirationInDays = (int?) content.GetValueForProperty("PasswordExpirationInDays",((JumpCloud.SDK.V1.Models.IOrganizationsettingsputPasswordPolicyInternal)this).PasswordExpirationInDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IOrganizationsettingsputPasswordPolicy is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(OrganizationsettingsputPasswordPolicyTypeConverter))]
    public partial interface IOrganizationsettingsputPasswordPolicy

    {

    }
}