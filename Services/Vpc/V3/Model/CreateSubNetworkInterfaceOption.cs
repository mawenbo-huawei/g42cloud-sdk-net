using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSubNetworkInterfaceOption 
    {

        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirsubnetId { get; set; }

        [JsonProperty("vlan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VlanId { get; set; }

        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIpAddress { get; set; }

        [JsonProperty("ipv6_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6IpAddress { get; set; }

        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubNetworkInterfaceOption {\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  vlanId: ").Append(VlanId).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  ipv6IpAddress: ").Append(Ipv6IpAddress).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubNetworkInterfaceOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubNetworkInterfaceOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VirsubnetId == input.VirsubnetId ||
                    (this.VirsubnetId != null &&
                    this.VirsubnetId.Equals(input.VirsubnetId))
                ) && 
                (
                    this.VlanId == input.VlanId ||
                    (this.VlanId != null &&
                    this.VlanId.Equals(input.VlanId))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Ipv6Enable == input.Ipv6Enable ||
                    (this.Ipv6Enable != null &&
                    this.Ipv6Enable.Equals(input.Ipv6Enable))
                ) && 
                (
                    this.PrivateIpAddress == input.PrivateIpAddress ||
                    (this.PrivateIpAddress != null &&
                    this.PrivateIpAddress.Equals(input.PrivateIpAddress))
                ) && 
                (
                    this.Ipv6IpAddress == input.Ipv6IpAddress ||
                    (this.Ipv6IpAddress != null &&
                    this.Ipv6IpAddress.Equals(input.Ipv6IpAddress))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.VirsubnetId != null)
                    hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.VlanId != null)
                    hashCode = hashCode * 59 + this.VlanId.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Ipv6Enable != null)
                    hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.PrivateIpAddress != null)
                    hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                if (this.Ipv6IpAddress != null)
                    hashCode = hashCode * 59 + this.Ipv6IpAddress.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
