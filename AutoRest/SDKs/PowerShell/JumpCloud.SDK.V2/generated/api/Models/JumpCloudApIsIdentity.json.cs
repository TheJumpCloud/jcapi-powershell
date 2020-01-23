namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class JumpCloudApIsIdentity
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
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity.</returns>
        public static JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new JumpCloudApIsIdentity(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="JumpCloudApIsIdentity" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal JumpCloudApIsIdentity(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_accountId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("account_id"), out var __jsonAccountId) ? (string)__jsonAccountId : (string)AccountId;}
            {_activedirectoryId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("activedirectory_id"), out var __jsonActivedirectoryId) ? (string)__jsonActivedirectoryId : (string)ActivedirectoryId;}
            {_applicationId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("application_id"), out var __jsonApplicationId) ? (string)__jsonApplicationId : (string)ApplicationId;}
            {_commandId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("command_id"), out var __jsonCommandId) ? (string)__jsonCommandId : (string)CommandId;}
            {_groupId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("group_id"), out var __jsonGroupId) ? (string)__jsonGroupId : (string)GroupId;}
            {_gsuiteId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("gsuite_id"), out var __jsonGsuiteId) ? (string)__jsonGsuiteId : (string)GsuiteId;}
            {_id = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_jobId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("job_id"), out var __jsonJobId) ? (string)__jsonJobId : (string)JobId;}
            {_ldapserverId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("ldapserver_id"), out var __jsonLdapserverId) ? (string)__jsonLdapserverId : (string)LdapserverId;}
            {_office365Id = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("office365_id"), out var __jsonOffice365Id) ? (string)__jsonOffice365Id : (string)Office365Id;}
            {_policyId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("policy_id"), out var __jsonPolicyId) ? (string)__jsonPolicyId : (string)PolicyId;}
            {_providerId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("provider_id"), out var __jsonProviderId) ? (string)__jsonProviderId : (string)ProviderId;}
            {_radiusserverId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("radiusserver_id"), out var __jsonRadiusserverId) ? (string)__jsonRadiusserverId : (string)RadiusserverId;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_userId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("user_id"), out var __jsonUserId) ? (string)__jsonUserId : (string)UserId;}
            {_workdayId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("workday_id"), out var __jsonWorkdayId) ? (string)__jsonWorkdayId : (string)WorkdayId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="JumpCloudApIsIdentity" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="JumpCloudApIsIdentity" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._accountId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._accountId.ToString()) : null, "account_id" ,container.Add );
            AddIf( null != (((object)this._activedirectoryId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._activedirectoryId.ToString()) : null, "activedirectory_id" ,container.Add );
            AddIf( null != (((object)this._applicationId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._applicationId.ToString()) : null, "application_id" ,container.Add );
            AddIf( null != (((object)this._commandId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._commandId.ToString()) : null, "command_id" ,container.Add );
            AddIf( null != (((object)this._groupId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._groupId.ToString()) : null, "group_id" ,container.Add );
            AddIf( null != (((object)this._gsuiteId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._gsuiteId.ToString()) : null, "gsuite_id" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != (((object)this._jobId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._jobId.ToString()) : null, "job_id" ,container.Add );
            AddIf( null != (((object)this._ldapserverId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._ldapserverId.ToString()) : null, "ldapserver_id" ,container.Add );
            AddIf( null != (((object)this._office365Id)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._office365Id.ToString()) : null, "office365_id" ,container.Add );
            AddIf( null != (((object)this._policyId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._policyId.ToString()) : null, "policy_id" ,container.Add );
            AddIf( null != (((object)this._providerId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._providerId.ToString()) : null, "provider_id" ,container.Add );
            AddIf( null != (((object)this._radiusserverId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._radiusserverId.ToString()) : null, "radiusserver_id" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != (((object)this._userId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._userId.ToString()) : null, "user_id" ,container.Add );
            AddIf( null != (((object)this._workdayId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._workdayId.ToString()) : null, "workday_id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}