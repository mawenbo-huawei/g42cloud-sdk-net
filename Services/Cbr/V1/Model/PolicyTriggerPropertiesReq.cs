using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PolicyTriggerPropertiesReq 
    {

        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Pattern { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTriggerPropertiesReq {\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyTriggerPropertiesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyTriggerPropertiesReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pattern == input.Pattern ||
                    this.Pattern != null &&
                    input.Pattern != null &&
                    this.Pattern.SequenceEqual(input.Pattern)
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
                return hashCode;
            }
        }
    }
}
