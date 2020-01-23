namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>Job Details</summary>
    [System.ComponentModel.TypeConverter(typeof(JobDetailsTypeConverter))]
    public partial class JobDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.JobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IJobDetails" />.</returns>
        public static JumpCloud.SDK.V2.Models.IJobDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JobDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.JobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IJobDetails" />.</returns>
        public static JumpCloud.SDK.V2.Models.IJobDetails DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new JobDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JobDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IJobDetails FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.JobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JobDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).AdminId = (string) content.GetValueForProperty("AdminId",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).AdminId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).CreatedAt = (string) content.GetValueForProperty("CreatedAt",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).CreatedAt, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Meta = (JumpCloud.SDK.V2.Models.IJobDetailsMeta) content.GetValueForProperty("Meta",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Meta, JumpCloud.SDK.V2.Models.JobDetailsMetaTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).PersistedFields = (string[]) content.GetValueForProperty("PersistedFields",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).PersistedFields, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Status = (string) content.GetValueForProperty("Status",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Status, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).UpdatedAt = (string) content.GetValueForProperty("UpdatedAt",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).UpdatedAt, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).WorkUnitsCount = (int?) content.GetValueForProperty("WorkUnitsCount",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).WorkUnitsCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.JobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal JobDetails(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).AdminId = (string) content.GetValueForProperty("AdminId",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).AdminId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).CreatedAt = (string) content.GetValueForProperty("CreatedAt",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).CreatedAt, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Meta = (JumpCloud.SDK.V2.Models.IJobDetailsMeta) content.GetValueForProperty("Meta",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Meta, JumpCloud.SDK.V2.Models.JobDetailsMetaTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).PersistedFields = (string[]) content.GetValueForProperty("PersistedFields",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).PersistedFields, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Status = (string) content.GetValueForProperty("Status",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).Status, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).UpdatedAt = (string) content.GetValueForProperty("UpdatedAt",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).UpdatedAt, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).WorkUnitsCount = (int?) content.GetValueForProperty("WorkUnitsCount",((JumpCloud.SDK.V2.Models.IJobDetailsInternal)this).WorkUnitsCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Job Details
    [System.ComponentModel.TypeConverter(typeof(JobDetailsTypeConverter))]
    public partial interface IJobDetails

    {

    }
}