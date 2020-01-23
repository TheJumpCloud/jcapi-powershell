namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>OrganizationList</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationslistTypeConverter))]
    public partial class Organizationslist
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Organizationslist"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IOrganizationslist" />.</returns>
        public static JumpCloud.SDK.V1.Models.IOrganizationslist DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Organizationslist(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Organizationslist"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IOrganizationslist" />.</returns>
        public static JumpCloud.SDK.V1.Models.IOrganizationslist DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Organizationslist(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Organizationslist" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IOrganizationslist FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Organizationslist"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Organizationslist(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IOrganizationslistInternal)this).Results = (JumpCloud.SDK.V1.Models.IOrganizationslistResultsItem[]) content.GetValueForProperty("Results",((JumpCloud.SDK.V1.Models.IOrganizationslistInternal)this).Results, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IOrganizationslistResultsItem>(__y, JumpCloud.SDK.V1.Models.OrganizationslistResultsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IOrganizationslistInternal)this).TotalCount = (int?) content.GetValueForProperty("TotalCount",((JumpCloud.SDK.V1.Models.IOrganizationslistInternal)this).TotalCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Organizationslist"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Organizationslist(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IOrganizationslistInternal)this).Results = (JumpCloud.SDK.V1.Models.IOrganizationslistResultsItem[]) content.GetValueForProperty("Results",((JumpCloud.SDK.V1.Models.IOrganizationslistInternal)this).Results, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IOrganizationslistResultsItem>(__y, JumpCloud.SDK.V1.Models.OrganizationslistResultsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IOrganizationslistInternal)this).TotalCount = (int?) content.GetValueForProperty("TotalCount",((JumpCloud.SDK.V1.Models.IOrganizationslistInternal)this).TotalCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// OrganizationList
    [System.ComponentModel.TypeConverter(typeof(OrganizationslistTypeConverter))]
    public partial interface IOrganizationslist

    {

    }
}