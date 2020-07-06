// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

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
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

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
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Systemuserput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ISystemuserput" />.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Systemuserput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Systemuserput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ISystemuserput" />.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Systemuserput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Systemuserput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserput FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Systemuserput"
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
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Mfa = (JumpCloud.SDK.V1.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Mfa, JumpCloud.SDK.V1.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Addresses = (JumpCloud.SDK.V1.Models.ISystemuserputAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserputAddressesItem>(__y, JumpCloud.SDK.V1.Models.SystemuserputAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Attributes = (JumpCloud.SDK.V1.Models.ISystemuserputAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserputAttributesItem>(__y, JumpCloud.SDK.V1.Models.SystemuserputAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalPasswordExpirationDate = (string) content.GetValueForProperty("ExternalPasswordExpirationDate",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalPasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Password = (string) content.GetValueForProperty("Password",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Password, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PhoneNumbers = (JumpCloud.SDK.V1.Models.ISystemuserputPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserputPhoneNumbersItem>(__y, JumpCloud.SDK.V1.Models.SystemuserputPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Relationships = (JumpCloud.SDK.V1.Models.ISystemuserputRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserputRelationshipsItem>(__y, JumpCloud.SDK.V1.Models.SystemuserputRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).SshKeys = (JumpCloud.SDK.V1.Models.ISshkeypost[]) content.GetValueForProperty("SshKeys",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISshkeypost>(__y, JumpCloud.SDK.V1.Models.SshkeypostTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Systemuserput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Systemuserput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Mfa = (JumpCloud.SDK.V1.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Mfa, JumpCloud.SDK.V1.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Addresses = (JumpCloud.SDK.V1.Models.ISystemuserputAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserputAddressesItem>(__y, JumpCloud.SDK.V1.Models.SystemuserputAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Attributes = (JumpCloud.SDK.V1.Models.ISystemuserputAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserputAttributesItem>(__y, JumpCloud.SDK.V1.Models.SystemuserputAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalPasswordExpirationDate = (string) content.GetValueForProperty("ExternalPasswordExpirationDate",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalPasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Password = (string) content.GetValueForProperty("Password",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Password, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PhoneNumbers = (JumpCloud.SDK.V1.Models.ISystemuserputPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserputPhoneNumbersItem>(__y, JumpCloud.SDK.V1.Models.SystemuserputPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Relationships = (JumpCloud.SDK.V1.Models.ISystemuserputRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserputRelationshipsItem>(__y, JumpCloud.SDK.V1.Models.SystemuserputRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).SshKeys = (JumpCloud.SDK.V1.Models.ISshkeypost[]) content.GetValueForProperty("SshKeys",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISshkeypost>(__y, JumpCloud.SDK.V1.Models.SshkeypostTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloud.SDK.V1.Models.ISystemuserputInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SystemUserPut
    [System.ComponentModel.TypeConverter(typeof(SystemuserputTypeConverter))]
    public partial interface ISystemuserput

    {

    }
}