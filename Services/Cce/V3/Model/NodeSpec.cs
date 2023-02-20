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
    public class NodeSpec 
    {

        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }

        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public Login Login { get; set; }

        [JsonProperty("rootVolume", NullValueHandling = NullValueHandling.Ignore)]
        public Volume RootVolume { get; set; }

        [JsonProperty("dataVolumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Volume> DataVolumes { get; set; }

        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public Storage Storage { get; set; }

        [JsonProperty("publicIP", NullValueHandling = NullValueHandling.Ignore)]
        public NodePublicIP PublicIP { get; set; }

        [JsonProperty("nodeNicSpec", NullValueHandling = NullValueHandling.Ignore)]
        public NodeNicSpec NodeNicSpec { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("billingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingMode { get; set; }

        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taint> Taints { get; set; }

        [JsonProperty("k8sTags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> K8sTags { get; set; }

        [JsonProperty("ecsGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsGroupId { get; set; }

        [JsonProperty("dedicatedHostId", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }

        [JsonProperty("userTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTag> UserTags { get; set; }

        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public Runtime Runtime { get; set; }

        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public NodeExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSpec {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  login: ").Append(Login).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  storage: ").Append(Storage).Append("\n");
            sb.Append("  publicIP: ").Append(PublicIP).Append("\n");
            sb.Append("  nodeNicSpec: ").Append(NodeNicSpec).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  k8sTags: ").Append(K8sTags).Append("\n");
            sb.Append("  ecsGroupId: ").Append(EcsGroupId).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("  userTags: ").Append(UserTags).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Az == input.Az ||
                    (this.Az != null &&
                    this.Az.Equals(input.Az))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.RootVolume == input.RootVolume ||
                    (this.RootVolume != null &&
                    this.RootVolume.Equals(input.RootVolume))
                ) && 
                (
                    this.DataVolumes == input.DataVolumes ||
                    this.DataVolumes != null &&
                    input.DataVolumes != null &&
                    this.DataVolumes.SequenceEqual(input.DataVolumes)
                ) && 
                (
                    this.Storage == input.Storage ||
                    (this.Storage != null &&
                    this.Storage.Equals(input.Storage))
                ) && 
                (
                    this.PublicIP == input.PublicIP ||
                    (this.PublicIP != null &&
                    this.PublicIP.Equals(input.PublicIP))
                ) && 
                (
                    this.NodeNicSpec == input.NodeNicSpec ||
                    (this.NodeNicSpec != null &&
                    this.NodeNicSpec.Equals(input.NodeNicSpec))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.BillingMode == input.BillingMode ||
                    (this.BillingMode != null &&
                    this.BillingMode.Equals(input.BillingMode))
                ) && 
                (
                    this.Taints == input.Taints ||
                    this.Taints != null &&
                    input.Taints != null &&
                    this.Taints.SequenceEqual(input.Taints)
                ) && 
                (
                    this.K8sTags == input.K8sTags ||
                    this.K8sTags != null &&
                    input.K8sTags != null &&
                    this.K8sTags.SequenceEqual(input.K8sTags)
                ) && 
                (
                    this.EcsGroupId == input.EcsGroupId ||
                    (this.EcsGroupId != null &&
                    this.EcsGroupId.Equals(input.EcsGroupId))
                ) && 
                (
                    this.DedicatedHostId == input.DedicatedHostId ||
                    (this.DedicatedHostId != null &&
                    this.DedicatedHostId.Equals(input.DedicatedHostId))
                ) && 
                (
                    this.UserTags == input.UserTags ||
                    this.UserTags != null &&
                    input.UserTags != null &&
                    this.UserTags.SequenceEqual(input.UserTags)
                ) && 
                (
                    this.Runtime == input.Runtime ||
                    (this.Runtime != null &&
                    this.Runtime.Equals(input.Runtime))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    (this.ExtendParam != null &&
                    this.ExtendParam.Equals(input.ExtendParam))
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
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Az != null)
                    hashCode = hashCode * 59 + this.Az.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.RootVolume != null)
                    hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null)
                    hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.Storage != null)
                    hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.PublicIP != null)
                    hashCode = hashCode * 59 + this.PublicIP.GetHashCode();
                if (this.NodeNicSpec != null)
                    hashCode = hashCode * 59 + this.NodeNicSpec.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.BillingMode != null)
                    hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                if (this.Taints != null)
                    hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.K8sTags != null)
                    hashCode = hashCode * 59 + this.K8sTags.GetHashCode();
                if (this.EcsGroupId != null)
                    hashCode = hashCode * 59 + this.EcsGroupId.GetHashCode();
                if (this.DedicatedHostId != null)
                    hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                if (this.UserTags != null)
                    hashCode = hashCode * 59 + this.UserTags.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
