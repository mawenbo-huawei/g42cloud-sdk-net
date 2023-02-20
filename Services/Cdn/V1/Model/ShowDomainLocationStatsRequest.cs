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
    public class ShowDomainLocationStatsRequest 
    {

        [SDKProperty("action", IsQuery = true)]
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        [SDKProperty("interval", IsQuery = true)]
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public long? Interval { get; set; }

        [SDKProperty("domain_name", IsQuery = true)]
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        [SDKProperty("stat_type", IsQuery = true)]
        [JsonProperty("stat_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StatType { get; set; }

        [SDKProperty("group_by", IsQuery = true)]
        [JsonProperty("group_by", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupBy { get; set; }

        [SDKProperty("country", IsQuery = true)]
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [SDKProperty("province", IsQuery = true)]
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        [SDKProperty("isp", IsQuery = true)]
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public string Isp { get; set; }

        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainLocationStatsRequest {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  statType: ").Append(StatType).Append("\n");
            sb.Append("  groupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  province: ").Append(Province).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainLocationStatsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainLocationStatsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.StatType == input.StatType ||
                    (this.StatType != null &&
                    this.StatType.Equals(input.StatType))
                ) && 
                (
                    this.GroupBy == input.GroupBy ||
                    (this.GroupBy != null &&
                    this.GroupBy.Equals(input.GroupBy))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.Isp == input.Isp ||
                    (this.Isp != null &&
                    this.Isp.Equals(input.Isp))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.StatType != null)
                    hashCode = hashCode * 59 + this.StatType.GetHashCode();
                if (this.GroupBy != null)
                    hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.Isp != null)
                    hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
