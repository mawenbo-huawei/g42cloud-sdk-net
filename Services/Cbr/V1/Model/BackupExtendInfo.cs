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
    public class BackupExtendInfo 
    {
        [JsonConverter(typeof(EnumClassConverter<SupportedRestoreModeEnum>))]
        public class SupportedRestoreModeEnum
        {
            /// <summary>
            /// Enum NA for value: na
            /// </summary>
            public static readonly SupportedRestoreModeEnum NA = new SupportedRestoreModeEnum("na");

            /// <summary>
            /// Enum _BACKUP for value:  backup
            /// </summary>
            public static readonly SupportedRestoreModeEnum _BACKUP = new SupportedRestoreModeEnum(" backup");

            /// <summary>
            /// Enum _SNAPSHOT for value:  snapshot
            /// </summary>
            public static readonly SupportedRestoreModeEnum _SNAPSHOT = new SupportedRestoreModeEnum(" snapshot");

            private static readonly Dictionary<string, SupportedRestoreModeEnum> StaticFields =
            new Dictionary<string, SupportedRestoreModeEnum>()
            {
                { "na", NA },
                { " backup", _BACKUP },
                { " snapshot", _SNAPSHOT },
            };

            private string _value;

            public SupportedRestoreModeEnum()
            {

            }

            public SupportedRestoreModeEnum(string value)
            {
                _value = value;
            }

            public static SupportedRestoreModeEnum FromValue(string value)
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

                if (this.Equals(obj as SupportedRestoreModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SupportedRestoreModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SupportedRestoreModeEnum a, SupportedRestoreModeEnum b)
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

            public static bool operator !=(SupportedRestoreModeEnum a, SupportedRestoreModeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("auto_trigger", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoTrigger { get; set; }

        [JsonProperty("bootable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bootable { get; set; }

        [JsonProperty("incremental", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incremental { get; set; }

        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        [JsonProperty("support_lld", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportLld { get; set; }

        [JsonProperty("supported_restore_mode", NullValueHandling = NullValueHandling.Ignore)]
        public SupportedRestoreModeEnum SupportedRestoreMode { get; set; }
        [JsonProperty("os_images_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageData> OsImagesData { get; set; }

        [JsonProperty("contain_system_disk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainSystemDisk { get; set; }

        [JsonProperty("encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Encrypted { get; set; }

        [JsonProperty("system_disk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SystemDisk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupExtendInfo {\n");
            sb.Append("  autoTrigger: ").Append(AutoTrigger).Append("\n");
            sb.Append("  bootable: ").Append(Bootable).Append("\n");
            sb.Append("  incremental: ").Append(Incremental).Append("\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("  supportLld: ").Append(SupportLld).Append("\n");
            sb.Append("  supportedRestoreMode: ").Append(SupportedRestoreMode).Append("\n");
            sb.Append("  osImagesData: ").Append(OsImagesData).Append("\n");
            sb.Append("  containSystemDisk: ").Append(ContainSystemDisk).Append("\n");
            sb.Append("  encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  systemDisk: ").Append(SystemDisk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupExtendInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupExtendInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoTrigger == input.AutoTrigger ||
                    (this.AutoTrigger != null &&
                    this.AutoTrigger.Equals(input.AutoTrigger))
                ) && 
                (
                    this.Bootable == input.Bootable ||
                    (this.Bootable != null &&
                    this.Bootable.Equals(input.Bootable))
                ) && 
                (
                    this.Incremental == input.Incremental ||
                    (this.Incremental != null &&
                    this.Incremental.Equals(input.Incremental))
                ) && 
                (
                    this.SnapshotId == input.SnapshotId ||
                    (this.SnapshotId != null &&
                    this.SnapshotId.Equals(input.SnapshotId))
                ) && 
                (
                    this.SupportLld == input.SupportLld ||
                    (this.SupportLld != null &&
                    this.SupportLld.Equals(input.SupportLld))
                ) && 
                (
                    this.SupportedRestoreMode == input.SupportedRestoreMode ||
                    (this.SupportedRestoreMode != null &&
                    this.SupportedRestoreMode.Equals(input.SupportedRestoreMode))
                ) && 
                (
                    this.OsImagesData == input.OsImagesData ||
                    this.OsImagesData != null &&
                    input.OsImagesData != null &&
                    this.OsImagesData.SequenceEqual(input.OsImagesData)
                ) && 
                (
                    this.ContainSystemDisk == input.ContainSystemDisk ||
                    (this.ContainSystemDisk != null &&
                    this.ContainSystemDisk.Equals(input.ContainSystemDisk))
                ) && 
                (
                    this.Encrypted == input.Encrypted ||
                    (this.Encrypted != null &&
                    this.Encrypted.Equals(input.Encrypted))
                ) && 
                (
                    this.SystemDisk == input.SystemDisk ||
                    (this.SystemDisk != null &&
                    this.SystemDisk.Equals(input.SystemDisk))
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
                if (this.AutoTrigger != null)
                    hashCode = hashCode * 59 + this.AutoTrigger.GetHashCode();
                if (this.Bootable != null)
                    hashCode = hashCode * 59 + this.Bootable.GetHashCode();
                if (this.Incremental != null)
                    hashCode = hashCode * 59 + this.Incremental.GetHashCode();
                if (this.SnapshotId != null)
                    hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                if (this.SupportLld != null)
                    hashCode = hashCode * 59 + this.SupportLld.GetHashCode();
                if (this.SupportedRestoreMode != null)
                    hashCode = hashCode * 59 + this.SupportedRestoreMode.GetHashCode();
                if (this.OsImagesData != null)
                    hashCode = hashCode * 59 + this.OsImagesData.GetHashCode();
                if (this.ContainSystemDisk != null)
                    hashCode = hashCode * 59 + this.ContainSystemDisk.GetHashCode();
                if (this.Encrypted != null)
                    hashCode = hashCode * 59 + this.Encrypted.GetHashCode();
                if (this.SystemDisk != null)
                    hashCode = hashCode * 59 + this.SystemDisk.GetHashCode();
                return hashCode;
            }
        }
    }
}
