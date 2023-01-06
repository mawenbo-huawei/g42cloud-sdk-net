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
    public class ApplicationEndpoint 
    {

        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        [JsonProperty("endpoint_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointUrn { get; set; }

        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string Enabled { get; set; }

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationEndpoint {\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  endpointUrn: ").Append(EndpointUrn).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationEndpoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplicationEndpoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.EndpointUrn == input.EndpointUrn ||
                    (this.EndpointUrn != null &&
                    this.EndpointUrn.Equals(input.EndpointUrn))
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EndpointUrn != null)
                    hashCode = hashCode * 59 + this.EndpointUrn.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }
    }
}
