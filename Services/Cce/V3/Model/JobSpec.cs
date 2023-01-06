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
    public class JobSpec 
    {

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("clusterUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterUID { get; set; }

        [JsonProperty("resourceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceID { get; set; }

        [JsonProperty("resourceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtendParam { get; set; }

        [JsonProperty("subJobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Job> SubJobs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobSpec {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  clusterUID: ").Append(ClusterUID).Append("\n");
            sb.Append("  resourceID: ").Append(ResourceID).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  subJobs: ").Append(SubJobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ClusterUID == input.ClusterUID ||
                    (this.ClusterUID != null &&
                    this.ClusterUID.Equals(input.ClusterUID))
                ) && 
                (
                    this.ResourceID == input.ResourceID ||
                    (this.ResourceID != null &&
                    this.ResourceID.Equals(input.ResourceID))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    this.ExtendParam != null &&
                    input.ExtendParam != null &&
                    this.ExtendParam.SequenceEqual(input.ExtendParam)
                ) && 
                (
                    this.SubJobs == input.SubJobs ||
                    this.SubJobs != null &&
                    input.SubJobs != null &&
                    this.SubJobs.SequenceEqual(input.SubJobs)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ClusterUID != null)
                    hashCode = hashCode * 59 + this.ClusterUID.GetHashCode();
                if (this.ResourceID != null)
                    hashCode = hashCode * 59 + this.ResourceID.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.SubJobs != null)
                    hashCode = hashCode * 59 + this.SubJobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
