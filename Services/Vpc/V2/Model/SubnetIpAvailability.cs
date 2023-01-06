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
    public class SubnetIpAvailability 
    {

        [JsonProperty("used_ips", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedIps { get; set; }

        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        [JsonProperty("subnet_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetName { get; set; }

        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        [JsonProperty("total_ips", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalIps { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubnetIpAvailability {\n");
            sb.Append("  usedIps: ").Append(UsedIps).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  subnetName: ").Append(SubnetName).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  totalIps: ").Append(TotalIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubnetIpAvailability);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubnetIpAvailability input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UsedIps == input.UsedIps ||
                    (this.UsedIps != null &&
                    this.UsedIps.Equals(input.UsedIps))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.SubnetName == input.SubnetName ||
                    (this.SubnetName != null &&
                    this.SubnetName.Equals(input.SubnetName))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.Cidr == input.Cidr ||
                    (this.Cidr != null &&
                    this.Cidr.Equals(input.Cidr))
                ) && 
                (
                    this.TotalIps == input.TotalIps ||
                    (this.TotalIps != null &&
                    this.TotalIps.Equals(input.TotalIps))
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
                if (this.UsedIps != null)
                    hashCode = hashCode * 59 + this.UsedIps.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SubnetName != null)
                    hashCode = hashCode * 59 + this.SubnetName.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.TotalIps != null)
                    hashCode = hashCode * 59 + this.TotalIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
