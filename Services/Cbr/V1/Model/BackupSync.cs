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
    public class BackupSync 
    {

        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        [JsonProperty("backup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupName { get; set; }

        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        [JsonProperty("image_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ImagePath { get; set; }

        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupSync {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  backupName: ").Append(BackupName).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  imagePath: ").Append(ImagePath).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupSync);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupSync input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.BackupName == input.BackupName ||
                    (this.BackupName != null &&
                    this.BackupName.Equals(input.BackupName))
                ) && 
                (
                    this.BucketName == input.BucketName ||
                    (this.BucketName != null &&
                    this.BucketName.Equals(input.BucketName))
                ) && 
                (
                    this.ImagePath == input.ImagePath ||
                    (this.ImagePath != null &&
                    this.ImagePath.Equals(input.ImagePath))
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
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.BackupName != null)
                    hashCode = hashCode * 59 + this.BackupName.GetHashCode();
                if (this.BucketName != null)
                    hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.ImagePath != null)
                    hashCode = hashCode * 59 + this.ImagePath.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
