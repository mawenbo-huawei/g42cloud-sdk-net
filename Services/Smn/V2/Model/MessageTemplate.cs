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
    public class MessageTemplate 
    {

        [JsonProperty("message_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageTemplateId { get; set; }

        [JsonProperty("message_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageTemplateName { get; set; }

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("tag_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagNames { get; set; }

        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageTemplate {\n");
            sb.Append("  messageTemplateId: ").Append(MessageTemplateId).Append("\n");
            sb.Append("  messageTemplateName: ").Append(MessageTemplateName).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  tagNames: ").Append(TagNames).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MessageTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageTemplateId == input.MessageTemplateId ||
                    (this.MessageTemplateId != null &&
                    this.MessageTemplateId.Equals(input.MessageTemplateId))
                ) && 
                (
                    this.MessageTemplateName == input.MessageTemplateName ||
                    (this.MessageTemplateName != null &&
                    this.MessageTemplateName.Equals(input.MessageTemplateName))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.TagNames == input.TagNames ||
                    this.TagNames != null &&
                    input.TagNames != null &&
                    this.TagNames.SequenceEqual(input.TagNames)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
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
                if (this.MessageTemplateId != null)
                    hashCode = hashCode * 59 + this.MessageTemplateId.GetHashCode();
                if (this.MessageTemplateName != null)
                    hashCode = hashCode * 59 + this.MessageTemplateName.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.TagNames != null)
                    hashCode = hashCode * 59 + this.TagNames.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
