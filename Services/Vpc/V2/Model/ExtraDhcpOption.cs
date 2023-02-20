using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 子网配置的NTP地址对象
    /// </summary>
    public class ExtraDhcpOption 
    {
        [JsonConverter(typeof(EnumClassConverter<OptNameEnum>))]
        public class OptNameEnum
        {
            /// <summary>
            /// Enum NTP for value: ntp
            /// </summary>
            public static readonly OptNameEnum NTP = new OptNameEnum("ntp");

            private static readonly Dictionary<string, OptNameEnum> StaticFields =
            new Dictionary<string, OptNameEnum>()
            {
                { "ntp", NTP },
            };

            private string _value;

            public OptNameEnum()
            {

            }

            public OptNameEnum(string value)
            {
                _value = value;
            }

            public static OptNameEnum FromValue(string value)
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

                if (this.Equals(obj as OptNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OptNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OptNameEnum a, OptNameEnum b)
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

            public static bool operator !=(OptNameEnum a, OptNameEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("opt_name", NullValueHandling = NullValueHandling.Ignore)]
        public OptNameEnum OptName { get; set; }
        [JsonProperty("opt_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OptValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtraDhcpOption {\n");
            sb.Append("  optName: ").Append(OptName).Append("\n");
            sb.Append("  optValue: ").Append(OptValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtraDhcpOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtraDhcpOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OptName == input.OptName ||
                    (this.OptName != null &&
                    this.OptName.Equals(input.OptName))
                ) && 
                (
                    this.OptValue == input.OptValue ||
                    (this.OptValue != null &&
                    this.OptValue.Equals(input.OptValue))
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
                if (this.OptName != null)
                    hashCode = hashCode * 59 + this.OptName.GetHashCode();
                if (this.OptValue != null)
                    hashCode = hashCode * 59 + this.OptValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
