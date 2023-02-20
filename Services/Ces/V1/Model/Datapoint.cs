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
    /// 
    /// </summary>
    public class Datapoint 
    {

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        [JsonProperty("average", NullValueHandling = NullValueHandling.Ignore)]
        public double? Average { get; set; }

        [JsonProperty("sum", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sum { get; set; }

        [JsonProperty("variance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Variance { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }

        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Datapoint {\n");
            sb.Append("  max: ").Append(Max).Append("\n");
            sb.Append("  min: ").Append(Min).Append("\n");
            sb.Append("  average: ").Append(Average).Append("\n");
            sb.Append("  sum: ").Append(Sum).Append("\n");
            sb.Append("  variance: ").Append(Variance).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Datapoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Datapoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Average == input.Average ||
                    (this.Average != null &&
                    this.Average.Equals(input.Average))
                ) && 
                (
                    this.Sum == input.Sum ||
                    (this.Sum != null &&
                    this.Sum.Equals(input.Sum))
                ) && 
                (
                    this.Variance == input.Variance ||
                    (this.Variance != null &&
                    this.Variance.Equals(input.Variance))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Average != null)
                    hashCode = hashCode * 59 + this.Average.GetHashCode();
                if (this.Sum != null)
                    hashCode = hashCode * 59 + this.Sum.GetHashCode();
                if (this.Variance != null)
                    hashCode = hashCode * 59 + this.Variance.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
