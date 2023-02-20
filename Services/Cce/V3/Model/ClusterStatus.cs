using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClusterStatus 
    {

        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        [JsonProperty("jobID", NullValueHandling = NullValueHandling.Ignore)]
        public string JobID { get; set; }

        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClusterEndpoints> Endpoints { get; set; }

        [JsonProperty("isLocked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLocked { get; set; }

        [JsonProperty("lockScene", NullValueHandling = NullValueHandling.Ignore)]
        public string LockScene { get; set; }

        [JsonProperty("lockSource", NullValueHandling = NullValueHandling.Ignore)]
        public string LockSource { get; set; }

        [JsonProperty("lockSourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string LockSourceId { get; set; }

        [JsonProperty("deleteOption", NullValueHandling = NullValueHandling.Ignore)]
        public Object DeleteOption { get; set; }

        [JsonProperty("deleteStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Object DeleteStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  jobID: ").Append(JobID).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  isLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  lockScene: ").Append(LockScene).Append("\n");
            sb.Append("  lockSource: ").Append(LockSource).Append("\n");
            sb.Append("  lockSourceId: ").Append(LockSourceId).Append("\n");
            sb.Append("  deleteOption: ").Append(DeleteOption).Append("\n");
            sb.Append("  deleteStatus: ").Append(DeleteStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.JobID == input.JobID ||
                    (this.JobID != null &&
                    this.JobID.Equals(input.JobID))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Endpoints == input.Endpoints ||
                    this.Endpoints != null &&
                    input.Endpoints != null &&
                    this.Endpoints.SequenceEqual(input.Endpoints)
                ) && 
                (
                    this.IsLocked == input.IsLocked ||
                    (this.IsLocked != null &&
                    this.IsLocked.Equals(input.IsLocked))
                ) && 
                (
                    this.LockScene == input.LockScene ||
                    (this.LockScene != null &&
                    this.LockScene.Equals(input.LockScene))
                ) && 
                (
                    this.LockSource == input.LockSource ||
                    (this.LockSource != null &&
                    this.LockSource.Equals(input.LockSource))
                ) && 
                (
                    this.LockSourceId == input.LockSourceId ||
                    (this.LockSourceId != null &&
                    this.LockSourceId.Equals(input.LockSourceId))
                ) && 
                (
                    this.DeleteOption == input.DeleteOption ||
                    (this.DeleteOption != null &&
                    this.DeleteOption.Equals(input.DeleteOption))
                ) && 
                (
                    this.DeleteStatus == input.DeleteStatus ||
                    (this.DeleteStatus != null &&
                    this.DeleteStatus.Equals(input.DeleteStatus))
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
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.JobID != null)
                    hashCode = hashCode * 59 + this.JobID.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.IsLocked != null)
                    hashCode = hashCode * 59 + this.IsLocked.GetHashCode();
                if (this.LockScene != null)
                    hashCode = hashCode * 59 + this.LockScene.GetHashCode();
                if (this.LockSource != null)
                    hashCode = hashCode * 59 + this.LockSource.GetHashCode();
                if (this.LockSourceId != null)
                    hashCode = hashCode * 59 + this.LockSourceId.GetHashCode();
                if (this.DeleteOption != null)
                    hashCode = hashCode * 59 + this.DeleteOption.GetHashCode();
                if (this.DeleteStatus != null)
                    hashCode = hashCode * 59 + this.DeleteStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
