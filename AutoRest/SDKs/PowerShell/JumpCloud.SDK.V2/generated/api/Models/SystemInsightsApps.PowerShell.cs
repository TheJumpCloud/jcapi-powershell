namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights Apps</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsAppsTypeConverter))]
    public partial class SystemInsightsApps
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsApps"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsApps" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsApps DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsApps(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsApps"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsApps" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsApps DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsApps(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsApps" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsApps FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsApps"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsApps(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).ApplescriptEnabled = (string) content.GetValueForProperty("ApplescriptEnabled",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).ApplescriptEnabled, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleExecutable = (string) content.GetValueForProperty("BundleExecutable",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleExecutable, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleIdentifier = (string) content.GetValueForProperty("BundleIdentifier",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleIdentifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleName = (string) content.GetValueForProperty("BundleName",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundlePackageType = (string) content.GetValueForProperty("BundlePackageType",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundlePackageType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleShortVersion = (string) content.GetValueForProperty("BundleShortVersion",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleShortVersion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleVersion = (string) content.GetValueForProperty("BundleVersion",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleVersion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Category = (string) content.GetValueForProperty("Category",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Category, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Compiler = (string) content.GetValueForProperty("Compiler",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Compiler, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Copyright = (string) content.GetValueForProperty("Copyright",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Copyright, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).DevelopmentRegion = (string) content.GetValueForProperty("DevelopmentRegion",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).DevelopmentRegion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Element = (string) content.GetValueForProperty("Element",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Element, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Environment = (string) content.GetValueForProperty("Environment",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Environment, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).InfoString = (string) content.GetValueForProperty("InfoString",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).InfoString, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).LastOpenedTime = (float?) content.GetValueForProperty("LastOpenedTime",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).LastOpenedTime, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).MinimumSystemVersion = (string) content.GetValueForProperty("MinimumSystemVersion",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).MinimumSystemVersion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsApps"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsApps(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).ApplescriptEnabled = (string) content.GetValueForProperty("ApplescriptEnabled",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).ApplescriptEnabled, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleExecutable = (string) content.GetValueForProperty("BundleExecutable",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleExecutable, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleIdentifier = (string) content.GetValueForProperty("BundleIdentifier",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleIdentifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleName = (string) content.GetValueForProperty("BundleName",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundlePackageType = (string) content.GetValueForProperty("BundlePackageType",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundlePackageType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleShortVersion = (string) content.GetValueForProperty("BundleShortVersion",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleShortVersion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleVersion = (string) content.GetValueForProperty("BundleVersion",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).BundleVersion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Category = (string) content.GetValueForProperty("Category",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Category, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Compiler = (string) content.GetValueForProperty("Compiler",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Compiler, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Copyright = (string) content.GetValueForProperty("Copyright",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Copyright, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).DevelopmentRegion = (string) content.GetValueForProperty("DevelopmentRegion",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).DevelopmentRegion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Element = (string) content.GetValueForProperty("Element",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Element, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Environment = (string) content.GetValueForProperty("Environment",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).Environment, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).InfoString = (string) content.GetValueForProperty("InfoString",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).InfoString, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).LastOpenedTime = (float?) content.GetValueForProperty("LastOpenedTime",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).LastOpenedTime, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).MinimumSystemVersion = (string) content.GetValueForProperty("MinimumSystemVersion",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).MinimumSystemVersion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Apps
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsAppsTypeConverter))]
    public partial interface ISystemInsightsApps

    {

    }
}