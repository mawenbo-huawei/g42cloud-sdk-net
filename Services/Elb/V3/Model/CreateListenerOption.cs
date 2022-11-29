using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 创建监听器的请求参数。
    /// </summary>
    public class CreateListenerOption 
    {

        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("default_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPoolId { get; set; }

        [JsonProperty("client_ca_tls_container_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientCaTlsContainerRef { get; set; }

        [JsonProperty("default_tls_container_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultTlsContainerRef { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("http2_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Http2Enable { get; set; }

        [JsonProperty("insert_headers", NullValueHandling = NullValueHandling.Ignore)]
        public ListenerInsertHeaders InsertHeaders { get; set; }

        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        [JsonProperty("sni_container_refs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SniContainerRefs { get; set; }

        [JsonProperty("sni_match_algo", NullValueHandling = NullValueHandling.Ignore)]
        public string SniMatchAlgo { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        [JsonProperty("tls_ciphers_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string TlsCiphersPolicy { get; set; }

        [JsonProperty("security_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityPolicyId { get; set; }

        [JsonProperty("enable_member_retry", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableMemberRetry { get; set; }

        [JsonProperty("keepalive_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepaliveTimeout { get; set; }

        [JsonProperty("client_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientTimeout { get; set; }

        [JsonProperty("member_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemberTimeout { get; set; }

        [JsonProperty("ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public CreateListenerIpGroupOption Ipgroup { get; set; }

        [JsonProperty("transparent_client_ip_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TransparentClientIpEnable { get; set; }

        [JsonProperty("enhance_l7policy_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnhanceL7policyEnable { get; set; }

        [JsonProperty("quic_config", NullValueHandling = NullValueHandling.Ignore)]
        public CreateListenerQuicConfigOption QuicConfig { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListenerOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  defaultPoolId: ").Append(DefaultPoolId).Append("\n");
            sb.Append("  clientCaTlsContainerRef: ").Append(ClientCaTlsContainerRef).Append("\n");
            sb.Append("  defaultTlsContainerRef: ").Append(DefaultTlsContainerRef).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  http2Enable: ").Append(Http2Enable).Append("\n");
            sb.Append("  insertHeaders: ").Append(InsertHeaders).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  sniContainerRefs: ").Append(SniContainerRefs).Append("\n");
            sb.Append("  sniMatchAlgo: ").Append(SniMatchAlgo).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tlsCiphersPolicy: ").Append(TlsCiphersPolicy).Append("\n");
            sb.Append("  securityPolicyId: ").Append(SecurityPolicyId).Append("\n");
            sb.Append("  enableMemberRetry: ").Append(EnableMemberRetry).Append("\n");
            sb.Append("  keepaliveTimeout: ").Append(KeepaliveTimeout).Append("\n");
            sb.Append("  clientTimeout: ").Append(ClientTimeout).Append("\n");
            sb.Append("  memberTimeout: ").Append(MemberTimeout).Append("\n");
            sb.Append("  ipgroup: ").Append(Ipgroup).Append("\n");
            sb.Append("  transparentClientIpEnable: ").Append(TransparentClientIpEnable).Append("\n");
            sb.Append("  enhanceL7policyEnable: ").Append(EnhanceL7policyEnable).Append("\n");
            sb.Append("  quicConfig: ").Append(QuicConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateListenerOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateListenerOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.DefaultPoolId == input.DefaultPoolId ||
                    (this.DefaultPoolId != null &&
                    this.DefaultPoolId.Equals(input.DefaultPoolId))
                ) && 
                (
                    this.ClientCaTlsContainerRef == input.ClientCaTlsContainerRef ||
                    (this.ClientCaTlsContainerRef != null &&
                    this.ClientCaTlsContainerRef.Equals(input.ClientCaTlsContainerRef))
                ) && 
                (
                    this.DefaultTlsContainerRef == input.DefaultTlsContainerRef ||
                    (this.DefaultTlsContainerRef != null &&
                    this.DefaultTlsContainerRef.Equals(input.DefaultTlsContainerRef))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Http2Enable == input.Http2Enable ||
                    (this.Http2Enable != null &&
                    this.Http2Enable.Equals(input.Http2Enable))
                ) && 
                (
                    this.InsertHeaders == input.InsertHeaders ||
                    (this.InsertHeaders != null &&
                    this.InsertHeaders.Equals(input.InsertHeaders))
                ) && 
                (
                    this.LoadbalancerId == input.LoadbalancerId ||
                    (this.LoadbalancerId != null &&
                    this.LoadbalancerId.Equals(input.LoadbalancerId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    (this.ProtocolPort != null &&
                    this.ProtocolPort.Equals(input.ProtocolPort))
                ) && 
                (
                    this.SniContainerRefs == input.SniContainerRefs ||
                    this.SniContainerRefs != null &&
                    input.SniContainerRefs != null &&
                    this.SniContainerRefs.SequenceEqual(input.SniContainerRefs)
                ) && 
                (
                    this.SniMatchAlgo == input.SniMatchAlgo ||
                    (this.SniMatchAlgo != null &&
                    this.SniMatchAlgo.Equals(input.SniMatchAlgo))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TlsCiphersPolicy == input.TlsCiphersPolicy ||
                    (this.TlsCiphersPolicy != null &&
                    this.TlsCiphersPolicy.Equals(input.TlsCiphersPolicy))
                ) && 
                (
                    this.SecurityPolicyId == input.SecurityPolicyId ||
                    (this.SecurityPolicyId != null &&
                    this.SecurityPolicyId.Equals(input.SecurityPolicyId))
                ) && 
                (
                    this.EnableMemberRetry == input.EnableMemberRetry ||
                    (this.EnableMemberRetry != null &&
                    this.EnableMemberRetry.Equals(input.EnableMemberRetry))
                ) && 
                (
                    this.KeepaliveTimeout == input.KeepaliveTimeout ||
                    (this.KeepaliveTimeout != null &&
                    this.KeepaliveTimeout.Equals(input.KeepaliveTimeout))
                ) && 
                (
                    this.ClientTimeout == input.ClientTimeout ||
                    (this.ClientTimeout != null &&
                    this.ClientTimeout.Equals(input.ClientTimeout))
                ) && 
                (
                    this.MemberTimeout == input.MemberTimeout ||
                    (this.MemberTimeout != null &&
                    this.MemberTimeout.Equals(input.MemberTimeout))
                ) && 
                (
                    this.Ipgroup == input.Ipgroup ||
                    (this.Ipgroup != null &&
                    this.Ipgroup.Equals(input.Ipgroup))
                ) && 
                (
                    this.TransparentClientIpEnable == input.TransparentClientIpEnable ||
                    (this.TransparentClientIpEnable != null &&
                    this.TransparentClientIpEnable.Equals(input.TransparentClientIpEnable))
                ) && 
                (
                    this.EnhanceL7policyEnable == input.EnhanceL7policyEnable ||
                    (this.EnhanceL7policyEnable != null &&
                    this.EnhanceL7policyEnable.Equals(input.EnhanceL7policyEnable))
                ) && 
                (
                    this.QuicConfig == input.QuicConfig ||
                    (this.QuicConfig != null &&
                    this.QuicConfig.Equals(input.QuicConfig))
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.DefaultPoolId != null)
                    hashCode = hashCode * 59 + this.DefaultPoolId.GetHashCode();
                if (this.ClientCaTlsContainerRef != null)
                    hashCode = hashCode * 59 + this.ClientCaTlsContainerRef.GetHashCode();
                if (this.DefaultTlsContainerRef != null)
                    hashCode = hashCode * 59 + this.DefaultTlsContainerRef.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Http2Enable != null)
                    hashCode = hashCode * 59 + this.Http2Enable.GetHashCode();
                if (this.InsertHeaders != null)
                    hashCode = hashCode * 59 + this.InsertHeaders.GetHashCode();
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.SniContainerRefs != null)
                    hashCode = hashCode * 59 + this.SniContainerRefs.GetHashCode();
                if (this.SniMatchAlgo != null)
                    hashCode = hashCode * 59 + this.SniMatchAlgo.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TlsCiphersPolicy != null)
                    hashCode = hashCode * 59 + this.TlsCiphersPolicy.GetHashCode();
                if (this.SecurityPolicyId != null)
                    hashCode = hashCode * 59 + this.SecurityPolicyId.GetHashCode();
                if (this.EnableMemberRetry != null)
                    hashCode = hashCode * 59 + this.EnableMemberRetry.GetHashCode();
                if (this.KeepaliveTimeout != null)
                    hashCode = hashCode * 59 + this.KeepaliveTimeout.GetHashCode();
                if (this.ClientTimeout != null)
                    hashCode = hashCode * 59 + this.ClientTimeout.GetHashCode();
                if (this.MemberTimeout != null)
                    hashCode = hashCode * 59 + this.MemberTimeout.GetHashCode();
                if (this.Ipgroup != null)
                    hashCode = hashCode * 59 + this.Ipgroup.GetHashCode();
                if (this.TransparentClientIpEnable != null)
                    hashCode = hashCode * 59 + this.TransparentClientIpEnable.GetHashCode();
                if (this.EnhanceL7policyEnable != null)
                    hashCode = hashCode * 59 + this.EnhanceL7policyEnable.GetHashCode();
                if (this.QuicConfig != null)
                    hashCode = hashCode * 59 + this.QuicConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
