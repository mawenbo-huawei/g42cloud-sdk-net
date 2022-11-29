using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 创建L7转发规则器请求
    /// </summary>
    public class CreateRuleOption 
    {

        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareType { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("invert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invert { get; set; }

        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateRuleCondition> Conditions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRuleOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  invert: ").Append(Invert).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRuleOption input)
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
                    this.CompareType == input.CompareType ||
                    (this.CompareType != null &&
                    this.CompareType.Equals(input.CompareType))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Invert == input.Invert ||
                    (this.Invert != null &&
                    this.Invert.Equals(input.Invert))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
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
                if (this.CompareType != null)
                    hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Invert != null)
                    hashCode = hashCode * 59 + this.Invert.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
