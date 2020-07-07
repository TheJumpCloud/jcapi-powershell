// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Windows Crashes</summary>
    public partial class SystemInsightsWindowsCrashes
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
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.ISystemInsightsWindowsCrashes.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.ISystemInsightsWindowsCrashes.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsWindowsCrashes FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new SystemInsightsWindowsCrashes(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsWindowsCrashes" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsWindowsCrashes(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_type = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_path = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_buildNumber = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("build_number"), out var __jsonBuildNumber) ? (int?)__jsonBuildNumber : BuildNumber;}
            {_collectionTime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_commandLine = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("command_line"), out var __jsonCommandLine) ? (string)__jsonCommandLine : (string)CommandLine;}
            {_crashPath = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("crash_path"), out var __jsonCrashPath) ? (string)__jsonCrashPath : (string)CrashPath;}
            {_currentDirectory = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("current_directory"), out var __jsonCurrentDirectory) ? (string)__jsonCurrentDirectory : (string)CurrentDirectory;}
            {_datetime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("datetime"), out var __jsonDatetime) ? (string)__jsonDatetime : (string)Datetime;}
            {_exceptionAddress = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("exception_address"), out var __jsonExceptionAddress) ? (string)__jsonExceptionAddress : (string)ExceptionAddress;}
            {_exceptionCode = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("exception_code"), out var __jsonExceptionCode) ? (string)__jsonExceptionCode : (string)ExceptionCode;}
            {_exceptionMessage = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("exception_message"), out var __jsonExceptionMessage) ? (string)__jsonExceptionMessage : (string)ExceptionMessage;}
            {_machineName = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("machine_name"), out var __jsonMachineName) ? (string)__jsonMachineName : (string)MachineName;}
            {_majorVersion = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("major_version"), out var __jsonMajorVersion) ? (int?)__jsonMajorVersion : MajorVersion;}
            {_minorVersion = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("minor_version"), out var __jsonMinorVersion) ? (int?)__jsonMinorVersion : MinorVersion;}
            {_module = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("module"), out var __jsonModule) ? (string)__jsonModule : (string)Module;}
            {_pid = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("pid"), out var __jsonPid) ? (string)__jsonPid : (string)Pid;}
            {_processUptime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("process_uptime"), out var __jsonProcessUptime) ? (string)__jsonProcessUptime : (string)ProcessUptime;}
            {_registers = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("registers"), out var __jsonRegisters) ? (string)__jsonRegisters : (string)Registers;}
            {_stackTrace = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("stack_trace"), out var __jsonStackTrace) ? (string)__jsonStackTrace : (string)StackTrace;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_tid = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("tid"), out var __jsonTid) ? (string)__jsonTid : (string)Tid;}
            {_username = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("username"), out var __jsonUsername) ? (string)__jsonUsername : (string)Username;}
            {_version = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsWindowsCrashes" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsWindowsCrashes" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._type)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._path)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._path.ToString()) : null, "path" ,container.Add );
            AddIf( null != this._buildNumber ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._buildNumber) : null, "build_number" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._commandLine)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._commandLine.ToString()) : null, "command_line" ,container.Add );
            AddIf( null != (((object)this._crashPath)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._crashPath.ToString()) : null, "crash_path" ,container.Add );
            AddIf( null != (((object)this._currentDirectory)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._currentDirectory.ToString()) : null, "current_directory" ,container.Add );
            AddIf( null != (((object)this._datetime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._datetime.ToString()) : null, "datetime" ,container.Add );
            AddIf( null != (((object)this._exceptionAddress)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._exceptionAddress.ToString()) : null, "exception_address" ,container.Add );
            AddIf( null != (((object)this._exceptionCode)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._exceptionCode.ToString()) : null, "exception_code" ,container.Add );
            AddIf( null != (((object)this._exceptionMessage)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._exceptionMessage.ToString()) : null, "exception_message" ,container.Add );
            AddIf( null != (((object)this._machineName)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._machineName.ToString()) : null, "machine_name" ,container.Add );
            AddIf( null != this._majorVersion ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._majorVersion) : null, "major_version" ,container.Add );
            AddIf( null != this._minorVersion ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._minorVersion) : null, "minor_version" ,container.Add );
            AddIf( null != (((object)this._module)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._module.ToString()) : null, "module" ,container.Add );
            AddIf( null != (((object)this._pid)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._pid.ToString()) : null, "pid" ,container.Add );
            AddIf( null != (((object)this._processUptime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._processUptime.ToString()) : null, "process_uptime" ,container.Add );
            AddIf( null != (((object)this._registers)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._registers.ToString()) : null, "registers" ,container.Add );
            AddIf( null != (((object)this._stackTrace)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._stackTrace.ToString()) : null, "stack_trace" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != (((object)this._tid)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._tid.ToString()) : null, "tid" ,container.Add );
            AddIf( null != (((object)this._username)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._username.ToString()) : null, "username" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}