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
    /// 快速通道创建镜像的请求体
    /// </summary>
    public class QuickImportImageByFileRequestBody 
    {
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ECS for value: ECS
            /// </summary>
            public static readonly TypeEnum ECS = new TypeEnum("ECS");

            /// <summary>
            /// Enum BMS for value: BMS
            /// </summary>
            public static readonly TypeEnum BMS = new TypeEnum("BMS");

            /// <summary>
            /// Enum DATAIMAGE for value: DataImage
            /// </summary>
            public static readonly TypeEnum DATAIMAGE = new TypeEnum("DataImage");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "ECS", ECS },
                { "BMS", BMS },
                { "DataImage", DATAIMAGE },
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

        [JsonConverter(typeof(EnumClassConverter<ArchitectureEnum>))]
        public class ArchitectureEnum
        {
            /// <summary>
            /// Enum X86 for value: x86
            /// </summary>
            public static readonly ArchitectureEnum X86 = new ArchitectureEnum("x86");

            /// <summary>
            /// Enum ARM for value: arm
            /// </summary>
            public static readonly ArchitectureEnum ARM = new ArchitectureEnum("arm");

            private static readonly Dictionary<string, ArchitectureEnum> StaticFields =
            new Dictionary<string, ArchitectureEnum>()
            {
                { "x86", X86 },
                { "arm", ARM },
            };

            private string _value;

            public ArchitectureEnum()
            {

            }

            public ArchitectureEnum(string value)
            {
                _value = value;
            }

            public static ArchitectureEnum FromValue(string value)
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

                if (this.Equals(obj as ArchitectureEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ArchitectureEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ArchitectureEnum a, ArchitectureEnum b)
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

            public static bool operator !=(ArchitectureEnum a, ArchitectureEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<OsTypeEnum>))]
        public class OsTypeEnum
        {
            /// <summary>
            /// Enum LINUX for value: Linux
            /// </summary>
            public static readonly OsTypeEnum LINUX = new OsTypeEnum("Linux");

            /// <summary>
            /// Enum WINDOWS for value: Windows
            /// </summary>
            public static readonly OsTypeEnum WINDOWS = new OsTypeEnum("Windows");

            private static readonly Dictionary<string, OsTypeEnum> StaticFields =
            new Dictionary<string, OsTypeEnum>()
            {
                { "Linux", LINUX },
                { "Windows", WINDOWS },
            };

            private string _value;

            public OsTypeEnum()
            {

            }

            public OsTypeEnum(string value)
            {
                _value = value;
            }

            public static OsTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OsTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OsTypeEnum a, OsTypeEnum b)
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

            public static bool operator !=(OsTypeEnum a, OsTypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public ArchitectureEnum Architecture { get; set; }
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        [JsonProperty("image_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> ImageTags { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickImportImageByFileRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  imageTags: ").Append(ImageTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuickImportImageByFileRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuickImportImageByFileRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.MinDisk == input.MinDisk ||
                    (this.MinDisk != null &&
                    this.MinDisk.Equals(input.MinDisk))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Architecture == input.Architecture ||
                    (this.Architecture != null &&
                    this.Architecture.Equals(input.Architecture))
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
                ) && 
                (
                    this.ImageTags == input.ImageTags ||
                    this.ImageTags != null &&
                    input.ImageTags != null &&
                    this.ImageTags.SequenceEqual(input.ImageTags)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.MinDisk != null)
                    hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Architecture != null)
                    hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.ImageTags != null)
                    hashCode = hashCode * 59 + this.ImageTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
