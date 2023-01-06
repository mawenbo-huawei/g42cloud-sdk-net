using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 集群参数定义。
    /// </summary>
    public class ClusterSpec 
    {
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum CCE for value: CCE
            /// </summary>
            public static readonly CategoryEnum CCE = new CategoryEnum("CCE");

            /// <summary>
            /// Enum TURBO for value: Turbo
            /// </summary>
            public static readonly CategoryEnum TURBO = new CategoryEnum("Turbo");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "CCE", CCE },
                { "Turbo", TURBO },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
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

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
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

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum VIRTUALMACHINE for value: VirtualMachine
            /// </summary>
            public static readonly TypeEnum VIRTUALMACHINE = new TypeEnum("VirtualMachine");

            /// <summary>
            /// Enum ARM64 for value: ARM64
            /// </summary>
            public static readonly TypeEnum ARM64 = new TypeEnum("ARM64");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "VirtualMachine", VIRTUALMACHINE },
                { "ARM64", ARM64 },
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

        [JsonConverter(typeof(EnumClassConverter<KubeProxyModeEnum>))]
        public class KubeProxyModeEnum
        {
            /// <summary>
            /// Enum IPTABLES for value: iptables
            /// </summary>
            public static readonly KubeProxyModeEnum IPTABLES = new KubeProxyModeEnum("iptables");

            /// <summary>
            /// Enum IPVS for value: ipvs
            /// </summary>
            public static readonly KubeProxyModeEnum IPVS = new KubeProxyModeEnum("ipvs");

            private static readonly Dictionary<string, KubeProxyModeEnum> StaticFields =
            new Dictionary<string, KubeProxyModeEnum>()
            {
                { "iptables", IPTABLES },
                { "ipvs", IPVS },
            };

            private string _value;

            public KubeProxyModeEnum()
            {

            }

            public KubeProxyModeEnum(string value)
            {
                _value = value;
            }

            public static KubeProxyModeEnum FromValue(string value)
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

                if (this.Equals(obj as KubeProxyModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KubeProxyModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KubeProxyModeEnum a, KubeProxyModeEnum b)
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

            public static bool operator !=(KubeProxyModeEnum a, KubeProxyModeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("platformVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformVersion { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("customSan", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomSan { get; set; }

        [JsonProperty("ipv6enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6enable { get; set; }

        [JsonProperty("hostNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public HostNetwork HostNetwork { get; set; }

        [JsonProperty("containerNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public ContainerNetwork ContainerNetwork { get; set; }

        [JsonProperty("eniNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public EniNetwork EniNetwork { get; set; }

        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public Authentication Authentication { get; set; }

        [JsonProperty("billingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingMode { get; set; }

        [JsonProperty("masters", NullValueHandling = NullValueHandling.Ignore)]
        public List<MasterSpec> Masters { get; set; }

        [JsonProperty("kubernetesSvcIpRange", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesSvcIpRange { get; set; }

        [JsonProperty("clusterTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> ClusterTags { get; set; }

        [JsonProperty("kubeProxyMode", NullValueHandling = NullValueHandling.Ignore)]
        public KubeProxyModeEnum KubeProxyMode { get; set; }
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }

        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterExtendParam ExtendParam { get; set; }

        [JsonProperty("supportIstio", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportIstio { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterSpec {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  platformVersion: ").Append(PlatformVersion).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  customSan: ").Append(CustomSan).Append("\n");
            sb.Append("  ipv6enable: ").Append(Ipv6enable).Append("\n");
            sb.Append("  hostNetwork: ").Append(HostNetwork).Append("\n");
            sb.Append("  containerNetwork: ").Append(ContainerNetwork).Append("\n");
            sb.Append("  eniNetwork: ").Append(EniNetwork).Append("\n");
            sb.Append("  authentication: ").Append(Authentication).Append("\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  masters: ").Append(Masters).Append("\n");
            sb.Append("  kubernetesSvcIpRange: ").Append(KubernetesSvcIpRange).Append("\n");
            sb.Append("  clusterTags: ").Append(ClusterTags).Append("\n");
            sb.Append("  kubeProxyMode: ").Append(KubeProxyMode).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  supportIstio: ").Append(SupportIstio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.PlatformVersion == input.PlatformVersion ||
                    (this.PlatformVersion != null &&
                    this.PlatformVersion.Equals(input.PlatformVersion))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CustomSan == input.CustomSan ||
                    this.CustomSan != null &&
                    input.CustomSan != null &&
                    this.CustomSan.SequenceEqual(input.CustomSan)
                ) && 
                (
                    this.Ipv6enable == input.Ipv6enable ||
                    (this.Ipv6enable != null &&
                    this.Ipv6enable.Equals(input.Ipv6enable))
                ) && 
                (
                    this.HostNetwork == input.HostNetwork ||
                    (this.HostNetwork != null &&
                    this.HostNetwork.Equals(input.HostNetwork))
                ) && 
                (
                    this.ContainerNetwork == input.ContainerNetwork ||
                    (this.ContainerNetwork != null &&
                    this.ContainerNetwork.Equals(input.ContainerNetwork))
                ) && 
                (
                    this.EniNetwork == input.EniNetwork ||
                    (this.EniNetwork != null &&
                    this.EniNetwork.Equals(input.EniNetwork))
                ) && 
                (
                    this.Authentication == input.Authentication ||
                    (this.Authentication != null &&
                    this.Authentication.Equals(input.Authentication))
                ) && 
                (
                    this.BillingMode == input.BillingMode ||
                    (this.BillingMode != null &&
                    this.BillingMode.Equals(input.BillingMode))
                ) && 
                (
                    this.Masters == input.Masters ||
                    this.Masters != null &&
                    input.Masters != null &&
                    this.Masters.SequenceEqual(input.Masters)
                ) && 
                (
                    this.KubernetesSvcIpRange == input.KubernetesSvcIpRange ||
                    (this.KubernetesSvcIpRange != null &&
                    this.KubernetesSvcIpRange.Equals(input.KubernetesSvcIpRange))
                ) && 
                (
                    this.ClusterTags == input.ClusterTags ||
                    this.ClusterTags != null &&
                    input.ClusterTags != null &&
                    this.ClusterTags.SequenceEqual(input.ClusterTags)
                ) && 
                (
                    this.KubeProxyMode == input.KubeProxyMode ||
                    (this.KubeProxyMode != null &&
                    this.KubeProxyMode.Equals(input.KubeProxyMode))
                ) && 
                (
                    this.Az == input.Az ||
                    (this.Az != null &&
                    this.Az.Equals(input.Az))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    (this.ExtendParam != null &&
                    this.ExtendParam.Equals(input.ExtendParam))
                ) && 
                (
                    this.SupportIstio == input.SupportIstio ||
                    (this.SupportIstio != null &&
                    this.SupportIstio.Equals(input.SupportIstio))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.PlatformVersion != null)
                    hashCode = hashCode * 59 + this.PlatformVersion.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CustomSan != null)
                    hashCode = hashCode * 59 + this.CustomSan.GetHashCode();
                if (this.Ipv6enable != null)
                    hashCode = hashCode * 59 + this.Ipv6enable.GetHashCode();
                if (this.HostNetwork != null)
                    hashCode = hashCode * 59 + this.HostNetwork.GetHashCode();
                if (this.ContainerNetwork != null)
                    hashCode = hashCode * 59 + this.ContainerNetwork.GetHashCode();
                if (this.EniNetwork != null)
                    hashCode = hashCode * 59 + this.EniNetwork.GetHashCode();
                if (this.Authentication != null)
                    hashCode = hashCode * 59 + this.Authentication.GetHashCode();
                if (this.BillingMode != null)
                    hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                if (this.Masters != null)
                    hashCode = hashCode * 59 + this.Masters.GetHashCode();
                if (this.KubernetesSvcIpRange != null)
                    hashCode = hashCode * 59 + this.KubernetesSvcIpRange.GetHashCode();
                if (this.ClusterTags != null)
                    hashCode = hashCode * 59 + this.ClusterTags.GetHashCode();
                if (this.KubeProxyMode != null)
                    hashCode = hashCode * 59 + this.KubeProxyMode.GetHashCode();
                if (this.Az != null)
                    hashCode = hashCode * 59 + this.Az.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.SupportIstio != null)
                    hashCode = hashCode * 59 + this.SupportIstio.GetHashCode();
                return hashCode;
            }
        }
    }
}
