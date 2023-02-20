using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 修改自定义告警模板，请求参数
    /// </summary>
    public class UpdateAlarmTemplateRequestBody 
    {

        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        [JsonProperty("template_description", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateDescription { get; set; }

        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        [JsonProperty("dimension_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DimensionName { get; set; }

        [JsonProperty("template_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateItem> TemplateItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAlarmTemplateRequestBody {\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateDescription: ").Append(TemplateDescription).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  dimensionName: ").Append(DimensionName).Append("\n");
            sb.Append("  templateItems: ").Append(TemplateItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAlarmTemplateRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAlarmTemplateRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.TemplateDescription == input.TemplateDescription ||
                    (this.TemplateDescription != null &&
                    this.TemplateDescription.Equals(input.TemplateDescription))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.DimensionName == input.DimensionName ||
                    (this.DimensionName != null &&
                    this.DimensionName.Equals(input.DimensionName))
                ) && 
                (
                    this.TemplateItems == input.TemplateItems ||
                    this.TemplateItems != null &&
                    input.TemplateItems != null &&
                    this.TemplateItems.SequenceEqual(input.TemplateItems)
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
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.TemplateDescription != null)
                    hashCode = hashCode * 59 + this.TemplateDescription.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.DimensionName != null)
                    hashCode = hashCode * 59 + this.DimensionName.GetHashCode();
                if (this.TemplateItems != null)
                    hashCode = hashCode * 59 + this.TemplateItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
