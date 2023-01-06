using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainItemDetail 
    {

        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        [JsonProperty("stat_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StatType { get; set; }

        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, Object>> Domains { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainItemDetail {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  statType: ").Append(StatType).Append("\n");
            sb.Append("  domains: ").Append(Domains).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainItemDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainItemDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.StatType == input.StatType ||
                    (this.StatType != null &&
                    this.StatType.Equals(input.StatType))
                ) && 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    input.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StatType != null)
                    hashCode = hashCode * 59 + this.StatType.GetHashCode();
                if (this.Domains != null)
                    hashCode = hashCode * 59 + this.Domains.GetHashCode();
                return hashCode;
            }
        }
    }
}
