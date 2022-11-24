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
    public class NeutronUpdateFirewallGroupOption 
    {

        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("egress_firewall_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EgressFirewallPolicyId { get; set; }

        [JsonProperty("ingress_firewall_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IngressFirewallPolicyId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ports { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronUpdateFirewallGroupOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  egressFirewallPolicyId: ").Append(EgressFirewallPolicyId).Append("\n");
            sb.Append("  ingressFirewallPolicyId: ").Append(IngressFirewallPolicyId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronUpdateFirewallGroupOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronUpdateFirewallGroupOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EgressFirewallPolicyId == input.EgressFirewallPolicyId ||
                    (this.EgressFirewallPolicyId != null &&
                    this.EgressFirewallPolicyId.Equals(input.EgressFirewallPolicyId))
                ) && 
                (
                    this.IngressFirewallPolicyId == input.IngressFirewallPolicyId ||
                    (this.IngressFirewallPolicyId != null &&
                    this.IngressFirewallPolicyId.Equals(input.IngressFirewallPolicyId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EgressFirewallPolicyId != null)
                    hashCode = hashCode * 59 + this.EgressFirewallPolicyId.GetHashCode();
                if (this.IngressFirewallPolicyId != null)
                    hashCode = hashCode * 59 + this.IngressFirewallPolicyId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                return hashCode;
            }
        }
    }
}
