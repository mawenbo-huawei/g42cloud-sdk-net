using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateVolumeTransferDetail 
    {

        [JsonProperty("auth_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthKey { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVolumeTransferDetail {\n");
            sb.Append("  authKey: ").Append(AuthKey).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVolumeTransferDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVolumeTransferDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthKey == input.AuthKey ||
                    (this.AuthKey != null &&
                    this.AuthKey.Equals(input.AuthKey))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
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
                if (this.AuthKey != null)
                    hashCode = hashCode * 59 + this.AuthKey.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
