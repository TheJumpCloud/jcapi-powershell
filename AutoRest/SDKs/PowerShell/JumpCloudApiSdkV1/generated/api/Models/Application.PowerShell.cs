namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>Application</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationTypeConverter))]
    public partial class Application
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Application"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Application(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Beta = (bool?) content.GetValueForProperty("Beta",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Beta, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).DisplayLabel = (string) content.GetValueForProperty("DisplayLabel",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).DisplayLabel, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).LearnMore = (string) content.GetValueForProperty("LearnMore",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).LearnMore, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).SsoUrl = (string) content.GetValueForProperty("SsoUrl",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).SsoUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Config = (JumpCloudApiSdkV1.Models.IApplicationConfig) content.GetValueForProperty("Config",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Config, JumpCloudApiSdkV1.Models.ApplicationConfigTypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Application"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Application(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Beta = (bool?) content.GetValueForProperty("Beta",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Beta, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).DisplayLabel = (string) content.GetValueForProperty("DisplayLabel",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).DisplayLabel, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).LearnMore = (string) content.GetValueForProperty("LearnMore",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).LearnMore, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).SsoUrl = (string) content.GetValueForProperty("SsoUrl",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).SsoUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Config = (JumpCloudApiSdkV1.Models.IApplicationConfig) content.GetValueForProperty("Config",((JumpCloudApiSdkV1.Models.IApplicationInternal)this).Config, JumpCloudApiSdkV1.Models.ApplicationConfigTypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Application"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IApplication" />.</returns>
        public static JumpCloudApiSdkV1.Models.IApplication DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Application(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Application"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IApplication" />.</returns>
        public static JumpCloudApiSdkV1.Models.IApplication DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Application(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Application" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.IApplication FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Application
    [System.ComponentModel.TypeConverter(typeof(ApplicationTypeConverter))]
    public partial interface IApplication

    {

    }
}