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
    public class BackupResp 
    {
        [JsonConverter(typeof(EnumClassConverter<ImageTypeEnum>))]
        public class ImageTypeEnum
        {
            /// <summary>
            /// Enum BACKUP for value: backup
            /// </summary>
            public static readonly ImageTypeEnum BACKUP = new ImageTypeEnum("backup");

            /// <summary>
            /// Enum REPLICATION for value: replication
            /// </summary>
            public static readonly ImageTypeEnum REPLICATION = new ImageTypeEnum("replication");

            private static readonly Dictionary<string, ImageTypeEnum> StaticFields =
            new Dictionary<string, ImageTypeEnum>()
            {
                { "backup", BACKUP },
                { "replication", REPLICATION },
            };

            private string _value;

            public ImageTypeEnum()
            {

            }

            public ImageTypeEnum(string value)
            {
                _value = value;
            }

            public static ImageTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ImageTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImageTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImageTypeEnum a, ImageTypeEnum b)
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

            public static bool operator !=(ImageTypeEnum a, ImageTypeEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum OS_NOVA_SERVER for value: OS::Nova::Server
            /// </summary>
            public static readonly ResourceTypeEnum OS_NOVA_SERVER = new ResourceTypeEnum("OS::Nova::Server");

            /// <summary>
            /// Enum OS_CINDER_VOLUME for value: OS::Cinder::Volume
            /// </summary>
            public static readonly ResourceTypeEnum OS_CINDER_VOLUME = new ResourceTypeEnum("OS::Cinder::Volume");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "OS::Nova::Server", OS_NOVA_SERVER },
                { "OS::Cinder::Volume", OS_CINDER_VOLUME },
            };

            private string _value;

            public ResourceTypeEnum()
            {

            }

            public ResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceTypeEnum a, ResourceTypeEnum b)
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: available
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("available");

            /// <summary>
            /// Enum PROTECTING for value: protecting
            /// </summary>
            public static readonly StatusEnum PROTECTING = new StatusEnum("protecting");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("deleting");

            /// <summary>
            /// Enum RESTORING for value: restoring
            /// </summary>
            public static readonly StatusEnum RESTORING = new StatusEnum("restoring");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("error");

            /// <summary>
            /// Enum WAITING_PROTECT for value: waiting_protect
            /// </summary>
            public static readonly StatusEnum WAITING_PROTECT = new StatusEnum("waiting_protect");

            /// <summary>
            /// Enum WAITING_DELETE for value: waiting_delete
            /// </summary>
            public static readonly StatusEnum WAITING_DELETE = new StatusEnum("waiting_delete");

            /// <summary>
            /// Enum WAITING_RESTORE for value: waiting_restore
            /// </summary>
            public static readonly StatusEnum WAITING_RESTORE = new StatusEnum("waiting_restore");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "available", AVAILABLE },
                { "protecting", PROTECTING },
                { "deleting", DELETING },
                { "restoring", RESTORING },
                { "error", ERROR },
                { "waiting_protect", WAITING_PROTECT },
                { "waiting_delete", WAITING_DELETE },
                { "waiting_restore", WAITING_RESTORE },
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


        [JsonProperty("checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointId { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("expired_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiredAt { get; set; }

        [JsonProperty("extend_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupExtendInfo ExtendInfo { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public ImageTypeEnum ImageType { get; set; }
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [JsonProperty("protected_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProtectedAt { get; set; }

        [JsonProperty("resource_az", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceAz { get; set; }

        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        [JsonProperty("resource_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSize { get; set; }

        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }

        [JsonProperty("replication_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplicationRecordGet> ReplicationRecords { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupResp> Children { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupResp {\n");
            sb.Append("  checkpointId: ").Append(CheckpointId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  expiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("  extendInfo: ").Append(ExtendInfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  protectedAt: ").Append(ProtectedAt).Append("\n");
            sb.Append("  resourceAz: ").Append(ResourceAz).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceSize: ").Append(ResourceSize).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("  replicationRecords: ").Append(ReplicationRecords).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckpointId == input.CheckpointId ||
                    (this.CheckpointId != null &&
                    this.CheckpointId.Equals(input.CheckpointId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExpiredAt == input.ExpiredAt ||
                    (this.ExpiredAt != null &&
                    this.ExpiredAt.Equals(input.ExpiredAt))
                ) && 
                (
                    this.ExtendInfo == input.ExtendInfo ||
                    (this.ExtendInfo != null &&
                    this.ExtendInfo.Equals(input.ExtendInfo))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImageType == input.ImageType ||
                    (this.ImageType != null &&
                    this.ImageType.Equals(input.ImageType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProtectedAt == input.ProtectedAt ||
                    (this.ProtectedAt != null &&
                    this.ProtectedAt.Equals(input.ProtectedAt))
                ) && 
                (
                    this.ResourceAz == input.ResourceAz ||
                    (this.ResourceAz != null &&
                    this.ResourceAz.Equals(input.ResourceAz))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.ResourceSize == input.ResourceSize ||
                    (this.ResourceSize != null &&
                    this.ResourceSize.Equals(input.ResourceSize))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.ReplicationRecords == input.ReplicationRecords ||
                    this.ReplicationRecords != null &&
                    input.ReplicationRecords != null &&
                    this.ReplicationRecords.SequenceEqual(input.ReplicationRecords)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
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
                if (this.CheckpointId != null)
                    hashCode = hashCode * 59 + this.CheckpointId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExpiredAt != null)
                    hashCode = hashCode * 59 + this.ExpiredAt.GetHashCode();
                if (this.ExtendInfo != null)
                    hashCode = hashCode * 59 + this.ExtendInfo.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageType != null)
                    hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProtectedAt != null)
                    hashCode = hashCode * 59 + this.ProtectedAt.GetHashCode();
                if (this.ResourceAz != null)
                    hashCode = hashCode * 59 + this.ResourceAz.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceSize != null)
                    hashCode = hashCode * 59 + this.ResourceSize.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.ReplicationRecords != null)
                    hashCode = hashCode * 59 + this.ReplicationRecords.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                return hashCode;
            }
        }
    }
}
