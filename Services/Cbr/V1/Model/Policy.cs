using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Policy 
    {
        [JsonConverter(typeof(EnumClassConverter<OperationTypeEnum>))]
        public class OperationTypeEnum
        {
            /// <summary>
            /// Enum BACKUP for value: backup
            /// </summary>
            public static readonly OperationTypeEnum BACKUP = new OperationTypeEnum("backup");

            /// <summary>
            /// Enum REPLICATION for value: replication
            /// </summary>
            public static readonly OperationTypeEnum REPLICATION = new OperationTypeEnum("replication");

            private static readonly Dictionary<string, OperationTypeEnum> StaticFields =
            new Dictionary<string, OperationTypeEnum>()
            {
                { "backup", BACKUP },
                { "replication", REPLICATION },
            };

            private string _value;

            public OperationTypeEnum()
            {

            }

            public OperationTypeEnum(string value)
            {
                _value = value;
            }

            public static OperationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationTypeEnum a, OperationTypeEnum b)
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

            public static bool operator !=(OperationTypeEnum a, OperationTypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("operation_definition", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyoODCreate OperationDefinition { get; set; }

        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperationTypeEnum OperationType { get; set; }
        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyTriggerResp Trigger { get; set; }

        [JsonProperty("associated_vaults", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyAssociateVault> AssociatedVaults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Policy {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  operationDefinition: ").Append(OperationDefinition).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  trigger: ").Append(Trigger).Append("\n");
            sb.Append("  associatedVaults: ").Append(AssociatedVaults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Policy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Policy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OperationDefinition == input.OperationDefinition ||
                    (this.OperationDefinition != null &&
                    this.OperationDefinition.Equals(input.OperationDefinition))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
                ) && 
                (
                    this.AssociatedVaults == input.AssociatedVaults ||
                    this.AssociatedVaults != null &&
                    input.AssociatedVaults != null &&
                    this.AssociatedVaults.SequenceEqual(input.AssociatedVaults)
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OperationDefinition != null)
                    hashCode = hashCode * 59 + this.OperationDefinition.GetHashCode();
                if (this.OperationType != null)
                    hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.AssociatedVaults != null)
                    hashCode = hashCode * 59 + this.AssociatedVaults.GetHashCode();
                return hashCode;
            }
        }
    }
}
