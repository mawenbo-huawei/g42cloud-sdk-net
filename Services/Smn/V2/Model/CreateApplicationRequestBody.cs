using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateApplicationRequestBody 
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        [JsonProperty("platform_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformPrincipal { get; set; }

        [JsonProperty("platform_credential", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformCredential { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  platformPrincipal: ").Append(PlatformPrincipal).Append("\n");
            sb.Append("  platformCredential: ").Append(PlatformCredential).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateApplicationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateApplicationRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.PlatformPrincipal == input.PlatformPrincipal ||
                    (this.PlatformPrincipal != null &&
                    this.PlatformPrincipal.Equals(input.PlatformPrincipal))
                ) && 
                (
                    this.PlatformCredential == input.PlatformCredential ||
                    (this.PlatformCredential != null &&
                    this.PlatformCredential.Equals(input.PlatformCredential))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.PlatformPrincipal != null)
                    hashCode = hashCode * 59 + this.PlatformPrincipal.GetHashCode();
                if (this.PlatformCredential != null)
                    hashCode = hashCode * 59 + this.PlatformCredential.GetHashCode();
                return hashCode;
            }
        }
    }
}
