namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>SystemUserPut</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemuserputTypeConverter))]
    public partial class Systemuserput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Systemuserput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ISystemuserput" />.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemuserput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Systemuserput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Systemuserput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ISystemuserput" />.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemuserput DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Systemuserput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Systemuserput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemuserput FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Systemuserput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Systemuserput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Mfa = (JumpCloudApiSdkV1.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Mfa, JumpCloudApiSdkV1.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Addresses = (JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem>(__y, JumpCloudApiSdkV1.Models.SystemuserputAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Attributes = (JumpCloudApiSdkV1.Models.ISystemuserputAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserputAttributesItem>(__y, JumpCloudApiSdkV1.Models.SystemuserputAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Password = (string) content.GetValueForProperty("Password",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Password, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PhoneNumbers = (JumpCloudApiSdkV1.Models.ISystemuserputPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserputPhoneNumbersItem>(__y, JumpCloudApiSdkV1.Models.SystemuserputPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Relationships = (JumpCloudApiSdkV1.Models.ISystemuserputRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserputRelationshipsItem>(__y, JumpCloudApiSdkV1.Models.SystemuserputRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).SshKeys = (JumpCloudApiSdkV1.Models.ISshkeypost[]) content.GetValueForProperty("SshKeys",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISshkeypost>(__y, JumpCloudApiSdkV1.Models.SshkeypostTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Systemuserput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Systemuserput(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Mfa = (JumpCloudApiSdkV1.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Mfa, JumpCloudApiSdkV1.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Addresses = (JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem>(__y, JumpCloudApiSdkV1.Models.SystemuserputAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Attributes = (JumpCloudApiSdkV1.Models.ISystemuserputAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserputAttributesItem>(__y, JumpCloudApiSdkV1.Models.SystemuserputAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Password = (string) content.GetValueForProperty("Password",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Password, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PhoneNumbers = (JumpCloudApiSdkV1.Models.ISystemuserputPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserputPhoneNumbersItem>(__y, JumpCloudApiSdkV1.Models.SystemuserputPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Relationships = (JumpCloudApiSdkV1.Models.ISystemuserputRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserputRelationshipsItem>(__y, JumpCloudApiSdkV1.Models.SystemuserputRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).SshKeys = (JumpCloudApiSdkV1.Models.ISshkeypost[]) content.GetValueForProperty("SshKeys",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISshkeypost>(__y, JumpCloudApiSdkV1.Models.SshkeypostTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloudApiSdkV1.Models.ISystemuserputInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SystemUserPut
    [System.ComponentModel.TypeConverter(typeof(SystemuserputTypeConverter))]
    public partial interface ISystemuserput

    {

    }
}