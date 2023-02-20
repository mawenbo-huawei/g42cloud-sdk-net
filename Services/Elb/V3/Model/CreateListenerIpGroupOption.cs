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
    /// 监听器对象中的控制组（ipgroup）信息，可以不传或传null或{}，表示监听器不绑定访问控制组。 若需要绑定访问控制组，则ipgroup_id是必须的。  [不支持该字段，请勿使用。](tag:hcso_dt)
    /// </summary>
    public class CreateListenerIpGroupOption 
    {
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum WHITE for value: white
            /// </summary>
            public static readonly TypeEnum WHITE = new TypeEnum("white");

            /// <summary>
            /// Enum BLACK for value: black
            /// </summary>
            public static readonly TypeEnum BLACK = new TypeEnum("black");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "white", WHITE },
                { "black", BLACK },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("ipgroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpgroupId { get; set; }

        [JsonProperty("enable_ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIpgroup { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListenerIpGroupOption {\n");
            sb.Append("  ipgroupId: ").Append(IpgroupId).Append("\n");
            sb.Append("  enableIpgroup: ").Append(EnableIpgroup).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateListenerIpGroupOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateListenerIpGroupOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpgroupId == input.IpgroupId ||
                    (this.IpgroupId != null &&
                    this.IpgroupId.Equals(input.IpgroupId))
                ) && 
                (
                    this.EnableIpgroup == input.EnableIpgroup ||
                    (this.EnableIpgroup != null &&
                    this.EnableIpgroup.Equals(input.EnableIpgroup))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.IpgroupId != null)
                    hashCode = hashCode * 59 + this.IpgroupId.GetHashCode();
                if (this.EnableIpgroup != null)
                    hashCode = hashCode * 59 + this.EnableIpgroup.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
