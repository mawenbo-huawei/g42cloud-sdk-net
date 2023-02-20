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
    /// 证书配置查询响应体
    /// </summary>
    public class HttpGetBody 
    {

        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsStatus { get; set; }

        [JsonProperty("certificate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateName { get; set; }

        [JsonProperty("certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateValue { get; set; }

        [JsonProperty("certificate_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateSource { get; set; }

        [JsonProperty("http2_status", NullValueHandling = NullValueHandling.Ignore)]
        public string Http2Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpGetBody {\n");
            sb.Append("  httpsStatus: ").Append(HttpsStatus).Append("\n");
            sb.Append("  certificateName: ").Append(CertificateName).Append("\n");
            sb.Append("  certificateValue: ").Append(CertificateValue).Append("\n");
            sb.Append("  certificateSource: ").Append(CertificateSource).Append("\n");
            sb.Append("  http2Status: ").Append(Http2Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpGetBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpGetBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpsStatus == input.HttpsStatus ||
                    (this.HttpsStatus != null &&
                    this.HttpsStatus.Equals(input.HttpsStatus))
                ) && 
                (
                    this.CertificateName == input.CertificateName ||
                    (this.CertificateName != null &&
                    this.CertificateName.Equals(input.CertificateName))
                ) && 
                (
                    this.CertificateValue == input.CertificateValue ||
                    (this.CertificateValue != null &&
                    this.CertificateValue.Equals(input.CertificateValue))
                ) && 
                (
                    this.CertificateSource == input.CertificateSource ||
                    (this.CertificateSource != null &&
                    this.CertificateSource.Equals(input.CertificateSource))
                ) && 
                (
                    this.Http2Status == input.Http2Status ||
                    (this.Http2Status != null &&
                    this.Http2Status.Equals(input.Http2Status))
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
                if (this.HttpsStatus != null)
                    hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.CertificateName != null)
                    hashCode = hashCode * 59 + this.CertificateName.GetHashCode();
                if (this.CertificateValue != null)
                    hashCode = hashCode * 59 + this.CertificateValue.GetHashCode();
                if (this.CertificateSource != null)
                    hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.Http2Status != null)
                    hashCode = hashCode * 59 + this.Http2Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
