namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Battery</summary>
    public partial class SystemInsightsBattery
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
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.ISystemInsightsBattery.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.ISystemInsightsBattery.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsBattery FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new SystemInsightsBattery(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsBattery" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsBattery(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_amgerage = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("amgerage"), out var __jsonAmgerage) ? (int?)__jsonAmgerage : Amgerage;}
            {_charged = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("charged"), out var __jsonCharged) ? (int?)__jsonCharged : Charged;}
            {_charging = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("charging"), out var __jsonCharging) ? (int?)__jsonCharging : Charging;}
            {_collectionTime = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_condition = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("condition"), out var __jsonCondition) ? (string)__jsonCondition : (string)Condition;}
            {_currentCapacity = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("current_capacity"), out var __jsonCurrentCapacity) ? (int?)__jsonCurrentCapacity : CurrentCapacity;}
            {_cycleCount = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("cycle_count"), out var __jsonCycleCount) ? (int?)__jsonCycleCount : CycleCount;}
            {_designedCapacity = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("designed_capacity"), out var __jsonDesignedCapacity) ? (int?)__jsonDesignedCapacity : DesignedCapacity;}
            {_health = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("health"), out var __jsonHealth) ? (string)__jsonHealth : (string)Health;}
            {_manufactureDate = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("manufacture_date"), out var __jsonManufactureDate) ? (int?)__jsonManufactureDate : ManufactureDate;}
            {_manufacturer = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("manufacturer"), out var __jsonManufacturer) ? (string)__jsonManufacturer : (string)Manufacturer;}
            {_maxCapacity = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("max_capacity"), out var __jsonMaxCapacity) ? (int?)__jsonMaxCapacity : MaxCapacity;}
            {_minutesToFullCharge = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("minutes_to_full_charge"), out var __jsonMinutesToFullCharge) ? (int?)__jsonMinutesToFullCharge : MinutesToFullCharge;}
            {_minutesUntilEmpty = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("minutes_until_empty"), out var __jsonMinutesUntilEmpty) ? (int?)__jsonMinutesUntilEmpty : MinutesUntilEmpty;}
            {_model = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("model"), out var __jsonModel) ? (string)__jsonModel : (string)Model;}
            {_percentRemaining = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("percent_remaining"), out var __jsonPercentRemaining) ? (int?)__jsonPercentRemaining : PercentRemaining;}
            {_serialNumber = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("serial_number"), out var __jsonSerialNumber) ? (string)__jsonSerialNumber : (string)SerialNumber;}
            {_state = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_systemId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_voltage = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("voltage"), out var __jsonVoltage) ? (int?)__jsonVoltage : Voltage;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsBattery" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsBattery" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._amgerage ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._amgerage) : null, "amgerage" ,container.Add );
            AddIf( null != this._charged ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._charged) : null, "charged" ,container.Add );
            AddIf( null != this._charging ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._charging) : null, "charging" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._condition)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._condition.ToString()) : null, "condition" ,container.Add );
            AddIf( null != this._currentCapacity ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._currentCapacity) : null, "current_capacity" ,container.Add );
            AddIf( null != this._cycleCount ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._cycleCount) : null, "cycle_count" ,container.Add );
            AddIf( null != this._designedCapacity ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._designedCapacity) : null, "designed_capacity" ,container.Add );
            AddIf( null != (((object)this._health)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._health.ToString()) : null, "health" ,container.Add );
            AddIf( null != this._manufactureDate ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._manufactureDate) : null, "manufacture_date" ,container.Add );
            AddIf( null != (((object)this._manufacturer)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._manufacturer.ToString()) : null, "manufacturer" ,container.Add );
            AddIf( null != this._maxCapacity ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._maxCapacity) : null, "max_capacity" ,container.Add );
            AddIf( null != this._minutesToFullCharge ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._minutesToFullCharge) : null, "minutes_to_full_charge" ,container.Add );
            AddIf( null != this._minutesUntilEmpty ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._minutesUntilEmpty) : null, "minutes_until_empty" ,container.Add );
            AddIf( null != (((object)this._model)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._model.ToString()) : null, "model" ,container.Add );
            AddIf( null != this._percentRemaining ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._percentRemaining) : null, "percent_remaining" ,container.Add );
            AddIf( null != (((object)this._serialNumber)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._serialNumber.ToString()) : null, "serial_number" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != this._voltage ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._voltage) : null, "voltage" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}