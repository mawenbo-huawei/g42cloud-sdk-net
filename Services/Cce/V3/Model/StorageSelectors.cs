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
    public class StorageSelectors 
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("storageType", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        [JsonProperty("matchLabels", NullValueHandling = NullValueHandling.Ignore)]
        public StorageSelectorsMatchLabels MatchLabels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageSelectors {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  matchLabels: ").Append(MatchLabels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageSelectors);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageSelectors input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StorageType == input.StorageType ||
                    (this.StorageType != null &&
                    this.StorageType.Equals(input.StorageType))
                ) && 
                (
                    this.MatchLabels == input.MatchLabels ||
                    (this.MatchLabels != null &&
                    this.MatchLabels.Equals(input.MatchLabels))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.MatchLabels != null)
                    hashCode = hashCode * 59 + this.MatchLabels.GetHashCode();
                return hashCode;
            }
        }
    }
}
