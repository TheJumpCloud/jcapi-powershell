namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>Organization</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationTypeConverter))]
    public partial class Organization
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Organization"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IOrganization" />.</returns>
        public static JumpCloudApiSdkV1.Models.IOrganization DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Organization(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Organization"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IOrganization" />.</returns>
        public static JumpCloudApiSdkV1.Models.IOrganization DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Organization(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Organization" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.IOrganization FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Organization"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Organization(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).HasStripeCustomerId = (bool?) content.GetValueForProperty("HasStripeCustomerId",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).HasStripeCustomerId, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).LogoUrl = (string) content.GetValueForProperty("LogoUrl",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).LogoUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Provider = (string) content.GetValueForProperty("Provider",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Provider, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Settings = (JumpCloudApiSdkV1.Models.IOrganizationsettings) content.GetValueForProperty("Settings",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Settings, JumpCloudApiSdkV1.Models.OrganizationsettingsTypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Organization"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Organization(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).HasStripeCustomerId = (bool?) content.GetValueForProperty("HasStripeCustomerId",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).HasStripeCustomerId, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).LogoUrl = (string) content.GetValueForProperty("LogoUrl",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).LogoUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Provider = (string) content.GetValueForProperty("Provider",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Provider, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Settings = (JumpCloudApiSdkV1.Models.IOrganizationsettings) content.GetValueForProperty("Settings",((JumpCloudApiSdkV1.Models.IOrganizationInternal)this).Settings, JumpCloudApiSdkV1.Models.OrganizationsettingsTypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Organization
    [System.ComponentModel.TypeConverter(typeof(OrganizationTypeConverter))]
    public partial interface IOrganization

    {

    }
}