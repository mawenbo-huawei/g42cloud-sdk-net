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
    /// 负载均衡相关各类资源的配额信息。仅返回资源的总配额，不包括剩余可用配额。
    /// </summary>
    public class Quota 
    {

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [JsonProperty("loadbalancer", NullValueHandling = NullValueHandling.Ignore)]
        public int? Loadbalancer { get; set; }

        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Certificate { get; set; }

        [JsonProperty("listener", NullValueHandling = NullValueHandling.Ignore)]
        public int? Listener { get; set; }

        [JsonProperty("l7policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? L7policy { get; set; }

        [JsonProperty("pool", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pool { get; set; }

        [JsonProperty("healthmonitor", NullValueHandling = NullValueHandling.Ignore)]
        public int? Healthmonitor { get; set; }

        [JsonProperty("member", NullValueHandling = NullValueHandling.Ignore)]
        public int? Member { get; set; }

        [JsonProperty("members_per_pool", NullValueHandling = NullValueHandling.Ignore)]
        public int? MembersPerPool { get; set; }

        [JsonProperty("ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ipgroup { get; set; }

        [JsonProperty("security_policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quota {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  loadbalancer: ").Append(Loadbalancer).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  listener: ").Append(Listener).Append("\n");
            sb.Append("  l7policy: ").Append(L7policy).Append("\n");
            sb.Append("  pool: ").Append(Pool).Append("\n");
            sb.Append("  healthmonitor: ").Append(Healthmonitor).Append("\n");
            sb.Append("  member: ").Append(Member).Append("\n");
            sb.Append("  membersPerPool: ").Append(MembersPerPool).Append("\n");
            sb.Append("  ipgroup: ").Append(Ipgroup).Append("\n");
            sb.Append("  securityPolicy: ").Append(SecurityPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Quota);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Quota input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Loadbalancer == input.Loadbalancer ||
                    (this.Loadbalancer != null &&
                    this.Loadbalancer.Equals(input.Loadbalancer))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Listener == input.Listener ||
                    (this.Listener != null &&
                    this.Listener.Equals(input.Listener))
                ) && 
                (
                    this.L7policy == input.L7policy ||
                    (this.L7policy != null &&
                    this.L7policy.Equals(input.L7policy))
                ) && 
                (
                    this.Pool == input.Pool ||
                    (this.Pool != null &&
                    this.Pool.Equals(input.Pool))
                ) && 
                (
                    this.Healthmonitor == input.Healthmonitor ||
                    (this.Healthmonitor != null &&
                    this.Healthmonitor.Equals(input.Healthmonitor))
                ) && 
                (
                    this.Member == input.Member ||
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
                ) && 
                (
                    this.MembersPerPool == input.MembersPerPool ||
                    (this.MembersPerPool != null &&
                    this.MembersPerPool.Equals(input.MembersPerPool))
                ) && 
                (
                    this.Ipgroup == input.Ipgroup ||
                    (this.Ipgroup != null &&
                    this.Ipgroup.Equals(input.Ipgroup))
                ) && 
                (
                    this.SecurityPolicy == input.SecurityPolicy ||
                    (this.SecurityPolicy != null &&
                    this.SecurityPolicy.Equals(input.SecurityPolicy))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Loadbalancer != null)
                    hashCode = hashCode * 59 + this.Loadbalancer.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Listener != null)
                    hashCode = hashCode * 59 + this.Listener.GetHashCode();
                if (this.L7policy != null)
                    hashCode = hashCode * 59 + this.L7policy.GetHashCode();
                if (this.Pool != null)
                    hashCode = hashCode * 59 + this.Pool.GetHashCode();
                if (this.Healthmonitor != null)
                    hashCode = hashCode * 59 + this.Healthmonitor.GetHashCode();
                if (this.Member != null)
                    hashCode = hashCode * 59 + this.Member.GetHashCode();
                if (this.MembersPerPool != null)
                    hashCode = hashCode * 59 + this.MembersPerPool.GetHashCode();
                if (this.Ipgroup != null)
                    hashCode = hashCode * 59 + this.Ipgroup.GetHashCode();
                if (this.SecurityPolicy != null)
                    hashCode = hashCode * 59 + this.SecurityPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
