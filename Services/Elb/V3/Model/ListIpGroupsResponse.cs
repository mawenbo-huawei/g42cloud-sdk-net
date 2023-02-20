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
    /// Response Object
    /// </summary>
    public class ListIpGroupsResponse : SdkResponse
    {

        [JsonProperty("ipgroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpGroup> Ipgroups { get; set; }

        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIpGroupsResponse {\n");
            sb.Append("  ipgroups: ").Append(Ipgroups).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIpGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIpGroupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ipgroups == input.Ipgroups ||
                    this.Ipgroups != null &&
                    input.Ipgroups != null &&
                    this.Ipgroups.SequenceEqual(input.Ipgroups)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
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
                if (this.Ipgroups != null)
                    hashCode = hashCode * 59 + this.Ipgroups.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
