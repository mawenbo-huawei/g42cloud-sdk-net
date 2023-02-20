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
    /// 告警规则设置的告警策略
    /// </summary>
    public class Condition 
    {

        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        [JsonProperty("suppress_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuppressDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Condition {\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  suppressDuration: ").Append(SuppressDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Condition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Condition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComparisonOperator == input.ComparisonOperator ||
                    (this.ComparisonOperator != null &&
                    this.ComparisonOperator.Equals(input.ComparisonOperator))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.SuppressDuration == input.SuppressDuration ||
                    (this.SuppressDuration != null &&
                    this.SuppressDuration.Equals(input.SuppressDuration))
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
                if (this.ComparisonOperator != null)
                    hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.SuppressDuration != null)
                    hashCode = hashCode * 59 + this.SuppressDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
