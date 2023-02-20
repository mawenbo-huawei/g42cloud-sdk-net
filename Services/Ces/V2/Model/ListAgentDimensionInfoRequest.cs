using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAgentDimensionInfoRequest 
    {
        [JsonConverter(typeof(EnumClassConverter<DimNameEnum>))]
        public class DimNameEnum
        {
            /// <summary>
            /// Enum MOUNT_POINT for value: mount_point
            /// </summary>
            public static readonly DimNameEnum MOUNT_POINT = new DimNameEnum("mount_point");

            /// <summary>
            /// Enum DISK for value: disk
            /// </summary>
            public static readonly DimNameEnum DISK = new DimNameEnum("disk");

            /// <summary>
            /// Enum PROC for value: proc
            /// </summary>
            public static readonly DimNameEnum PROC = new DimNameEnum("proc");

            /// <summary>
            /// Enum GPU for value: gpu
            /// </summary>
            public static readonly DimNameEnum GPU = new DimNameEnum("gpu");

            /// <summary>
            /// Enum RAID for value: raid
            /// </summary>
            public static readonly DimNameEnum RAID = new DimNameEnum("raid");

            private static readonly Dictionary<string, DimNameEnum> StaticFields =
            new Dictionary<string, DimNameEnum>()
            {
                { "mount_point", MOUNT_POINT },
                { "disk", DISK },
                { "proc", PROC },
                { "gpu", GPU },
                { "raid", RAID },
            };

            private string _value;

            public DimNameEnum()
            {

            }

            public DimNameEnum(string value)
            {
                _value = value;
            }

            public static DimNameEnum FromValue(string value)
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

                if (this.Equals(obj as DimNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DimNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DimNameEnum a, DimNameEnum b)
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

            public static bool operator !=(DimNameEnum a, DimNameEnum b)
            {
                return !(a == b);
            }
        }


        [SDKProperty("Content-Type", IsHeader = true)]
        [JsonProperty("Content-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        [SDKProperty("dim_name", IsQuery = true)]
        [JsonProperty("dim_name", NullValueHandling = NullValueHandling.Ignore)]
        public DimNameEnum DimName { get; set; }
        [SDKProperty("dim_value", IsQuery = true)]
        [JsonProperty("dim_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DimValue { get; set; }

        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgentDimensionInfoRequest {\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  dimName: ").Append(DimName).Append("\n");
            sb.Append("  dimValue: ").Append(DimValue).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAgentDimensionInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgentDimensionInfoRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.DimName == input.DimName ||
                    (this.DimName != null &&
                    this.DimName.Equals(input.DimName))
                ) && 
                (
                    this.DimValue == input.DimValue ||
                    (this.DimValue != null &&
                    this.DimValue.Equals(input.DimValue))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.DimName != null)
                    hashCode = hashCode * 59 + this.DimName.GetHashCode();
                if (this.DimValue != null)
                    hashCode = hashCode * 59 + this.DimValue.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
