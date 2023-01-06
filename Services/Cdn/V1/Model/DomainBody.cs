using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 创建域名Body
    /// </summary>
    public class DomainBody 
    {
        [JsonConverter(typeof(EnumClassConverter<BusinessTypeEnum>))]
        public class BusinessTypeEnum
        {
            /// <summary>
            /// Enum WEB for value: web
            /// </summary>
            public static readonly BusinessTypeEnum WEB = new BusinessTypeEnum("web");

            /// <summary>
            /// Enum DOWNLOAD for value: download
            /// </summary>
            public static readonly BusinessTypeEnum DOWNLOAD = new BusinessTypeEnum("download");

            /// <summary>
            /// Enum VIDEO for value: video
            /// </summary>
            public static readonly BusinessTypeEnum VIDEO = new BusinessTypeEnum("video");

            /// <summary>
            /// Enum WHOLESITE for value: wholeSite
            /// </summary>
            public static readonly BusinessTypeEnum WHOLESITE = new BusinessTypeEnum("wholeSite");

            private static readonly Dictionary<string, BusinessTypeEnum> StaticFields =
            new Dictionary<string, BusinessTypeEnum>()
            {
                { "web", WEB },
                { "download", DOWNLOAD },
                { "video", VIDEO },
                { "wholeSite", WHOLESITE },
            };

            private string _value;

            public BusinessTypeEnum()
            {

            }

            public BusinessTypeEnum(string value)
            {
                _value = value;
            }

            public static BusinessTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BusinessTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BusinessTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BusinessTypeEnum a, BusinessTypeEnum b)
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

            public static bool operator !=(BusinessTypeEnum a, BusinessTypeEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<ServiceAreaEnum>))]
        public class ServiceAreaEnum
        {
            /// <summary>
            /// Enum MAINLAND_CHINA for value: mainland_china
            /// </summary>
            public static readonly ServiceAreaEnum MAINLAND_CHINA = new ServiceAreaEnum("mainland_china");

            /// <summary>
            /// Enum OUTSIDE_MAINLAND_CHINA for value: outside_mainland_china
            /// </summary>
            public static readonly ServiceAreaEnum OUTSIDE_MAINLAND_CHINA = new ServiceAreaEnum("outside_mainland_china");

            /// <summary>
            /// Enum GLOBAL for value: global
            /// </summary>
            public static readonly ServiceAreaEnum GLOBAL = new ServiceAreaEnum("global");

            private static readonly Dictionary<string, ServiceAreaEnum> StaticFields =
            new Dictionary<string, ServiceAreaEnum>()
            {
                { "mainland_china", MAINLAND_CHINA },
                { "outside_mainland_china", OUTSIDE_MAINLAND_CHINA },
                { "global", GLOBAL },
            };

            private string _value;

            public ServiceAreaEnum()
            {

            }

            public ServiceAreaEnum(string value)
            {
                _value = value;
            }

            public static ServiceAreaEnum FromValue(string value)
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

                if (this.Equals(obj as ServiceAreaEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServiceAreaEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServiceAreaEnum a, ServiceAreaEnum b)
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

            public static bool operator !=(ServiceAreaEnum a, ServiceAreaEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessTypeEnum BusinessType { get; set; }
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Sources> Sources { get; set; }

        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceAreaEnum ServiceArea { get; set; }
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainBody {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.BusinessType == input.BusinessType ||
                    (this.BusinessType != null &&
                    this.BusinessType.Equals(input.BusinessType))
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && 
                (
                    this.ServiceArea == input.ServiceArea ||
                    (this.ServiceArea != null &&
                    this.ServiceArea.Equals(input.ServiceArea))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.BusinessType != null)
                    hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.ServiceArea != null)
                    hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
