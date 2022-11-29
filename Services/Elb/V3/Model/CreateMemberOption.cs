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
    /// 创建后端服务器请求参数
    /// </summary>
    public class CreateMemberOption 
    {

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        [JsonProperty("subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetCidrId { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMemberOption {\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  subnetCidrId: ").Append(SubnetCidrId).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMemberOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMemberOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    (this.ProtocolPort != null &&
                    this.ProtocolPort.Equals(input.ProtocolPort))
                ) && 
                (
                    this.SubnetCidrId == input.SubnetCidrId ||
                    (this.SubnetCidrId != null &&
                    this.SubnetCidrId.Equals(input.SubnetCidrId))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.SubnetCidrId != null)
                    hashCode = hashCode * 59 + this.SubnetCidrId.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                return hashCode;
            }
        }
    }
}
