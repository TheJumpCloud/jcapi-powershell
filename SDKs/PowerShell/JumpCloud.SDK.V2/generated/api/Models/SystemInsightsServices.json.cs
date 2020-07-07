// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Services</summary>
    public partial class SystemInsightsServices
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
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.ISystemInsightsServices.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.ISystemInsightsServices.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsServices FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new SystemInsightsServices(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsServices" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsServices(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_path = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_description = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_displayName = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("display_name"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_modulePath = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("module_path"), out var __jsonModulePath) ? (string)__jsonModulePath : (string)ModulePath;}
            {_pid = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("pid"), out var __jsonPid) ? (int?)__jsonPid : Pid;}
            {_serviceExitCode = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("service_exit_code"), out var __jsonServiceExitCode) ? (int?)__jsonServiceExitCode : ServiceExitCode;}
            {_serviceType = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("service_type"), out var __jsonServiceType) ? (string)__jsonServiceType : (string)ServiceType;}
            {_startType = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("start_type"), out var __jsonStartType) ? (string)__jsonStartType : (string)StartType;}
            {_status = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_userAccount = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("user_account"), out var __jsonUserAccount) ? (string)__jsonUserAccount : (string)UserAccount;}
            {_win32ExitCode = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonNumber>("win32_exit_code"), out var __jsonWin32ExitCode) ? (int?)__jsonWin32ExitCode : Win32ExitCode;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsServices" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsServices" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._description)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._displayName.ToString()) : null, "display_name" ,container.Add );
            AddIf( null != (((object)this._modulePath)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._modulePath.ToString()) : null, "module_path" ,container.Add );
            AddIf( null != this._pid ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._pid) : null, "pid" ,container.Add );
            AddIf( null != this._serviceExitCode ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._serviceExitCode) : null, "service_exit_code" ,container.Add );
            AddIf( null != (((object)this._serviceType)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._serviceType.ToString()) : null, "service_type" ,container.Add );
            AddIf( null != (((object)this._startType)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._startType.ToString()) : null, "start_type" ,container.Add );
            AddIf( null != (((object)this._status)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != (((object)this._userAccount)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._userAccount.ToString()) : null, "user_account" ,container.Add );
            AddIf( null != this._win32ExitCode ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode)new JumpCloud.SDK.V2.Runtime.Json.JsonNumber((int)this._win32ExitCode) : null, "win32_exit_code" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}