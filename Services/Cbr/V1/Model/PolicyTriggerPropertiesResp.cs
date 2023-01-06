using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PolicyTriggerPropertiesResp 
    {

        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Pattern { get; set; }

        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTriggerPropertiesResp {\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyTriggerPropertiesResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyTriggerPropertiesResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pattern == input.Pattern ||
                    this.Pattern != null &&
                    input.Pattern != null &&
                    this.Pattern.SequenceEqual(input.Pattern)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
