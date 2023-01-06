using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点池详细状态。
    /// </summary>
    public class NodePoolCondition 
    {

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("lastProbeTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastProbeTime { get; set; }

        [JsonProperty("lastTransitTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastTransitTime { get; set; }

        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolCondition {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  lastProbeTime: ").Append(LastProbeTime).Append("\n");
            sb.Append("  lastTransitTime: ").Append(LastTransitTime).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.LastProbeTime == input.LastProbeTime ||
                    (this.LastProbeTime != null &&
                    this.LastProbeTime.Equals(input.LastProbeTime))
                ) && 
                (
                    this.LastTransitTime == input.LastTransitTime ||
                    (this.LastTransitTime != null &&
                    this.LastTransitTime.Equals(input.LastTransitTime))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastProbeTime != null)
                    hashCode = hashCode * 59 + this.LastProbeTime.GetHashCode();
                if (this.LastTransitTime != null)
                    hashCode = hashCode * 59 + this.LastTransitTime.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
