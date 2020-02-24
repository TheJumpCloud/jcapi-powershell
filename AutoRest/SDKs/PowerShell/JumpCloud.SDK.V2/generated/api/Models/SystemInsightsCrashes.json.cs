// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Crashes</summary>
    public partial class SystemInsightsCrashes
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
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.ISystemInsightsCrashes.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.ISystemInsightsCrashes.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsCrashes FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new SystemInsightsCrashes(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsCrashes" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsCrashes(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_type = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_path = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_collectionTime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_crashPath = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("crash_path"), out var __jsonCrashPath) ? (string)__jsonCrashPath : (string)CrashPath;}
            {_crashedThread = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("crashed_thread"), out var __jsonCrashedThread) ? (string)__jsonCrashedThread : (string)CrashedThread;}
            {_datetime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("datetime"), out var __jsonDatetime) ? (string)__jsonDatetime : (string)Datetime;}
            {_exceptionCodes = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("exception_codes"), out var __jsonExceptionCodes) ? (string)__jsonExceptionCodes : (string)ExceptionCodes;}
            {_exceptionNotes = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("exception_notes"), out var __jsonExceptionNotes) ? (string)__jsonExceptionNotes : (string)ExceptionNotes;}
            {_exceptionType = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("exception_type"), out var __jsonExceptionType) ? (string)__jsonExceptionType : (string)ExceptionType;}
            {_identifier = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("identifier"), out var __jsonIdentifier) ? (string)__jsonIdentifier : (string)Identifier;}
            {_parent = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("parent"), out var __jsonParent) ? (string)__jsonParent : (string)Parent;}
            {_pid = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("pid"), out var __jsonPid) ? (string)__jsonPid : (string)Pid;}
            {_registers = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("registers"), out var __jsonRegisters) ? (string)__jsonRegisters : (string)Registers;}
            {_responsible = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("responsible"), out var __jsonResponsible) ? (string)__jsonResponsible : (string)Responsible;}
            {_stackTrace = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("stack_trace"), out var __jsonStackTrace) ? (string)__jsonStackTrace : (string)StackTrace;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_uid = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("uid"), out var __jsonUid) ? (int?)__jsonUid : Uid;}
            {_version = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsCrashes" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsCrashes" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._crashPath)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._crashPath.ToString()) : null, "crash_path" ,container.Add );
            AddIf( null != (((object)this._crashedThread)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._crashedThread.ToString()) : null, "crashed_thread" ,container.Add );
            AddIf( null != (((object)this._datetime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._datetime.ToString()) : null, "datetime" ,container.Add );
            AddIf( null != (((object)this._exceptionCodes)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._exceptionCodes.ToString()) : null, "exception_codes" ,container.Add );
            AddIf( null != (((object)this._exceptionNotes)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._exceptionNotes.ToString()) : null, "exception_notes" ,container.Add );
            AddIf( null != (((object)this._exceptionType)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._exceptionType.ToString()) : null, "exception_type" ,container.Add );
            AddIf( null != (((object)this._identifier)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._identifier.ToString()) : null, "identifier" ,container.Add );
            AddIf( null != (((object)this._parent)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._parent.ToString()) : null, "parent" ,container.Add );
            AddIf( null != (((object)this._pid)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._pid.ToString()) : null, "pid" ,container.Add );
            AddIf( null != (((object)this._registers)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._registers.ToString()) : null, "registers" ,container.Add );
            AddIf( null != (((object)this._responsible)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._responsible.ToString()) : null, "responsible" ,container.Add );
            AddIf( null != (((object)this._stackTrace)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._stackTrace.ToString()) : null, "stack_trace" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != this._uid ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._uid) : null, "uid" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}