using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Vpc 
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        [JsonProperty("extend_cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExtendCidrs { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("cloud_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<CloudResource> CloudResources { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vpc {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  extendCidrs: ").Append(ExtendCidrs).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  cloudResources: ").Append(CloudResources).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Vpc);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Vpc input)
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
                    this.Cidr == input.Cidr ||
                    (this.Cidr != null &&
                    this.Cidr.Equals(input.Cidr))
                ) && 
                (
                    this.ExtendCidrs == input.ExtendCidrs ||
                    this.ExtendCidrs != null &&
                    input.ExtendCidrs != null &&
                    this.ExtendCidrs.SequenceEqual(input.ExtendCidrs)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                    this.CloudResources == input.CloudResources ||
                    this.CloudResources != null &&
                    input.CloudResources != null &&
                    this.CloudResources.SequenceEqual(input.CloudResources)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.ExtendCidrs != null)
                    hashCode = hashCode * 59 + this.ExtendCidrs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CloudResources != null)
                    hashCode = hashCode * 59 + this.CloudResources.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
