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
    /// 
    /// </summary>
    public class ContainerNetworkUpdate 
    {

        [JsonProperty("cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContainerCIDR> Cidrs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainerNetworkUpdate {\n");
            sb.Append("  cidrs: ").Append(Cidrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContainerNetworkUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContainerNetworkUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cidrs == input.Cidrs ||
                    this.Cidrs != null &&
                    input.Cidrs != null &&
                    this.Cidrs.SequenceEqual(input.Cidrs)
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
                if (this.Cidrs != null)
                    hashCode = hashCode * 59 + this.Cidrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
