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
    public class AddSubscriptionRequestBody 
    {

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddSubscriptionRequestBody {\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddSubscriptionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddSubscriptionRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
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
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Remark != null)
                    hashCode = hashCode * 59 + this.Remark.GetHashCode();
                return hashCode;
            }
        }
    }
}
