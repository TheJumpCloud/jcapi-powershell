namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>ApplicationTemplate</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationtemplateTypeConverter))]
    public partial class Applicationtemplate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Applicationtemplate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Applicationtemplate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Jit = (JumpCloud.SDK.V1.Models.IApplicationtemplateJit) content.GetValueForProperty("Jit",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Jit, JumpCloud.SDK.V1.Models.ApplicationtemplateJitTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Beta = (bool?) content.GetValueForProperty("Beta",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Beta, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Color = (string) content.GetValueForProperty("Color",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Color, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).DisplayLabel = (string) content.GetValueForProperty("DisplayLabel",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).DisplayLabel, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).IsConfigured = (bool?) content.GetValueForProperty("IsConfigured",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).IsConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).LearnMore = (string) content.GetValueForProperty("LearnMore",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).LearnMore, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).SsoUrl = (string) content.GetValueForProperty("SsoUrl",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).SsoUrl, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Config = (JumpCloud.SDK.V1.Models.IApplicationtemplateConfig) content.GetValueForProperty("Config",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Config, JumpCloud.SDK.V1.Models.ApplicationtemplateConfigTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).JitAttributes = (JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes) content.GetValueForProperty("JitAttributes",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).JitAttributes, JumpCloud.SDK.V1.Models.ApplicationtemplateJitAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).JitCreateOnly = (bool?) content.GetValueForProperty("JitCreateOnly",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).JitCreateOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Applicationtemplate"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Applicationtemplate(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Jit = (JumpCloud.SDK.V1.Models.IApplicationtemplateJit) content.GetValueForProperty("Jit",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Jit, JumpCloud.SDK.V1.Models.ApplicationtemplateJitTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Beta = (bool?) content.GetValueForProperty("Beta",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Beta, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Color = (string) content.GetValueForProperty("Color",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Color, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).DisplayLabel = (string) content.GetValueForProperty("DisplayLabel",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).DisplayLabel, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).IsConfigured = (bool?) content.GetValueForProperty("IsConfigured",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).IsConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).LearnMore = (string) content.GetValueForProperty("LearnMore",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).LearnMore, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).SsoUrl = (string) content.GetValueForProperty("SsoUrl",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).SsoUrl, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Config = (JumpCloud.SDK.V1.Models.IApplicationtemplateConfig) content.GetValueForProperty("Config",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).Config, JumpCloud.SDK.V1.Models.ApplicationtemplateConfigTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).JitAttributes = (JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes) content.GetValueForProperty("JitAttributes",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).JitAttributes, JumpCloud.SDK.V1.Models.ApplicationtemplateJitAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).JitCreateOnly = (bool?) content.GetValueForProperty("JitCreateOnly",((JumpCloud.SDK.V1.Models.IApplicationtemplateInternal)this).JitCreateOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Applicationtemplate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationtemplate" />.</returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Applicationtemplate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Applicationtemplate"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationtemplate" />.</returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplate DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Applicationtemplate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Applicationtemplate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplate FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// ApplicationTemplate
    [System.ComponentModel.TypeConverter(typeof(ApplicationtemplateTypeConverter))]
    public partial interface IApplicationtemplate

    {

    }
}