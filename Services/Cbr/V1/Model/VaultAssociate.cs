using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VaultAssociate 
    {

        [JsonProperty("destination_vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationVaultId { get; set; }

        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        [JsonProperty("add_policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddPolicyIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VaultAssociate {\n");
            sb.Append("  destinationVaultId: ").Append(DestinationVaultId).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  addPolicyIds: ").Append(AddPolicyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VaultAssociate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VaultAssociate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinationVaultId == input.DestinationVaultId ||
                    (this.DestinationVaultId != null &&
                    this.DestinationVaultId.Equals(input.DestinationVaultId))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.AddPolicyIds == input.AddPolicyIds ||
                    this.AddPolicyIds != null &&
                    input.AddPolicyIds != null &&
                    this.AddPolicyIds.SequenceEqual(input.AddPolicyIds)
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
                if (this.DestinationVaultId != null)
                    hashCode = hashCode * 59 + this.DestinationVaultId.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.AddPolicyIds != null)
                    hashCode = hashCode * 59 + this.AddPolicyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
