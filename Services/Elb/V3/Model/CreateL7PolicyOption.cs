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
    /// 创建转发策略请求参数。
    /// </summary>
    public class CreateL7PolicyOption 
    {

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [JsonProperty("redirect_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectListenerId { get; set; }

        [JsonProperty("redirect_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectPoolId { get; set; }

        [JsonProperty("redirect_pools_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateRedirectPoolsConfig> RedirectPoolsConfig { get; set; }

        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; set; }

        [JsonProperty("redirect_url_config", NullValueHandling = NullValueHandling.Ignore)]
        public CreateRedirectUrlConfig RedirectUrlConfig { get; set; }

        [JsonProperty("fixed_response_config", NullValueHandling = NullValueHandling.Ignore)]
        public CreateFixtedResponseConfig FixedResponseConfig { get; set; }

        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateL7PolicyRuleOption> Rules { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateL7PolicyOption {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  redirectListenerId: ").Append(RedirectListenerId).Append("\n");
            sb.Append("  redirectPoolId: ").Append(RedirectPoolId).Append("\n");
            sb.Append("  redirectPoolsConfig: ").Append(RedirectPoolsConfig).Append("\n");
            sb.Append("  redirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  redirectUrlConfig: ").Append(RedirectUrlConfig).Append("\n");
            sb.Append("  fixedResponseConfig: ").Append(FixedResponseConfig).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateL7PolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateL7PolicyOption input)
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
                    this.ListenerId == input.ListenerId ||
                    (this.ListenerId != null &&
                    this.ListenerId.Equals(input.ListenerId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                    this.RedirectPoolsConfig == input.RedirectPoolsConfig ||
                    this.RedirectPoolsConfig != null &&
                    input.RedirectPoolsConfig != null &&
                    this.RedirectPoolsConfig.SequenceEqual(input.RedirectPoolsConfig)
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ListenerId != null)
                    hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RedirectListenerId != null)
                    hashCode = hashCode * 59 + this.RedirectListenerId.GetHashCode();
                if (this.RedirectPoolId != null)
                    hashCode = hashCode * 59 + this.RedirectPoolId.GetHashCode();
                if (this.RedirectPoolsConfig != null)
                    hashCode = hashCode * 59 + this.RedirectPoolsConfig.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.RedirectUrlConfig != null)
                    hashCode = hashCode * 59 + this.RedirectUrlConfig.GetHashCode();
                if (this.FixedResponseConfig != null)
                    hashCode = hashCode * 59 + this.FixedResponseConfig.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }
    }
}
