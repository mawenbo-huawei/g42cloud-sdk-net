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
    public class BackupReplicateReqBody 
    {

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("destination_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationProjectId { get; set; }

        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        [JsonProperty("destination_vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationVaultId { get; set; }

        [JsonProperty("enable_acceleration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAcceleration { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupReplicateReqBody {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  destinationVaultId: ").Append(DestinationVaultId).Append("\n");
            sb.Append("  enableAcceleration: ").Append(EnableAcceleration).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupReplicateReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupReplicateReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DestinationProjectId == input.DestinationProjectId ||
                    (this.DestinationProjectId != null &&
                    this.DestinationProjectId.Equals(input.DestinationProjectId))
                ) && 
                (
                    this.DestinationRegion == input.DestinationRegion ||
                    (this.DestinationRegion != null &&
                    this.DestinationRegion.Equals(input.DestinationRegion))
                ) && 
                (
                    this.DestinationVaultId == input.DestinationVaultId ||
                    (this.DestinationVaultId != null &&
                    this.DestinationVaultId.Equals(input.DestinationVaultId))
                ) && 
                (
                    this.EnableAcceleration == input.EnableAcceleration ||
                    (this.EnableAcceleration != null &&
                    this.EnableAcceleration.Equals(input.EnableAcceleration))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DestinationProjectId != null)
                    hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                if (this.DestinationRegion != null)
                    hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.DestinationVaultId != null)
                    hashCode = hashCode * 59 + this.DestinationVaultId.GetHashCode();
                if (this.EnableAcceleration != null)
                    hashCode = hashCode * 59 + this.EnableAcceleration.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
