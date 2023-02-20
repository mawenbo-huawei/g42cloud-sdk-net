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
    /// 
    /// </summary>
    public class Referer 
    {

        [JsonProperty("referer_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RefererType { get; set; }

        [JsonProperty("referer_list", NullValueHandling = NullValueHandling.Ignore)]
        public string RefererList { get; set; }

        [JsonProperty("include_empty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeEmpty { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Referer {\n");
            sb.Append("  refererType: ").Append(RefererType).Append("\n");
            sb.Append("  refererList: ").Append(RefererList).Append("\n");
            sb.Append("  includeEmpty: ").Append(IncludeEmpty).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Referer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Referer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RefererType == input.RefererType ||
                    (this.RefererType != null &&
                    this.RefererType.Equals(input.RefererType))
                ) && 
                (
                    this.RefererList == input.RefererList ||
                    (this.RefererList != null &&
                    this.RefererList.Equals(input.RefererList))
                ) && 
                (
                    this.IncludeEmpty == input.IncludeEmpty ||
                    (this.IncludeEmpty != null &&
                    this.IncludeEmpty.Equals(input.IncludeEmpty))
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
                if (this.RefererType != null)
                    hashCode = hashCode * 59 + this.RefererType.GetHashCode();
                if (this.RefererList != null)
                    hashCode = hashCode * 59 + this.RefererList.GetHashCode();
                if (this.IncludeEmpty != null)
                    hashCode = hashCode * 59 + this.IncludeEmpty.GetHashCode();
                return hashCode;
            }
        }
    }
}
