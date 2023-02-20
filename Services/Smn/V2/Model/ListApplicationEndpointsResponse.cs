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
    /// Response Object
    /// </summary>
    public class ListApplicationEndpointsResponse : SdkResponse
    {

        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        [JsonProperty("next_page_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NextPageFlag { get; set; }

        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicationEndpoint> Endpoints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListApplicationEndpointsResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  nextPageFlag: ").Append(NextPageFlag).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListApplicationEndpointsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListApplicationEndpointsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.NextPageFlag == input.NextPageFlag ||
                    (this.NextPageFlag != null &&
                    this.NextPageFlag.Equals(input.NextPageFlag))
                ) && 
                (
                    this.Endpoints == input.Endpoints ||
                    this.Endpoints != null &&
                    input.Endpoints != null &&
                    this.Endpoints.SequenceEqual(input.Endpoints)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.NextPageFlag != null)
                    hashCode = hashCode * 59 + this.NextPageFlag.GetHashCode();
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                return hashCode;
            }
        }
    }
}
