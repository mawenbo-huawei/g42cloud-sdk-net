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
    public class ClusterInformationSpec 
    {

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("customSan", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomSan { get; set; }

        [JsonProperty("containerNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public ContainerNetworkUpdate ContainerNetwork { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterInformationSpec {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  customSan: ").Append(CustomSan).Append("\n");
            sb.Append("  containerNetwork: ").Append(ContainerNetwork).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterInformationSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterInformationSpec input)
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
                    this.CustomSan == input.CustomSan ||
                    this.CustomSan != null &&
                    input.CustomSan != null &&
                    this.CustomSan.SequenceEqual(input.CustomSan)
                ) && 
                (
                    this.ContainerNetwork == input.ContainerNetwork ||
                    (this.ContainerNetwork != null &&
                    this.ContainerNetwork.Equals(input.ContainerNetwork))
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
                if (this.CustomSan != null)
                    hashCode = hashCode * 59 + this.CustomSan.GetHashCode();
                if (this.ContainerNetwork != null)
                    hashCode = hashCode * 59 + this.ContainerNetwork.GetHashCode();
                return hashCode;
            }
        }
    }
}
