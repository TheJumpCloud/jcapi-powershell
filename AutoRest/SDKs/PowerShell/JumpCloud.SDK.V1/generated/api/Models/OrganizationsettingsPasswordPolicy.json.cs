namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class OrganizationsettingsPasswordPolicy
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
        /// Deserializes a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicy.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicy.</returns>
        public static JumpCloud.SDK.V1.Models.IOrganizationsettingsPasswordPolicy FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V1.Runtime.Json.JsonObject json ? new OrganizationsettingsPasswordPolicy(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V1.Runtime.Json.JsonObject into a new instance of <see cref="OrganizationsettingsPasswordPolicy" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V1.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OrganizationsettingsPasswordPolicy(JumpCloud.SDK.V1.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_allowUsernameSubstring = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("allowUsernameSubstring"), out var __jsonAllowUsernameSubstring) ? (bool?)__jsonAllowUsernameSubstring : AllowUsernameSubstring;}
            {_daysAfterExpirationToSelfRecover = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("daysAfterExpirationToSelfRecover"), out var __jsonDaysAfterExpirationToSelfRecover) ? (int?)__jsonDaysAfterExpirationToSelfRecover : DaysAfterExpirationToSelfRecover;}
            {_daysBeforeExpirationToForceReset = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("daysBeforeExpirationToForceReset"), out var __jsonDaysBeforeExpirationToForceReset) ? (int?)__jsonDaysBeforeExpirationToForceReset : DaysBeforeExpirationToForceReset;}
            {_effectiveDate = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonString>("effectiveDate"), out var __jsonEffectiveDate) ? (string)__jsonEffectiveDate : (string)EffectiveDate;}
            {_enableDaysAfterExpirationToSelfRecover = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableDaysAfterExpirationToSelfRecover"), out var __jsonEnableDaysAfterExpirationToSelfRecover) ? (bool?)__jsonEnableDaysAfterExpirationToSelfRecover : EnableDaysAfterExpirationToSelfRecover;}
            {_enableDaysBeforeExpirationToForceReset = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableDaysBeforeExpirationToForceReset"), out var __jsonEnableDaysBeforeExpirationToForceReset) ? (bool?)__jsonEnableDaysBeforeExpirationToForceReset : EnableDaysBeforeExpirationToForceReset;}
            {_enableLockoutTimeInSeconds = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableLockoutTimeInSeconds"), out var __jsonEnableLockoutTimeInSeconds) ? (bool?)__jsonEnableLockoutTimeInSeconds : EnableLockoutTimeInSeconds;}
            {_enableMaxHistory = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableMaxHistory"), out var __jsonEnableMaxHistory) ? (bool?)__jsonEnableMaxHistory : EnableMaxHistory;}
            {_enableMaxLoginAttempts = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableMaxLoginAttempts"), out var __jsonEnableMaxLoginAttempts) ? (bool?)__jsonEnableMaxLoginAttempts : EnableMaxLoginAttempts;}
            {_enableMinChangePeriodInDays = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableMinChangePeriodInDays"), out var __jsonEnableMinChangePeriodInDays) ? (bool?)__jsonEnableMinChangePeriodInDays : EnableMinChangePeriodInDays;}
            {_enableMinLength = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enableMinLength"), out var __jsonEnableMinLength) ? (bool?)__jsonEnableMinLength : EnableMinLength;}
            {_enablePasswordExpirationInDays = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("enablePasswordExpirationInDays"), out var __jsonEnablePasswordExpirationInDays) ? (bool?)__jsonEnablePasswordExpirationInDays : EnablePasswordExpirationInDays;}
            {_lockoutTimeInSeconds = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("lockoutTimeInSeconds"), out var __jsonLockoutTimeInSeconds) ? (int?)__jsonLockoutTimeInSeconds : LockoutTimeInSeconds;}
            {_maxHistory = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("maxHistory"), out var __jsonMaxHistory) ? (int?)__jsonMaxHistory : MaxHistory;}
            {_maxLoginAttempts = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("maxLoginAttempts"), out var __jsonMaxLoginAttempts) ? (int?)__jsonMaxLoginAttempts : MaxLoginAttempts;}
            {_minChangePeriodInDays = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("minChangePeriodInDays"), out var __jsonMinChangePeriodInDays) ? (int?)__jsonMinChangePeriodInDays : MinChangePeriodInDays;}
            {_minLength = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("minLength"), out var __jsonMinLength) ? (int?)__jsonMinLength : MinLength;}
            {_needsLowercase = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("needsLowercase"), out var __jsonNeedsLowercase) ? (bool?)__jsonNeedsLowercase : NeedsLowercase;}
            {_needsNumeric = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("needsNumeric"), out var __jsonNeedsNumeric) ? (bool?)__jsonNeedsNumeric : NeedsNumeric;}
            {_needsSymbolic = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("needsSymbolic"), out var __jsonNeedsSymbolic) ? (bool?)__jsonNeedsSymbolic : NeedsSymbolic;}
            {_needsUppercase = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonBoolean>("needsUppercase"), out var __jsonNeedsUppercase) ? (bool?)__jsonNeedsUppercase : NeedsUppercase;}
            {_passwordExpirationInDays = If( json?.PropertyT<JumpCloud.SDK.V1.Runtime.Json.JsonNumber>("passwordExpirationInDays"), out var __jsonPasswordExpirationInDays) ? (int?)__jsonPasswordExpirationInDays : PasswordExpirationInDays;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OrganizationsettingsPasswordPolicy" /> into a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V1.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OrganizationsettingsPasswordPolicy" /> as a <see cref="JumpCloud.SDK.V1.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._allowUsernameSubstring ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._allowUsernameSubstring) : null, "allowUsernameSubstring" ,container.Add );
            AddIf( null != this._daysAfterExpirationToSelfRecover ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._daysAfterExpirationToSelfRecover) : null, "daysAfterExpirationToSelfRecover" ,container.Add );
            AddIf( null != this._daysBeforeExpirationToForceReset ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._daysBeforeExpirationToForceReset) : null, "daysBeforeExpirationToForceReset" ,container.Add );
            AddIf( null != (((object)this._effectiveDate)?.ToString()) ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode) new JumpCloud.SDK.V1.Runtime.Json.JsonString(this._effectiveDate.ToString()) : null, "effectiveDate" ,container.Add );
            AddIf( null != this._enableDaysAfterExpirationToSelfRecover ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableDaysAfterExpirationToSelfRecover) : null, "enableDaysAfterExpirationToSelfRecover" ,container.Add );
            AddIf( null != this._enableDaysBeforeExpirationToForceReset ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableDaysBeforeExpirationToForceReset) : null, "enableDaysBeforeExpirationToForceReset" ,container.Add );
            AddIf( null != this._enableLockoutTimeInSeconds ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableLockoutTimeInSeconds) : null, "enableLockoutTimeInSeconds" ,container.Add );
            AddIf( null != this._enableMaxHistory ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableMaxHistory) : null, "enableMaxHistory" ,container.Add );
            AddIf( null != this._enableMaxLoginAttempts ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableMaxLoginAttempts) : null, "enableMaxLoginAttempts" ,container.Add );
            AddIf( null != this._enableMinChangePeriodInDays ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableMinChangePeriodInDays) : null, "enableMinChangePeriodInDays" ,container.Add );
            AddIf( null != this._enableMinLength ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enableMinLength) : null, "enableMinLength" ,container.Add );
            AddIf( null != this._enablePasswordExpirationInDays ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._enablePasswordExpirationInDays) : null, "enablePasswordExpirationInDays" ,container.Add );
            AddIf( null != this._lockoutTimeInSeconds ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._lockoutTimeInSeconds) : null, "lockoutTimeInSeconds" ,container.Add );
            AddIf( null != this._maxHistory ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._maxHistory) : null, "maxHistory" ,container.Add );
            AddIf( null != this._maxLoginAttempts ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._maxLoginAttempts) : null, "maxLoginAttempts" ,container.Add );
            AddIf( null != this._minChangePeriodInDays ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._minChangePeriodInDays) : null, "minChangePeriodInDays" ,container.Add );
            AddIf( null != this._minLength ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._minLength) : null, "minLength" ,container.Add );
            AddIf( null != this._needsLowercase ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._needsLowercase) : null, "needsLowercase" ,container.Add );
            AddIf( null != this._needsNumeric ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._needsNumeric) : null, "needsNumeric" ,container.Add );
            AddIf( null != this._needsSymbolic ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._needsSymbolic) : null, "needsSymbolic" ,container.Add );
            AddIf( null != this._needsUppercase ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonBoolean((bool)this._needsUppercase) : null, "needsUppercase" ,container.Add );
            AddIf( null != this._passwordExpirationInDays ? (JumpCloud.SDK.V1.Runtime.Json.JsonNode)new JumpCloud.SDK.V1.Runtime.Json.JsonNumber((int)this._passwordExpirationInDays) : null, "passwordExpirationInDays" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}