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
    /// 
    /// </summary>
    public class NeutronCreateSecurityGroupRuleOption 
    {
        [JsonConverter(typeof(EnumClassConverter<DirectionEnum>))]
        public class DirectionEnum
        {
            /// <summary>
            /// Enum INGRESS for value: ingress
            /// </summary>
            public static readonly DirectionEnum INGRESS = new DirectionEnum("ingress");

            /// <summary>
            /// Enum EGRESS for value: egress
            /// </summary>
            public static readonly DirectionEnum EGRESS = new DirectionEnum("egress");

            private static readonly Dictionary<string, DirectionEnum> StaticFields =
            new Dictionary<string, DirectionEnum>()
            {
                { "ingress", INGRESS },
                { "egress", EGRESS },
            };

            private string _value;

            public DirectionEnum()
            {

            }

            public DirectionEnum(string value)
            {
                _value = value;
            }

            public static DirectionEnum FromValue(string value)
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

                if (this.Equals(obj as DirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DirectionEnum a, DirectionEnum b)
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

            public static bool operator !=(DirectionEnum a, DirectionEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<EthertypeEnum>))]
        public class EthertypeEnum
        {
            /// <summary>
            /// Enum IPV4 for value: IPv4
            /// </summary>
            public static readonly EthertypeEnum IPV4 = new EthertypeEnum("IPv4");

            /// <summary>
            /// Enum IPV6 for value: IPv6
            /// </summary>
            public static readonly EthertypeEnum IPV6 = new EthertypeEnum("IPv6");

            private static readonly Dictionary<string, EthertypeEnum> StaticFields =
            new Dictionary<string, EthertypeEnum>()
            {
                { "IPv4", IPV4 },
                { "IPv6", IPV6 },
            };

            private string _value;

            public EthertypeEnum()
            {

            }

            public EthertypeEnum(string value)
            {
                _value = value;
            }

            public static EthertypeEnum FromValue(string value)
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

                if (this.Equals(obj as EthertypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EthertypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EthertypeEnum a, EthertypeEnum b)
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

            public static bool operator !=(EthertypeEnum a, EthertypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public DirectionEnum Direction { get; set; }
        [JsonProperty("ethertype", NullValueHandling = NullValueHandling.Ignore)]
        public EthertypeEnum Ethertype { get; set; }
        [JsonProperty("port_range_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortRangeMax { get; set; }

        [JsonProperty("port_range_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortRangeMin { get; set; }

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("remote_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteGroupId { get; set; }

        [JsonProperty("remote_ip_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteIpPrefix { get; set; }

        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateSecurityGroupRuleOption {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  ethertype: ").Append(Ethertype).Append("\n");
            sb.Append("  portRangeMax: ").Append(PortRangeMax).Append("\n");
            sb.Append("  portRangeMin: ").Append(PortRangeMin).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  remoteGroupId: ").Append(RemoteGroupId).Append("\n");
            sb.Append("  remoteIpPrefix: ").Append(RemoteIpPrefix).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateSecurityGroupRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateSecurityGroupRuleOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Ethertype == input.Ethertype ||
                    (this.Ethertype != null &&
                    this.Ethertype.Equals(input.Ethertype))
                ) && 
                (
                    this.PortRangeMax == input.PortRangeMax ||
                    (this.PortRangeMax != null &&
                    this.PortRangeMax.Equals(input.PortRangeMax))
                ) && 
                (
                    this.PortRangeMin == input.PortRangeMin ||
                    (this.PortRangeMin != null &&
                    this.PortRangeMin.Equals(input.PortRangeMin))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.RemoteGroupId == input.RemoteGroupId ||
                    (this.RemoteGroupId != null &&
                    this.RemoteGroupId.Equals(input.RemoteGroupId))
                ) && 
                (
                    this.RemoteIpPrefix == input.RemoteIpPrefix ||
                    (this.RemoteIpPrefix != null &&
                    this.RemoteIpPrefix.Equals(input.RemoteIpPrefix))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Ethertype != null)
                    hashCode = hashCode * 59 + this.Ethertype.GetHashCode();
                if (this.PortRangeMax != null)
                    hashCode = hashCode * 59 + this.PortRangeMax.GetHashCode();
                if (this.PortRangeMin != null)
                    hashCode = hashCode * 59 + this.PortRangeMin.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.RemoteGroupId != null)
                    hashCode = hashCode * 59 + this.RemoteGroupId.GetHashCode();
                if (this.RemoteIpPrefix != null)
                    hashCode = hashCode * 59 + this.RemoteIpPrefix.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
