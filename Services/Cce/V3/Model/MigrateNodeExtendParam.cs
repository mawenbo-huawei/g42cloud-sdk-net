using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MigrateNodeExtendParam 
    {

        [JsonProperty("maxPods", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPods { get; set; }

        [JsonProperty("DockerLVMConfigOverride", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerLVMConfigOverride { get; set; }

        [JsonProperty("alpha.cce/preInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePreInstall { get; set; }

        [JsonProperty("alpha.cce/postInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePostInstall { get; set; }

        [JsonProperty("alpha.cce/NodeImageID", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCceNodeImageID { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateNodeExtendParam {\n");
            sb.Append("  maxPods: ").Append(MaxPods).Append("\n");
            sb.Append("  dockerLVMConfigOverride: ").Append(DockerLVMConfigOverride).Append("\n");
            sb.Append("  alphaCcePreInstall: ").Append(AlphaCcePreInstall).Append("\n");
            sb.Append("  alphaCcePostInstall: ").Append(AlphaCcePostInstall).Append("\n");
            sb.Append("  alphaCceNodeImageID: ").Append(AlphaCceNodeImageID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateNodeExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateNodeExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxPods == input.MaxPods ||
                    (this.MaxPods != null &&
                    this.MaxPods.Equals(input.MaxPods))
                ) && 
                (
                    this.DockerLVMConfigOverride == input.DockerLVMConfigOverride ||
                    (this.DockerLVMConfigOverride != null &&
                    this.DockerLVMConfigOverride.Equals(input.DockerLVMConfigOverride))
                ) && 
                (
                    this.AlphaCcePreInstall == input.AlphaCcePreInstall ||
                    (this.AlphaCcePreInstall != null &&
                    this.AlphaCcePreInstall.Equals(input.AlphaCcePreInstall))
                ) && 
                (
                    this.AlphaCcePostInstall == input.AlphaCcePostInstall ||
                    (this.AlphaCcePostInstall != null &&
                    this.AlphaCcePostInstall.Equals(input.AlphaCcePostInstall))
                ) && 
                (
                    this.AlphaCceNodeImageID == input.AlphaCceNodeImageID ||
                    (this.AlphaCceNodeImageID != null &&
                    this.AlphaCceNodeImageID.Equals(input.AlphaCceNodeImageID))
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
                if (this.MaxPods != null)
                    hashCode = hashCode * 59 + this.MaxPods.GetHashCode();
                if (this.DockerLVMConfigOverride != null)
                    hashCode = hashCode * 59 + this.DockerLVMConfigOverride.GetHashCode();
                if (this.AlphaCcePreInstall != null)
                    hashCode = hashCode * 59 + this.AlphaCcePreInstall.GetHashCode();
                if (this.AlphaCcePostInstall != null)
                    hashCode = hashCode * 59 + this.AlphaCcePostInstall.GetHashCode();
                if (this.AlphaCceNodeImageID != null)
                    hashCode = hashCode * 59 + this.AlphaCceNodeImageID.GetHashCode();
                return hashCode;
            }
        }
    }
}
