namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Apps</summary>
    public partial class SystemInsightsApps
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloud.SDK.V2.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloud.SDK.V2.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloud.SDK.V2.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloud.SDK.V2.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.ISystemInsightsApps.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.ISystemInsightsApps.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsApps FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new SystemInsightsApps(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsApps" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsApps(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_path = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_applescriptEnabled = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("applescript_enabled"), out var __jsonApplescriptEnabled) ? (string)__jsonApplescriptEnabled : (string)ApplescriptEnabled;}
            {_bundleExecutable = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("bundle_executable"), out var __jsonBundleExecutable) ? (string)__jsonBundleExecutable : (string)BundleExecutable;}
            {_bundleIdentifier = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("bundle_identifier"), out var __jsonBundleIdentifier) ? (string)__jsonBundleIdentifier : (string)BundleIdentifier;}
            {_bundleName = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("bundle_name"), out var __jsonBundleName) ? (string)__jsonBundleName : (string)BundleName;}
            {_bundlePackageType = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("bundle_package_type"), out var __jsonBundlePackageType) ? (string)__jsonBundlePackageType : (string)BundlePackageType;}
            {_bundleShortVersion = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("bundle_short_version"), out var __jsonBundleShortVersion) ? (string)__jsonBundleShortVersion : (string)BundleShortVersion;}
            {_bundleVersion = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("bundle_version"), out var __jsonBundleVersion) ? (string)__jsonBundleVersion : (string)BundleVersion;}
            {_category = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("category"), out var __jsonCategory) ? (string)__jsonCategory : (string)Category;}
            {_collectionTime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_compiler = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("compiler"), out var __jsonCompiler) ? (string)__jsonCompiler : (string)Compiler;}
            {_copyright = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("copyright"), out var __jsonCopyright) ? (string)__jsonCopyright : (string)Copyright;}
            {_developmentRegion = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("development_region"), out var __jsonDevelopmentRegion) ? (string)__jsonDevelopmentRegion : (string)DevelopmentRegion;}
            {_displayName = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("display_name"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_element = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("element"), out var __jsonElement) ? (string)__jsonElement : (string)Element;}
            {_environment = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("environment"), out var __jsonEnvironment) ? (string)__jsonEnvironment : (string)Environment;}
            {_infoString = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("info_string"), out var __jsonInfoString) ? (string)__jsonInfoString : (string)InfoString;}
            {_lastOpenedTime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("last_opened_time"), out var __jsonLastOpenedTime) ? (float?)__jsonLastOpenedTime : LastOpenedTime;}
            {_minimumSystemVersion = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("minimum_system_version"), out var __jsonMinimumSystemVersion) ? (string)__jsonMinimumSystemVersion : (string)MinimumSystemVersion;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsApps" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsApps" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloud.SDK.V2.Runtime.Json.JsonNode ToJson(JumpCloud.SDK.V2.Runtime.Json.JsonObject container, JumpCloud.SDK.V2.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloud.SDK.V2.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._path)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._path.ToString()) : null, "path" ,container.Add );
            AddIf( null != (((object)this._applescriptEnabled)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._applescriptEnabled.ToString()) : null, "applescript_enabled" ,container.Add );
            AddIf( null != (((object)this._bundleExecutable)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._bundleExecutable.ToString()) : null, "bundle_executable" ,container.Add );
            AddIf( null != (((object)this._bundleIdentifier)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._bundleIdentifier.ToString()) : null, "bundle_identifier" ,container.Add );
            AddIf( null != (((object)this._bundleName)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._bundleName.ToString()) : null, "bundle_name" ,container.Add );
            AddIf( null != (((object)this._bundlePackageType)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._bundlePackageType.ToString()) : null, "bundle_package_type" ,container.Add );
            AddIf( null != (((object)this._bundleShortVersion)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._bundleShortVersion.ToString()) : null, "bundle_short_version" ,container.Add );
            AddIf( null != (((object)this._bundleVersion)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._bundleVersion.ToString()) : null, "bundle_version" ,container.Add );
            AddIf( null != (((object)this._category)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._category.ToString()) : null, "category" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._compiler)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._compiler.ToString()) : null, "compiler" ,container.Add );
            AddIf( null != (((object)this._copyright)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._copyright.ToString()) : null, "copyright" ,container.Add );
            AddIf( null != (((object)this._developmentRegion)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._developmentRegion.ToString()) : null, "development_region" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._displayName.ToString()) : null, "display_name" ,container.Add );
            AddIf( null != (((object)this._element)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._element.ToString()) : null, "element" ,container.Add );
            AddIf( null != (((object)this._environment)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._environment.ToString()) : null, "environment" ,container.Add );
            AddIf( null != (((object)this._infoString)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._infoString.ToString()) : null, "info_string" ,container.Add );
            AddIf( null != this._lastOpenedTime ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((float)this._lastOpenedTime) : null, "last_opened_time" ,container.Add );
            AddIf( null != (((object)this._minimumSystemVersion)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._minimumSystemVersion.ToString()) : null, "minimum_system_version" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}