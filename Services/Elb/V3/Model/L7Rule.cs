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
    /// L7转发规则
    /// </summary>
    public class L7Rule 
    {
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum HOST_NAME for value: HOST_NAME
            /// </summary>
            public static readonly TypeEnum HOST_NAME = new TypeEnum("HOST_NAME");

            /// <summary>
            /// Enum PATH for value: PATH
            /// </summary>
            public static readonly TypeEnum PATH = new TypeEnum("PATH");

            /// <summary>
            /// Enum METHOD for value: METHOD
            /// </summary>
            public static readonly TypeEnum METHOD = new TypeEnum("METHOD");

            /// <summary>
            /// Enum HEADER for value: HEADER
            /// </summary>
            public static readonly TypeEnum HEADER = new TypeEnum("HEADER");

            /// <summary>
            /// Enum QUERY_STRING for value: QUERY_STRING
            /// </summary>
            public static readonly TypeEnum QUERY_STRING = new TypeEnum("QUERY_STRING");

            /// <summary>
            /// Enum SOURCE_IP for value: SOURCE_IP
            /// </summary>
            public static readonly TypeEnum SOURCE_IP = new TypeEnum("SOURCE_IP");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "HOST_NAME", HOST_NAME },
                { "PATH", PATH },
                { "METHOD", METHOD },
                { "HEADER", HEADER },
                { "QUERY_STRING", QUERY_STRING },
                { "SOURCE_IP", SOURCE_IP },
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


        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareType { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        [JsonProperty("invert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invert { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleCondition> Conditions { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class L7Rule {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  invert: ").Append(Invert).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as L7Rule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(L7Rule input)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
                ) && 
                (
                    this.Invert == input.Invert ||
                    (this.Invert != null &&
                    this.Invert.Equals(input.Invert))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.Invert != null)
                    hashCode = hashCode * 59 + this.Invert.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
