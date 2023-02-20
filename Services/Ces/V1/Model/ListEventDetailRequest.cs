using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEventDetailRequest 
    {
        [JsonConverter(typeof(EnumClassConverter<EventTypeEnum>))]
        public class EventTypeEnum
        {
            /// <summary>
            /// Enum EVENT_SYS for value: EVENT.SYS
            /// </summary>
            public static readonly EventTypeEnum EVENT_SYS = new EventTypeEnum("EVENT.SYS");

            /// <summary>
            /// Enum EVENT_CUSTOM for value: EVENT.CUSTOM
            /// </summary>
            public static readonly EventTypeEnum EVENT_CUSTOM = new EventTypeEnum("EVENT.CUSTOM");

            private static readonly Dictionary<string, EventTypeEnum> StaticFields =
            new Dictionary<string, EventTypeEnum>()
            {
                { "EVENT.SYS", EVENT_SYS },
                { "EVENT.CUSTOM", EVENT_CUSTOM },
            };

            private string _value;

            public EventTypeEnum()
            {

            }

            public EventTypeEnum(string value)
            {
                _value = value;
            }

            public static EventTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as EventTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventTypeEnum a, EventTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(EventTypeEnum a, EventTypeEnum b)
            {
                return !(a == b);
            }
        }


        [SDKProperty("Content-Type", IsHeader = true)]
        [JsonProperty("Content-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        [SDKProperty("event_name", IsPath = true)]
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        [SDKProperty("event_type", IsQuery = true)]
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        [SDKProperty("event_source", IsQuery = true)]
        [JsonProperty("event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSource { get; set; }

        [SDKProperty("event_level", IsQuery = true)]
        [JsonProperty("event_level", NullValueHandling = NullValueHandling.Ignore)]
        public string EventLevel { get; set; }

        [SDKProperty("event_user", IsQuery = true)]
        [JsonProperty("event_user", NullValueHandling = NullValueHandling.Ignore)]
        public string EventUser { get; set; }

        [SDKProperty("event_state", IsQuery = true)]
        [JsonProperty("event_state", NullValueHandling = NullValueHandling.Ignore)]
        public string EventState { get; set; }

        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }

        [SDKProperty("start", IsQuery = true)]
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public int? Start { get; set; }

        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEventDetailRequest {\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventSource: ").Append(EventSource).Append("\n");
            sb.Append("  eventLevel: ").Append(EventLevel).Append("\n");
            sb.Append("  eventUser: ").Append(EventUser).Append("\n");
            sb.Append("  eventState: ").Append(EventState).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEventDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEventDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.EventSource == input.EventSource ||
                    (this.EventSource != null &&
                    this.EventSource.Equals(input.EventSource))
                ) && 
                (
                    this.EventLevel == input.EventLevel ||
                    (this.EventLevel != null &&
                    this.EventLevel.Equals(input.EventLevel))
                ) && 
                (
                    this.EventUser == input.EventUser ||
                    (this.EventUser != null &&
                    this.EventUser.Equals(input.EventUser))
                ) && 
                (
                    this.EventState == input.EventState ||
                    (this.EventState != null &&
                    this.EventState.Equals(input.EventState))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventSource != null)
                    hashCode = hashCode * 59 + this.EventSource.GetHashCode();
                if (this.EventLevel != null)
                    hashCode = hashCode * 59 + this.EventLevel.GetHashCode();
                if (this.EventUser != null)
                    hashCode = hashCode * 59 + this.EventUser.GetHashCode();
                if (this.EventState != null)
                    hashCode = hashCode * 59 + this.EventState.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
