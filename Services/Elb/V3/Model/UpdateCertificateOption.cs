using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateCertificateOption 
    {

        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        [JsonProperty("enc_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string EncCertificate { get; set; }

        [JsonProperty("enc_private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string EncPrivateKey { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCertificateOption {\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  encCertificate: ").Append(EncCertificate).Append("\n");
            sb.Append("  encPrivateKey: ").Append(EncPrivateKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCertificateOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCertificateOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.EncCertificate == input.EncCertificate ||
                    (this.EncCertificate != null &&
                    this.EncCertificate.Equals(input.EncCertificate))
                ) && 
                (
                    this.EncPrivateKey == input.EncPrivateKey ||
                    (this.EncPrivateKey != null &&
                    this.EncPrivateKey.Equals(input.EncPrivateKey))
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
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.EncCertificate != null)
                    hashCode = hashCode * 59 + this.EncCertificate.GetHashCode();
                if (this.EncPrivateKey != null)
                    hashCode = hashCode * 59 + this.EncPrivateKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
