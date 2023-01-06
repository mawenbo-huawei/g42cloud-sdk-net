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
    /// 查询负载均衡状态树返回对象中的rule数据模型。
    /// </summary>
    public class LoadBalancerStatusL7Rule 
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadBalancerStatusL7Rule {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadBalancerStatusL7Rule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoadBalancerStatusL7Rule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
