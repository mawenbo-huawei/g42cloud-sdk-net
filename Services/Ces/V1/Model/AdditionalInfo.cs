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
    /// 告警历史额外字段，仅针对事件监控告警场景所产生的告警历史信息。
    /// </summary>
    public class AdditionalInfo 
    {

        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalInfo {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdditionalInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
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
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                return hashCode;
            }
        }
    }
}
