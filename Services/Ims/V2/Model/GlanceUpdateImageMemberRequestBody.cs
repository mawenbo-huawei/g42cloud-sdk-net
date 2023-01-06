using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 镜像成员的状态。
    /// </summary>
    public class GlanceUpdateImageMemberRequestBody 
    {
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACCEPTED for value: accepted
            /// </summary>
            public static readonly StatusEnum ACCEPTED = new StatusEnum("accepted");

            /// <summary>
            /// Enum REJECTED for value: rejected
            /// </summary>
            public static readonly StatusEnum REJECTED = new StatusEnum("rejected");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "accepted", ACCEPTED },
                { "rejected", REJECTED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlanceUpdateImageMemberRequestBody {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlanceUpdateImageMemberRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlanceUpdateImageMemberRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }
    }
}
