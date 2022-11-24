using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSubnetOption 
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        [JsonProperty("gateway_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayIp { get; set; }

        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        [JsonProperty("dhcp_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DhcpEnable { get; set; }

        [JsonProperty("primary_dns", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryDns { get; set; }

        [JsonProperty("secondary_dns", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryDns { get; set; }

        [JsonProperty("dnsList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsList { get; set; }

        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraDhcpOption> ExtraDhcpOpts { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubnetOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  gatewayIp: ").Append(GatewayIp).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  dhcpEnable: ").Append(DhcpEnable).Append("\n");
            sb.Append("  primaryDns: ").Append(PrimaryDns).Append("\n");
            sb.Append("  secondaryDns: ").Append(SecondaryDns).Append("\n");
            sb.Append("  dnsList: ").Append(DnsList).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubnetOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubnetOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Cidr == input.Cidr ||
                    (this.Cidr != null &&
                    this.Cidr.Equals(input.Cidr))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.GatewayIp == input.GatewayIp ||
                    (this.GatewayIp != null &&
                    this.GatewayIp.Equals(input.GatewayIp))
                ) && 
                (
                    this.Ipv6Enable == input.Ipv6Enable ||
                    (this.Ipv6Enable != null &&
                    this.Ipv6Enable.Equals(input.Ipv6Enable))
                ) && 
                (
                    this.DhcpEnable == input.DhcpEnable ||
                    (this.DhcpEnable != null &&
                    this.DhcpEnable.Equals(input.DhcpEnable))
                ) && 
                (
                    this.PrimaryDns == input.PrimaryDns ||
                    (this.PrimaryDns != null &&
                    this.PrimaryDns.Equals(input.PrimaryDns))
                ) && 
                (
                    this.SecondaryDns == input.SecondaryDns ||
                    (this.SecondaryDns != null &&
                    this.SecondaryDns.Equals(input.SecondaryDns))
                ) && 
                (
                    this.DnsList == input.DnsList ||
                    this.DnsList != null &&
                    input.DnsList != null &&
                    this.DnsList.SequenceEqual(input.DnsList)
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.ExtraDhcpOpts == input.ExtraDhcpOpts ||
                    this.ExtraDhcpOpts != null &&
                    input.ExtraDhcpOpts != null &&
                    this.ExtraDhcpOpts.SequenceEqual(input.ExtraDhcpOpts)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.GatewayIp != null)
                    hashCode = hashCode * 59 + this.GatewayIp.GetHashCode();
                if (this.Ipv6Enable != null)
                    hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.DhcpEnable != null)
                    hashCode = hashCode * 59 + this.DhcpEnable.GetHashCode();
                if (this.PrimaryDns != null)
                    hashCode = hashCode * 59 + this.PrimaryDns.GetHashCode();
                if (this.SecondaryDns != null)
                    hashCode = hashCode * 59 + this.SecondaryDns.GetHashCode();
                if (this.DnsList != null)
                    hashCode = hashCode * 59 + this.DnsList.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ExtraDhcpOpts != null)
                    hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                return hashCode;
            }
        }
    }
}
