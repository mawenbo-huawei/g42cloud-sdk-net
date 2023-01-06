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
    /// 备份时跳过的资源
    /// </summary>
    public class CheckpointCreateSkippedResource 
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckpointCreateSkippedResource {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckpointCreateSkippedResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckpointCreateSkippedResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                return hashCode;
            }
        }
    }
}
