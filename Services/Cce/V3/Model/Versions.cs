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
    /// 具体插件版本信息
    /// </summary>
    public class Versions 
    {

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public Object Input { get; set; }

        [JsonProperty("stable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stable { get; set; }

        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public Object Translate { get; set; }

        [JsonProperty("supportVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportVersions> SupportVersions { get; set; }

        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationTimestamp { get; set; }

        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTimestamp { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Versions {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  stable: ").Append(Stable).Append("\n");
            sb.Append("  translate: ").Append(Translate).Append("\n");
            sb.Append("  supportVersions: ").Append(SupportVersions).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Versions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Versions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.Stable == input.Stable ||
                    (this.Stable != null &&
                    this.Stable.Equals(input.Stable))
                ) && 
                (
                    this.Translate == input.Translate ||
                    (this.Translate != null &&
                    this.Translate.Equals(input.Translate))
                ) && 
                (
                    this.SupportVersions == input.SupportVersions ||
                    this.SupportVersions != null &&
                    input.SupportVersions != null &&
                    this.SupportVersions.SequenceEqual(input.SupportVersions)
                ) && 
                (
                    this.CreationTimestamp == input.CreationTimestamp ||
                    (this.CreationTimestamp != null &&
                    this.CreationTimestamp.Equals(input.CreationTimestamp))
                ) && 
                (
                    this.UpdateTimestamp == input.UpdateTimestamp ||
                    (this.UpdateTimestamp != null &&
                    this.UpdateTimestamp.Equals(input.UpdateTimestamp))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Stable != null)
                    hashCode = hashCode * 59 + this.Stable.GetHashCode();
                if (this.Translate != null)
                    hashCode = hashCode * 59 + this.Translate.GetHashCode();
                if (this.SupportVersions != null)
                    hashCode = hashCode * 59 + this.SupportVersions.GetHashCode();
                if (this.CreationTimestamp != null)
                    hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.UpdateTimestamp != null)
                    hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
