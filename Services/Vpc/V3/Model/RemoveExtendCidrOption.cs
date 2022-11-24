using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RemoveExtendCidrOption 
    {

        [JsonProperty("extend_cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExtendCidrs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveExtendCidrOption {\n");
            sb.Append("  extendCidrs: ").Append(ExtendCidrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoveExtendCidrOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoveExtendCidrOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtendCidrs == input.ExtendCidrs ||
                    this.ExtendCidrs != null &&
                    input.ExtendCidrs != null &&
                    this.ExtendCidrs.SequenceEqual(input.ExtendCidrs)
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
                if (this.ExtendCidrs != null)
                    hashCode = hashCode * 59 + this.ExtendCidrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
