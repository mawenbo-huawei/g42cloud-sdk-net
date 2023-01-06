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
    /// Request Object
    /// </summary>
    public class ListSubscriptionsRequest 
    {

        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        [SDKProperty("endpoint", IsQuery = true)]
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubscriptionsRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubscriptionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubscriptionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
