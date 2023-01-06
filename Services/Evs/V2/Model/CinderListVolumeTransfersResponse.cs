using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CinderListVolumeTransfersResponse : SdkResponse
    {

        [JsonProperty("transfers", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeTransferSummary> Transfers { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderListVolumeTransfersResponse {\n");
            sb.Append("  transfers: ").Append(Transfers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderListVolumeTransfersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderListVolumeTransfersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Transfers == input.Transfers ||
                    this.Transfers != null &&
                    input.Transfers != null &&
                    this.Transfers.SequenceEqual(input.Transfers)
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
                if (this.Transfers != null)
                    hashCode = hashCode * 59 + this.Transfers.GetHashCode();
                return hashCode;
            }
        }
    }
}
