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
    /// 
    /// </summary>
    public class UpdateSubNetworkInterfaceOption 
    {

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubNetworkInterfaceOption {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSubNetworkInterfaceOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubNetworkInterfaceOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
