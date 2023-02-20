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
    public class StorageGroups 
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("cceManaged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CceManaged { get; set; }

        [JsonProperty("selectorNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SelectorNames { get; set; }

        [JsonProperty("virtualSpaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<VirtualSpace> VirtualSpaces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageGroups {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  cceManaged: ").Append(CceManaged).Append("\n");
            sb.Append("  selectorNames: ").Append(SelectorNames).Append("\n");
            sb.Append("  virtualSpaces: ").Append(VirtualSpaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageGroups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageGroups input)
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
                    this.CceManaged == input.CceManaged ||
                    (this.CceManaged != null &&
                    this.CceManaged.Equals(input.CceManaged))
                ) && 
                (
                    this.SelectorNames == input.SelectorNames ||
                    this.SelectorNames != null &&
                    input.SelectorNames != null &&
                    this.SelectorNames.SequenceEqual(input.SelectorNames)
                ) && 
                (
                    this.VirtualSpaces == input.VirtualSpaces ||
                    this.VirtualSpaces != null &&
                    input.VirtualSpaces != null &&
                    this.VirtualSpaces.SequenceEqual(input.VirtualSpaces)
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
                if (this.CceManaged != null)
                    hashCode = hashCode * 59 + this.CceManaged.GetHashCode();
                if (this.SelectorNames != null)
                    hashCode = hashCode * 59 + this.SelectorNames.GetHashCode();
                if (this.VirtualSpaces != null)
                    hashCode = hashCode * 59 + this.VirtualSpaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
