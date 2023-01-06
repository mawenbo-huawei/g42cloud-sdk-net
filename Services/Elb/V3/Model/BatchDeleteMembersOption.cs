using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 批量删除member请求参数。
    /// </summary>
    public class BatchDeleteMembersOption 
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteMembersOption {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteMembersOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteMembersOption input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    (this.ProtocolPort != null &&
                    this.ProtocolPort.Equals(input.ProtocolPort))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
