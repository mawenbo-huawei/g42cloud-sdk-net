using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// listener对象中的ipgroup信息
    /// </summary>
    public class ListenerIpGroup 
    {

        [JsonProperty("ipgroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpgroupId { get; set; }

        [JsonProperty("enable_ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIpgroup { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListenerIpGroup {\n");
            sb.Append("  ipgroupId: ").Append(IpgroupId).Append("\n");
            sb.Append("  enableIpgroup: ").Append(EnableIpgroup).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListenerIpGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListenerIpGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpgroupId == input.IpgroupId ||
                    (this.IpgroupId != null &&
                    this.IpgroupId.Equals(input.IpgroupId))
                ) && 
                (
                    this.EnableIpgroup == input.EnableIpgroup ||
                    (this.EnableIpgroup != null &&
                    this.EnableIpgroup.Equals(input.EnableIpgroup))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.IpgroupId != null)
                    hashCode = hashCode * 59 + this.IpgroupId.GetHashCode();
                if (this.EnableIpgroup != null)
                    hashCode = hashCode * 59 + this.EnableIpgroup.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
