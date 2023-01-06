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
    /// Response Object
    /// </summary>
    public class ListMessageTemplatesResponse : SdkResponse
    {

        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        [JsonProperty("message_template_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageTemplateCount { get; set; }

        [JsonProperty("message_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<MessageTemplate> MessageTemplates { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMessageTemplatesResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  messageTemplateCount: ").Append(MessageTemplateCount).Append("\n");
            sb.Append("  messageTemplates: ").Append(MessageTemplates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMessageTemplatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMessageTemplatesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.MessageTemplateCount == input.MessageTemplateCount ||
                    (this.MessageTemplateCount != null &&
                    this.MessageTemplateCount.Equals(input.MessageTemplateCount))
                ) && 
                (
                    this.MessageTemplates == input.MessageTemplates ||
                    this.MessageTemplates != null &&
                    input.MessageTemplates != null &&
                    this.MessageTemplates.SequenceEqual(input.MessageTemplates)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.MessageTemplateCount != null)
                    hashCode = hashCode * 59 + this.MessageTemplateCount.GetHashCode();
                if (this.MessageTemplates != null)
                    hashCode = hashCode * 59 + this.MessageTemplates.GetHashCode();
                return hashCode;
            }
        }
    }
}
