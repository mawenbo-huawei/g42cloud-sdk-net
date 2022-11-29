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
    /// 创建自定义告警模板添加的告警规则。
    /// </summary>
    public class TemplateItem 
    {

        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmTemplateCondition Condition { get; set; }

        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateItem {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.AlarmLevel == input.AlarmLevel ||
                    (this.AlarmLevel != null &&
                    this.AlarmLevel.Equals(input.AlarmLevel))
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
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AlarmLevel != null)
                    hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
