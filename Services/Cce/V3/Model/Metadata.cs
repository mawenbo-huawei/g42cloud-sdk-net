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
    /// 插件基本信息，集合类的元素类型，包含一组由不同名称定义的属性。
    /// </summary>
    public class Metadata 
    {

        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotations { get; set; }

        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTimestamp { get; set; }

        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationTimestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Metadata {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Metadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Metadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.UpdateTimestamp == input.UpdateTimestamp ||
                    (this.UpdateTimestamp != null &&
                    this.UpdateTimestamp.Equals(input.UpdateTimestamp))
                ) && 
                (
                    this.CreationTimestamp == input.CreationTimestamp ||
                    (this.CreationTimestamp != null &&
                    this.CreationTimestamp.Equals(input.CreationTimestamp))
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
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.UpdateTimestamp != null)
                    hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                if (this.CreationTimestamp != null)
                    hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
