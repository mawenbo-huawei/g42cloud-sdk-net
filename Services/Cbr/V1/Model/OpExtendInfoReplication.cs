using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OpExtendInfoReplication 
    {

        [JsonProperty("destination_backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationBackupId { get; set; }

        [JsonProperty("destination_checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationCheckpointId { get; set; }

        [JsonProperty("destination_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationProjectId { get; set; }

        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        [JsonProperty("source_backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBackupId { get; set; }

        [JsonProperty("source_checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCheckpointId { get; set; }

        [JsonProperty("source_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceProjectId { get; set; }

        [JsonProperty("source_region", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceRegion { get; set; }

        [JsonProperty("source_backup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBackupName { get; set; }

        [JsonProperty("destination_backup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationBackupName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpExtendInfoReplication {\n");
            sb.Append("  destinationBackupId: ").Append(DestinationBackupId).Append("\n");
            sb.Append("  destinationCheckpointId: ").Append(DestinationCheckpointId).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  sourceBackupId: ").Append(SourceBackupId).Append("\n");
            sb.Append("  sourceCheckpointId: ").Append(SourceCheckpointId).Append("\n");
            sb.Append("  sourceProjectId: ").Append(SourceProjectId).Append("\n");
            sb.Append("  sourceRegion: ").Append(SourceRegion).Append("\n");
            sb.Append("  sourceBackupName: ").Append(SourceBackupName).Append("\n");
            sb.Append("  destinationBackupName: ").Append(DestinationBackupName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpExtendInfoReplication);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpExtendInfoReplication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinationBackupId == input.DestinationBackupId ||
                    (this.DestinationBackupId != null &&
                    this.DestinationBackupId.Equals(input.DestinationBackupId))
                ) && 
                (
                    this.DestinationCheckpointId == input.DestinationCheckpointId ||
                    (this.DestinationCheckpointId != null &&
                    this.DestinationCheckpointId.Equals(input.DestinationCheckpointId))
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
                    this.SourceBackupId == input.SourceBackupId ||
                    (this.SourceBackupId != null &&
                    this.SourceBackupId.Equals(input.SourceBackupId))
                ) && 
                (
                    this.SourceCheckpointId == input.SourceCheckpointId ||
                    (this.SourceCheckpointId != null &&
                    this.SourceCheckpointId.Equals(input.SourceCheckpointId))
                ) && 
                (
                    this.SourceProjectId == input.SourceProjectId ||
                    (this.SourceProjectId != null &&
                    this.SourceProjectId.Equals(input.SourceProjectId))
                ) && 
                (
                    this.SourceRegion == input.SourceRegion ||
                    (this.SourceRegion != null &&
                    this.SourceRegion.Equals(input.SourceRegion))
                ) && 
                (
                    this.SourceBackupName == input.SourceBackupName ||
                    (this.SourceBackupName != null &&
                    this.SourceBackupName.Equals(input.SourceBackupName))
                ) && 
                (
                    this.DestinationBackupName == input.DestinationBackupName ||
                    (this.DestinationBackupName != null &&
                    this.DestinationBackupName.Equals(input.DestinationBackupName))
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
                if (this.DestinationBackupId != null)
                    hashCode = hashCode * 59 + this.DestinationBackupId.GetHashCode();
                if (this.DestinationCheckpointId != null)
                    hashCode = hashCode * 59 + this.DestinationCheckpointId.GetHashCode();
                if (this.DestinationProjectId != null)
                    hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                if (this.DestinationRegion != null)
                    hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.SourceBackupId != null)
                    hashCode = hashCode * 59 + this.SourceBackupId.GetHashCode();
                if (this.SourceCheckpointId != null)
                    hashCode = hashCode * 59 + this.SourceCheckpointId.GetHashCode();
                if (this.SourceProjectId != null)
                    hashCode = hashCode * 59 + this.SourceProjectId.GetHashCode();
                if (this.SourceRegion != null)
                    hashCode = hashCode * 59 + this.SourceRegion.GetHashCode();
                if (this.SourceBackupName != null)
                    hashCode = hashCode * 59 + this.SourceBackupName.GetHashCode();
                if (this.DestinationBackupName != null)
                    hashCode = hashCode * 59 + this.DestinationBackupName.GetHashCode();
                return hashCode;
            }
        }
    }
}
