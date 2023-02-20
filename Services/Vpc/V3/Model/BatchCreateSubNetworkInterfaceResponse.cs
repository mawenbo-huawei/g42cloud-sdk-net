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
    public class BatchCreateSubNetworkInterfaceResponse : SdkResponse
    {

        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        [JsonProperty("sub_network_interfaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubNetworkInterface> SubNetworkInterfaces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateSubNetworkInterfaceResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  subNetworkInterfaces: ").Append(SubNetworkInterfaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateSubNetworkInterfaceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateSubNetworkInterfaceResponse input)
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
                    this.SubNetworkInterfaces == input.SubNetworkInterfaces ||
                    this.SubNetworkInterfaces != null &&
                    input.SubNetworkInterfaces != null &&
                    this.SubNetworkInterfaces.SequenceEqual(input.SubNetworkInterfaces)
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
                if (this.SubNetworkInterfaces != null)
                    hashCode = hashCode * 59 + this.SubNetworkInterfaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
