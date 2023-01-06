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
    /// 域名信息
    /// </summary>
    public class Domains 
    {
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


        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        [JsonProperty("user_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDomainId { get; set; }

        [JsonProperty("domain_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainStatus { get; set; }

        [JsonProperty("cname", NullValueHandling = NullValueHandling.Ignore)]
        public string Cname { get; set; }

        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Sources> Sources { get; set; }

        [JsonProperty("domain_origin_host", NullValueHandling = NullValueHandling.Ignore)]
        public DomainOriginHost DomainOriginHost { get; set; }

        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsStatus { get; set; }

        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        [JsonProperty("modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifyTime { get; set; }

        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public int? Disabled { get; set; }

        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public int? Locked { get; set; }

        [JsonProperty("auto_refresh_preheat", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoRefreshPreheat { get; set; }

        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceAreaEnum ServiceArea { get; set; }
        [JsonProperty("range_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RangeStatus { get; set; }

        [JsonProperty("follow_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowStatus { get; set; }

        [JsonProperty("origin_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginStatus { get; set; }

        [JsonProperty("banned_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string BannedReason { get; set; }

        [JsonProperty("locked_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string LockedReason { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Domains {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  userDomainId: ").Append(UserDomainId).Append("\n");
            sb.Append("  domainStatus: ").Append(DomainStatus).Append("\n");
            sb.Append("  cname: ").Append(Cname).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  domainOriginHost: ").Append(DomainOriginHost).Append("\n");
            sb.Append("  httpsStatus: ").Append(HttpsStatus).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  modifyTime: ").Append(ModifyTime).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  autoRefreshPreheat: ").Append(AutoRefreshPreheat).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  rangeStatus: ").Append(RangeStatus).Append("\n");
            sb.Append("  followStatus: ").Append(FollowStatus).Append("\n");
            sb.Append("  originStatus: ").Append(OriginStatus).Append("\n");
            sb.Append("  bannedReason: ").Append(BannedReason).Append("\n");
            sb.Append("  lockedReason: ").Append(LockedReason).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Domains);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Domains input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                    this.UserDomainId == input.UserDomainId ||
                    (this.UserDomainId != null &&
                    this.UserDomainId.Equals(input.UserDomainId))
                ) && 
                (
                    this.DomainStatus == input.DomainStatus ||
                    (this.DomainStatus != null &&
                    this.DomainStatus.Equals(input.DomainStatus))
                ) && 
                (
                    this.Cname == input.Cname ||
                    (this.Cname != null &&
                    this.Cname.Equals(input.Cname))
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && 
                (
                    this.DomainOriginHost == input.DomainOriginHost ||
                    (this.DomainOriginHost != null &&
                    this.DomainOriginHost.Equals(input.DomainOriginHost))
                ) && 
                (
                    this.HttpsStatus == input.HttpsStatus ||
                    (this.HttpsStatus != null &&
                    this.HttpsStatus.Equals(input.HttpsStatus))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.ModifyTime == input.ModifyTime ||
                    (this.ModifyTime != null &&
                    this.ModifyTime.Equals(input.ModifyTime))
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.AutoRefreshPreheat == input.AutoRefreshPreheat ||
                    (this.AutoRefreshPreheat != null &&
                    this.AutoRefreshPreheat.Equals(input.AutoRefreshPreheat))
                ) && 
                (
                    this.ServiceArea == input.ServiceArea ||
                    (this.ServiceArea != null &&
                    this.ServiceArea.Equals(input.ServiceArea))
                ) && 
                (
                    this.RangeStatus == input.RangeStatus ||
                    (this.RangeStatus != null &&
                    this.RangeStatus.Equals(input.RangeStatus))
                ) && 
                (
                    this.FollowStatus == input.FollowStatus ||
                    (this.FollowStatus != null &&
                    this.FollowStatus.Equals(input.FollowStatus))
                ) && 
                (
                    this.OriginStatus == input.OriginStatus ||
                    (this.OriginStatus != null &&
                    this.OriginStatus.Equals(input.OriginStatus))
                ) && 
                (
                    this.BannedReason == input.BannedReason ||
                    (this.BannedReason != null &&
                    this.BannedReason.Equals(input.BannedReason))
                ) && 
                (
                    this.LockedReason == input.LockedReason ||
                    (this.LockedReason != null &&
                    this.LockedReason.Equals(input.LockedReason))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.BusinessType != null)
                    hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.UserDomainId != null)
                    hashCode = hashCode * 59 + this.UserDomainId.GetHashCode();
                if (this.DomainStatus != null)
                    hashCode = hashCode * 59 + this.DomainStatus.GetHashCode();
                if (this.Cname != null)
                    hashCode = hashCode * 59 + this.Cname.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.DomainOriginHost != null)
                    hashCode = hashCode * 59 + this.DomainOriginHost.GetHashCode();
                if (this.HttpsStatus != null)
                    hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ModifyTime != null)
                    hashCode = hashCode * 59 + this.ModifyTime.GetHashCode();
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.AutoRefreshPreheat != null)
                    hashCode = hashCode * 59 + this.AutoRefreshPreheat.GetHashCode();
                if (this.ServiceArea != null)
                    hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.RangeStatus != null)
                    hashCode = hashCode * 59 + this.RangeStatus.GetHashCode();
                if (this.FollowStatus != null)
                    hashCode = hashCode * 59 + this.FollowStatus.GetHashCode();
                if (this.OriginStatus != null)
                    hashCode = hashCode * 59 + this.OriginStatus.GetHashCode();
                if (this.BannedReason != null)
                    hashCode = hashCode * 59 + this.BannedReason.GetHashCode();
                if (this.LockedReason != null)
                    hashCode = hashCode * 59 + this.LockedReason.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
