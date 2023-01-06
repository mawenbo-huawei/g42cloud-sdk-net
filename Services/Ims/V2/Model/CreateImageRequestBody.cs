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
    /// 创建镜像请求参数体
    /// </summary>
    public class CreateImageRequestBody 
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
            /// Enum FUSIONCOMPUTE for value: FusionCompute
            /// </summary>
            public static readonly TypeEnum FUSIONCOMPUTE = new TypeEnum("FusionCompute");

            /// <summary>
            /// Enum IRONIC for value: Ironic
            /// </summary>
            public static readonly TypeEnum IRONIC = new TypeEnum("Ironic");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "ECS", ECS },
                { "BMS", BMS },
                { "FusionCompute", FUSIONCOMPUTE },
                { "Ironic", IRONIC },
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


        [JsonProperty("data_images", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateDataImage> DataImages { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("image_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagKeyValue> ImageTags { get; set; }

        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("max_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRam { get; set; }

        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRam { get; set; }

        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        [JsonProperty("is_config", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsConfig { get; set; }

        [JsonProperty("cmk_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkId { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        [JsonProperty("is_quick_import", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQuickImport { get; set; }

        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public ArchitectureEnum Architecture { get; set; }
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateImageRequestBody {\n");
            sb.Append("  dataImages: ").Append(DataImages).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  imageTags: ").Append(ImageTags).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  maxRam: ").Append(MaxRam).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  isConfig: ").Append(IsConfig).Append("\n");
            sb.Append("  cmkId: ").Append(CmkId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  isQuickImport: ").Append(IsQuickImport).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateImageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateImageRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataImages == input.DataImages ||
                    this.DataImages != null &&
                    input.DataImages != null &&
                    this.DataImages.SequenceEqual(input.DataImages)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.ImageTags == input.ImageTags ||
                    this.ImageTags != null &&
                    input.ImageTags != null &&
                    this.ImageTags.SequenceEqual(input.ImageTags)
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.MaxRam == input.MaxRam ||
                    (this.MaxRam != null &&
                    this.MaxRam.Equals(input.MaxRam))
                ) && 
                (
                    this.MinRam == input.MinRam ||
                    (this.MinRam != null &&
                    this.MinRam.Equals(input.MinRam))
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
                    this.IsConfig == input.IsConfig ||
                    (this.IsConfig != null &&
                    this.IsConfig.Equals(input.IsConfig))
                ) && 
                (
                    this.CmkId == input.CmkId ||
                    (this.CmkId != null &&
                    this.CmkId.Equals(input.CmkId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsQuickImport == input.IsQuickImport ||
                    (this.IsQuickImport != null &&
                    this.IsQuickImport.Equals(input.IsQuickImport))
                ) && 
                (
                    this.Architecture == input.Architecture ||
                    (this.Architecture != null &&
                    this.Architecture.Equals(input.Architecture))
                ) && 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
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
                if (this.DataImages != null)
                    hashCode = hashCode * 59 + this.DataImages.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ImageTags != null)
                    hashCode = hashCode * 59 + this.ImageTags.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.MaxRam != null)
                    hashCode = hashCode * 59 + this.MaxRam.GetHashCode();
                if (this.MinRam != null)
                    hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.MinDisk != null)
                    hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.IsConfig != null)
                    hashCode = hashCode * 59 + this.IsConfig.GetHashCode();
                if (this.CmkId != null)
                    hashCode = hashCode * 59 + this.CmkId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsQuickImport != null)
                    hashCode = hashCode * 59 + this.IsQuickImport.GetHashCode();
                if (this.Architecture != null)
                    hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
