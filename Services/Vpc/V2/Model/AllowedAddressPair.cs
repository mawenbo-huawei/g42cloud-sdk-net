using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AllowedAddressPair 
    {

        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        [JsonProperty("mac_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllowedAddressPair {\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  macAddress: ").Append(MacAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllowedAddressPair);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AllowedAddressPair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    (this.MacAddress != null &&
                    this.MacAddress.Equals(input.MacAddress))
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
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.MacAddress != null)
                    hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
