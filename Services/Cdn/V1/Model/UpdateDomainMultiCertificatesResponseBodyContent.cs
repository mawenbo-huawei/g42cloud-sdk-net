using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateDomainMultiCertificatesResponseBodyContent 
    {

        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        [JsonProperty("https_switch", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsSwitch { get; set; }

        [JsonProperty("access_origin_way", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessOriginWay { get; set; }

        [JsonProperty("force_redirect_https", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForceRedirectHttps { get; set; }

        [JsonProperty("force_redirect_config", NullValueHandling = NullValueHandling.Ignore)]
        public ForceRedirect ForceRedirectConfig { get; set; }

        [JsonProperty("http2", NullValueHandling = NullValueHandling.Ignore)]
        public int? Http2 { get; set; }

        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateType { get; set; }

        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpirationTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainMultiCertificatesResponseBodyContent {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  httpsSwitch: ").Append(HttpsSwitch).Append("\n");
            sb.Append("  accessOriginWay: ").Append(AccessOriginWay).Append("\n");
            sb.Append("  forceRedirectHttps: ").Append(ForceRedirectHttps).Append("\n");
            sb.Append("  forceRedirectConfig: ").Append(ForceRedirectConfig).Append("\n");
            sb.Append("  http2: ").Append(Http2).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainMultiCertificatesResponseBodyContent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainMultiCertificatesResponseBodyContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.HttpsSwitch == input.HttpsSwitch ||
                    (this.HttpsSwitch != null &&
                    this.HttpsSwitch.Equals(input.HttpsSwitch))
                ) && 
                (
                    this.AccessOriginWay == input.AccessOriginWay ||
                    (this.AccessOriginWay != null &&
                    this.AccessOriginWay.Equals(input.AccessOriginWay))
                ) && 
                (
                    this.ForceRedirectHttps == input.ForceRedirectHttps ||
                    (this.ForceRedirectHttps != null &&
                    this.ForceRedirectHttps.Equals(input.ForceRedirectHttps))
                ) && 
                (
                    this.ForceRedirectConfig == input.ForceRedirectConfig ||
                    (this.ForceRedirectConfig != null &&
                    this.ForceRedirectConfig.Equals(input.ForceRedirectConfig))
                ) && 
                (
                    this.Http2 == input.Http2 ||
                    (this.Http2 != null &&
                    this.Http2.Equals(input.Http2))
                ) && 
                (
                    this.CertName == input.CertName ||
                    (this.CertName != null &&
                    this.CertName.Equals(input.CertName))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.CertificateType == input.CertificateType ||
                    (this.CertificateType != null &&
                    this.CertificateType.Equals(input.CertificateType))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.HttpsSwitch != null)
                    hashCode = hashCode * 59 + this.HttpsSwitch.GetHashCode();
                if (this.AccessOriginWay != null)
                    hashCode = hashCode * 59 + this.AccessOriginWay.GetHashCode();
                if (this.ForceRedirectHttps != null)
                    hashCode = hashCode * 59 + this.ForceRedirectHttps.GetHashCode();
                if (this.ForceRedirectConfig != null)
                    hashCode = hashCode * 59 + this.ForceRedirectConfig.GetHashCode();
                if (this.Http2 != null)
                    hashCode = hashCode * 59 + this.Http2.GetHashCode();
                if (this.CertName != null)
                    hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.CertificateType != null)
                    hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
