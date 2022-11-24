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
    public class ClusterExtendParam 
    {

        [JsonProperty("clusterAZ", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterAZ { get; set; }

        [JsonProperty("dssMasterVolumes", NullValueHandling = NullValueHandling.Ignore)]
        public string DssMasterVolumes { get; set; }

        [JsonProperty("enterpriseProjectId", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("kubeProxyMode", NullValueHandling = NullValueHandling.Ignore)]
        public string KubeProxyMode { get; set; }

        [JsonProperty("clusterExternalIP", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterExternalIP { get; set; }

        [JsonProperty("alpha.cce/fixPoolMask", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCceFixPoolMask { get; set; }

        [JsonProperty("decMasterFlavor", NullValueHandling = NullValueHandling.Ignore)]
        public string DecMasterFlavor { get; set; }

        [JsonProperty("dockerUmaskMode", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerUmaskMode { get; set; }

        [JsonProperty("kubernetes.io/cpuManagerPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesIoCpuManagerPolicy { get; set; }

        [JsonProperty("orderID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }

        [JsonProperty("periodType", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        [JsonProperty("periodNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        [JsonProperty("isAutoRenew", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoRenew { get; set; }

        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }

        [JsonProperty("upgradefrom", NullValueHandling = NullValueHandling.Ignore)]
        public string Upgradefrom { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterExtendParam {\n");
            sb.Append("  clusterAZ: ").Append(ClusterAZ).Append("\n");
            sb.Append("  dssMasterVolumes: ").Append(DssMasterVolumes).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  kubeProxyMode: ").Append(KubeProxyMode).Append("\n");
            sb.Append("  clusterExternalIP: ").Append(ClusterExternalIP).Append("\n");
            sb.Append("  alphaCceFixPoolMask: ").Append(AlphaCceFixPoolMask).Append("\n");
            sb.Append("  decMasterFlavor: ").Append(DecMasterFlavor).Append("\n");
            sb.Append("  dockerUmaskMode: ").Append(DockerUmaskMode).Append("\n");
            sb.Append("  kubernetesIoCpuManagerPolicy: ").Append(KubernetesIoCpuManagerPolicy).Append("\n");
            sb.Append("  orderID: ").Append(OrderID).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  upgradefrom: ").Append(Upgradefrom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterAZ == input.ClusterAZ ||
                    (this.ClusterAZ != null &&
                    this.ClusterAZ.Equals(input.ClusterAZ))
                ) && 
                (
                    this.DssMasterVolumes == input.DssMasterVolumes ||
                    (this.DssMasterVolumes != null &&
                    this.DssMasterVolumes.Equals(input.DssMasterVolumes))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.KubeProxyMode == input.KubeProxyMode ||
                    (this.KubeProxyMode != null &&
                    this.KubeProxyMode.Equals(input.KubeProxyMode))
                ) && 
                (
                    this.ClusterExternalIP == input.ClusterExternalIP ||
                    (this.ClusterExternalIP != null &&
                    this.ClusterExternalIP.Equals(input.ClusterExternalIP))
                ) && 
                (
                    this.AlphaCceFixPoolMask == input.AlphaCceFixPoolMask ||
                    (this.AlphaCceFixPoolMask != null &&
                    this.AlphaCceFixPoolMask.Equals(input.AlphaCceFixPoolMask))
                ) && 
                (
                    this.DecMasterFlavor == input.DecMasterFlavor ||
                    (this.DecMasterFlavor != null &&
                    this.DecMasterFlavor.Equals(input.DecMasterFlavor))
                ) && 
                (
                    this.DockerUmaskMode == input.DockerUmaskMode ||
                    (this.DockerUmaskMode != null &&
                    this.DockerUmaskMode.Equals(input.DockerUmaskMode))
                ) && 
                (
                    this.KubernetesIoCpuManagerPolicy == input.KubernetesIoCpuManagerPolicy ||
                    (this.KubernetesIoCpuManagerPolicy != null &&
                    this.KubernetesIoCpuManagerPolicy.Equals(input.KubernetesIoCpuManagerPolicy))
                ) && 
                (
                    this.OrderID == input.OrderID ||
                    (this.OrderID != null &&
                    this.OrderID.Equals(input.OrderID))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.IsAutoRenew == input.IsAutoRenew ||
                    (this.IsAutoRenew != null &&
                    this.IsAutoRenew.Equals(input.IsAutoRenew))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
                ) && 
                (
                    this.Upgradefrom == input.Upgradefrom ||
                    (this.Upgradefrom != null &&
                    this.Upgradefrom.Equals(input.Upgradefrom))
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
                if (this.ClusterAZ != null)
                    hashCode = hashCode * 59 + this.ClusterAZ.GetHashCode();
                if (this.DssMasterVolumes != null)
                    hashCode = hashCode * 59 + this.DssMasterVolumes.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.KubeProxyMode != null)
                    hashCode = hashCode * 59 + this.KubeProxyMode.GetHashCode();
                if (this.ClusterExternalIP != null)
                    hashCode = hashCode * 59 + this.ClusterExternalIP.GetHashCode();
                if (this.AlphaCceFixPoolMask != null)
                    hashCode = hashCode * 59 + this.AlphaCceFixPoolMask.GetHashCode();
                if (this.DecMasterFlavor != null)
                    hashCode = hashCode * 59 + this.DecMasterFlavor.GetHashCode();
                if (this.DockerUmaskMode != null)
                    hashCode = hashCode * 59 + this.DockerUmaskMode.GetHashCode();
                if (this.KubernetesIoCpuManagerPolicy != null)
                    hashCode = hashCode * 59 + this.KubernetesIoCpuManagerPolicy.GetHashCode();
                if (this.OrderID != null)
                    hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null)
                    hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.Upgradefrom != null)
                    hashCode = hashCode * 59 + this.Upgradefrom.GetHashCode();
                return hashCode;
            }
        }
    }
}
