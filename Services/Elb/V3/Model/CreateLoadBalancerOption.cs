using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 创建负载均衡器参数。
    /// </summary>
    public class CreateLoadBalancerOption 
    {
        [JsonConverter(typeof(EnumClassConverter<WafFailureActionEnum>))]
        public class WafFailureActionEnum
        {
            /// <summary>
            /// Enum DISCARD for value: discard
            /// </summary>
            public static readonly WafFailureActionEnum DISCARD = new WafFailureActionEnum("discard");

            /// <summary>
            /// Enum FORWARD for value: forward
            /// </summary>
            public static readonly WafFailureActionEnum FORWARD = new WafFailureActionEnum("forward");

            private static readonly Dictionary<string, WafFailureActionEnum> StaticFields =
            new Dictionary<string, WafFailureActionEnum>()
            {
                { "discard", DISCARD },
                { "forward", FORWARD },
            };

            private string _value;

            public WafFailureActionEnum()
            {

            }

            public WafFailureActionEnum(string value)
            {
                _value = value;
            }

            public static WafFailureActionEnum FromValue(string value)
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

                if (this.Equals(obj as WafFailureActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WafFailureActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WafFailureActionEnum a, WafFailureActionEnum b)
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

            public static bool operator !=(WafFailureActionEnum a, WafFailureActionEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        [JsonProperty("vip_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipSubnetCidrId { get; set; }

        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipVirsubnetId { get; set; }

        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4FlavorId { get; set; }

        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        [JsonProperty("guaranteed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Guaranteed { get; set; }

        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        [JsonProperty("ipv6_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthRef Ipv6Bandwidth { get; set; }

        [JsonProperty("publicip_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicipIds { get; set; }

        [JsonProperty("publicip", NullValueHandling = NullValueHandling.Ignore)]
        public CreateLoadBalancerPublicIpOption Publicip { get; set; }

        [JsonProperty("elb_virsubnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElbVirsubnetIds { get; set; }

        [JsonProperty("ip_target_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpTargetEnable { get; set; }

        [JsonProperty("deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletionProtectionEnable { get; set; }

        [JsonProperty("prepaid_options", NullValueHandling = NullValueHandling.Ignore)]
        public PrepaidCreateOption PrepaidOptions { get; set; }

        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public CreateLoadbalancerAutoscalingOption Autoscaling { get; set; }

        [JsonProperty("waf_failure_action", NullValueHandling = NullValueHandling.Ignore)]
        public WafFailureActionEnum WafFailureAction { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoadBalancerOption {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  vipSubnetCidrId: ").Append(VipSubnetCidrId).Append("\n");
            sb.Append("  ipv6VipVirsubnetId: ").Append(Ipv6VipVirsubnetId).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  l4FlavorId: ").Append(L4FlavorId).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  guaranteed: ").Append(Guaranteed).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  availabilityZoneList: ").Append(AvailabilityZoneList).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  ipv6Bandwidth: ").Append(Ipv6Bandwidth).Append("\n");
            sb.Append("  publicipIds: ").Append(PublicipIds).Append("\n");
            sb.Append("  publicip: ").Append(Publicip).Append("\n");
            sb.Append("  elbVirsubnetIds: ").Append(ElbVirsubnetIds).Append("\n");
            sb.Append("  ipTargetEnable: ").Append(IpTargetEnable).Append("\n");
            sb.Append("  deletionProtectionEnable: ").Append(DeletionProtectionEnable).Append("\n");
            sb.Append("  prepaidOptions: ").Append(PrepaidOptions).Append("\n");
            sb.Append("  autoscaling: ").Append(Autoscaling).Append("\n");
            sb.Append("  wafFailureAction: ").Append(WafFailureAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoadBalancerOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoadBalancerOption input)
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
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                    this.VipAddress == input.VipAddress ||
                    (this.VipAddress != null &&
                    this.VipAddress.Equals(input.VipAddress))
                ) && 
                (
                    this.VipSubnetCidrId == input.VipSubnetCidrId ||
                    (this.VipSubnetCidrId != null &&
                    this.VipSubnetCidrId.Equals(input.VipSubnetCidrId))
                ) && 
                (
                    this.Ipv6VipVirsubnetId == input.Ipv6VipVirsubnetId ||
                    (this.Ipv6VipVirsubnetId != null &&
                    this.Ipv6VipVirsubnetId.Equals(input.Ipv6VipVirsubnetId))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.L4FlavorId == input.L4FlavorId ||
                    (this.L4FlavorId != null &&
                    this.L4FlavorId.Equals(input.L4FlavorId))
                ) && 
                (
                    this.L7FlavorId == input.L7FlavorId ||
                    (this.L7FlavorId != null &&
                    this.L7FlavorId.Equals(input.L7FlavorId))
                ) && 
                (
                    this.Guaranteed == input.Guaranteed ||
                    (this.Guaranteed != null &&
                    this.Guaranteed.Equals(input.Guaranteed))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.AvailabilityZoneList == input.AvailabilityZoneList ||
                    this.AvailabilityZoneList != null &&
                    input.AvailabilityZoneList != null &&
                    this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.BillingInfo == input.BillingInfo ||
                    (this.BillingInfo != null &&
                    this.BillingInfo.Equals(input.BillingInfo))
                ) && 
                (
                    this.Ipv6Bandwidth == input.Ipv6Bandwidth ||
                    (this.Ipv6Bandwidth != null &&
                    this.Ipv6Bandwidth.Equals(input.Ipv6Bandwidth))
                ) && 
                (
                    this.PublicipIds == input.PublicipIds ||
                    this.PublicipIds != null &&
                    input.PublicipIds != null &&
                    this.PublicipIds.SequenceEqual(input.PublicipIds)
                ) && 
                (
                    this.Publicip == input.Publicip ||
                    (this.Publicip != null &&
                    this.Publicip.Equals(input.Publicip))
                ) && 
                (
                    this.ElbVirsubnetIds == input.ElbVirsubnetIds ||
                    this.ElbVirsubnetIds != null &&
                    input.ElbVirsubnetIds != null &&
                    this.ElbVirsubnetIds.SequenceEqual(input.ElbVirsubnetIds)
                ) && 
                (
                    this.IpTargetEnable == input.IpTargetEnable ||
                    (this.IpTargetEnable != null &&
                    this.IpTargetEnable.Equals(input.IpTargetEnable))
                ) && 
                (
                    this.DeletionProtectionEnable == input.DeletionProtectionEnable ||
                    (this.DeletionProtectionEnable != null &&
                    this.DeletionProtectionEnable.Equals(input.DeletionProtectionEnable))
                ) && 
                (
                    this.PrepaidOptions == input.PrepaidOptions ||
                    (this.PrepaidOptions != null &&
                    this.PrepaidOptions.Equals(input.PrepaidOptions))
                ) && 
                (
                    this.Autoscaling == input.Autoscaling ||
                    (this.Autoscaling != null &&
                    this.Autoscaling.Equals(input.Autoscaling))
                ) && 
                (
                    this.WafFailureAction == input.WafFailureAction ||
                    (this.WafFailureAction != null &&
                    this.WafFailureAction.Equals(input.WafFailureAction))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VipAddress != null)
                    hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.VipSubnetCidrId != null)
                    hashCode = hashCode * 59 + this.VipSubnetCidrId.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null)
                    hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.L4FlavorId != null)
                    hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L7FlavorId != null)
                    hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.Guaranteed != null)
                    hashCode = hashCode * 59 + this.Guaranteed.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.AvailabilityZoneList != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.BillingInfo != null)
                    hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.Ipv6Bandwidth != null)
                    hashCode = hashCode * 59 + this.Ipv6Bandwidth.GetHashCode();
                if (this.PublicipIds != null)
                    hashCode = hashCode * 59 + this.PublicipIds.GetHashCode();
                if (this.Publicip != null)
                    hashCode = hashCode * 59 + this.Publicip.GetHashCode();
                if (this.ElbVirsubnetIds != null)
                    hashCode = hashCode * 59 + this.ElbVirsubnetIds.GetHashCode();
                if (this.IpTargetEnable != null)
                    hashCode = hashCode * 59 + this.IpTargetEnable.GetHashCode();
                if (this.DeletionProtectionEnable != null)
                    hashCode = hashCode * 59 + this.DeletionProtectionEnable.GetHashCode();
                if (this.PrepaidOptions != null)
                    hashCode = hashCode * 59 + this.PrepaidOptions.GetHashCode();
                if (this.Autoscaling != null)
                    hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                if (this.WafFailureAction != null)
                    hashCode = hashCode * 59 + this.WafFailureAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
