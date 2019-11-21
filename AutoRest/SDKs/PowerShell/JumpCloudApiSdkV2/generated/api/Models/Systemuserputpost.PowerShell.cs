namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>SystemUserPost</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemuserputpostTypeConverter))]
    public partial class Systemuserputpost
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.Systemuserputpost"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemuserputpost" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemuserputpost DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Systemuserputpost(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.Systemuserputpost"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemuserputpost" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemuserputpost DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Systemuserputpost(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Systemuserputpost" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemuserputpost FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.Systemuserputpost"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Systemuserputpost(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Mfa = (JumpCloudApiSdkV2.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Mfa, JumpCloudApiSdkV2.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Addresses = (JumpCloudApiSdkV2.Models.ISystemuserputpostAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserputpostAddressesItem>(__y, JumpCloudApiSdkV2.Models.SystemuserputpostAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Attributes = (JumpCloudApiSdkV2.Models.ISystemuserputpostAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserputpostAttributesItem>(__y, JumpCloudApiSdkV2.Models.SystemuserputpostAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Password = (string) content.GetValueForProperty("Password",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Password, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PhoneNumbers = (JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem>(__y, JumpCloudApiSdkV2.Models.SystemuserputpostPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Relationships = (JumpCloudApiSdkV2.Models.ISystemuserputpostRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserputpostRelationshipsItem>(__y, JumpCloudApiSdkV2.Models.SystemuserputpostRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.Systemuserputpost"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Systemuserputpost(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Mfa = (JumpCloudApiSdkV2.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Mfa, JumpCloudApiSdkV2.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Addresses = (JumpCloudApiSdkV2.Models.ISystemuserputpostAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserputpostAddressesItem>(__y, JumpCloudApiSdkV2.Models.SystemuserputpostAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Attributes = (JumpCloudApiSdkV2.Models.ISystemuserputpostAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserputpostAttributesItem>(__y, JumpCloudApiSdkV2.Models.SystemuserputpostAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Password = (string) content.GetValueForProperty("Password",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Password, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PhoneNumbers = (JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserputpostPhoneNumbersItem>(__y, JumpCloudApiSdkV2.Models.SystemuserputpostPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Relationships = (JumpCloudApiSdkV2.Models.ISystemuserputpostRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserputpostRelationshipsItem>(__y, JumpCloudApiSdkV2.Models.SystemuserputpostRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloudApiSdkV2.Models.ISystemuserputpostInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SystemUserPost
    [System.ComponentModel.TypeConverter(typeof(SystemuserputpostTypeConverter))]
    public partial interface ISystemuserputpost

    {

    }
}