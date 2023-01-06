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
    public class NodeBandwidth 
    {

        [JsonProperty("chargemode", NullValueHandling = NullValueHandling.Ignore)]
        public string Chargemode { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        [JsonProperty("sharetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Sharetype { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeBandwidth {\n");
            sb.Append("  chargemode: ").Append(Chargemode).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  sharetype: ").Append(Sharetype).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeBandwidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeBandwidth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Chargemode == input.Chargemode ||
                    (this.Chargemode != null &&
                    this.Chargemode.Equals(input.Chargemode))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Sharetype == input.Sharetype ||
                    (this.Sharetype != null &&
                    this.Sharetype.Equals(input.Sharetype))
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
                if (this.Chargemode != null)
                    hashCode = hashCode * 59 + this.Chargemode.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Sharetype != null)
                    hashCode = hashCode * 59 + this.Sharetype.GetHashCode();
                return hashCode;
            }
        }
    }
}
