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
    /// This is a auto create Body Object
    /// </summary>
    public class CreateSubNetworkInterfaceRequestBody 
    {

        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }

        [JsonProperty("sub_network_interface", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubNetworkInterfaceOption SubNetworkInterface { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubNetworkInterfaceRequestBody {\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("  subNetworkInterface: ").Append(SubNetworkInterface).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubNetworkInterfaceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubNetworkInterfaceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DryRun == input.DryRun ||
                    (this.DryRun != null &&
                    this.DryRun.Equals(input.DryRun))
                ) && 
                (
                    this.SubNetworkInterface == input.SubNetworkInterface ||
                    (this.SubNetworkInterface != null &&
                    this.SubNetworkInterface.Equals(input.SubNetworkInterface))
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
                if (this.DryRun != null)
                    hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                if (this.SubNetworkInterface != null)
                    hashCode = hashCode * 59 + this.SubNetworkInterface.GetHashCode();
                return hashCode;
            }
        }
    }
}
