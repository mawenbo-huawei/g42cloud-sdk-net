using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Port 
    {
        [JsonConverter(typeof(EnumClassConverter<DeviceOwnerEnum>))]
        public class DeviceOwnerEnum
        {
            /// <summary>
            /// Enum NETWORK_DHCP for value: network:dhcp
            /// </summary>
            public static readonly DeviceOwnerEnum NETWORK_DHCP = new DeviceOwnerEnum("network:dhcp");

            /// <summary>
            /// Enum NEUTRON_VIP_PORT for value: neutron:VIP_PORT
            /// </summary>
            public static readonly DeviceOwnerEnum NEUTRON_VIP_PORT = new DeviceOwnerEnum("neutron:VIP_PORT");

            /// <summary>
            /// Enum NETWORK_ROUTER_INTERFACE_DISTRIBUTED for value: network:router_interface_distributed
            /// </summary>
            public static readonly DeviceOwnerEnum NETWORK_ROUTER_INTERFACE_DISTRIBUTED = new DeviceOwnerEnum("network:router_interface_distributed");

            /// <summary>
            /// Enum NETWORK_ROUTER_CENTRALIZED_SNAT for value: network:router_centralized_snat
            /// </summary>
            public static readonly DeviceOwnerEnum NETWORK_ROUTER_CENTRALIZED_SNAT = new DeviceOwnerEnum("network:router_centralized_snat");

            private static readonly Dictionary<string, DeviceOwnerEnum> StaticFields =
            new Dictionary<string, DeviceOwnerEnum>()
            {
                { "network:dhcp", NETWORK_DHCP },
                { "neutron:VIP_PORT", NEUTRON_VIP_PORT },
                { "network:router_interface_distributed", NETWORK_ROUTER_INTERFACE_DISTRIBUTED },
                { "network:router_centralized_snat", NETWORK_ROUTER_CENTRALIZED_SNAT },
            };

            private string Value;

            public DeviceOwnerEnum(string value)
            {
                Value = value;
            }

            public static DeviceOwnerEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as DeviceOwnerEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeviceOwnerEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeviceOwnerEnum a, DeviceOwnerEnum b)
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

            public static bool operator !=(DeviceOwnerEnum a, DeviceOwnerEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum BUILD for value: BUILD
            /// </summary>
            public static readonly StatusEnum BUILD = new StatusEnum("BUILD");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly StatusEnum DOWN = new StatusEnum("DOWN");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "BUILD", BUILD },
                { "DOWN", DOWN },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
            }

            public static StatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }

        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("mac_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddress { get; set; }

        [JsonProperty("fixed_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<FixedIp> FixedIps { get; set; }

        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceOwnerEnum DeviceOwner { get; set; }
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowedAddressPair> AllowedAddressPairs { get; set; }

        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraDhcpOpt> ExtraDhcpOpts { get; set; }

        [JsonProperty("binding:vnic_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BindingvnicType { get; set; }

        [JsonProperty("dns_assignment", NullValueHandling = NullValueHandling.Ignore)]
        public List<DnsAssignMent> DnsAssignment { get; set; }

        [JsonProperty("dns_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsName { get; set; }

        [JsonProperty("binding:vif_details", NullValueHandling = NullValueHandling.Ignore)]
        public BindingVifDetails BindingvifDetails { get; set; }

        [JsonProperty("binding:profile", NullValueHandling = NullValueHandling.Ignore)]
        public Object Bindingprofile { get; set; }

        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        [JsonProperty("port_security_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortSecurityEnabled { get; set; }

        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Port {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  macAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  fixedIps: ").Append(FixedIps).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("  bindingvnicType: ").Append(BindingvnicType).Append("\n");
            sb.Append("  dnsAssignment: ").Append(DnsAssignment).Append("\n");
            sb.Append("  dnsName: ").Append(DnsName).Append("\n");
            sb.Append("  bindingvifDetails: ").Append(BindingvifDetails).Append("\n");
            sb.Append("  bindingprofile: ").Append(Bindingprofile).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  portSecurityEnabled: ").Append(PortSecurityEnabled).Append("\n");
            sb.Append("  zoneId: ").Append(ZoneId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Port);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Port input)
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
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    (this.MacAddress != null &&
                    this.MacAddress.Equals(input.MacAddress))
                ) && 
                (
                    this.FixedIps == input.FixedIps ||
                    this.FixedIps != null &&
                    input.FixedIps != null &&
                    this.FixedIps.SequenceEqual(input.FixedIps)
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.DeviceOwner == input.DeviceOwner ||
                    (this.DeviceOwner != null &&
                    this.DeviceOwner.Equals(input.DeviceOwner))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.AllowedAddressPairs == input.AllowedAddressPairs ||
                    this.AllowedAddressPairs != null &&
                    input.AllowedAddressPairs != null &&
                    this.AllowedAddressPairs.SequenceEqual(input.AllowedAddressPairs)
                ) && 
                (
                    this.ExtraDhcpOpts == input.ExtraDhcpOpts ||
                    this.ExtraDhcpOpts != null &&
                    input.ExtraDhcpOpts != null &&
                    this.ExtraDhcpOpts.SequenceEqual(input.ExtraDhcpOpts)
                ) && 
                (
                    this.BindingvnicType == input.BindingvnicType ||
                    (this.BindingvnicType != null &&
                    this.BindingvnicType.Equals(input.BindingvnicType))
                ) && 
                (
                    this.DnsAssignment == input.DnsAssignment ||
                    this.DnsAssignment != null &&
                    input.DnsAssignment != null &&
                    this.DnsAssignment.SequenceEqual(input.DnsAssignment)
                ) && 
                (
                    this.DnsName == input.DnsName ||
                    (this.DnsName != null &&
                    this.DnsName.Equals(input.DnsName))
                ) && 
                (
                    this.BindingvifDetails == input.BindingvifDetails ||
                    (this.BindingvifDetails != null &&
                    this.BindingvifDetails.Equals(input.BindingvifDetails))
                ) && 
                (
                    this.Bindingprofile == input.Bindingprofile ||
                    (this.Bindingprofile != null &&
                    this.Bindingprofile.Equals(input.Bindingprofile))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceType == input.InstanceType ||
                    (this.InstanceType != null &&
                    this.InstanceType.Equals(input.InstanceType))
                ) && 
                (
                    this.PortSecurityEnabled == input.PortSecurityEnabled ||
                    (this.PortSecurityEnabled != null &&
                    this.PortSecurityEnabled.Equals(input.PortSecurityEnabled))
                ) && 
                (
                    this.ZoneId == input.ZoneId ||
                    (this.ZoneId != null &&
                    this.ZoneId.Equals(input.ZoneId))
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
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.MacAddress != null)
                    hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.FixedIps != null)
                    hashCode = hashCode * 59 + this.FixedIps.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceOwner != null)
                    hashCode = hashCode * 59 + this.DeviceOwner.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.AllowedAddressPairs != null)
                    hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                if (this.ExtraDhcpOpts != null)
                    hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                if (this.BindingvnicType != null)
                    hashCode = hashCode * 59 + this.BindingvnicType.GetHashCode();
                if (this.DnsAssignment != null)
                    hashCode = hashCode * 59 + this.DnsAssignment.GetHashCode();
                if (this.DnsName != null)
                    hashCode = hashCode * 59 + this.DnsName.GetHashCode();
                if (this.BindingvifDetails != null)
                    hashCode = hashCode * 59 + this.BindingvifDetails.GetHashCode();
                if (this.Bindingprofile != null)
                    hashCode = hashCode * 59 + this.Bindingprofile.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null)
                    hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.PortSecurityEnabled != null)
                    hashCode = hashCode * 59 + this.PortSecurityEnabled.GetHashCode();
                if (this.ZoneId != null)
                    hashCode = hashCode * 59 + this.ZoneId.GetHashCode();
                return hashCode;
            }
        }
    }
}
