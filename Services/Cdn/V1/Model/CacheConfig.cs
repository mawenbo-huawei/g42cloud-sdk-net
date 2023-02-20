using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CacheConfig 
    {

        [JsonProperty("ignore_url_parameter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreUrlParameter { get; set; }

        [JsonProperty("follow_origin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FollowOrigin { get; set; }

        [JsonProperty("compress", NullValueHandling = NullValueHandling.Ignore)]
        public CompressResponse Compress { get; set; }

        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<Rules> Rules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CacheConfig {\n");
            sb.Append("  ignoreUrlParameter: ").Append(IgnoreUrlParameter).Append("\n");
            sb.Append("  followOrigin: ").Append(FollowOrigin).Append("\n");
            sb.Append("  compress: ").Append(Compress).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CacheConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CacheConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IgnoreUrlParameter == input.IgnoreUrlParameter ||
                    (this.IgnoreUrlParameter != null &&
                    this.IgnoreUrlParameter.Equals(input.IgnoreUrlParameter))
                ) && 
                (
                    this.FollowOrigin == input.FollowOrigin ||
                    (this.FollowOrigin != null &&
                    this.FollowOrigin.Equals(input.FollowOrigin))
                ) && 
                (
                    this.Compress == input.Compress ||
                    (this.Compress != null &&
                    this.Compress.Equals(input.Compress))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
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
                if (this.IgnoreUrlParameter != null)
                    hashCode = hashCode * 59 + this.IgnoreUrlParameter.GetHashCode();
                if (this.FollowOrigin != null)
                    hashCode = hashCode * 59 + this.FollowOrigin.GetHashCode();
                if (this.Compress != null)
                    hashCode = hashCode * 59 + this.Compress.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }
    }
}
