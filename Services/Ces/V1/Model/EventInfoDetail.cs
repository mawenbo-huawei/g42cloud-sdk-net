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
    /// 一条事件监控详细信息
    /// </summary>
    public class EventInfoDetail 
    {

        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        [JsonProperty("event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSource { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }

        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public EventItemDetail Detail { get; set; }

        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventInfoDetail {\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  eventSource: ").Append(EventSource).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventInfoDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventInfoDetail input)
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
                    this.EventSource == input.EventSource ||
                    (this.EventSource != null &&
                    this.EventSource.Equals(input.EventSource))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
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
                if (this.EventSource != null)
                    hashCode = hashCode * 59 + this.EventSource.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                return hashCode;
            }
        }
    }
}
