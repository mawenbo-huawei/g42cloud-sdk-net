using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 云硬盘详情。
    /// </summary>
    public class VolumeDetailForTag 
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attachment> Attachments { get; set; }

        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        [JsonProperty("os-vol-host-attr:host", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolHostAttrhost { get; set; }

        [JsonProperty("source_volid", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceVolid { get; set; }

        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        [JsonProperty("os-vol-tenant-attr:tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolTenantAttrtenantId { get; set; }

        [JsonProperty("volume_image_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> VolumeImageMetadata { get; set; }

        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        [JsonProperty("consistencygroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsistencygroupId { get; set; }

        [JsonProperty("bootable", NullValueHandling = NullValueHandling.Ignore)]
        public string Bootable { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeMetadata Metadata { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        [JsonProperty("encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Encrypted { get; set; }

        [JsonProperty("replication_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationStatus { get; set; }

        [JsonProperty("os-volume-replication:extended_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolumeReplicationextendedStatus { get; set; }

        [JsonProperty("os-vol-mig-status-attr:migstat", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolMigStatusAttrmigstat { get; set; }

        [JsonProperty("os-vol-mig-status-attr:name_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolMigStatusAttrnameId { get; set; }

        [JsonProperty("shareable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shareable { get; set; }

        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        [JsonProperty("multiattach", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multiattach { get; set; }

        [JsonProperty("dedicated_storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageId { get; set; }

        [JsonProperty("dedicated_storage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageName { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        [JsonProperty("wwn", NullValueHandling = NullValueHandling.Ignore)]
        public string Wwn { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeDetailForTag {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  attachments: ").Append(Attachments).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  osVolHostAttrhost: ").Append(OsVolHostAttrhost).Append("\n");
            sb.Append("  sourceVolid: ").Append(SourceVolid).Append("\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  osVolTenantAttrtenantId: ").Append(OsVolTenantAttrtenantId).Append("\n");
            sb.Append("  volumeImageMetadata: ").Append(VolumeImageMetadata).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  consistencygroupId: ").Append(ConsistencygroupId).Append("\n");
            sb.Append("  bootable: ").Append(Bootable).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  replicationStatus: ").Append(ReplicationStatus).Append("\n");
            sb.Append("  osVolumeReplicationextendedStatus: ").Append(OsVolumeReplicationextendedStatus).Append("\n");
            sb.Append("  osVolMigStatusAttrmigstat: ").Append(OsVolMigStatusAttrmigstat).Append("\n");
            sb.Append("  osVolMigStatusAttrnameId: ").Append(OsVolMigStatusAttrnameId).Append("\n");
            sb.Append("  shareable: ").Append(Shareable).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  multiattach: ").Append(Multiattach).Append("\n");
            sb.Append("  dedicatedStorageId: ").Append(DedicatedStorageId).Append("\n");
            sb.Append("  dedicatedStorageName: ").Append(DedicatedStorageName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  wwn: ").Append(Wwn).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeDetailForTag);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeDetailForTag input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.OsVolHostAttrhost == input.OsVolHostAttrhost ||
                    (this.OsVolHostAttrhost != null &&
                    this.OsVolHostAttrhost.Equals(input.OsVolHostAttrhost))
                ) && 
                (
                    this.SourceVolid == input.SourceVolid ||
                    (this.SourceVolid != null &&
                    this.SourceVolid.Equals(input.SourceVolid))
                ) && 
                (
                    this.SnapshotId == input.SnapshotId ||
                    (this.SnapshotId != null &&
                    this.SnapshotId.Equals(input.SnapshotId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.OsVolTenantAttrtenantId == input.OsVolTenantAttrtenantId ||
                    (this.OsVolTenantAttrtenantId != null &&
                    this.OsVolTenantAttrtenantId.Equals(input.OsVolTenantAttrtenantId))
                ) && 
                (
                    this.VolumeImageMetadata == input.VolumeImageMetadata ||
                    this.VolumeImageMetadata != null &&
                    input.VolumeImageMetadata != null &&
                    this.VolumeImageMetadata.SequenceEqual(input.VolumeImageMetadata)
                ) && 
                (
                    this.VolumeType == input.VolumeType ||
                    (this.VolumeType != null &&
                    this.VolumeType.Equals(input.VolumeType))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ConsistencygroupId == input.ConsistencygroupId ||
                    (this.ConsistencygroupId != null &&
                    this.ConsistencygroupId.Equals(input.ConsistencygroupId))
                ) && 
                (
                    this.Bootable == input.Bootable ||
                    (this.Bootable != null &&
                    this.Bootable.Equals(input.Bootable))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Encrypted == input.Encrypted ||
                    (this.Encrypted != null &&
                    this.Encrypted.Equals(input.Encrypted))
                ) && 
                (
                    this.ReplicationStatus == input.ReplicationStatus ||
                    (this.ReplicationStatus != null &&
                    this.ReplicationStatus.Equals(input.ReplicationStatus))
                ) && 
                (
                    this.OsVolumeReplicationextendedStatus == input.OsVolumeReplicationextendedStatus ||
                    (this.OsVolumeReplicationextendedStatus != null &&
                    this.OsVolumeReplicationextendedStatus.Equals(input.OsVolumeReplicationextendedStatus))
                ) && 
                (
                    this.OsVolMigStatusAttrmigstat == input.OsVolMigStatusAttrmigstat ||
                    (this.OsVolMigStatusAttrmigstat != null &&
                    this.OsVolMigStatusAttrmigstat.Equals(input.OsVolMigStatusAttrmigstat))
                ) && 
                (
                    this.OsVolMigStatusAttrnameId == input.OsVolMigStatusAttrnameId ||
                    (this.OsVolMigStatusAttrnameId != null &&
                    this.OsVolMigStatusAttrnameId.Equals(input.OsVolMigStatusAttrnameId))
                ) && 
                (
                    this.Shareable == input.Shareable ||
                    (this.Shareable != null &&
                    this.Shareable.Equals(input.Shareable))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.Multiattach == input.Multiattach ||
                    (this.Multiattach != null &&
                    this.Multiattach.Equals(input.Multiattach))
                ) && 
                (
                    this.DedicatedStorageId == input.DedicatedStorageId ||
                    (this.DedicatedStorageId != null &&
                    this.DedicatedStorageId.Equals(input.DedicatedStorageId))
                ) && 
                (
                    this.DedicatedStorageName == input.DedicatedStorageName ||
                    (this.DedicatedStorageName != null &&
                    this.DedicatedStorageName.Equals(input.DedicatedStorageName))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Wwn == input.Wwn ||
                    (this.Wwn != null &&
                    this.Wwn.Equals(input.Wwn))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.OsVolHostAttrhost != null)
                    hashCode = hashCode * 59 + this.OsVolHostAttrhost.GetHashCode();
                if (this.SourceVolid != null)
                    hashCode = hashCode * 59 + this.SourceVolid.GetHashCode();
                if (this.SnapshotId != null)
                    hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.OsVolTenantAttrtenantId != null)
                    hashCode = hashCode * 59 + this.OsVolTenantAttrtenantId.GetHashCode();
                if (this.VolumeImageMetadata != null)
                    hashCode = hashCode * 59 + this.VolumeImageMetadata.GetHashCode();
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ConsistencygroupId != null)
                    hashCode = hashCode * 59 + this.ConsistencygroupId.GetHashCode();
                if (this.Bootable != null)
                    hashCode = hashCode * 59 + this.Bootable.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Encrypted != null)
                    hashCode = hashCode * 59 + this.Encrypted.GetHashCode();
                if (this.ReplicationStatus != null)
                    hashCode = hashCode * 59 + this.ReplicationStatus.GetHashCode();
                if (this.OsVolumeReplicationextendedStatus != null)
                    hashCode = hashCode * 59 + this.OsVolumeReplicationextendedStatus.GetHashCode();
                if (this.OsVolMigStatusAttrmigstat != null)
                    hashCode = hashCode * 59 + this.OsVolMigStatusAttrmigstat.GetHashCode();
                if (this.OsVolMigStatusAttrnameId != null)
                    hashCode = hashCode * 59 + this.OsVolMigStatusAttrnameId.GetHashCode();
                if (this.Shareable != null)
                    hashCode = hashCode * 59 + this.Shareable.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.Multiattach != null)
                    hashCode = hashCode * 59 + this.Multiattach.GetHashCode();
                if (this.DedicatedStorageId != null)
                    hashCode = hashCode * 59 + this.DedicatedStorageId.GetHashCode();
                if (this.DedicatedStorageName != null)
                    hashCode = hashCode * 59 + this.DedicatedStorageName.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Wwn != null)
                    hashCode = hashCode * 59 + this.Wwn.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
