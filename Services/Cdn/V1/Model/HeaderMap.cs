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
    /// 设置HTTP头参数。取值：\&quot;Content-Disposition\&quot;, \&quot;Content-Language\&quot;, \&quot;Access-Control-Allow-Origin\&quot;,\&quot;Access-Control-Allow-Methods\&quot;, \&quot;Access-Control-Max-Age\&quot;, \&quot;Access-Control-Expose-Headers\&quot;。
    /// </summary>
    public class HeaderMap 
    {

        [JsonProperty("Content-Disposition", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentDisposition { get; set; }

        [JsonProperty("Content-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentLanguage { get; set; }

        [JsonProperty("Access-Control-Allow-Origin", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowOrigin { get; set; }

        [JsonProperty("Access-Control-Allow-Methods", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowMethods { get; set; }

        [JsonProperty("Access-Control-Max-Age", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlMaxAge { get; set; }

        [JsonProperty("Access-Control-Expose-Headers", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlExposeHeaders { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HeaderMap {\n");
            sb.Append("  contentDisposition: ").Append(ContentDisposition).Append("\n");
            sb.Append("  contentLanguage: ").Append(ContentLanguage).Append("\n");
            sb.Append("  accessControlAllowOrigin: ").Append(AccessControlAllowOrigin).Append("\n");
            sb.Append("  accessControlAllowMethods: ").Append(AccessControlAllowMethods).Append("\n");
            sb.Append("  accessControlMaxAge: ").Append(AccessControlMaxAge).Append("\n");
            sb.Append("  accessControlExposeHeaders: ").Append(AccessControlExposeHeaders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HeaderMap);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HeaderMap input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentDisposition == input.ContentDisposition ||
                    (this.ContentDisposition != null &&
                    this.ContentDisposition.Equals(input.ContentDisposition))
                ) && 
                (
                    this.ContentLanguage == input.ContentLanguage ||
                    (this.ContentLanguage != null &&
                    this.ContentLanguage.Equals(input.ContentLanguage))
                ) && 
                (
                    this.AccessControlAllowOrigin == input.AccessControlAllowOrigin ||
                    (this.AccessControlAllowOrigin != null &&
                    this.AccessControlAllowOrigin.Equals(input.AccessControlAllowOrigin))
                ) && 
                (
                    this.AccessControlAllowMethods == input.AccessControlAllowMethods ||
                    (this.AccessControlAllowMethods != null &&
                    this.AccessControlAllowMethods.Equals(input.AccessControlAllowMethods))
                ) && 
                (
                    this.AccessControlMaxAge == input.AccessControlMaxAge ||
                    (this.AccessControlMaxAge != null &&
                    this.AccessControlMaxAge.Equals(input.AccessControlMaxAge))
                ) && 
                (
                    this.AccessControlExposeHeaders == input.AccessControlExposeHeaders ||
                    (this.AccessControlExposeHeaders != null &&
                    this.AccessControlExposeHeaders.Equals(input.AccessControlExposeHeaders))
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
                if (this.ContentDisposition != null)
                    hashCode = hashCode * 59 + this.ContentDisposition.GetHashCode();
                if (this.ContentLanguage != null)
                    hashCode = hashCode * 59 + this.ContentLanguage.GetHashCode();
                if (this.AccessControlAllowOrigin != null)
                    hashCode = hashCode * 59 + this.AccessControlAllowOrigin.GetHashCode();
                if (this.AccessControlAllowMethods != null)
                    hashCode = hashCode * 59 + this.AccessControlAllowMethods.GetHashCode();
                if (this.AccessControlMaxAge != null)
                    hashCode = hashCode * 59 + this.AccessControlMaxAge.GetHashCode();
                if (this.AccessControlExposeHeaders != null)
                    hashCode = hashCode * 59 + this.AccessControlExposeHeaders.GetHashCode();
                return hashCode;
            }
        }
    }
}
