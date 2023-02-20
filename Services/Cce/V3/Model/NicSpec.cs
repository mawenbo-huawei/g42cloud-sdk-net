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
    /// 主网卡的描述信息。  
    /// </summary>
    public class NicSpec 
    {

        [JsonProperty("subnetId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        [JsonProperty("fixedIps", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FixedIps { get; set; }

        [JsonProperty("ipBlock", NullValueHandling = NullValueHandling.Ignore)]
        public string IpBlock { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NicSpec {\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  fixedIps: ").Append(FixedIps).Append("\n");
            sb.Append("  ipBlock: ").Append(IpBlock).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NicSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NicSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.FixedIps == input.FixedIps ||
                    this.FixedIps != null &&
                    input.FixedIps != null &&
                    this.FixedIps.SequenceEqual(input.FixedIps)
                ) && 
                (
                    this.IpBlock == input.IpBlock ||
                    (this.IpBlock != null &&
                    this.IpBlock.Equals(input.IpBlock))
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
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.FixedIps != null)
                    hashCode = hashCode * 59 + this.FixedIps.GetHashCode();
                if (this.IpBlock != null)
                    hashCode = hashCode * 59 + this.IpBlock.GetHashCode();
                return hashCode;
            }
        }
    }
}
