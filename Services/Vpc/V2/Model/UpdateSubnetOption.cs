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
    public class UpdateSubnetOption 
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

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

        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraDhcpOption> ExtraDhcpOpts { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubnetOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  dhcpEnable: ").Append(DhcpEnable).Append("\n");
            sb.Append("  primaryDns: ").Append(PrimaryDns).Append("\n");
            sb.Append("  secondaryDns: ").Append(SecondaryDns).Append("\n");
            sb.Append("  dnsList: ").Append(DnsList).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSubnetOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubnetOption input)
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
                if (this.ExtraDhcpOpts != null)
                    hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                return hashCode;
            }
        }
    }
}
