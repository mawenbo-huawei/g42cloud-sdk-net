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
    /// 插件模板详细信息
    /// </summary>
    public class Templatespec 
    {

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("require", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Require { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        [JsonProperty("logoURL", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoURL { get; set; }

        [JsonProperty("readmeURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadmeURL { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Versions> Versions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Templatespec {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  require: ").Append(Require).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  logoURL: ").Append(LogoURL).Append("\n");
            sb.Append("  readmeURL: ").Append(ReadmeURL).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  versions: ").Append(Versions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Templatespec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Templatespec input)
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
                    this.Require == input.Require ||
                    (this.Require != null &&
                    this.Require.Equals(input.Require))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.LogoURL == input.LogoURL ||
                    (this.LogoURL != null &&
                    this.LogoURL.Equals(input.LogoURL))
                ) && 
                (
                    this.ReadmeURL == input.ReadmeURL ||
                    (this.ReadmeURL != null &&
                    this.ReadmeURL.Equals(input.ReadmeURL))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    input.Versions != null &&
                    this.Versions.SequenceEqual(input.Versions)
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
                if (this.Require != null)
                    hashCode = hashCode * 59 + this.Require.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.LogoURL != null)
                    hashCode = hashCode * 59 + this.LogoURL.GetHashCode();
                if (this.ReadmeURL != null)
                    hashCode = hashCode * 59 + this.ReadmeURL.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Versions != null)
                    hashCode = hashCode * 59 + this.Versions.GetHashCode();
                return hashCode;
            }
        }
    }
}
