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
    public class NodeSpecUpdate 
    {

        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taint> Taints { get; set; }

        [JsonProperty("k8sTags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> K8sTags { get; set; }

        [JsonProperty("userTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTag> UserTags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSpecUpdate {\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  k8sTags: ").Append(K8sTags).Append("\n");
            sb.Append("  userTags: ").Append(UserTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSpecUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSpecUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Taints == input.Taints ||
                    this.Taints != null &&
                    input.Taints != null &&
                    this.Taints.SequenceEqual(input.Taints)
                ) && 
                (
                    this.K8sTags == input.K8sTags ||
                    this.K8sTags != null &&
                    input.K8sTags != null &&
                    this.K8sTags.SequenceEqual(input.K8sTags)
                ) && 
                (
                    this.UserTags == input.UserTags ||
                    this.UserTags != null &&
                    input.UserTags != null &&
                    this.UserTags.SequenceEqual(input.UserTags)
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
                if (this.Taints != null)
                    hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.K8sTags != null)
                    hashCode = hashCode * 59 + this.K8sTags.GetHashCode();
                if (this.UserTags != null)
                    hashCode = hashCode * 59 + this.UserTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
