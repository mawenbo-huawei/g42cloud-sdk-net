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
    /// Request Object
    /// </summary>
    public class ListAllMembersRequest 
    {

        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        [SDKProperty("weight", IsQuery = true)]
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Weight { get; set; }

        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [SDKProperty("subnet_cidr_id", IsQuery = true)]
        [JsonProperty("subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetCidrId { get; set; }

        [SDKProperty("address", IsQuery = true)]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Address { get; set; }

        [SDKProperty("protocol_port", IsQuery = true)]
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ProtocolPort { get; set; }

        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        [SDKProperty("operating_status", IsQuery = true)]
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OperatingStatus { get; set; }

        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpVersion { get; set; }

        [SDKProperty("pool_id", IsQuery = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PoolId { get; set; }

        [SDKProperty("loadbalancer_id", IsQuery = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllMembersRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  subnetCidrId: ").Append(SubnetCidrId).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllMembersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllMembersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight != null &&
                    input.Weight != null &&
                    this.Weight.SequenceEqual(input.Weight)
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.SubnetCidrId == input.SubnetCidrId ||
                    this.SubnetCidrId != null &&
                    input.SubnetCidrId != null &&
                    this.SubnetCidrId.SequenceEqual(input.SubnetCidrId)
                ) && 
                (
                    this.Address == input.Address ||
                    this.Address != null &&
                    input.Address != null &&
                    this.Address.SequenceEqual(input.Address)
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    this.ProtocolPort != null &&
                    input.ProtocolPort != null &&
                    this.ProtocolPort.SequenceEqual(input.ProtocolPort)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.OperatingStatus == input.OperatingStatus ||
                    this.OperatingStatus != null &&
                    input.OperatingStatus != null &&
                    this.OperatingStatus.SequenceEqual(input.OperatingStatus)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    this.IpVersion != null &&
                    input.IpVersion != null &&
                    this.IpVersion.SequenceEqual(input.IpVersion)
                ) && 
                (
                    this.PoolId == input.PoolId ||
                    this.PoolId != null &&
                    input.PoolId != null &&
                    this.PoolId.SequenceEqual(input.PoolId)
                ) && 
                (
                    this.LoadbalancerId == input.LoadbalancerId ||
                    this.LoadbalancerId != null &&
                    input.LoadbalancerId != null &&
                    this.LoadbalancerId.SequenceEqual(input.LoadbalancerId)
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
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.SubnetCidrId != null)
                    hashCode = hashCode * 59 + this.SubnetCidrId.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
