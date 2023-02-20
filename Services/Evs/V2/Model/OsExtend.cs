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
    ///  
    /// </summary>
    public class OsExtend 
    {

        [JsonProperty("new_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsExtend {\n");
            sb.Append("  newSize: ").Append(NewSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsExtend);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsExtend input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewSize == input.NewSize ||
                    (this.NewSize != null &&
                    this.NewSize.Equals(input.NewSize))
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
                if (this.NewSize != null)
                    hashCode = hashCode * 59 + this.NewSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
