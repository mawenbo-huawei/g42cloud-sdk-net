using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VaultResourceInstancesReq 
    {
        [JsonConverter(typeof(EnumClassConverter<CloudTypeEnum>))]
        public class CloudTypeEnum
        {
            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly CloudTypeEnum PUBLIC = new CloudTypeEnum("public");

            /// <summary>
            /// Enum _HYBRID for value:  hybrid
            /// </summary>
            public static readonly CloudTypeEnum _HYBRID = new CloudTypeEnum(" hybrid");

            private static readonly Dictionary<string, CloudTypeEnum> StaticFields =
            new Dictionary<string, CloudTypeEnum>()
            {
                { "public", PUBLIC },
                { " hybrid", _HYBRID },
            };

            private string Value;

            public CloudTypeEnum(string value)
            {
                Value = value;
            }

            public static CloudTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as CloudTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CloudTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(CloudTypeEnum a, CloudTypeEnum b)
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

            public static bool operator !=(CloudTypeEnum a, CloudTypeEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<ObjectTypeEnum>))]
        public class ObjectTypeEnum
        {
            /// <summary>
            /// Enum SERVER for value: server
            /// </summary>
            public static readonly ObjectTypeEnum SERVER = new ObjectTypeEnum("server");

            /// <summary>
            /// Enum DISK for value: disk
            /// </summary>
            public static readonly ObjectTypeEnum DISK = new ObjectTypeEnum("disk");

            private static readonly Dictionary<string, ObjectTypeEnum> StaticFields =
            new Dictionary<string, ObjectTypeEnum>()
            {
                { "server", SERVER },
                { "disk", DISK },
            };

            private string Value;

            public ObjectTypeEnum(string value)
            {
                Value = value;
            }

            public static ObjectTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ObjectTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ObjectTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ObjectTypeEnum a, ObjectTypeEnum b)
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

            public static bool operator !=(ObjectTypeEnum a, ObjectTypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("without_any_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithoutAnyTag { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsReq> Tags { get; set; }

        [JsonProperty("tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsReq> TagsAny { get; set; }

        [JsonProperty("not_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsReq> NotTags { get; set; }

        [JsonProperty("not_tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsReq> NotTagsAny { get; set; }

        [JsonProperty("sys_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<SysTags> SysTags { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<Match> Matches { get; set; }

        [JsonProperty("cloud_type", NullValueHandling = NullValueHandling.Ignore)]
        public CloudTypeEnum CloudType { get; set; }
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectTypeEnum ObjectType { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VaultResourceInstancesReq {\n");
            sb.Append("  withoutAnyTag: ").Append(WithoutAnyTag).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tagsAny: ").Append(TagsAny).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  notTagsAny: ").Append(NotTagsAny).Append("\n");
            sb.Append("  sysTags: ").Append(SysTags).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("  cloudType: ").Append(CloudType).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VaultResourceInstancesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VaultResourceInstancesReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WithoutAnyTag == input.WithoutAnyTag ||
                    (this.WithoutAnyTag != null &&
                    this.WithoutAnyTag.Equals(input.WithoutAnyTag))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TagsAny == input.TagsAny ||
                    this.TagsAny != null &&
                    input.TagsAny != null &&
                    this.TagsAny.SequenceEqual(input.TagsAny)
                ) && 
                (
                    this.NotTags == input.NotTags ||
                    this.NotTags != null &&
                    input.NotTags != null &&
                    this.NotTags.SequenceEqual(input.NotTags)
                ) && 
                (
                    this.NotTagsAny == input.NotTagsAny ||
                    this.NotTagsAny != null &&
                    input.NotTagsAny != null &&
                    this.NotTagsAny.SequenceEqual(input.NotTagsAny)
                ) && 
                (
                    this.SysTags == input.SysTags ||
                    this.SysTags != null &&
                    input.SysTags != null &&
                    this.SysTags.SequenceEqual(input.SysTags)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Matches == input.Matches ||
                    this.Matches != null &&
                    input.Matches != null &&
                    this.Matches.SequenceEqual(input.Matches)
                ) && 
                (
                    this.CloudType == input.CloudType ||
                    (this.CloudType != null &&
                    this.CloudType.Equals(input.CloudType))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
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
                if (this.WithoutAnyTag != null)
                    hashCode = hashCode * 59 + this.WithoutAnyTag.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TagsAny != null)
                    hashCode = hashCode * 59 + this.TagsAny.GetHashCode();
                if (this.NotTags != null)
                    hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.NotTagsAny != null)
                    hashCode = hashCode * 59 + this.NotTagsAny.GetHashCode();
                if (this.SysTags != null)
                    hashCode = hashCode * 59 + this.SysTags.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Matches != null)
                    hashCode = hashCode * 59 + this.Matches.GetHashCode();
                if (this.CloudType != null)
                    hashCode = hashCode * 59 + this.CloudType.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                return hashCode;
            }
        }
    }
}
