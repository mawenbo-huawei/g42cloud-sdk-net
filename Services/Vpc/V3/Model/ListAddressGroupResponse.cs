using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAddressGroupResponse : SdkResponse
    {

        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        [JsonProperty("address_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddressGroup> AddressGroups { get; set; }

        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAddressGroupResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  addressGroups: ").Append(AddressGroups).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAddressGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAddressGroupResponse input)
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
                    this.AddressGroups == input.AddressGroups ||
                    this.AddressGroups != null &&
                    input.AddressGroups != null &&
                    this.AddressGroups.SequenceEqual(input.AddressGroups)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.AddressGroups != null)
                    hashCode = hashCode * 59 + this.AddressGroups.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
