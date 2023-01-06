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
    public class CreateAddressGroupRequestBody 
    {

        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }

        [JsonProperty("address_group", NullValueHandling = NullValueHandling.Ignore)]
        public CreateAddressGroupOption AddressGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAddressGroupRequestBody {\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("  addressGroup: ").Append(AddressGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAddressGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAddressGroupRequestBody input)
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
                    this.AddressGroup == input.AddressGroup ||
                    (this.AddressGroup != null &&
                    this.AddressGroup.Equals(input.AddressGroup))
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
                if (this.AddressGroup != null)
                    hashCode = hashCode * 59 + this.AddressGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
