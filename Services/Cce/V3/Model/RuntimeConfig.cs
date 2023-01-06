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
    public class RuntimeConfig 
    {

        [JsonProperty("lvType", NullValueHandling = NullValueHandling.Ignore)]
        public string LvType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuntimeConfig {\n");
            sb.Append("  lvType: ").Append(LvType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuntimeConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuntimeConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LvType == input.LvType ||
                    (this.LvType != null &&
                    this.LvType.Equals(input.LvType))
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
                if (this.LvType != null)
                    hashCode = hashCode * 59 + this.LvType.GetHashCode();
                return hashCode;
            }
        }
    }
}
