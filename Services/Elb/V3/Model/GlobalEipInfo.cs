using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GlobalEipInfo 
    {

        [JsonProperty("global_eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalEipId { get; set; }

        [JsonProperty("global_eip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalEipAddress { get; set; }

        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalEipInfo {\n");
            sb.Append("  globalEipId: ").Append(GlobalEipId).Append("\n");
            sb.Append("  globalEipAddress: ").Append(GlobalEipAddress).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlobalEipInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlobalEipInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GlobalEipId == input.GlobalEipId ||
                    (this.GlobalEipId != null &&
                    this.GlobalEipId.Equals(input.GlobalEipId))
                ) && 
                (
                    this.GlobalEipAddress == input.GlobalEipAddress ||
                    (this.GlobalEipAddress != null &&
                    this.GlobalEipAddress.Equals(input.GlobalEipAddress))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
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
                if (this.GlobalEipId != null)
                    hashCode = hashCode * 59 + this.GlobalEipId.GetHashCode();
                if (this.GlobalEipAddress != null)
                    hashCode = hashCode * 59 + this.GlobalEipAddress.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
