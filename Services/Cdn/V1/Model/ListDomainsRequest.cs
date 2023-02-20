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
    /// Request Object
    /// </summary>
    public class ListDomainsRequest 
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

        [JsonConverter(typeof(EnumClassConverter<DomainStatusEnum>))]
        public class DomainStatusEnum
        {
            /// <summary>
            /// Enum ONLINE for value: online
            /// </summary>
            public static readonly DomainStatusEnum ONLINE = new DomainStatusEnum("online");

            /// <summary>
            /// Enum OFFLINE for value: offline
            /// </summary>
            public static readonly DomainStatusEnum OFFLINE = new DomainStatusEnum("offline");

            /// <summary>
            /// Enum CONFIGURING for value: configuring
            /// </summary>
            public static readonly DomainStatusEnum CONFIGURING = new DomainStatusEnum("configuring");

            /// <summary>
            /// Enum CONFIGURE_FAILED for value: configure_failed
            /// </summary>
            public static readonly DomainStatusEnum CONFIGURE_FAILED = new DomainStatusEnum("configure_failed");

            /// <summary>
            /// Enum CHECKING for value: checking
            /// </summary>
            public static readonly DomainStatusEnum CHECKING = new DomainStatusEnum("checking");

            /// <summary>
            /// Enum CHECK_FAILED for value: check_failed
            /// </summary>
            public static readonly DomainStatusEnum CHECK_FAILED = new DomainStatusEnum("check_failed");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly DomainStatusEnum DELETING = new DomainStatusEnum("deleting");

            private static readonly Dictionary<string, DomainStatusEnum> StaticFields =
            new Dictionary<string, DomainStatusEnum>()
            {
                { "online", ONLINE },
                { "offline", OFFLINE },
                { "configuring", CONFIGURING },
                { "configure_failed", CONFIGURE_FAILED },
                { "checking", CHECKING },
                { "check_failed", CHECK_FAILED },
                { "deleting", DELETING },
            };

            private string _value;

            public DomainStatusEnum()
            {

            }

            public DomainStatusEnum(string value)
            {
                _value = value;
            }

            public static DomainStatusEnum FromValue(string value)
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

                if (this.Equals(obj as DomainStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DomainStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DomainStatusEnum a, DomainStatusEnum b)
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

            public static bool operator !=(DomainStatusEnum a, DomainStatusEnum b)
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


        [SDKProperty("domain_name", IsQuery = true)]
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        [SDKProperty("business_type", IsQuery = true)]
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessTypeEnum BusinessType { get; set; }
        [SDKProperty("domain_status", IsQuery = true)]
        [JsonProperty("domain_status", NullValueHandling = NullValueHandling.Ignore)]
        public DomainStatusEnum DomainStatus { get; set; }
        [SDKProperty("service_area", IsQuery = true)]
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceAreaEnum ServiceArea { get; set; }
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        [SDKProperty("page_number", IsQuery = true)]
        [JsonProperty("page_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNumber { get; set; }

        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainsRequest {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  domainStatus: ").Append(DomainStatus).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  pageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainsRequest input)
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
                    this.DomainStatus == input.DomainStatus ||
                    (this.DomainStatus != null &&
                    this.DomainStatus.Equals(input.DomainStatus))
                ) && 
                (
                    this.ServiceArea == input.ServiceArea ||
                    (this.ServiceArea != null &&
                    this.ServiceArea.Equals(input.ServiceArea))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
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
                if (this.DomainStatus != null)
                    hashCode = hashCode * 59 + this.DomainStatus.GetHashCode();
                if (this.ServiceArea != null)
                    hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
