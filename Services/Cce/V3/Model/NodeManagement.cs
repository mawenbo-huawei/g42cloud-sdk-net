using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeManagement 
    {

        [JsonProperty("serverGroupReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupReference { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeManagement {\n");
            sb.Append("  serverGroupReference: ").Append(ServerGroupReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeManagement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeManagement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerGroupReference == input.ServerGroupReference ||
                    (this.ServerGroupReference != null &&
                    this.ServerGroupReference.Equals(input.ServerGroupReference))
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
                if (this.ServerGroupReference != null)
                    hashCode = hashCode * 59 + this.ServerGroupReference.GetHashCode();
                return hashCode;
            }
        }
    }
}
