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
    /// 
    /// </summary>
    public class JobProgressEntities 
    {

        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        [JsonProperty("current_task", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentTask { get; set; }

        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        [JsonProperty("process_percent", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProcessPercent { get; set; }

        [JsonProperty("subJobId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubJobId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobProgressEntities {\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  currentTask: ").Append(CurrentTask).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  processPercent: ").Append(ProcessPercent).Append("\n");
            sb.Append("  subJobId: ").Append(SubJobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobProgressEntities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobProgressEntities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.CurrentTask == input.CurrentTask ||
                    (this.CurrentTask != null &&
                    this.CurrentTask.Equals(input.CurrentTask))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.ProcessPercent == input.ProcessPercent ||
                    (this.ProcessPercent != null &&
                    this.ProcessPercent.Equals(input.ProcessPercent))
                ) && 
                (
                    this.SubJobId == input.SubJobId ||
                    (this.SubJobId != null &&
                    this.SubJobId.Equals(input.SubJobId))
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
                if (this.ImageId != null)
                    hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.CurrentTask != null)
                    hashCode = hashCode * 59 + this.CurrentTask.GetHashCode();
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ProcessPercent != null)
                    hashCode = hashCode * 59 + this.ProcessPercent.GetHashCode();
                if (this.SubJobId != null)
                    hashCode = hashCode * 59 + this.SubJobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
