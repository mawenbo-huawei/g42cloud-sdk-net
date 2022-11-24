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
    /// authenticatingProxy模式相关配置。认证模式为authenticating_proxy时必选
    /// </summary>
    public class AuthenticatingProxy 
    {

        [JsonProperty("ca", NullValueHandling = NullValueHandling.Ignore)]
        public string Ca { get; set; }

        [JsonProperty("cert", NullValueHandling = NullValueHandling.Ignore)]
        public string Cert { get; set; }

        [JsonProperty("privateKey", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticatingProxy {\n");
            sb.Append("  ca: ").Append(Ca).Append("\n");
            sb.Append("  cert: ").Append(Cert).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthenticatingProxy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthenticatingProxy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ca == input.Ca ||
                    (this.Ca != null &&
                    this.Ca.Equals(input.Ca))
                ) && 
                (
                    this.Cert == input.Cert ||
                    (this.Cert != null &&
                    this.Cert.Equals(input.Cert))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
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
                if (this.Ca != null)
                    hashCode = hashCode * 59 + this.Ca.GetHashCode();
                if (this.Cert != null)
                    hashCode = hashCode * 59 + this.Cert.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
