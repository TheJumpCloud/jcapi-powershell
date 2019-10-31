namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>Command</summary>
    public partial class Command
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloudApiSdkV1.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloudApiSdkV1.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloudApiSdkV1.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloudApiSdkV1.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV1.Runtime.Json.JsonObject into a new instance of <see cref="Command" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Command(JumpCloudApiSdkV1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_command1 = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("command"), out var __jsonCommand) ? (string)__jsonCommand : (string)Command1;}
            {_commandRunners = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonArray>("commandRunners"), out var __jsonCommandRunners) ? If( __jsonCommandRunners as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is JumpCloudApiSdkV1.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : CommandRunners;}
            {_commandType = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("commandType"), out var __jsonCommandType) ? (string)__jsonCommandType : (string)CommandType;}
            {_files = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonArray>("files"), out var __jsonFiles) ? If( __jsonFiles as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is JumpCloudApiSdkV1.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : Files;}
            {_launchType = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("launchType"), out var __jsonLaunchType) ? (string)__jsonLaunchType : (string)LaunchType;}
            {_listensTo = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("listensTo"), out var __jsonListensTo) ? (string)__jsonListensTo : (string)ListensTo;}
            {_organization = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("organization"), out var __jsonOrganization) ? (string)__jsonOrganization : (string)Organization;}
            {_schedule = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("schedule"), out var __jsonSchedule) ? (string)__jsonSchedule : (string)Schedule;}
            {_scheduleRepeatType = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("scheduleRepeatType"), out var __jsonScheduleRepeatType) ? (string)__jsonScheduleRepeatType : (string)ScheduleRepeatType;}
            {_sudo = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonBoolean>("sudo"), out var __jsonSudo) ? (bool?)__jsonSudo : Sudo;}
            {_systems = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonArray>("systems"), out var __jsonSystems) ? If( __jsonSystems as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is JumpCloudApiSdkV1.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : Systems;}
            {_timeout = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("timeout"), out var __jsonTimeout) ? (string)__jsonTimeout : (string)Timeout;}
            {_trigger = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("trigger"), out var __jsonTrigger) ? (string)__jsonTrigger : (string)Trigger;}
            {_user = If( json?.PropertyT<JumpCloudApiSdkV1.Runtime.Json.JsonString>("user"), out var __jsonUser) ? (string)__jsonUser : (string)User;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV1.Models.ICommand.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV1.Models.ICommand.</returns>
        public static JumpCloudApiSdkV1.Models.ICommand FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV1.Runtime.Json.JsonObject json ? new Command(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Command" /> into a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Command" /> as a <see cref="JumpCloudApiSdkV1.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloudApiSdkV1.Runtime.Json.JsonNode ToJson(JumpCloudApiSdkV1.Runtime.Json.JsonObject container, JumpCloudApiSdkV1.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloudApiSdkV1.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._command1)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._command1.ToString()) : null, "command" ,container.Add );
            if (null != this._commandRunners)
            {
                var __w = new JumpCloudApiSdkV1.Runtime.Json.XNodeArray();
                foreach( var __x in this._commandRunners )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("commandRunners",__w);
            }
            AddIf( null != (((object)this._commandType)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._commandType.ToString()) : null, "commandType" ,container.Add );
            if (null != this._files)
            {
                var __r = new JumpCloudApiSdkV1.Runtime.Json.XNodeArray();
                foreach( var __s in this._files )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("files",__r);
            }
            AddIf( null != (((object)this._launchType)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._launchType.ToString()) : null, "launchType" ,container.Add );
            AddIf( null != (((object)this._listensTo)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._listensTo.ToString()) : null, "listensTo" ,container.Add );
            AddIf( null != (((object)this._organization)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._organization.ToString()) : null, "organization" ,container.Add );
            AddIf( null != (((object)this._schedule)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._schedule.ToString()) : null, "schedule" ,container.Add );
            AddIf( null != (((object)this._scheduleRepeatType)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._scheduleRepeatType.ToString()) : null, "scheduleRepeatType" ,container.Add );
            AddIf( null != this._sudo ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode)new JumpCloudApiSdkV1.Runtime.Json.JsonBoolean((bool)this._sudo) : null, "sudo" ,container.Add );
            if (null != this._systems)
            {
                var __m = new JumpCloudApiSdkV1.Runtime.Json.XNodeArray();
                foreach( var __n in this._systems )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("systems",__m);
            }
            AddIf( null != (((object)this._timeout)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._timeout.ToString()) : null, "timeout" ,container.Add );
            AddIf( null != (((object)this._trigger)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._trigger.ToString()) : null, "trigger" ,container.Add );
            AddIf( null != (((object)this._user)?.ToString()) ? (JumpCloudApiSdkV1.Runtime.Json.JsonNode) new JumpCloudApiSdkV1.Runtime.Json.JsonString(this._user.ToString()) : null, "user" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}