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
    /// 创建节点时的扩展参数。
    /// </summary>
    public class NodeExtendParam 
    {

        [JsonProperty("ecs:performancetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Ecsperformancetype { get; set; }

        [JsonProperty("orderID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }

        [JsonProperty("productID", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductID { get; set; }

        [JsonProperty("maxPods", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPods { get; set; }

        [JsonProperty("periodType", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        [JsonProperty("periodNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        [JsonProperty("isAutoRenew", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoRenew { get; set; }

        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }

        [JsonProperty("DockerLVMConfigOverride", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerLVMConfigOverride { get; set; }

        [JsonProperty("dockerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? DockerBaseSize { get; set; }

        [JsonProperty("publicKey", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        [JsonProperty("alpha.cce/preInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePreInstall { get; set; }

        [JsonProperty("alpha.cce/postInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePostInstall { get; set; }

        [JsonProperty("alpha.cce/NodeImageID", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCceNodeImageID { get; set; }

        [JsonProperty("nicMultiqueue", NullValueHandling = NullValueHandling.Ignore)]
        public string NicMultiqueue { get; set; }

        [JsonProperty("nicThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public string NicThreshold { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("chargingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeExtendParam {\n");
            sb.Append("  ecsperformancetype: ").Append(Ecsperformancetype).Append("\n");
            sb.Append("  orderID: ").Append(OrderID).Append("\n");
            sb.Append("  productID: ").Append(ProductID).Append("\n");
            sb.Append("  maxPods: ").Append(MaxPods).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  dockerLVMConfigOverride: ").Append(DockerLVMConfigOverride).Append("\n");
            sb.Append("  dockerBaseSize: ").Append(DockerBaseSize).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  alphaCcePreInstall: ").Append(AlphaCcePreInstall).Append("\n");
            sb.Append("  alphaCcePostInstall: ").Append(AlphaCcePostInstall).Append("\n");
            sb.Append("  alphaCceNodeImageID: ").Append(AlphaCceNodeImageID).Append("\n");
            sb.Append("  nicMultiqueue: ").Append(NicMultiqueue).Append("\n");
            sb.Append("  nicThreshold: ").Append(NicThreshold).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ecsperformancetype == input.Ecsperformancetype ||
                    (this.Ecsperformancetype != null &&
                    this.Ecsperformancetype.Equals(input.Ecsperformancetype))
                ) && 
                (
                    this.OrderID == input.OrderID ||
                    (this.OrderID != null &&
                    this.OrderID.Equals(input.OrderID))
                ) && 
                (
                    this.ProductID == input.ProductID ||
                    (this.ProductID != null &&
                    this.ProductID.Equals(input.ProductID))
                ) && 
                (
                    this.MaxPods == input.MaxPods ||
                    (this.MaxPods != null &&
                    this.MaxPods.Equals(input.MaxPods))
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
                    this.DockerLVMConfigOverride == input.DockerLVMConfigOverride ||
                    (this.DockerLVMConfigOverride != null &&
                    this.DockerLVMConfigOverride.Equals(input.DockerLVMConfigOverride))
                ) && 
                (
                    this.DockerBaseSize == input.DockerBaseSize ||
                    (this.DockerBaseSize != null &&
                    this.DockerBaseSize.Equals(input.DockerBaseSize))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
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
                ) && 
                (
                    this.NicMultiqueue == input.NicMultiqueue ||
                    (this.NicMultiqueue != null &&
                    this.NicMultiqueue.Equals(input.NicMultiqueue))
                ) && 
                (
                    this.NicThreshold == input.NicThreshold ||
                    (this.NicThreshold != null &&
                    this.NicThreshold.Equals(input.NicThreshold))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
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
                if (this.Ecsperformancetype != null)
                    hashCode = hashCode * 59 + this.Ecsperformancetype.GetHashCode();
                if (this.OrderID != null)
                    hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                if (this.ProductID != null)
                    hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.MaxPods != null)
                    hashCode = hashCode * 59 + this.MaxPods.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null)
                    hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.DockerLVMConfigOverride != null)
                    hashCode = hashCode * 59 + this.DockerLVMConfigOverride.GetHashCode();
                if (this.DockerBaseSize != null)
                    hashCode = hashCode * 59 + this.DockerBaseSize.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.AlphaCcePreInstall != null)
                    hashCode = hashCode * 59 + this.AlphaCcePreInstall.GetHashCode();
                if (this.AlphaCcePostInstall != null)
                    hashCode = hashCode * 59 + this.AlphaCcePostInstall.GetHashCode();
                if (this.AlphaCceNodeImageID != null)
                    hashCode = hashCode * 59 + this.AlphaCceNodeImageID.GetHashCode();
                if (this.NicMultiqueue != null)
                    hashCode = hashCode * 59 + this.NicMultiqueue.GetHashCode();
                if (this.NicThreshold != null)
                    hashCode = hashCode * 59 + this.NicThreshold.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
