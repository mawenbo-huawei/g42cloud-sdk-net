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
    /// Response Object
    /// </summary>
    public class GlanceCreateImageMetadataResponse : SdkResponse
    {
        [JsonConverter(typeof(EnumClassConverter<DiskFormatEnum>))]
        public class DiskFormatEnum
        {
            /// <summary>
            /// Enum VHD for value: vhd
            /// </summary>
            public static readonly DiskFormatEnum VHD = new DiskFormatEnum("vhd");

            /// <summary>
            /// Enum ZVHD for value: zvhd
            /// </summary>
            public static readonly DiskFormatEnum ZVHD = new DiskFormatEnum("zvhd");

            /// <summary>
            /// Enum RAW for value: raw
            /// </summary>
            public static readonly DiskFormatEnum RAW = new DiskFormatEnum("raw");

            /// <summary>
            /// Enum QCOW2 for value: qcow2
            /// </summary>
            public static readonly DiskFormatEnum QCOW2 = new DiskFormatEnum("qcow2");

            private static readonly Dictionary<string, DiskFormatEnum> StaticFields =
            new Dictionary<string, DiskFormatEnum>()
            {
                { "vhd", VHD },
                { "zvhd", ZVHD },
                { "raw", RAW },
                { "qcow2", QCOW2 },
            };

            private string _value;

            public DiskFormatEnum()
            {

            }

            public DiskFormatEnum(string value)
            {
                _value = value;
            }

            public static DiskFormatEnum FromValue(string value)
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

                if (this.Equals(obj as DiskFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DiskFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DiskFormatEnum a, DiskFormatEnum b)
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

            public static bool operator !=(DiskFormatEnum a, DiskFormatEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum QUEUED for value: queued
            /// </summary>
            public static readonly StatusEnum QUEUED = new StatusEnum("queued");

            /// <summary>
            /// Enum SAVING for value: saving
            /// </summary>
            public static readonly StatusEnum SAVING = new StatusEnum("saving");

            /// <summary>
            /// Enum DELETED for value: deleted
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("deleted");

            /// <summary>
            /// Enum KILLED for value: killed
            /// </summary>
            public static readonly StatusEnum KILLED = new StatusEnum("killed");

            /// <summary>
            /// Enum ACTIVE for value: active
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("active");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "queued", QUEUED },
                { "saving", SAVING },
                { "deleted", DELETED },
                { "killed", KILLED },
                { "active", ACTIVE },
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

        [JsonConverter(typeof(EnumClassConverter<OsTypeEnum>))]
        public class OsTypeEnum
        {
            /// <summary>
            /// Enum WINDOWS for value: Windows
            /// </summary>
            public static readonly OsTypeEnum WINDOWS = new OsTypeEnum("Windows");

            /// <summary>
            /// Enum LINUX for value: Linux
            /// </summary>
            public static readonly OsTypeEnum LINUX = new OsTypeEnum("Linux");

            /// <summary>
            /// Enum OTHER for value: other
            /// </summary>
            public static readonly OsTypeEnum OTHER = new OsTypeEnum("other");

            private static readonly Dictionary<string, OsTypeEnum> StaticFields =
            new Dictionary<string, OsTypeEnum>()
            {
                { "Windows", WINDOWS },
                { "Linux", LINUX },
                { "other", OTHER },
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

        [JsonConverter(typeof(EnumClassConverter<OsBitEnum>))]
        public class OsBitEnum
        {
            /// <summary>
            /// Enum _32 for value: 32
            /// </summary>
            public static readonly OsBitEnum _32 = new OsBitEnum("32");

            /// <summary>
            /// Enum _64 for value: 64
            /// </summary>
            public static readonly OsBitEnum _64 = new OsBitEnum("64");

            private static readonly Dictionary<string, OsBitEnum> StaticFields =
            new Dictionary<string, OsBitEnum>()
            {
                { "32", _32 },
                { "64", _64 },
            };

            private string _value;

            public OsBitEnum()
            {

            }

            public OsBitEnum(string value)
            {
                _value = value;
            }

            public static OsBitEnum FromValue(string value)
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

                if (this.Equals(obj as OsBitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsBitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OsBitEnum a, OsBitEnum b)
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

            public static bool operator !=(OsBitEnum a, OsBitEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<VirtualEnvTypeEnum>))]
        public class VirtualEnvTypeEnum
        {
            /// <summary>
            /// Enum FUSIONCOMPUTE for value: FusionCompute
            /// </summary>
            public static readonly VirtualEnvTypeEnum FUSIONCOMPUTE = new VirtualEnvTypeEnum("FusionCompute");

            /// <summary>
            /// Enum IRONIC for value: Ironic
            /// </summary>
            public static readonly VirtualEnvTypeEnum IRONIC = new VirtualEnvTypeEnum("Ironic");

            /// <summary>
            /// Enum DATAIMAGE for value: DataImage
            /// </summary>
            public static readonly VirtualEnvTypeEnum DATAIMAGE = new VirtualEnvTypeEnum("DataImage");

            private static readonly Dictionary<string, VirtualEnvTypeEnum> StaticFields =
            new Dictionary<string, VirtualEnvTypeEnum>()
            {
                { "FusionCompute", FUSIONCOMPUTE },
                { "Ironic", IRONIC },
                { "DataImage", DATAIMAGE },
            };

            private string _value;

            public VirtualEnvTypeEnum()
            {

            }

            public VirtualEnvTypeEnum(string value)
            {
                _value = value;
            }

            public static VirtualEnvTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VirtualEnvTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VirtualEnvTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VirtualEnvTypeEnum a, VirtualEnvTypeEnum b)
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

            public static bool operator !=(VirtualEnvTypeEnum a, VirtualEnvTypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        [JsonProperty("container_format", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerFormat { get; set; }

        [JsonProperty("disk_format", NullValueHandling = NullValueHandling.Ignore)]
        public DiskFormatEnum DiskFormat { get; set; }
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRam { get; set; }

        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public string Self { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }

        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        [JsonProperty("__image_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageSourceType { get; set; }

        [JsonProperty("__image_size", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageSize { get; set; }

        [JsonProperty("__isregistered", NullValueHandling = NullValueHandling.Ignore)]
        public string Isregistered { get; set; }

        [JsonProperty("__os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        [JsonProperty("__os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        [JsonProperty("__platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        [JsonProperty("__os_bit", NullValueHandling = NullValueHandling.Ignore)]
        public OsBitEnum OsBit { get; set; }
        [JsonProperty("__imagetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Imagetype { get; set; }

        [JsonProperty("virtual_env_type", NullValueHandling = NullValueHandling.Ignore)]
        public VirtualEnvTypeEnum VirtualEnvType { get; set; }
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        [JsonProperty("virtual_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirtualSize { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Object Properties { get; set; }

        [JsonProperty("__root_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string RootOrigin { get; set; }

        [JsonProperty("checksum", NullValueHandling = NullValueHandling.Ignore)]
        public string Checksum { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlanceCreateImageMetadataResponse {\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  containerFormat: ").Append(ContainerFormat).Append("\n");
            sb.Append("  diskFormat: ").Append(DiskFormat).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  self: ").Append(Self).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  file: ").Append(File).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  imageSourceType: ").Append(ImageSourceType).Append("\n");
            sb.Append("  imageSize: ").Append(ImageSize).Append("\n");
            sb.Append("  isregistered: ").Append(Isregistered).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  osBit: ").Append(OsBit).Append("\n");
            sb.Append("  imagetype: ").Append(Imagetype).Append("\n");
            sb.Append("  virtualEnvType: ").Append(VirtualEnvType).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  virtualSize: ").Append(VirtualSize).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  rootOrigin: ").Append(RootOrigin).Append("\n");
            sb.Append("  checksum: ").Append(Checksum).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlanceCreateImageMetadataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlanceCreateImageMetadataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Protected == input.Protected ||
                    (this.Protected != null &&
                    this.Protected.Equals(input.Protected))
                ) && 
                (
                    this.ContainerFormat == input.ContainerFormat ||
                    (this.ContainerFormat != null &&
                    this.ContainerFormat.Equals(input.ContainerFormat))
                ) && 
                (
                    this.DiskFormat == input.DiskFormat ||
                    (this.DiskFormat != null &&
                    this.DiskFormat.Equals(input.DiskFormat))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.MinRam == input.MinRam ||
                    (this.MinRam != null &&
                    this.MinRam.Equals(input.MinRam))
                ) && 
                (
                    this.MinDisk == input.MinDisk ||
                    (this.MinDisk != null &&
                    this.MinDisk.Equals(input.MinDisk))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.ImageSourceType == input.ImageSourceType ||
                    (this.ImageSourceType != null &&
                    this.ImageSourceType.Equals(input.ImageSourceType))
                ) && 
                (
                    this.ImageSize == input.ImageSize ||
                    (this.ImageSize != null &&
                    this.ImageSize.Equals(input.ImageSize))
                ) && 
                (
                    this.Isregistered == input.Isregistered ||
                    (this.Isregistered != null &&
                    this.Isregistered.Equals(input.Isregistered))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.OsBit == input.OsBit ||
                    (this.OsBit != null &&
                    this.OsBit.Equals(input.OsBit))
                ) && 
                (
                    this.Imagetype == input.Imagetype ||
                    (this.Imagetype != null &&
                    this.Imagetype.Equals(input.Imagetype))
                ) && 
                (
                    this.VirtualEnvType == input.VirtualEnvType ||
                    (this.VirtualEnvType != null &&
                    this.VirtualEnvType.Equals(input.VirtualEnvType))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.VirtualSize == input.VirtualSize ||
                    (this.VirtualSize != null &&
                    this.VirtualSize.Equals(input.VirtualSize))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.RootOrigin == input.RootOrigin ||
                    (this.RootOrigin != null &&
                    this.RootOrigin.Equals(input.RootOrigin))
                ) && 
                (
                    this.Checksum == input.Checksum ||
                    (this.Checksum != null &&
                    this.Checksum.Equals(input.Checksum))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Protected != null)
                    hashCode = hashCode * 59 + this.Protected.GetHashCode();
                if (this.ContainerFormat != null)
                    hashCode = hashCode * 59 + this.ContainerFormat.GetHashCode();
                if (this.DiskFormat != null)
                    hashCode = hashCode * 59 + this.DiskFormat.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.MinRam != null)
                    hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                if (this.MinDisk != null)
                    hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.ImageSourceType != null)
                    hashCode = hashCode * 59 + this.ImageSourceType.GetHashCode();
                if (this.ImageSize != null)
                    hashCode = hashCode * 59 + this.ImageSize.GetHashCode();
                if (this.Isregistered != null)
                    hashCode = hashCode * 59 + this.Isregistered.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.OsBit != null)
                    hashCode = hashCode * 59 + this.OsBit.GetHashCode();
                if (this.Imagetype != null)
                    hashCode = hashCode * 59 + this.Imagetype.GetHashCode();
                if (this.VirtualEnvType != null)
                    hashCode = hashCode * 59 + this.VirtualEnvType.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.VirtualSize != null)
                    hashCode = hashCode * 59 + this.VirtualSize.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.RootOrigin != null)
                    hashCode = hashCode * 59 + this.RootOrigin.GetHashCode();
                if (this.Checksum != null)
                    hashCode = hashCode * 59 + this.Checksum.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
