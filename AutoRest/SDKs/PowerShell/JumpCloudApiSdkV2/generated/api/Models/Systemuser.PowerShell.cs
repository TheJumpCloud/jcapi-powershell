namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>SystemUser</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemuserTypeConverter))]
    public partial class Systemuser
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.Systemuser"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemuser" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemuser DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Systemuser(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.Systemuser"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemuser" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemuser DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Systemuser(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Systemuser" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemuser FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.Systemuser"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Systemuser(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Mfa = (JumpCloudApiSdkV2.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Mfa, JumpCloudApiSdkV2.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AssociatedTagCount = (int?) content.GetValueForProperty("AssociatedTagCount",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AssociatedTagCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Attributes = (JumpCloudApiSdkV2.Models.ISystemuserAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserAttributesItem>(__y, JumpCloudApiSdkV2.Models.SystemuserAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalPasswordExpirationDate = (string) content.GetValueForProperty("ExternalPasswordExpirationDate",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalPasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordExpirationDate = (string) content.GetValueForProperty("PasswordExpirationDate",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordExpired = (bool?) content.GetValueForProperty("PasswordExpired",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordExpired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).SshKeys = (JumpCloudApiSdkV2.Models.ISshkeylist[]) content.GetValueForProperty("SshKeys",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISshkeylist>(__y, JumpCloudApiSdkV2.Models.SshkeylistTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).TotpEnabled = (bool?) content.GetValueForProperty("TotpEnabled",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).TotpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.Systemuser"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Systemuser(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Mfa = (JumpCloudApiSdkV2.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Mfa, JumpCloudApiSdkV2.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AssociatedTagCount = (int?) content.GetValueForProperty("AssociatedTagCount",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).AssociatedTagCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Attributes = (JumpCloudApiSdkV2.Models.ISystemuserAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISystemuserAttributesItem>(__y, JumpCloudApiSdkV2.Models.SystemuserAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalPasswordExpirationDate = (string) content.GetValueForProperty("ExternalPasswordExpirationDate",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalPasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordExpirationDate = (string) content.GetValueForProperty("PasswordExpirationDate",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordExpired = (bool?) content.GetValueForProperty("PasswordExpired",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordExpired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).SshKeys = (JumpCloudApiSdkV2.Models.ISshkeylist[]) content.GetValueForProperty("SshKeys",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.ISshkeylist>(__y, JumpCloudApiSdkV2.Models.SshkeylistTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).TotpEnabled = (bool?) content.GetValueForProperty("TotpEnabled",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).TotpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloudApiSdkV2.Models.ISystemuserInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SystemUser
    [System.ComponentModel.TypeConverter(typeof(SystemuserTypeConverter))]
    public partial interface ISystemuser

    {

    }
}