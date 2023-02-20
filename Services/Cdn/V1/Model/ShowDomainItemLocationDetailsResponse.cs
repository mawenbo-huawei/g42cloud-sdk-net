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
    /// Response Object
    /// </summary>
    public class ShowDomainItemLocationDetailsResponse : SdkResponse
    {

        [JsonProperty("domain_item_location_details", NullValueHandling = NullValueHandling.Ignore)]
        public DomainItemLocationDetails DomainItemLocationDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainItemLocationDetailsResponse {\n");
            sb.Append("  domainItemLocationDetails: ").Append(DomainItemLocationDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainItemLocationDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainItemLocationDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainItemLocationDetails == input.DomainItemLocationDetails ||
                    (this.DomainItemLocationDetails != null &&
                    this.DomainItemLocationDetails.Equals(input.DomainItemLocationDetails))
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
                if (this.DomainItemLocationDetails != null)
                    hashCode = hashCode * 59 + this.DomainItemLocationDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
