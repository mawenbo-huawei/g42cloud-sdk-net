using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceExtraInfo 
    {

        [JsonProperty("exclude_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExcludeVolumes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceExtraInfo {\n");
            sb.Append("  excludeVolumes: ").Append(ExcludeVolumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceExtraInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceExtraInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeVolumes == input.ExcludeVolumes ||
                    this.ExcludeVolumes != null &&
                    input.ExcludeVolumes != null &&
                    this.ExcludeVolumes.SequenceEqual(input.ExcludeVolumes)
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
                if (this.ExcludeVolumes != null)
                    hashCode = hashCode * 59 + this.ExcludeVolumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
