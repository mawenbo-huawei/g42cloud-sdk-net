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
    /// 更新七层转发策略的请求参数。
    /// </summary>
    public class UpdateL7PolicyOption 
    {

        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("redirect_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectListenerId { get; set; }

        [JsonProperty("redirect_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectPoolId { get; set; }

        [JsonProperty("redirect_url_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateRedirectUrlConfig RedirectUrlConfig { get; set; }

        [JsonProperty("fixed_response_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateFixtedResponseConfig FixedResponseConfig { get; set; }

        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateRuleOption> Rules { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        [JsonProperty("redirect_pools_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateRedirectPoolsConfig> RedirectPoolsConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateL7PolicyOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  redirectListenerId: ").Append(RedirectListenerId).Append("\n");
            sb.Append("  redirectPoolId: ").Append(RedirectPoolId).Append("\n");
            sb.Append("  redirectUrlConfig: ").Append(RedirectUrlConfig).Append("\n");
            sb.Append("  fixedResponseConfig: ").Append(FixedResponseConfig).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  redirectPoolsConfig: ").Append(RedirectPoolsConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateL7PolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateL7PolicyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RedirectListenerId == input.RedirectListenerId ||
                    (this.RedirectListenerId != null &&
                    this.RedirectListenerId.Equals(input.RedirectListenerId))
                ) && 
                (
                    this.RedirectPoolId == input.RedirectPoolId ||
                    (this.RedirectPoolId != null &&
                    this.RedirectPoolId.Equals(input.RedirectPoolId))
                ) && 
                (
                    this.RedirectUrlConfig == input.RedirectUrlConfig ||
                    (this.RedirectUrlConfig != null &&
                    this.RedirectUrlConfig.Equals(input.RedirectUrlConfig))
                ) && 
                (
                    this.FixedResponseConfig == input.FixedResponseConfig ||
                    (this.FixedResponseConfig != null &&
                    this.FixedResponseConfig.Equals(input.FixedResponseConfig))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.RedirectPoolsConfig == input.RedirectPoolsConfig ||
                    this.RedirectPoolsConfig != null &&
                    input.RedirectPoolsConfig != null &&
                    this.RedirectPoolsConfig.SequenceEqual(input.RedirectPoolsConfig)
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RedirectListenerId != null)
                    hashCode = hashCode * 59 + this.RedirectListenerId.GetHashCode();
                if (this.RedirectPoolId != null)
                    hashCode = hashCode * 59 + this.RedirectPoolId.GetHashCode();
                if (this.RedirectUrlConfig != null)
                    hashCode = hashCode * 59 + this.RedirectUrlConfig.GetHashCode();
                if (this.FixedResponseConfig != null)
                    hashCode = hashCode * 59 + this.FixedResponseConfig.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RedirectPoolsConfig != null)
                    hashCode = hashCode * 59 + this.RedirectPoolsConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
