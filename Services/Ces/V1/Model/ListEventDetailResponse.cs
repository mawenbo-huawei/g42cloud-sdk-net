using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEventDetailResponse : SdkResponse
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

            private string Value;

            public EventTypeEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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


        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        [JsonProperty("event_users", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EventUsers { get; set; }

        [JsonProperty("event_sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EventSources { get; set; }

        [JsonProperty("event_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventInfoDetail> EventInfo { get; set; }

        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public TotalMetaData MetaData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEventDetailResponse {\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventUsers: ").Append(EventUsers).Append("\n");
            sb.Append("  eventSources: ").Append(EventSources).Append("\n");
            sb.Append("  eventInfo: ").Append(EventInfo).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEventDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEventDetailResponse input)
        {
            if (input == null)
                return false;

            return 
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
                    this.EventUsers == input.EventUsers ||
                    this.EventUsers != null &&
                    input.EventUsers != null &&
                    this.EventUsers.SequenceEqual(input.EventUsers)
                ) && 
                (
                    this.EventSources == input.EventSources ||
                    this.EventSources != null &&
                    input.EventSources != null &&
                    this.EventSources.SequenceEqual(input.EventSources)
                ) && 
                (
                    this.EventInfo == input.EventInfo ||
                    this.EventInfo != null &&
                    input.EventInfo != null &&
                    this.EventInfo.SequenceEqual(input.EventInfo)
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
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
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventUsers != null)
                    hashCode = hashCode * 59 + this.EventUsers.GetHashCode();
                if (this.EventSources != null)
                    hashCode = hashCode * 59 + this.EventSources.GetHashCode();
                if (this.EventInfo != null)
                    hashCode = hashCode * 59 + this.EventInfo.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
