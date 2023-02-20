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
    public class DeleteStatus 
    {

        [JsonProperty("previous_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousTotal { get; set; }

        [JsonProperty("current_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentTotal { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public int? Updated { get; set; }

        [JsonProperty("added", NullValueHandling = NullValueHandling.Ignore)]
        public int? Added { get; set; }

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deleted { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteStatus {\n");
            sb.Append("  previousTotal: ").Append(PreviousTotal).Append("\n");
            sb.Append("  currentTotal: ").Append(CurrentTotal).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  added: ").Append(Added).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreviousTotal == input.PreviousTotal ||
                    (this.PreviousTotal != null &&
                    this.PreviousTotal.Equals(input.PreviousTotal))
                ) && 
                (
                    this.CurrentTotal == input.CurrentTotal ||
                    (this.CurrentTotal != null &&
                    this.CurrentTotal.Equals(input.CurrentTotal))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Added == input.Added ||
                    (this.Added != null &&
                    this.Added.Equals(input.Added))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
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
                if (this.PreviousTotal != null)
                    hashCode = hashCode * 59 + this.PreviousTotal.GetHashCode();
                if (this.CurrentTotal != null)
                    hashCode = hashCode * 59 + this.CurrentTotal.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Added != null)
                    hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                return hashCode;
            }
        }
    }
}
