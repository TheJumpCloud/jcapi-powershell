namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Systemuserreturn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ISystemuserreturn" />.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserreturn DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Systemuserreturn(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Systemuserreturn"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ISystemuserreturn" />.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserreturn DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Systemuserreturn(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Systemuserreturn" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserreturn FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Systemuserreturn"
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
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Mfa = (JumpCloud.SDK.V1.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Mfa, JumpCloud.SDK.V1.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Addresses = (JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItem>(__y, JumpCloud.SDK.V1.Models.SystemuserreturnAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Attributes = (JumpCloud.SDK.V1.Models.ISystemuserreturnAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserreturnAttributesItem>(__y, JumpCloud.SDK.V1.Models.SystemuserreturnAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).BadLoginAttempts = (int?) content.GetValueForProperty("BadLoginAttempts",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).BadLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalPasswordExpirationDate = (string) content.GetValueForProperty("ExternalPasswordExpirationDate",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalPasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordExpirationDate = (string) content.GetValueForProperty("PasswordExpirationDate",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordExpired = (bool?) content.GetValueForProperty("PasswordExpired",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordExpired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PhoneNumbers = (JumpCloud.SDK.V1.Models.ISystemuserreturnPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserreturnPhoneNumbersItem>(__y, JumpCloud.SDK.V1.Models.SystemuserreturnPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Relationships = (JumpCloud.SDK.V1.Models.ISystemuserreturnRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserreturnRelationshipsItem>(__y, JumpCloud.SDK.V1.Models.SystemuserreturnRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).SshKeys = (JumpCloud.SDK.V1.Models.ISshkeylist[]) content.GetValueForProperty("SshKeys",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISshkeylist>(__y, JumpCloud.SDK.V1.Models.SshkeylistTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).TotpEnabled = (bool?) content.GetValueForProperty("TotpEnabled",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).TotpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Systemuserreturn"
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
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Mfa = (JumpCloud.SDK.V1.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Mfa, JumpCloud.SDK.V1.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Addresses = (JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItem[]) content.GetValueForProperty("Addresses",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Addresses, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItem>(__y, JumpCloud.SDK.V1.Models.SystemuserreturnAddressesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Attributes = (JumpCloud.SDK.V1.Models.ISystemuserreturnAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserreturnAttributesItem>(__y, JumpCloud.SDK.V1.Models.SystemuserreturnAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).BadLoginAttempts = (int?) content.GetValueForProperty("BadLoginAttempts",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).BadLoginAttempts, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalPasswordExpirationDate = (string) content.GetValueForProperty("ExternalPasswordExpirationDate",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalPasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordExpirationDate = (string) content.GetValueForProperty("PasswordExpirationDate",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordExpired = (bool?) content.GetValueForProperty("PasswordExpired",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordExpired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PhoneNumbers = (JumpCloud.SDK.V1.Models.ISystemuserreturnPhoneNumbersItem[]) content.GetValueForProperty("PhoneNumbers",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PhoneNumbers, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserreturnPhoneNumbersItem>(__y, JumpCloud.SDK.V1.Models.SystemuserreturnPhoneNumbersItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Relationships = (JumpCloud.SDK.V1.Models.ISystemuserreturnRelationshipsItem[]) content.GetValueForProperty("Relationships",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Relationships, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISystemuserreturnRelationshipsItem>(__y, JumpCloud.SDK.V1.Models.SystemuserreturnRelationshipsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).SshKeys = (JumpCloud.SDK.V1.Models.ISshkeylist[]) content.GetValueForProperty("SshKeys",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ISshkeylist>(__y, JumpCloud.SDK.V1.Models.SshkeylistTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).TotpEnabled = (bool?) content.GetValueForProperty("TotpEnabled",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).TotpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloud.SDK.V1.Models.ISystemuserreturnInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SystemUserReturn
    [System.ComponentModel.TypeConverter(typeof(SystemuserreturnTypeConverter))]
    public partial interface ISystemuserreturn

    {

    }
}