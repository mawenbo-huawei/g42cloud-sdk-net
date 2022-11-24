using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Volume 
    {

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        [JsonProperty("volumetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Volumetype { get; set; }

        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> ExtendParam { get; set; }

        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        [JsonProperty("cluster_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterType { get; set; }

        [JsonProperty("hw:passthrough", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hwpassthrough { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeMetadata Metadata { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Volume {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  volumetype: ").Append(Volumetype).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterType: ").Append(ClusterType).Append("\n");
            sb.Append("  hwpassthrough: ").Append(Hwpassthrough).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Volume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Volume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Volumetype == input.Volumetype ||
                    (this.Volumetype != null &&
                    this.Volumetype.Equals(input.Volumetype))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    this.ExtendParam != null &&
                    input.ExtendParam != null &&
                    this.ExtendParam.SequenceEqual(input.ExtendParam)
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterType == input.ClusterType ||
                    (this.ClusterType != null &&
                    this.ClusterType.Equals(input.ClusterType))
                ) && 
                (
                    this.Hwpassthrough == input.Hwpassthrough ||
                    (this.Hwpassthrough != null &&
                    this.Hwpassthrough.Equals(input.Hwpassthrough))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Volumetype != null)
                    hashCode = hashCode * 59 + this.Volumetype.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterType != null)
                    hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.Hwpassthrough != null)
                    hashCode = hashCode * 59 + this.Hwpassthrough.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
