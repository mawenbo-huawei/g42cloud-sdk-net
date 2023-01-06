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
    public class PublishMessageRequestBody 
    {

        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("message_structure", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageStructure { get; set; }

        [JsonProperty("message_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageTemplateName { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        [JsonProperty("time_to_live", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeToLive { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishMessageRequestBody {\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  messageStructure: ").Append(MessageStructure).Append("\n");
            sb.Append("  messageTemplateName: ").Append(MessageTemplateName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  timeToLive: ").Append(TimeToLive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublishMessageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublishMessageRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageStructure == input.MessageStructure ||
                    (this.MessageStructure != null &&
                    this.MessageStructure.Equals(input.MessageStructure))
                ) && 
                (
                    this.MessageTemplateName == input.MessageTemplateName ||
                    (this.MessageTemplateName != null &&
                    this.MessageTemplateName.Equals(input.MessageTemplateName))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TimeToLive == input.TimeToLive ||
                    (this.TimeToLive != null &&
                    this.TimeToLive.Equals(input.TimeToLive))
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
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MessageStructure != null)
                    hashCode = hashCode * 59 + this.MessageStructure.GetHashCode();
                if (this.MessageTemplateName != null)
                    hashCode = hashCode * 59 + this.MessageTemplateName.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TimeToLive != null)
                    hashCode = hashCode * 59 + this.TimeToLive.GetHashCode();
                return hashCode;
            }
        }
    }
}
