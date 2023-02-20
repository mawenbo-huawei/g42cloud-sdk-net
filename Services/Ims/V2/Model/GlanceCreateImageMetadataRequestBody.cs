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
    /// 创建镜像请求体
    /// </summary>
    public class GlanceCreateImageMetadataRequestBody 
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
            /// Enum ZVHD2 for value: zvhd2
            /// </summary>
            public static readonly DiskFormatEnum ZVHD2 = new DiskFormatEnum("zvhd2");

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
                { "zvhd2", ZVHD2 },
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


        [JsonProperty("__os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        [JsonProperty("container_format", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerFormat { get; set; }

        [JsonProperty("disk_format", NullValueHandling = NullValueHandling.Ignore)]
        public DiskFormatEnum DiskFormat { get; set; }
        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRam { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlanceCreateImageMetadataRequestBody {\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  containerFormat: ").Append(ContainerFormat).Append("\n");
            sb.Append("  diskFormat: ").Append(DiskFormat).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlanceCreateImageMetadataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlanceCreateImageMetadataRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
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
                    this.MinDisk == input.MinDisk ||
                    (this.MinDisk != null &&
                    this.MinDisk.Equals(input.MinDisk))
                ) && 
                (
                    this.MinRam == input.MinRam ||
                    (this.MinRam != null &&
                    this.MinRam.Equals(input.MinRam))
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
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
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
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.ContainerFormat != null)
                    hashCode = hashCode * 59 + this.ContainerFormat.GetHashCode();
                if (this.DiskFormat != null)
                    hashCode = hashCode * 59 + this.DiskFormat.GetHashCode();
                if (this.MinDisk != null)
                    hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.MinRam != null)
                    hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Protected != null)
                    hashCode = hashCode * 59 + this.Protected.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                return hashCode;
            }
        }
    }
}
