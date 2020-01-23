namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>Search</summary>
    [System.ComponentModel.TypeConverter(typeof(SearchTypeConverter))]
    public partial class Search
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Search"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ISearch" />.</returns>
        public static JumpCloud.SDK.V1.Models.ISearch DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Search(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Search"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ISearch" />.</returns>
        public static JumpCloud.SDK.V1.Models.ISearch DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Search(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Search" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.ISearch FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Search"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Search(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ISearchInternal)this).Fields = (string) content.GetValueForProperty("Fields",((JumpCloud.SDK.V1.Models.ISearchInternal)this).Fields, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISearchInternal)this).Filter = (JumpCloud.SDK.V1.Models.ISearchFilter) content.GetValueForProperty("Filter",((JumpCloud.SDK.V1.Models.ISearchInternal)this).Filter, JumpCloud.SDK.V1.Models.SearchFilterTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.ISearchInternal)this).SearchFilter = (JumpCloud.SDK.V1.Models.ISearchFilter1) content.GetValueForProperty("SearchFilter",((JumpCloud.SDK.V1.Models.ISearchInternal)this).SearchFilter, JumpCloud.SDK.V1.Models.SearchFilter1TypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Search"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Search(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ISearchInternal)this).Fields = (string) content.GetValueForProperty("Fields",((JumpCloud.SDK.V1.Models.ISearchInternal)this).Fields, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISearchInternal)this).Filter = (JumpCloud.SDK.V1.Models.ISearchFilter) content.GetValueForProperty("Filter",((JumpCloud.SDK.V1.Models.ISearchInternal)this).Filter, JumpCloud.SDK.V1.Models.SearchFilterTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.ISearchInternal)this).SearchFilter = (JumpCloud.SDK.V1.Models.ISearchFilter1) content.GetValueForProperty("SearchFilter",((JumpCloud.SDK.V1.Models.ISearchInternal)this).SearchFilter, JumpCloud.SDK.V1.Models.SearchFilter1TypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Search
    [System.ComponentModel.TypeConverter(typeof(SearchTypeConverter))]
    public partial interface ISearch

    {

    }
}