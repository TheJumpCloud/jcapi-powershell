namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.Systemuser"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemuser" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemuser DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Systemuser(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.Systemuser"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemuser" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemuser DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Systemuser(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Systemuser" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemuser FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.Systemuser"
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
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Mfa = (JumpCloud.SDK.V2.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Mfa, JumpCloud.SDK.V2.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AssociatedTagCount = (int?) content.GetValueForProperty("AssociatedTagCount",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AssociatedTagCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Attributes = (JumpCloud.SDK.V2.Models.ISystemuserAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.ISystemuserAttributesItem>(__y, JumpCloud.SDK.V2.Models.SystemuserAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalPasswordExpirationDate = (string) content.GetValueForProperty("ExternalPasswordExpirationDate",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalPasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordExpirationDate = (string) content.GetValueForProperty("PasswordExpirationDate",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordExpired = (bool?) content.GetValueForProperty("PasswordExpired",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordExpired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).SshKeys = (JumpCloud.SDK.V2.Models.ISshkeylist[]) content.GetValueForProperty("SshKeys",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.ISshkeylist>(__y, JumpCloud.SDK.V2.Models.SshkeylistTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).TotpEnabled = (bool?) content.GetValueForProperty("TotpEnabled",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).TotpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.Systemuser"
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
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Mfa = (JumpCloud.SDK.V2.Models.IMfa) content.GetValueForProperty("Mfa",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Mfa, JumpCloud.SDK.V2.Models.MfaTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AccountLocked = (bool?) content.GetValueForProperty("AccountLocked",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Activated = (bool?) content.GetValueForProperty("Activated",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Activated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AllowPublicKey = (bool?) content.GetValueForProperty("AllowPublicKey",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AllowPublicKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AssociatedTagCount = (int?) content.GetValueForProperty("AssociatedTagCount",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).AssociatedTagCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Attributes = (JumpCloud.SDK.V2.Models.ISystemuserAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.ISystemuserAttributesItem>(__y, JumpCloud.SDK.V2.Models.SystemuserAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Company = (string) content.GetValueForProperty("Company",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Company, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).CostCenter = (string) content.GetValueForProperty("CostCenter",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).CostCenter, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Department = (string) content.GetValueForProperty("Department",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Department, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Displayname = (string) content.GetValueForProperty("Displayname",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Displayname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EmployeeIdentifier = (string) content.GetValueForProperty("EmployeeIdentifier",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EmployeeIdentifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EmployeeType = (string) content.GetValueForProperty("EmployeeType",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EmployeeType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EnableManagedUid = (bool?) content.GetValueForProperty("EnableManagedUid",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EnableManagedUid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EnableUserPortalMultifactor = (bool?) content.GetValueForProperty("EnableUserPortalMultifactor",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).EnableUserPortalMultifactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalPasswordExpirationDate = (string) content.GetValueForProperty("ExternalPasswordExpirationDate",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalPasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).JobTitle = (string) content.GetValueForProperty("JobTitle",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).JobTitle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).LdapBindingUser = (bool?) content.GetValueForProperty("LdapBindingUser",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).LdapBindingUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Middlename = (string) content.GetValueForProperty("Middlename",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Middlename, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordExpirationDate = (string) content.GetValueForProperty("PasswordExpirationDate",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordExpirationDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordExpired = (bool?) content.GetValueForProperty("PasswordExpired",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordExpired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordNeverExpires = (bool?) content.GetValueForProperty("PasswordNeverExpires",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordNeverExpires, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordlessSudo = (bool?) content.GetValueForProperty("PasswordlessSudo",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PasswordlessSudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PublicKey = (string) content.GetValueForProperty("PublicKey",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).PublicKey, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).SambaServiceUser = (bool?) content.GetValueForProperty("SambaServiceUser",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).SambaServiceUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).SshKeys = (JumpCloud.SDK.V2.Models.ISshkeylist[]) content.GetValueForProperty("SshKeys",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).SshKeys, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.ISshkeylist>(__y, JumpCloud.SDK.V2.Models.SshkeylistTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Suspended = (bool?) content.GetValueForProperty("Suspended",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Suspended, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).TotpEnabled = (bool?) content.GetValueForProperty("TotpEnabled",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).TotpEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).UnixGuid = (int?) content.GetValueForProperty("UnixGuid",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).UnixGuid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).UnixUid = (int?) content.GetValueForProperty("UnixUid",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).UnixUid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaExclusionUntil = (global::System.DateTime?) content.GetValueForProperty("MfaExclusionUntil",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaExclusionUntil, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaConfigured = (bool?) content.GetValueForProperty("MfaConfigured",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaExclusion = (bool?) content.GetValueForProperty("MfaExclusion",((JumpCloud.SDK.V2.Models.ISystemuserInternal)this).MfaExclusion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SystemUser
    [System.ComponentModel.TypeConverter(typeof(SystemuserTypeConverter))]
    public partial interface ISystemuser

    {

    }
}