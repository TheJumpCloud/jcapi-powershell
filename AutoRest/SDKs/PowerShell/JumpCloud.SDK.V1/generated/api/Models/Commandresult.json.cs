namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>CommandResult</summary>
    public partial class Commandresult
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloud.SDK.V1.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloud.SDK.V1.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloud.SDK.V1.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloud.SDK.V1.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="Commandresult" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Commandresult(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_response = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonObject>("response"), out var __jsonResponse) ? JumpCloud.SDK.V1.Models.CommandresultResponse.FromJson(__jsonResponse) : Response;}
            {_name = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_id = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("_id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_command = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("command"), out var __jsonCommand) ? (string)__jsonCommand : (string)Command;}
            {_files = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonArray>("files"), out var __jsonFiles) ? If( __jsonFiles as JumpCloud.SDK.V1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is JumpCloud.SDK.V1.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Files;}
            {_organization = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("organization"), out var __jsonOrganization) ? (string)__jsonOrganization : (string)Organization;}
            {_requestTime = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("requestTime"), out var __jsonRequestTime) ? (string)__jsonRequestTime : (string)RequestTime;}
            {_responseTime = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("responseTime"), out var __jsonResponseTime) ? (string)__jsonResponseTime : (string)ResponseTime;}
            {_sudo = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("sudo"), out var __jsonSudo) ? (bool?)__jsonSudo : Sudo;}
            {_system = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("system"), out var __jsonSystem) ? (string)__jsonSystem : (string)System;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("systemId"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_user = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("user"), out var __jsonUser) ? (string)__jsonUser : (string)User;}
            {_workflowId = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("workflowId"), out var __jsonWorkflowId) ? (string)__jsonWorkflowId : (string)WorkflowId;}
            {_workflowInstanceId = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("workflowInstanceId"), out var __jsonWorkflowInstanceId) ? (string)__jsonWorkflowInstanceId : (string)WorkflowInstanceId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.ICommandresult.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.ICommandresult.</returns>
        public static JumpCloud.SDK.V1.Models.ICommandresult FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new Commandresult(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Commandresult" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Commandresult" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloud.SDK.V1.Runtime.Json.JsonNode ToJson(JumpCloud.SDK.V1.Runtime.Json.JsonObject container, JumpCloud.SDK.V1.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloud.SDK.V1.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._response ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) this._response.ToJson(null,serializationMode) : null, "response" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._id.ToString()) : null, "_id" ,container.Add );
            AddIf( null != (((object)this._command)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._command.ToString()) : null, "command" ,container.Add );
            if (null != this._files)
            {
                var __w = new JumpCloud.SDK.V1.Runtime.Json.XNodeArray();
                foreach( var __x in this._files )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("files",__w);
            }
            AddIf( null != (((object)this._organization)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._organization.ToString()) : null, "organization" ,container.Add );
            AddIf( null != (((object)this._requestTime)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._requestTime.ToString()) : null, "requestTime" ,container.Add );
            AddIf( null != (((object)this._responseTime)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._responseTime.ToString()) : null, "responseTime" ,container.Add );
            AddIf( null != this._sudo ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._sudo) : null, "sudo" ,container.Add );
            AddIf( null != (((object)this._system)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._system.ToString()) : null, "system" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._systemId.ToString()) : null, "systemId" ,container.Add );
            AddIf( null != (((object)this._user)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._user.ToString()) : null, "user" ,container.Add );
            AddIf( null != (((object)this._workflowId)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._workflowId.ToString()) : null, "workflowId" ,container.Add );
            AddIf( null != (((object)this._workflowInstanceId)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._workflowInstanceId.ToString()) : null, "workflowInstanceId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}