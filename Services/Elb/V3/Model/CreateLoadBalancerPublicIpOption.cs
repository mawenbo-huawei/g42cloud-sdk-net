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
    /// 创建ELB时，新建公网IP请求参数
    /// </summary>
    public class CreateLoadBalancerPublicIpOption 
    {

        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        [JsonProperty("network_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkType { get; set; }

        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public CreateLoadBalancerBandwidthOption Bandwidth { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoadBalancerPublicIpOption {\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  networkType: ").Append(NetworkType).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoadBalancerPublicIpOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoadBalancerPublicIpOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.NetworkType == input.NetworkType ||
                    (this.NetworkType != null &&
                    this.NetworkType.Equals(input.NetworkType))
                ) && 
                (
                    this.BillingInfo == input.BillingInfo ||
                    (this.BillingInfo != null &&
                    this.BillingInfo.Equals(input.BillingInfo))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
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
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.NetworkType != null)
                    hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.BillingInfo != null)
                    hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
