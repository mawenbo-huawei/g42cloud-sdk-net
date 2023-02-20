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
    /// ENI网络配置，创建集群指定使用云原生网络2.0网络模式时必填subnets和eniSubnetId其中一个字段(eniSubnetCIDR可选，若填写了会校验是否合法)，1.19.10及新版本集群使用subnets字段，1.19.8及老版本若使用subnets字段，则取值subnets数组中的第一个子网ID作为容器地址使用的子网ID。
    /// </summary>
    public class EniNetwork 
    {

        [JsonProperty("eniSubnetId", NullValueHandling = NullValueHandling.Ignore)]
        public string EniSubnetId { get; set; }

        [JsonProperty("eniSubnetCIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string EniSubnetCIDR { get; set; }

        [JsonProperty("subnets", NullValueHandling = NullValueHandling.Ignore)]
        public List<NetworkSubnet> Subnets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EniNetwork {\n");
            sb.Append("  eniSubnetId: ").Append(EniSubnetId).Append("\n");
            sb.Append("  eniSubnetCIDR: ").Append(EniSubnetCIDR).Append("\n");
            sb.Append("  subnets: ").Append(Subnets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EniNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EniNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EniSubnetId == input.EniSubnetId ||
                    (this.EniSubnetId != null &&
                    this.EniSubnetId.Equals(input.EniSubnetId))
                ) && 
                (
                    this.EniSubnetCIDR == input.EniSubnetCIDR ||
                    (this.EniSubnetCIDR != null &&
                    this.EniSubnetCIDR.Equals(input.EniSubnetCIDR))
                ) && 
                (
                    this.Subnets == input.Subnets ||
                    this.Subnets != null &&
                    input.Subnets != null &&
                    this.Subnets.SequenceEqual(input.Subnets)
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
                if (this.EniSubnetId != null)
                    hashCode = hashCode * 59 + this.EniSubnetId.GetHashCode();
                if (this.EniSubnetCIDR != null)
                    hashCode = hashCode * 59 + this.EniSubnetCIDR.GetHashCode();
                if (this.Subnets != null)
                    hashCode = hashCode * 59 + this.Subnets.GetHashCode();
                return hashCode;
            }
        }
    }
}
