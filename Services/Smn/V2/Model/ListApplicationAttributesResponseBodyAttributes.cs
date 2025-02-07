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
    public class ListApplicationAttributesResponseBodyAttributes 
    {

        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string Enabled { get; set; }

        [JsonProperty("apple_certificate_expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AppleCertificateExpirationDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListApplicationAttributesResponseBodyAttributes {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  appleCertificateExpirationDate: ").Append(AppleCertificateExpirationDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListApplicationAttributesResponseBodyAttributes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListApplicationAttributesResponseBodyAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.AppleCertificateExpirationDate == input.AppleCertificateExpirationDate ||
                    (this.AppleCertificateExpirationDate != null &&
                    this.AppleCertificateExpirationDate.Equals(input.AppleCertificateExpirationDate))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.AppleCertificateExpirationDate != null)
                    hashCode = hashCode * 59 + this.AppleCertificateExpirationDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
