using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteResourceGroupRequest 
    {

        [SDKProperty("Content-Type", IsHeader = true)]
        [JsonProperty("Content-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteResourceGroupRequest {\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteResourceGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteResourceGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
