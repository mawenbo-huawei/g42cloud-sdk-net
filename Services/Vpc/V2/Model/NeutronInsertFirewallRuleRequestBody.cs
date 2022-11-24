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
    public class NeutronInsertFirewallRuleRequestBody 
    {

        [JsonProperty("firewall_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallRuleId { get; set; }

        [JsonProperty("insert_after", NullValueHandling = NullValueHandling.Ignore)]
        public string InsertAfter { get; set; }

        [JsonProperty("insert_before", NullValueHandling = NullValueHandling.Ignore)]
        public string InsertBefore { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronInsertFirewallRuleRequestBody {\n");
            sb.Append("  firewallRuleId: ").Append(FirewallRuleId).Append("\n");
            sb.Append("  insertAfter: ").Append(InsertAfter).Append("\n");
            sb.Append("  insertBefore: ").Append(InsertBefore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronInsertFirewallRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronInsertFirewallRuleRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallRuleId == input.FirewallRuleId ||
                    (this.FirewallRuleId != null &&
                    this.FirewallRuleId.Equals(input.FirewallRuleId))
                ) && 
                (
                    this.InsertAfter == input.InsertAfter ||
                    (this.InsertAfter != null &&
                    this.InsertAfter.Equals(input.InsertAfter))
                ) && 
                (
                    this.InsertBefore == input.InsertBefore ||
                    (this.InsertBefore != null &&
                    this.InsertBefore.Equals(input.InsertBefore))
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
                if (this.InsertAfter != null)
                    hashCode = hashCode * 59 + this.InsertAfter.GetHashCode();
                if (this.InsertBefore != null)
                    hashCode = hashCode * 59 + this.InsertBefore.GetHashCode();
                return hashCode;
            }
        }
    }
}
