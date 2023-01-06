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
    /// Response Object
    /// </summary>
    public class ShowMetricDataResponse : SdkResponse
    {

        [JsonProperty("datapoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Datapoint> Datapoints { get; set; }

        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMetricDataResponse {\n");
            sb.Append("  datapoints: ").Append(Datapoints).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMetricDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMetricDataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Datapoints == input.Datapoints ||
                    this.Datapoints != null &&
                    input.Datapoints != null &&
                    this.Datapoints.SequenceEqual(input.Datapoints)
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
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
                if (this.Datapoints != null)
                    hashCode = hashCode * 59 + this.Datapoints.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                return hashCode;
            }
        }
    }
}
