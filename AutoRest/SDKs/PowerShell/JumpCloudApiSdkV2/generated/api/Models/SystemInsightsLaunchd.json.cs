namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights LaunchD</summary>
    public partial class SystemInsightsLaunchd
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloudApiSdkV2.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloudApiSdkV2.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloudApiSdkV2.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloudApiSdkV2.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.ISystemInsightsLaunchd.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.ISystemInsightsLaunchd.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsLaunchd FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new SystemInsightsLaunchd(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsLaunchd" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsLaunchd(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_path = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_collectionTime = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_disabled = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("disabled"), out var __jsonDisabled) ? (string)__jsonDisabled : (string)Disabled;}
            {_groupname = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("groupname"), out var __jsonGroupname) ? (string)__jsonGroupname : (string)Groupname;}
            {_inetdCompatibility = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("inetd_compatibility"), out var __jsonInetdCompatibility) ? (string)__jsonInetdCompatibility : (string)InetdCompatibility;}
            {_keepAlive = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("keep_alive"), out var __jsonKeepAlive) ? (string)__jsonKeepAlive : (string)KeepAlive;}
            {_label = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("label"), out var __jsonLabel) ? (string)__jsonLabel : (string)Label;}
            {_onDemand = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("on_demand"), out var __jsonOnDemand) ? (string)__jsonOnDemand : (string)OnDemand;}
            {_processType = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("process_type"), out var __jsonProcessType) ? (string)__jsonProcessType : (string)ProcessType;}
            {_program = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("program"), out var __jsonProgram) ? (string)__jsonProgram : (string)Program;}
            {_programArguments = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("program_arguments"), out var __jsonProgramArguments) ? (string)__jsonProgramArguments : (string)ProgramArguments;}
            {_queueDirectories = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("queue_directories"), out var __jsonQueueDirectories) ? (string)__jsonQueueDirectories : (string)QueueDirectories;}
            {_rootDirectory = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("root_directory"), out var __jsonRootDirectory) ? (string)__jsonRootDirectory : (string)RootDirectory;}
            {_runAtLoad = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("run_at_load"), out var __jsonRunAtLoad) ? (string)__jsonRunAtLoad : (string)RunAtLoad;}
            {_startInterval = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("start_interval"), out var __jsonStartInterval) ? (string)__jsonStartInterval : (string)StartInterval;}
            {_startOnMount = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("start_on_mount"), out var __jsonStartOnMount) ? (string)__jsonStartOnMount : (string)StartOnMount;}
            {_stderrPath = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("stderr_path"), out var __jsonStderrPath) ? (string)__jsonStderrPath : (string)StderrPath;}
            {_stdoutPath = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("stdout_path"), out var __jsonStdoutPath) ? (string)__jsonStdoutPath : (string)StdoutPath;}
            {_systemId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_username = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("username"), out var __jsonUsername) ? (string)__jsonUsername : (string)Username;}
            {_watchPaths = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("watch_paths"), out var __jsonWatchPaths) ? (string)__jsonWatchPaths : (string)WatchPaths;}
            {_workingDirectory = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("working_directory"), out var __jsonWorkingDirectory) ? (string)__jsonWorkingDirectory : (string)WorkingDirectory;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsLaunchd" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsLaunchd" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloudApiSdkV2.Runtime.Json.JsonNode ToJson(JumpCloudApiSdkV2.Runtime.Json.JsonObject container, JumpCloudApiSdkV2.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloudApiSdkV2.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._path)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._path.ToString()) : null, "path" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._disabled)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._disabled.ToString()) : null, "disabled" ,container.Add );
            AddIf( null != (((object)this._groupname)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._groupname.ToString()) : null, "groupname" ,container.Add );
            AddIf( null != (((object)this._inetdCompatibility)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._inetdCompatibility.ToString()) : null, "inetd_compatibility" ,container.Add );
            AddIf( null != (((object)this._keepAlive)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._keepAlive.ToString()) : null, "keep_alive" ,container.Add );
            AddIf( null != (((object)this._label)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._label.ToString()) : null, "label" ,container.Add );
            AddIf( null != (((object)this._onDemand)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._onDemand.ToString()) : null, "on_demand" ,container.Add );
            AddIf( null != (((object)this._processType)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._processType.ToString()) : null, "process_type" ,container.Add );
            AddIf( null != (((object)this._program)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._program.ToString()) : null, "program" ,container.Add );
            AddIf( null != (((object)this._programArguments)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._programArguments.ToString()) : null, "program_arguments" ,container.Add );
            AddIf( null != (((object)this._queueDirectories)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._queueDirectories.ToString()) : null, "queue_directories" ,container.Add );
            AddIf( null != (((object)this._rootDirectory)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._rootDirectory.ToString()) : null, "root_directory" ,container.Add );
            AddIf( null != (((object)this._runAtLoad)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._runAtLoad.ToString()) : null, "run_at_load" ,container.Add );
            AddIf( null != (((object)this._startInterval)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._startInterval.ToString()) : null, "start_interval" ,container.Add );
            AddIf( null != (((object)this._startOnMount)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._startOnMount.ToString()) : null, "start_on_mount" ,container.Add );
            AddIf( null != (((object)this._stderrPath)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._stderrPath.ToString()) : null, "stderr_path" ,container.Add );
            AddIf( null != (((object)this._stdoutPath)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._stdoutPath.ToString()) : null, "stdout_path" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != (((object)this._username)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._username.ToString()) : null, "username" ,container.Add );
            AddIf( null != (((object)this._watchPaths)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._watchPaths.ToString()) : null, "watch_paths" ,container.Add );
            AddIf( null != (((object)this._workingDirectory)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._workingDirectory.ToString()) : null, "working_directory" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}