namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>SystemUserReturn</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemuserreturnTypeConverter))]
    public partial class Systemuserreturn
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Systemuserreturn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ISystemuserreturn" />.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemuserreturn DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Systemuserreturn(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Systemuserreturn"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ISystemuserreturn" />.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemuserreturn DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Systemuserreturn(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Systemuserreturn" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemuserreturn FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Systemuserreturn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Systemuserreturn(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Mfa = (JumpCloudApiSdkV1.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Mfa, JumpCloudApiSdkV1.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Addresses = (JumpCloudApiSdkV1.Models.ISystemuserreturnAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserreturnAddressesItem>(__y, JumpCloudApiSdkV1.Models.SystemuserreturnAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Attributes = (JumpCloudApiSdkV1.Models.ISystemuserreturnAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserreturnAttributesItem>(__y, JumpCloudApiSdkV1.Models.SystemuserreturnAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).BadLoginAttempts = (int?) content.GetValueForProperty("BadLoginAttempts",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).BadLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordExpirationDate = (string) content.GetValueForProperty("PasswordExpirationDate",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordExpired = (bool?) content.GetValueForProperty("PasswordExpired",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordExpired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PhoneNumbers = (JumpCloudApiSdkV1.Models.ISystemuserreturnPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserreturnPhoneNumbersItem>(__y, JumpCloudApiSdkV1.Models.SystemuserreturnPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Relationships = (JumpCloudApiSdkV1.Models.ISystemuserreturnRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserreturnRelationshipsItem>(__y, JumpCloudApiSdkV1.Models.SystemuserreturnRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).SshKeys = (JumpCloudApiSdkV1.Models.ISshkeylist[]) content.GetValueForProperty("SshKeys",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISshkeylist>(__y, JumpCloudApiSdkV1.Models.SshkeylistTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).TotpEnabled = (bool?) content.GetValueForProperty("TotpEnabled",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).TotpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Systemuserreturn"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Systemuserreturn(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Mfa = (JumpCloudApiSdkV1.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Mfa, JumpCloudApiSdkV1.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Addresses = (JumpCloudApiSdkV1.Models.ISystemuserreturnAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserreturnAddressesItem>(__y, JumpCloudApiSdkV1.Models.SystemuserreturnAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Attributes = (JumpCloudApiSdkV1.Models.ISystemuserreturnAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserreturnAttributesItem>(__y, JumpCloudApiSdkV1.Models.SystemuserreturnAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).BadLoginAttempts = (int?) content.GetValueForProperty("BadLoginAttempts",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).BadLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordExpirationDate = (string) content.GetValueForProperty("PasswordExpirationDate",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordExpired = (bool?) content.GetValueForProperty("PasswordExpired",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordExpired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PhoneNumbers = (JumpCloudApiSdkV1.Models.ISystemuserreturnPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserreturnPhoneNumbersItem>(__y, JumpCloudApiSdkV1.Models.SystemuserreturnPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Relationships = (JumpCloudApiSdkV1.Models.ISystemuserreturnRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemuserreturnRelationshipsItem>(__y, JumpCloudApiSdkV1.Models.SystemuserreturnRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).SshKeys = (JumpCloudApiSdkV1.Models.ISshkeylist[]) content.GetValueForProperty("SshKeys",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISshkeylist>(__y, JumpCloudApiSdkV1.Models.SshkeylistTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).TotpEnabled = (bool?) content.GetValueForProperty("TotpEnabled",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).TotpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloudApiSdkV1.Models.ISystemuserreturnInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SystemUserReturn
    [System.ComponentModel.TypeConverter(typeof(SystemuserreturnTypeConverter))]
    public partial interface ISystemuserreturn

    {

    }
}