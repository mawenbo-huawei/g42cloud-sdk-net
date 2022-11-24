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
    public class NeutronRemoveFirewallRuleRequestBody 
    {

        [JsonProperty("firewall_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallRuleId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronRemoveFirewallRuleRequestBody {\n");
            sb.Append("  firewallRuleId: ").Append(FirewallRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronRemoveFirewallRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronRemoveFirewallRuleRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallRuleId == input.FirewallRuleId ||
                    (this.FirewallRuleId != null &&
                    this.FirewallRuleId.Equals(input.FirewallRuleId))
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
                if (this.FirewallRuleId != null)
                    hashCode = hashCode * 59 + this.FirewallRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
