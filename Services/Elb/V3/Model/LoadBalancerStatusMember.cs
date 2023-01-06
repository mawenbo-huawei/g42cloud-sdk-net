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
    /// LB状态树的后端服务器组的后端服务器状态信息
    /// </summary>
    public class LoadBalancerStatusMember 
    {

        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatingStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadBalancerStatusMember {\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadBalancerStatusMember);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoadBalancerStatusMember input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    (this.ProtocolPort != null &&
                    this.ProtocolPort.Equals(input.ProtocolPort))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OperatingStatus == input.OperatingStatus ||
                    (this.OperatingStatus != null &&
                    this.OperatingStatus.Equals(input.OperatingStatus))
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
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
