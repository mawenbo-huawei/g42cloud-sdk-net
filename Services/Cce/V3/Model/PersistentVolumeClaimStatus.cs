using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PersistentVolumeClaimStatus 
    {

        [JsonProperty("accessModes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessModes { get; set; }

        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string Capacity { get; set; }

        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersistentVolumeClaimStatus {\n");
            sb.Append("  accessModes: ").Append(AccessModes).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PersistentVolumeClaimStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PersistentVolumeClaimStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessModes == input.AccessModes ||
                    this.AccessModes != null &&
                    input.AccessModes != null &&
                    this.AccessModes.SequenceEqual(input.AccessModes)
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
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
                if (this.AccessModes != null)
                    hashCode = hashCode * 59 + this.AccessModes.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                return hashCode;
            }
        }
    }
}
