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
    /// 负载均衡器的包周期规格变更信息
    /// </summary>
    public class PrepaidUpdateOption 
    {
        [JsonConverter(typeof(EnumClassConverter<ChangeModeEnum>))]
        public class ChangeModeEnum
        {
            /// <summary>
            /// Enum IMMEDIATE for value: immediate
            /// </summary>
            public static readonly ChangeModeEnum IMMEDIATE = new ChangeModeEnum("immediate");

            /// <summary>
            /// Enum DELAY for value: delay
            /// </summary>
            public static readonly ChangeModeEnum DELAY = new ChangeModeEnum("delay");

            private static readonly Dictionary<string, ChangeModeEnum> StaticFields =
            new Dictionary<string, ChangeModeEnum>()
            {
                { "immediate", IMMEDIATE },
                { "delay", DELAY },
            };

            private string _value;

            public ChangeModeEnum()
            {

            }

            public ChangeModeEnum(string value)
            {
                _value = value;
            }

            public static ChangeModeEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as ChangeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChangeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChangeModeEnum a, ChangeModeEnum b)
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

            public static bool operator !=(ChangeModeEnum a, ChangeModeEnum b)
            {
                return !(a == b);
            }
        }

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

            private string _value;

            public PeriodTypeEnum()
            {

            }

            public PeriodTypeEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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


        [JsonProperty("auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoPay { get; set; }

        [JsonProperty("change_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeModeEnum ChangeMode { get; set; }
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrepaidUpdateOption {\n");
            sb.Append("  autoPay: ").Append(AutoPay).Append("\n");
            sb.Append("  changeMode: ").Append(ChangeMode).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrepaidUpdateOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrepaidUpdateOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoPay == input.AutoPay ||
                    (this.AutoPay != null &&
                    this.AutoPay.Equals(input.AutoPay))
                ) && 
                (
                    this.ChangeMode == input.ChangeMode ||
                    (this.ChangeMode != null &&
                    this.ChangeMode.Equals(input.ChangeMode))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
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
                if (this.AutoPay != null)
                    hashCode = hashCode * 59 + this.AutoPay.GetHashCode();
                if (this.ChangeMode != null)
                    hashCode = hashCode * 59 + this.ChangeMode.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                return hashCode;
            }
        }
    }
}
