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
    /// 一条事件监控信息
    /// </summary>
    public class EventInfo 
    {

        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        [JsonProperty("event_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventCount { get; set; }

        [JsonProperty("latest_occur_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LatestOccurTime { get; set; }

        [JsonProperty("latest_event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestEventSource { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventInfo {\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventCount: ").Append(EventCount).Append("\n");
            sb.Append("  latestOccurTime: ").Append(LatestOccurTime).Append("\n");
            sb.Append("  latestEventSource: ").Append(LatestEventSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventInfo input)
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
                    this.EventCount == input.EventCount ||
                    (this.EventCount != null &&
                    this.EventCount.Equals(input.EventCount))
                ) && 
                (
                    this.LatestOccurTime == input.LatestOccurTime ||
                    (this.LatestOccurTime != null &&
                    this.LatestOccurTime.Equals(input.LatestOccurTime))
                ) && 
                (
                    this.LatestEventSource == input.LatestEventSource ||
                    (this.LatestEventSource != null &&
                    this.LatestEventSource.Equals(input.LatestEventSource))
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
                if (this.EventCount != null)
                    hashCode = hashCode * 59 + this.EventCount.GetHashCode();
                if (this.LatestOccurTime != null)
                    hashCode = hashCode * 59 + this.LatestOccurTime.GetHashCode();
                if (this.LatestEventSource != null)
                    hashCode = hashCode * 59 + this.LatestEventSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
