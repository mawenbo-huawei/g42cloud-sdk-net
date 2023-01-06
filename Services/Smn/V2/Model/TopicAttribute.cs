using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TopicAttribute 
    {

        [JsonProperty("Version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("Statement", NullValueHandling = NullValueHandling.Ignore)]
        public List<Statement> Statement { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicAttribute {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  statement: ").Append(Statement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopicAttribute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopicAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Statement == input.Statement ||
                    this.Statement != null &&
                    input.Statement != null &&
                    this.Statement.SequenceEqual(input.Statement)
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Statement != null)
                    hashCode = hashCode * 59 + this.Statement.GetHashCode();
                return hashCode;
            }
        }
    }
}
