using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 创建负载均衡器的包周期信息，若传入该结构体，则创建包周期的LB。  [不支持该字段，请勿使用](tag:dt,dt_test,hcso_dt)
    /// </summary>
    public class PrepaidCreateOption 
    {
        [JsonConverter(typeof(EnumClassConverter<PeriodTypeEnum>))]
        public class PeriodTypeEnum
        {
            /// <summary>
            /// Enum MONTH for value: month
            /// </summary>
            public static readonly PeriodTypeEnum MONTH = new PeriodTypeEnum("month");

            /// <summary>
            /// Enum YEAR for value: year
            /// </summary>
            public static readonly PeriodTypeEnum YEAR = new PeriodTypeEnum("year");

            private static readonly Dictionary<string, PeriodTypeEnum> StaticFields =
            new Dictionary<string, PeriodTypeEnum>()
            {
                { "month", MONTH },
                { "year", YEAR },
            };

            private string Value;

            public PeriodTypeEnum(string value)
            {
                Value = value;
            }

            public static PeriodTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as PeriodTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(PeriodTypeEnum a, PeriodTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PeriodTypeEnum a, PeriodTypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        [JsonProperty("auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoRenew { get; set; }

        [JsonProperty("auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoPay { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrepaidCreateOption {\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  autoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("  autoPay: ").Append(AutoPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrepaidCreateOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrepaidCreateOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.AutoRenew == input.AutoRenew ||
                    (this.AutoRenew != null &&
                    this.AutoRenew.Equals(input.AutoRenew))
                ) && 
                (
                    this.AutoPay == input.AutoPay ||
                    (this.AutoPay != null &&
                    this.AutoPay.Equals(input.AutoPay))
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
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.AutoRenew != null)
                    hashCode = hashCode * 59 + this.AutoRenew.GetHashCode();
                if (this.AutoPay != null)
                    hashCode = hashCode * 59 + this.AutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
