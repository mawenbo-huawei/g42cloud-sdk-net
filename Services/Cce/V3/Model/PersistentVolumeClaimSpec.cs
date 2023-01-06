using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PersistentVolumeClaimSpec 
    {
        [JsonConverter(typeof(EnumClassConverter<AccessModesEnum>))]
        public class AccessModesEnum
        {
            /// <summary>
            /// Enum READONLYMANY for value: ReadOnlyMany
            /// </summary>
            public static readonly AccessModesEnum READONLYMANY = new AccessModesEnum("ReadOnlyMany");

            /// <summary>
            /// Enum READWRITEMANY for value: ReadWriteMany
            /// </summary>
            public static readonly AccessModesEnum READWRITEMANY = new AccessModesEnum("ReadWriteMany");

            private static readonly Dictionary<string, AccessModesEnum> StaticFields =
            new Dictionary<string, AccessModesEnum>()
            {
                { "ReadOnlyMany", READONLYMANY },
                { "ReadWriteMany", READWRITEMANY },
            };

            private string _value;

            public AccessModesEnum()
            {

            }

            public AccessModesEnum(string value)
            {
                _value = value;
            }

            public static AccessModesEnum FromValue(string value)
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

                if (this.Equals(obj as AccessModesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccessModesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccessModesEnum a, AccessModesEnum b)
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

            public static bool operator !=(AccessModesEnum a, AccessModesEnum b)
            {
                return !(a == b);
            }
        }



        [JsonProperty("volumeID", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeID { get; set; }

        [JsonProperty("storageType", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        [JsonProperty("accessModes", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessModesEnum> AccessModes { get; set; }
        [JsonProperty("storageClassName", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageClassName { get; set; }

        [JsonProperty("volumeName", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeName { get; set; }

        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceRequirements Resources { get; set; }

        [JsonProperty("volumeMode", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersistentVolumeClaimSpec {\n");
            sb.Append("  volumeID: ").Append(VolumeID).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  accessModes: ").Append(AccessModes).Append("\n");
            sb.Append("  storageClassName: ").Append(StorageClassName).Append("\n");
            sb.Append("  volumeName: ").Append(VolumeName).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  volumeMode: ").Append(VolumeMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PersistentVolumeClaimSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PersistentVolumeClaimSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VolumeID == input.VolumeID ||
                    (this.VolumeID != null &&
                    this.VolumeID.Equals(input.VolumeID))
                ) && 
                (
                    this.StorageType == input.StorageType ||
                    (this.StorageType != null &&
                    this.StorageType.Equals(input.StorageType))
                ) && 
                (
                    this.AccessModes == input.AccessModes ||
                    this.AccessModes != null &&
                    input.AccessModes != null &&
                    this.AccessModes.SequenceEqual(input.AccessModes)
                ) && 
                (
                    this.StorageClassName == input.StorageClassName ||
                    (this.StorageClassName != null &&
                    this.StorageClassName.Equals(input.StorageClassName))
                ) && 
                (
                    this.VolumeName == input.VolumeName ||
                    (this.VolumeName != null &&
                    this.VolumeName.Equals(input.VolumeName))
                ) && 
                (
                    this.Resources == input.Resources ||
                    (this.Resources != null &&
                    this.Resources.Equals(input.Resources))
                ) && 
                (
                    this.VolumeMode == input.VolumeMode ||
                    (this.VolumeMode != null &&
                    this.VolumeMode.Equals(input.VolumeMode))
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
                if (this.VolumeID != null)
                    hashCode = hashCode * 59 + this.VolumeID.GetHashCode();
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.AccessModes != null)
                    hashCode = hashCode * 59 + this.AccessModes.GetHashCode();
                if (this.StorageClassName != null)
                    hashCode = hashCode * 59 + this.StorageClassName.GetHashCode();
                if (this.VolumeName != null)
                    hashCode = hashCode * 59 + this.VolumeName.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.VolumeMode != null)
                    hashCode = hashCode * 59 + this.VolumeMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
