namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights Firefox Addons</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsFirefoxAddonsTypeConverter))]
    public partial class SystemInsightsFirefoxAddons
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsFirefoxAddons"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddons" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddons DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsFirefoxAddons(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsFirefoxAddons"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddons" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddons DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsFirefoxAddons(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsFirefoxAddons" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddons FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsFirefoxAddons"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsFirefoxAddons(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Active = (int?) content.GetValueForProperty("Active",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Active, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Autoupdate = (int?) content.GetValueForProperty("Autoupdate",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Autoupdate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Creator = (string) content.GetValueForProperty("Creator",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Creator, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Disabled = (int?) content.GetValueForProperty("Disabled",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Disabled, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Identifier = (string) content.GetValueForProperty("Identifier",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Identifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).SourceUrl = (string) content.GetValueForProperty("SourceUrl",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).SourceUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Uid = (string) content.GetValueForProperty("Uid",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Uid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Version, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Visible = (int?) content.GetValueForProperty("Visible",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Visible, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsFirefoxAddons"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsFirefoxAddons(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Active = (int?) content.GetValueForProperty("Active",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Active, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Autoupdate = (int?) content.GetValueForProperty("Autoupdate",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Autoupdate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Creator = (string) content.GetValueForProperty("Creator",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Creator, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Disabled = (int?) content.GetValueForProperty("Disabled",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Disabled, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Identifier = (string) content.GetValueForProperty("Identifier",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Identifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Location = (string) content.GetValueForProperty("Location",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Location, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).SourceUrl = (string) content.GetValueForProperty("SourceUrl",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).SourceUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Uid = (string) content.GetValueForProperty("Uid",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Uid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Version, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Visible = (int?) content.GetValueForProperty("Visible",((JumpCloudApiSdkV2.Models.ISystemInsightsFirefoxAddonsInternal)this).Visible, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Firefox Addons
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsFirefoxAddonsTypeConverter))]
    public partial interface ISystemInsightsFirefoxAddons

    {

    }
}