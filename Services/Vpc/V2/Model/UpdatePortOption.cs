using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdatePortOption 
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowedAddressPair> AllowedAddressPairs { get; set; }

        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraDhcpOpt> ExtraDhcpOpts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePortOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePortOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePortOption input)
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
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.AllowedAddressPairs == input.AllowedAddressPairs ||
                    this.AllowedAddressPairs != null &&
                    input.AllowedAddressPairs != null &&
                    this.AllowedAddressPairs.SequenceEqual(input.AllowedAddressPairs)
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
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.AllowedAddressPairs != null)
                    hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                if (this.ExtraDhcpOpts != null)
                    hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                return hashCode;
            }
        }
    }
}
