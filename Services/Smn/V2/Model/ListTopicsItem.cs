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
    public class ListTopicsItem 
    {

        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        [JsonProperty("push_policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? PushPolicy { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopicsItem {\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  pushPolicy: ").Append(PushPolicy).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopicsItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopicsItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopicUrn == input.TopicUrn ||
                    (this.TopicUrn != null &&
                    this.TopicUrn.Equals(input.TopicUrn))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.PushPolicy == input.PushPolicy ||
                    (this.PushPolicy != null &&
                    this.PushPolicy.Equals(input.PushPolicy))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.TopicUrn != null)
                    hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.PushPolicy != null)
                    hashCode = hashCode * 59 + this.PushPolicy.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
