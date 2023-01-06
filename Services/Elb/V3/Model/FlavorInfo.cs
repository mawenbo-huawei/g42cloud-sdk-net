using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 规格内容信息。
    /// </summary>
    public class FlavorInfo 
    {

        [JsonProperty("connection", NullValueHandling = NullValueHandling.Ignore)]
        public int? Connection { get; set; }

        [JsonProperty("cps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cps { get; set; }

        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qps { get; set; }

        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bandwidth { get; set; }

        [JsonProperty("lcu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lcu { get; set; }

        [JsonProperty("https_cps", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsCps { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorInfo {\n");
            sb.Append("  connection: ").Append(Connection).Append("\n");
            sb.Append("  cps: ").Append(Cps).Append("\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  lcu: ").Append(Lcu).Append("\n");
            sb.Append("  httpsCps: ").Append(HttpsCps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Connection == input.Connection ||
                    (this.Connection != null &&
                    this.Connection.Equals(input.Connection))
                ) && 
                (
                    this.Cps == input.Cps ||
                    (this.Cps != null &&
                    this.Cps.Equals(input.Cps))
                ) && 
                (
                    this.Qps == input.Qps ||
                    (this.Qps != null &&
                    this.Qps.Equals(input.Qps))
                ) && 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
                ) && 
                (
                    this.Lcu == input.Lcu ||
                    (this.Lcu != null &&
                    this.Lcu.Equals(input.Lcu))
                ) && 
                (
                    this.HttpsCps == input.HttpsCps ||
                    (this.HttpsCps != null &&
                    this.HttpsCps.Equals(input.HttpsCps))
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
                if (this.Connection != null)
                    hashCode = hashCode * 59 + this.Connection.GetHashCode();
                if (this.Cps != null)
                    hashCode = hashCode * 59 + this.Cps.GetHashCode();
                if (this.Qps != null)
                    hashCode = hashCode * 59 + this.Qps.GetHashCode();
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.Lcu != null)
                    hashCode = hashCode * 59 + this.Lcu.GetHashCode();
                if (this.HttpsCps != null)
                    hashCode = hashCode * 59 + this.HttpsCps.GetHashCode();
                return hashCode;
            }
        }
    }
}
