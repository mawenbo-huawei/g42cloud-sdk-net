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
    /// Response Object
    /// </summary>
    public class ListVolumesResponse : SdkResponse
    {

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("volumes_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> VolumesLinks { get; set; }

        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeDetail> Volumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVolumesResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  volumesLinks: ").Append(VolumesLinks).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVolumesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVolumesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.VolumesLinks == input.VolumesLinks ||
                    this.VolumesLinks != null &&
                    input.VolumesLinks != null &&
                    this.VolumesLinks.SequenceEqual(input.VolumesLinks)
                ) && 
                (
                    this.Volumes == input.Volumes ||
                    this.Volumes != null &&
                    input.Volumes != null &&
                    this.Volumes.SequenceEqual(input.Volumes)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.VolumesLinks != null)
                    hashCode = hashCode * 59 + this.VolumesLinks.GetHashCode();
                if (this.Volumes != null)
                    hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
