using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 快照信息。
    /// </summary>
    public class CreateSnapshotOption 
    {

        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSnapshotOption {\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSnapshotOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSnapshotOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
                ) && 
                (
                    this.Force == input.Force ||
                    (this.Force != null &&
                    this.Force.Equals(input.Force))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.Force != null)
                    hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
