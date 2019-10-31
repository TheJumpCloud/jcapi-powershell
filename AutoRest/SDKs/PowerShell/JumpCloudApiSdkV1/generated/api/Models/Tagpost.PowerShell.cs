namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>TagPost</summary>
    [System.ComponentModel.TypeConverter(typeof(TagpostTypeConverter))]
    public partial class Tagpost
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Tagpost"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ITagpost" />.</returns>
        public static JumpCloudApiSdkV1.Models.ITagpost DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Tagpost(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Tagpost"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ITagpost" />.</returns>
        public static JumpCloudApiSdkV1.Models.ITagpost DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Tagpost(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Tagpost" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.ITagpost FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Tagpost"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Tagpost(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExpirationTime = (int?) content.GetValueForProperty("ExpirationTime",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExpirationTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).GroupGid = (string) content.GetValueForProperty("GroupGid",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).GroupGid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).GroupName = (string) content.GetValueForProperty("GroupName",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).GroupName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).RegularExpressions = (string[]) content.GetValueForProperty("RegularExpressions",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).RegularExpressions, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).SendToLdap = (bool?) content.GetValueForProperty("SendToLdap",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).SendToLdap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Systems = (string[]) content.GetValueForProperty("Systems",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Systems, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Systemusers = (string[]) content.GetValueForProperty("Systemusers",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Systemusers, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Tagpost"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Tagpost(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExpirationTime = (int?) content.GetValueForProperty("ExpirationTime",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExpirationTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternalDn = (string) content.GetValueForProperty("ExternalDn",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternalDn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternalSourceType = (string) content.GetValueForProperty("ExternalSourceType",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternalSourceType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternallyManaged = (bool?) content.GetValueForProperty("ExternallyManaged",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).ExternallyManaged, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).GroupGid = (string) content.GetValueForProperty("GroupGid",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).GroupGid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).GroupName = (string) content.GetValueForProperty("GroupName",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).GroupName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).RegularExpressions = (string[]) content.GetValueForProperty("RegularExpressions",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).RegularExpressions, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).SendToLdap = (bool?) content.GetValueForProperty("SendToLdap",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).SendToLdap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Systems = (string[]) content.GetValueForProperty("Systems",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Systems, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Systemusers = (string[]) content.GetValueForProperty("Systemusers",((JumpCloudApiSdkV1.Models.ITagpostInternal)this).Systemusers, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// TagPost
    [System.ComponentModel.TypeConverter(typeof(TagpostTypeConverter))]
    public partial interface ITagpost

    {

    }
}